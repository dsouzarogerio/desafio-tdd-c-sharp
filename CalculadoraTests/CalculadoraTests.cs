using Calculadora.Models;
using Xunit.Sdk;

namespace CalculadoraTests;

public class CalculadoraTests
{
    private CalculadoraModel _calc;

    public CalculadoraTests()
    {
        _calc = new CalculadoraModel();
    }

    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(4, 5, 9)]
    public void DeveSomarDoisNumeroERetornarResultado(int n1, int n2, int resultado)
    {
        //Arrange
        //Act
        var resultadoTeste = _calc.Somar(n1, n2);

        //Assert
        Assert.Equal(resultado, resultadoTeste);
    }

    [Theory]
    [InlineData(3, 2, 1)]
    [InlineData(5, 2, 3)]
    public void DeveSubtrirDoisNumeroERetornarResultado(int n1, int n2, int resultado)
    {
        //Arrange
        //Act
        var resultadoTeste = _calc.Subtrair(n1, n2);

        //Assert
        Assert.Equal(resultado, resultadoTeste);
    }

    [Theory]
    [InlineData(3, 2, 6)]
    [InlineData(5, 2, 10)]
    public void DeveMultiplicarDoisNumeroERetornarResultado(int n1, int n2, int resultado)
    {
        //Arrange
        //Act
        var resultadoTeste = _calc.Multiplicar(n1, n2);

        //Assert
        Assert.Equal(resultado, resultadoTeste);
    }

    [Theory]
    [InlineData(4, 2, 2)]
    [InlineData(6, 2, 3)]
    public void DeveDividirDoisNumeroERetornarResultado(int n1, int n2, int resultado)
    {
        //Arrange
        //Act
        var resultadoTeste = _calc.Dividir(n1, n2);

        //Assert
        Assert.Equal(resultado, resultadoTeste);
    }

    [Fact]
    public void DeveDividirPorZeroERetornarExcecao()
    {
        //Arrange
        //Act
        //Assert
        Assert.Throws<DivideByZeroException>(() => _calc.Dividir(3, 0));
    }

    [Fact]
    public void DeveConsultarListaERetornarOsTresUltimosRestulados()
    {
        //Arrange
        _calc.Somar(1,2);
        _calc.Somar(3,4);
        _calc.Somar(6,5);
        _calc.Somar(8,10);
        
        //Act
        var lista = _calc.historico();
        
        //Assert
        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count());

    }
}