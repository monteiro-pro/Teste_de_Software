using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibrary.Atividade_01_Calculadora
{
    public class Calculadora : ICalculadora
    {
        public double Dividir(string valor1, string valor2)
        {
            return Convert.ToDouble(valor1) / Convert.ToDouble(valor2);
        }

        public double RaizQuadrada(string valor)
        {
            return Convert.ToDouble(valor) * Convert.ToDouble(valor);
        }

        public int Somar(string valor1, string valor2)
        {
            return Convert.ToInt32(valor1) + Convert.ToInt32(valor2);
        }
    }
}
