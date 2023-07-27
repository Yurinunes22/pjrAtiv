using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjrAtiv.Classes
{
    internal class Conta
    {
        public int IdConta { get; set; }
        public int IdCliente { get; set; }
        public double Saldo { get; set; }
        public string? Status { get; set; }
        public DateTime DataAbertura { get; set; }
        public DateTime? Datafechamento { get; set; }
        

        public Conta()
        {
            
        }

        public Conta(int idConta, int idCliente, double saldo, string status, DateTime dataAbertura, DateTime? dataFechamento)
        {
            this.IdConta = idConta;
            this.IdCliente = idCliente;
            this.Saldo = saldo;
            this.Status = status;
            this.DataAbertura = dataAbertura;   
            this.Datafechamento = dataFechamento;
        }

        public double Depositar(double valordeposito) 
        {
            this.Saldo = this.Saldo + valordeposito;
            return this.Saldo;
            //this.Saldo += valordeposito;
        }
    }
}
