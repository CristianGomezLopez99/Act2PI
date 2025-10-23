using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act2PI
{
    public class Funciones
    {
       public static long CalcularFactorial(int num)
        {
            if (num < 0)
            {
                return -1;
            }
            else
            {
                long resultado = 1;
                for (int i = 1; i <= num; i++)
                {
                    resultado *= i;
                }
                return resultado;
            }

        }
        public static bool EsContrasenyaValida(string contrasenya)
        {
            return true;
        }
    }
}
    
