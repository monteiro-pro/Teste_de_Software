using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestLibrary.Atividade_01_Calculadora;

namespace TestProject
{
    [TestClass]
    public class UnitTest
    {
        Calculadora calculadora = new Calculadora();

        [TestInitialize]
        public void IniciarTeste()
        {

        }

        // ## Teste Atividade 01. Calculadora
        #region Calculadora
        [TestMethod]
        public void Somar_01()
        {
            string valor1 = "2";
            string valor2 = "4";

            Assert.AreEqual(calculadora.Somar(valor1, valor2), 6);
        }

        [TestMethod]
        public void Somar_02()
        {
            string valor1 = "Teste";
            string valor2 = "4";

            calculadora.Somar(valor1, valor2);

            // Resultado: Erro, pois não se pode converter um character (variável valor1) em uma valor inteiro.
        }

        [TestMethod]
        public void Dividir_01()
        {
            string valor1 = "12";
            string valor2 = "4";

            Assert.AreEqual(calculadora.Dividir(valor1, valor2), 3);
        }

        [TestMethod]
        public void Dividir_02()
        {
            string valor1 = "2";
            string valor2 = "4";

            Assert.AreEqual(calculadora.Dividir(valor1, valor2), 1);

            // Resultado: Erro, pois o resultado esperado é 1 enquanto o valor dá operação será 0,5.
        }

        [TestMethod]
        public void RaizQuadrada_01()
        {
            string valor1 = "5";

            Assert.AreEqual(calculadora.RaizQuadrada(valor1), 25);
        }

        [TestMethod]
        public void RaizQuadrada_02()
        {
            string valor1 = "0";

            Assert.AreEqual(calculadora.RaizQuadrada(valor1), 1);

            // Resultado: Erro, pois o resultado esperado é 1 enquanto o valor dá operação será 0.
        }
        #endregion

        [TestCleanup]
        public void TerminarTeste()
        {

        }
    }
}
