using Elasticsearch.Net;
using Jose;
using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;
using SalesWebMvc.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Controllers
{
    public class SellersController : Controller
    {

        //Declarando um dependia para o service SellerService
        private readonly SellerService _sellerService;
        private readonly DepartmentService _departmentService;

        public SellersController(SellerService sellerService, DepartmentService departmentService)
        {
            // Injeção de dependencia concluido.
            _sellerService = sellerService;
            _departmentService = departmentService;
        }


        //public IActionResult Index()
        public async Task<IActionResult> Index()
        {
            //Implementando a chamado o SellerService
            List<Models.Seller> list = await _sellerService.FindAllAsync();

            // Passando list como agumento para a Views
            return View(list);
        }


        public async Task<IActionResult> Create()
        {
            //Buscar do banco de dados todos os departamentos
            var departments = await _departmentService.FindAllAsync();
            //Agora a tela de cadastro quando for aberta pela 1 vez ela já
            //vai trazer os dados do departamento populado
            var viewModel = new SellerFormViewModel { Departments = departments };
            return View(viewModel);
        }


        
        
        //Recebe ação de post
        [HttpPost]
        //previnindo ataques CSRF, aproveintando a sua sessão
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Seller seller)
        {
            if (!ModelState.IsValid)
            {
                var departments = await _departmentService.FindAllAsync();
                var viewModel = new SellerFormViewModel { Seller = seller, Departments = departments };
                return View(viewModel);
            }
            await _sellerService.InsertAsync(seller);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int? id)
        {
            //se o id for nulo significa que a sequisição foi feito de uma forma indevida
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não fornecido" });
            }
            //Buscar o Obj que estamos deletando
            var obj = await _sellerService.FindByIdAsync(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não encontrado" });
            }

            return View(obj);
        }

        //Recebe ação de post
        [HttpPost]
        //previnindo ataques CSRF, aproveintando a sua sessão
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _sellerService.RemoveAsync(id);
                return RedirectToAction(nameof(Index));
            }
            catch (IntegrityException e)
            {
                return RedirectToAction(nameof(Error), new { message = e.Message });
            }
        }

    }
}
