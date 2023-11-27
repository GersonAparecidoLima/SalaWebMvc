using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace SalesWebMvc.Models
{
    public class Seller
    {
        public int Id { get; set; }


        //Validação com mensagem parametrizado 0 required, 0 = Name 
        [Required(ErrorMessage = "{0} obrigatório")]
        //Limitação entre minimo(03) e maximo(60) com mensagem
        //0  = Name, 2 = 60 e 2  = 3
        [StringLength(60, MinimumLength = 3, ErrorMessage = "{0} deve estar entre {2} e {1}")]
        [Display(Name = "Nome")]
        public string Name { get; set; }

        //Validação com mensagem parametrizado {0} required, {0} = Name(Email)
        [Required(ErrorMessage = "{0} obrigatório")]
        [EmailAddress(ErrorMessage = "(Entre com email")]
        //transformando o Email em um link de e-mail
        //Acinando o aplicativo de e-mail padrão
        [DataType(DataType.EmailAddress)]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        //Validação com mensagem parametrizado {0} required, {0} = Name(Data Nascimento)
        [Required(ErrorMessage = "{0} obrigatório")]
        //Aqui eu altera o titulo da coluna na view
        [Display(Name = "Data Nascimento")]
        //para apresentar somente o calendario sem hora minuto e segundo
        [DataType(DataType.Date)]
        //Colocando mascara na data
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime BirthDate { get; set; }


        //Validação com mensagem parametrizado {0} required, {0} = Name(Salário base)
        [Required(ErrorMessage = "{0} obrigatório")]
        //Aqui eu altera o titulo da coluna na view
        [Display(Name = "Salário base")]
        //Colocando duas casa decimais com formatação
        [DisplayFormat(DataFormatString = "{0:F2}")]
        //Salario no minimo 100 e no maximo 50000
        [Range(100.0, 50000.0, ErrorMessage = "{0} deve ser entre {1} e {2}")]
        public double BaseSalary { get; set; }

        public Department Department { get; set; }

        public int DepartmentId { get; set; }

        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        public Seller()
        {
        }

        public Seller(int id, string name, string email, DateTime birthDate, double baseSalary, Department department)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddSales(SalesRecord sr)
        {
            Sales.Add(sr);
        }

        public void RemoveSales(SalesRecord sr)
        {
            Sales.Remove(sr);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sales.Where(sr => sr.Date >= initial && sr.Date <= final).Sum(sr => sr.Amount);
        }

    }
}
