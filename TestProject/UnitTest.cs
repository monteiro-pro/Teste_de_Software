using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestLibrary.Atividade_01_Calculadora;
using TestLibrary.Atividade_03_Polindromo;
using TestLibrary.Atividade_04_Anagrama;

namespace TestProject
{
    [TestClass]
    public class UnitTest
    {
        Calculadora calculadora = new Calculadora();
        Palindromo palindromo = new Palindromo();
        Anagrama anagrama = new Anagrama();

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

            // Resultado: Esperado.
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

            // Resultado: Esperado.
        }

        [TestMethod]
        public void Dividir_02()
        {
            string valor1 = "2";
            string valor2 = "4";

            Assert.AreEqual(calculadora.Dividir(valor1, valor2), 1);

            // Resultado: Erro, pois o resultado esperado é 1 enquanto o valor dá operação será 0,5...
        }

        [TestMethod]
        public void RaizQuadrada_01()
        {
            string valor1 = "5";

            Assert.AreEqual(calculadora.RaizQuadrada(valor1), 25);

            // Resultado: Esperado.
        }

        [TestMethod]
        public void RaizQuadrada_02()
        {
            string valor1 = "0";

            Assert.AreEqual(calculadora.RaizQuadrada(valor1), 1);

            // Resultado: Erro, pois o resultado esperado é 1 enquanto o valor dá operação será 0.
        }
        #endregion

        // Teste Atividade 03. Polindromo
        #region Polindromo
        [TestMethod]
        public void PositipoPalindromo()
        {
            string valor = "Após a Sopa";

            Assert.AreEqual(palindromo.isPalindromo(valor), true);

            // Resultado: Esperado.
        }

        [TestMethod]
        public void PositipoNaoPalindromo()
        {
            string valor = "Carro";

            Assert.AreEqual(palindromo.isPalindromo(valor), false);

            // Resultado: Esperado.
        }

        [TestMethod]
        public void NegativoPalindromo()
        {
            string valor = "Carro";

            Assert.AreEqual(palindromo.isPalindromo(valor), true);

            // Resultado: A palavra carro não é um Palindromo.
        }

        [TestMethod]
        public void ExcecaoPalindromo()
        {
            string valor = null;

            Assert.AreEqual(palindromo.isPalindromo(valor), true);

            // Resultado: Exception, pois o valor do parâmetro não pode ser nulo.
        }
        #endregion

        // Teste Atividade 04. Anagrama
        #region Anagrama
        [TestMethod]
        public void PositipoAnagrama()
        {
            string valor1 = "Amor";
            string valor2 = "Roma";

            Assert.AreEqual(anagrama.isAnagrama(valor1, valor2), true);

            // Resultado: Esperado.
        }

        [TestMethod]
        public void PositipoNaoAnagrama()
        {
            string valor1 = "Carro";
            string valor2 = "Livro";

            Assert.AreEqual(anagrama.isAnagrama(valor1, valor2), false);

            // Resultado: Esperado.
        }

        [TestMethod]
        public void NegativoAnagrama()
        {
            string valor1 = "Velho";
            string valor2 = "casa";

            Assert.AreEqual(anagrama.isAnagrama(valor1, valor2), true);

            // Resultado: A palavra carro não é um Palindromo.
        }

        [TestMethod]
        public void ExcecaoAnagrama()
        {
            string valor1 = null;
            string valor2 = null;

            Assert.AreEqual(anagrama.isAnagrama(valor1, valor2), true);

            // Resultado: Exception, pois o valor do parâmetro não pode ser nulo.
        }
        #endregion

        [TestCleanup]
        public void TerminarTeste()
        {

        }
    }
}
