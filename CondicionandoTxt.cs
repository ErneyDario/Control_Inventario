using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace Control_Inventario
{
    internal class CondicionandoTxt
    {
        public static bool soloNum (KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
                return true;
            }
            else if(char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                return true;
            }
            else
            {
                e.Handled = true;
                return false;
            }
        }
        /*public static bool soloTex(KeyPressEventArgs e) 
        { 
        if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
                return true;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                return true;
            }else
            {
                e.Handled = true;
                return false;
            }
            
             
        }*/
        public static bool soloEmail (String sCorreo)
        {
            return sCorreo != null && Regex.IsMatch(sCorreo, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }
    }

}
