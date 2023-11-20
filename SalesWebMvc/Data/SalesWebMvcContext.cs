using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Models;

namespace SalesWebMvc.Data
{
    public class SalesWebMvcContext : DbContext
    {
        // O objetico do DbContext e mapea as clasee para que ela 
        // se torne banco de dados
        // E o DbSet ser para mapea a classe 

        //DefaultConnection vai ser o  name="DefaultConnection" no  ConnectionStrings 
        public SalesWebMvcContext (DbContextOptions<SalesWebMvcContext> options)
            : base(options)
        {
        }

        //Mapeando a classe
        public DbSet<Department> Department { get; set; }
               
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }


        //******************************************
        //para o Entity não aplicar o plural
        //******************************************
        //Exemplo
        //public DbSet<Aluno> Alunos { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
            //******************************************
            //para o Entity não aplicar o plural
            //******************************************

            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //modelBuilder.Entity<Aluno>().ToTable("Alunos");
            //base.OnModelCreating(modelBuilder);
        //}

    }
}
