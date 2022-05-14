using Microsoft.AspNetCore.Mvc;
using CalculadoraApi.Web.Exceptions;

namespace CalculadoraApi.Web.Controllers;

[ApiController]
[Route("[controller]")]
public class CalculadoraController : ControllerBase
{
    [HttpGet("Somar")]
    public IActionResult Soma(double valorUm, double valorDois)
    {
        try
        {
            var calculadora = new Calculadora();
            var resultado = calculadora.Somar(valorUm, valorDois);
            return Ok(resultado);
        }
        catch (ErroDeValidacaoException ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("Subtrair")]
    public IActionResult Subtracao(double valorUm, double valorDois)
    {
        try
        {
            var calculadora = new Calculadora();
            var resultado = calculadora.Substrair(valorUm, valorDois);
            return Ok(resultado);
        }
        catch (ErroDeValidacaoException ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("Dividir")]
    public IActionResult Divisao(double valorUm, double valorDois)
    {
        try
        {
            var calculadora = new Calculadora();
            var resultado = calculadora.Dividir(valorUm, valorDois);
            return Ok(resultado);
        }
        catch (ErroDeValidacaoException ex)
        {
            return BadRequest(ex.Message);
        }
    }


    [HttpGet("Multiplicar")]
    public IActionResult Multiplicacao(double valorUm, double valorDois)
    {
        try
        {
            var calculadora = new Calculadora();
            var resultado = calculadora.Multiplicar(valorUm, valorDois);
            return Ok(resultado);
        }
        catch (ErroDeValidacaoException ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
