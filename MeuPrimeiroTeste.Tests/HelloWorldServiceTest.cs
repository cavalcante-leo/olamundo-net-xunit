using MeuPrimeiroTeste.App;
namespace MeuPrimeiroTeste.Tests;

public class HelloWorldServiceTest
{
    [Fact]
    public void GerarSaudacao_DeveRetornarSaudacaoPadrao_QuandoNomeForNuloOuVazio()
    {
        // Arrange (Preparação)
        var service = new HelloWorldService();

        // Act (Ação)
        var resultado = service.GerarSaudacao(null);

        // Assert (Verificação)
        Assert.Equal("Olá, Mundo!", resultado);
    }    
    
    [Theory]
    [InlineData("Leandro", "Olá, Leandro!")]
    [InlineData("Cora", "Olá, Cora!")]
    public void GerarSaudacao_DeveRetornarSaudacao_QuandoNomeStringValida(string nome, string resultadoEsperado)
    {
        // Arrange (Preparação)
        var service = new HelloWorldService();

        // Act (Ação)
        var resultado = service.GerarSaudacao(nome);

        // Assert (Verificação)
        Assert.Equal(resultadoEsperado, resultado);
    }   
}
