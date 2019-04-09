using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibrary.Atividade_04_Anagrama
{
    public class Anagrama : IAnagrama
    {
        public bool isAnagrama(string valor1, string valor2)
        {
            char[] letras1 = valor1.ToCharArray();
            char[] letras2 = valor2.ToCharArray();

            Array.Sort(letras1);
            Array.Sort(letras1);


            if ((letras1.Length == letras2.Length) && Array.Equals(letras1, letras2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
