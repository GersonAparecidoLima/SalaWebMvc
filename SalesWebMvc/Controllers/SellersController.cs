using Microsoft.AspNetCore.Mvc;
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
    }
}
