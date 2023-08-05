using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjrAtiv.Classes
{
    public class Cliente
    {

        private int Id;
        public int id
        {
            get 
            {
             return this.Id;
            }
            set 
            {
                if (value <=0)
                {
                    throw new Exception("Id nao pode ser maior que zero!");
                 
                 
                }
                else
                {
                    this.id = value;

                }
              
            }
 
        }




        public string Nome { get; set; }

        public Cliente(int id, string nome) 
        {
         this.Id = id;
         this.Nome = nome;  
        }
    }
}
