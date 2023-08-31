using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Conta
    {
        
            public int idCliente { get; set; }

            public int idConta { get; set; }

            public DateTime dataAbertura { get; set; }

            public DateTime dataEncerramento { get; set; }

            //public DateTime DataFechamento { get; set; }

            public decimal saldo { get; set; }

            public string tipoConta { get; set; }

            public string statusConta { get; set; }

            public string senhaConta { get; set; }



        
    }
}
