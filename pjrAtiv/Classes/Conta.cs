using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace pjrAtiv.Classes
{
    internal class Conta
    {
        public static int ContadordeContas { get; set; }
        /*public static double SaldoTotal { get; set; }*/
        public int IdConta { get; set; }
        public int IdCliente { get; set; }
        public double Saldo { get; set; }
        public string? Status { get; set; }
        public DateTime DataAbertura { get; set; }
        public DateTime? Datafechamento { get; set; }
        

        public Conta() 
        {
            ContadordeContas = ContadordeContas + 1;
            /*SaldoTotal = SaldoTotal + Saldo;*/
        }

        public Conta(int idConta, int idCliente, double saldo, string status, DateTime dataAbertura, DateTime? dataFechamento)
        {
            /*this.IdConta = idConta;
            this.IdCliente = idCliente;
            this.Saldo = saldo;
            this.Status = status;
            this.DataAbertura = dataAbertura;   
            this.Datafechamento = dataFechamento;*/

            IdConta = idConta;
            IdCliente = idCliente;
            Saldo = saldo;
            Status = status;
            DataAbertura = dataAbertura;
            Datafechamento = dataFechamento;
            ContadordeContas = ContadordeContas + 1;
            /*SaldoTotal = SaldoTotal + Saldo;*/



        }+

        public double Depositar(double valordeposito)
        {
            if (valordeposito < 0.01)
            {
                MessageBox.Show("Valor de Deposito Indisponivel");

            }
            else
            {
                this.Saldo = this.Saldo + valordeposito;
                /*SaldoTotal += valordeposito;*/
            }
           
            return this.Saldo;
            //this.Saldo += valordeposito;
        }

        /*public static double RetornoSaldoTotal()
        {
            double saldoTodasContas;
            saldoTodasContas = SaldoTotal + saldoTodasContas;
            return SaldoTotal;
        }*/
        /*public static string RetornoSaldoTotal()
        {
            return $"O saldo total é R$:{SaldoTotal}";
        }*/

        public double Saque(double valorSaque )
        {
            /*if (valorSaque <= this.Saldo)
            {
                this.Saldo = this.Saldo - valorSaque;
            }
            else
            {
                throw new Exception("Saldo Indisponível ou Valor inválido");     
            }*/
            if (valorSaque > this.Saldo)
            {
                throw new Exception("O Valor é Maior que o Saldo Disponivel");

            }

            else if (valorSaque <= 0.01)
            {
                
               throw new Exception("Valor Invalido");
            }
            else
            {
                this.Saldo = this.Saldo - valorSaque;


            }

            return this.Saldo;

        } 

        public string VerSaldo() 
        {
            return $"Saldo: R${this.Saldo.ToString("n2")}";

        }
        

            
  
        

        

    }


}
