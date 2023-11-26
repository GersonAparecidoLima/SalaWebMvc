using Jose;
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

        public async Task InsertAsync(Seller obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }

        public async Task<Seller> FindByIdAsync(int id)
        {
            //retornando o vendedor, caso não tenha vendedor retorna nulo
            //esta expreção Include atraves da expresão lanbd faz um join
            return await _context.Seller.Include(obj => obj.Department).FirstOrDefaultAsync(obj => obj.Id == id);
        }

        public async Task RemoveAsync(int id)
        {
            try
            {
                var obj = await _context.Seller.FindAsync(id);
                _context.Seller.Remove(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException e)
            {
                throw new IntegrityException("Can't delete seller because he/she has sales");
            }
        }


    }
}
