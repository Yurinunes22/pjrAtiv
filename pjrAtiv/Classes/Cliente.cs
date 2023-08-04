using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjrAtiv.Classes
{
    public class Cliente
    {

        private int _id;
        public int id
        {
            get 
            {
             return this._id;
            }
            set 
            {
                if (value <=0)
                {
                    throw new Exception("Id nao pode ser maior que zero!");
                 
                 
                }
                else
                {
                    this._id = value;

                }
              
            }
 
        }




        public string NomeCliente { get; set; }
    }
}
