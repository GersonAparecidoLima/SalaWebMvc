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


        public SellersController(SellerService sellerService)
        {
            // Injeção de dependencia concluido.
            _sellerService = sellerService;
          
        }


        //public IActionResult Index()
        public async Task<IActionResult> Index()
        {
            //Implementando a chamado o SellerService
            List<Models.Seller> list = await _sellerService.FindAllAsync();

            // Passando list como agumento para a Views
            return View(list);
        }


        public IActionResult Create()
        {
            // var departments = await _departmentService.FindAllAsync();
            //var viewModel = new SellerFormViewModel { Departments = departments };
            //return View(viewModel);
            return View();
        }
        //Ação de post
        [HttpPost]
        //previnindo ataques CSRF, aproveintando a sua sessão
        [AutoValidateAntiforgeryToken]
        public IActionResult Create(Seller saller)
        {
            _sellerService.Insert(saller);
            return RedirectToAction(nameof(Index));
        }


    }
}
