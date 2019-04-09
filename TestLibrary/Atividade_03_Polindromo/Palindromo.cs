using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibrary.Atividade_03_Polindromo
{
    public class Palindromo : IPalindromo
    {
        public bool isPalindromo(string valor)
        {
            // Converte a palavra em um array de letras (caracteres) e reverte as posições.
            char[] letras = valor.ToCharArray();
            Array.Reverse(letras);

            // Trasnforma as letras reversas em string.
            string valorRevertido = new string(letras);

            // Compara colocando em minúscula pois o que importa é o sentido.
            if (RemoveAcentuacao(valor.ToLower()) == RemoveAcentuacao(valorRevertido.ToLower()))
                return true;
            else
                return false;
        }

        // Remove acentuação.
        private static string RemoveAcentuacao(string word)
        {
            word = word.Replace("À", "A");
            word = word.Replace("Â", "A");
            word = word.Replace("Á", "A");
            word = word.Replace("Ã", "A");

            word = word.Replace("à", "a");
            word = word.Replace("â", "a");
            word = word.Replace("á", "a");
            word = word.Replace("ã", "a");

            word = word.Replace("Ê", "E");
            word = word.Replace("É", "E");

            word = word.Replace("ê", "e");
            word = word.Replace("é", "e");

            word = word.Replace("Ó", "O");
            word = word.Replace("Ô", "O");

            word = word.Replace("ó", "o");
            word = word.Replace("ô", "o");

            word = word.Replace("ú", "u");

            return word;
        }
    }
}
