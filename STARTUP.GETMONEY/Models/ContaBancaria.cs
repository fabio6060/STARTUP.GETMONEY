using Microsoft.AspNetCore.Routing.Constraints;
using System.ComponentModel.DataAnnotations;

namespace GETMONEY.Models
{
    public class ContaBancaria
    {
        private string nomeTitular;
        private double saldo;
        private bool ativa;

        [Required(ErrorMessage = "Introduza o nome do Titular")]
        public string NomeTitular
        {
            get { return nomeTitular; }
            set { nomeTitular = value; }
        }

        [Required(ErrorMessage = "Introduza um saldo")]
        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

        
        public bool Ativa
        {
            get { return ativa; }
            set { ativa = value; }
        }


    }
}