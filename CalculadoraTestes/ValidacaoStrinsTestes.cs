using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculadora.Services;

namespace CalculadoraTestes
{
    public class ValidacaoStrinsTestes
    {
        private ValidacaoString _validacao;

        public ValidacaoStrinsTestes()
        {
            _validacao = new ValidacaoString();
        }

        [Fact]
        public void DeveContarCaracteresOlaRetornar3()
        {
            //Arrange
            string texto = "Ola";

            //Act
            int resultado = _validacao.ContarCaracter(texto);

            //Assert
            Assert.Equal(3, resultado);
        }


    }
}