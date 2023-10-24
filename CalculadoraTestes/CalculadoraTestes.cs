using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTestes
{
    private CalculadoraImp _calc;

    public CalculadoraTestes()
    {
        _calc = new CalculadoraImp();
    }


    [Theory]
    [InlineData(2, 4, 6)]
    [InlineData(26, 30, 56)]
    public void TesteSomar(int num1, int num2, int res)
    {
        //Arrange

        //Act
        int resultado = _calc.Somar(num1, num2);

        //Assert
        Assert.Equal(res, resultado);
    }

    [Theory]
    [InlineData(5, 4, 1)]
    [InlineData(90, 81, 9)]
    public void TesteSubtrair(int num1, int num2, int res)
    {
        //Arrange

        //Act
        int resultado = _calc.Subtrair(num1, num2);

        //Assert
        Assert.Equal(res, resultado);
    }

    [Fact]
    public void DeveVerificar4ParRetornarVerdadeiro()
    {
        //Arrange
        int num = 4;

        //Act
        bool resultado = _calc.EhPar(num);

        //Assert
        Assert.True(resultado);
    }

    [Theory]
    [InlineData(new int[] {2, 4, 6, 8, 10})]
    [InlineData(new int[] {26, 30})]
    public void DeveVerificarNumerosParesRetornarVerdadeiro(int[] numeros)
    {
        //Arrange
        // Ja em InlineData

        //Act / Assert
        Assert.All(numeros, num => Assert.True(_calc.EhPar(num)));
    }
}