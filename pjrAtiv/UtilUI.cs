using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjrAtiv
{
    public class UtilUi
    {
        public static void Limpaform(Form form) 
        {
            foreach (Control c in form.Controls) 
            {
                if (c is TextBox || c is ComboBox)
                {
                  c.Text = String.Empty;
                }
                else if (c is DateTimePicker) 
                {
                    c.Text = DateTime.Now.ToString();
                }
            } 
        }
    }
}
