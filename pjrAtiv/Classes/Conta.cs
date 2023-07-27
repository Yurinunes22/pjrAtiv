using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjrAtiv.Classes
{
    public class Conta
    {
        public int IdConta { get; set; }
        public int IdCliente { get; set; }

        public double saldo { get; set; }

        public string Status { get; set; }

        public double Limite { get; set; }
        public DateTime DataAbertura { get; set; }
        public DateTime DataFechamento { get; set; }


        public Conta()
        { 
        }
}
