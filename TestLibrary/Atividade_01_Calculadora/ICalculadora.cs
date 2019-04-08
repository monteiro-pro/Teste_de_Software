using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibrary.Atividade_01_Calculadora
{
    interface ICalculadora
    {
        int Somar(string valor1, string valor2);
        double Dividir(string valor1, string valor2);
        double RaizQuadrada(string valor);
    }
}
