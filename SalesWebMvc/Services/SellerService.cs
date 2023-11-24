using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Data;
using SalesWebMvc.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SalesWebMvc.Services
{
    public class SellerService
    {
        //Declarando dependicia DbContext
        // readonly previne que a dependica não possa ser alterada
        private readonly SalesWebMvcContext _context;

        //Construindo um construtor para que a injeção de dependencia possa aconteceer
        public SellerService(SalesWebMvcContext context)
        {
            _context = context;
        }

        // acessar uma fonte de dados para retornar uma lista com todos
        // os vendedores do banco de dados
        public async Task<List<Seller>> FindAllAsync()
        {
            return await _context.Seller.ToListAsync();
        }

    }
}
