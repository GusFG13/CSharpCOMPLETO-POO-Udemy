using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section16.Aula226.Extensions
{
    static class StringExtensions
    {
        public static string Cut(this string esteObjeto, int count) 
        { 
            if (esteObjeto.Length < count)
            {
                return esteObjeto;
            }
            else
            {
                return esteObjeto.Substring(0, count) + "...";
            }
        }
    }
}
