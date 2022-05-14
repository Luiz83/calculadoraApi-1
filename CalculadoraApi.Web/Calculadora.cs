using CalculadoraApi.Web.Exceptions;
namespace CalculadoraApi.Web
{
    public class Calculadora
    {
        public double Somar(double num1, double num2)
        {
            AplicarValidacoes(num1, num2);
            return num1 + num2;
        }
        public double Substrair(double num1, double num2)
        {
            AplicarValidacoes(num1, num2);
            return num1 - num2;
        }
        public double Dividir(double num1, double num2)
        {
           AplicarValidacoes(num1, num2);
            return num1 / num2;
        }
        public double Multiplicar(double num1, double num2)
        {
            AplicarValidacoes(num1, num2);
            return num1 * num2;
        }

        public bool AplicarValidacoes(double valorUm, double valorDois)
        {
            if (ValidarNumeroMaiorQueZero(valorUm, valorDois) && ValidarNumeroMenorQueMil(valorUm, valorDois))
                return true;
            return false;
        }
        public bool ValidarNumeroMaiorQueZero(double valorUm, double valorDois)
        {
            if (valorUm > 0 && valorDois > 0)
                return true;
            throw new ErroDeValidacaoException("Voce inseriu um valor menor que zero");
        }
        public bool ValidarNumeroMenorQueMil(double valorUm, double valorDois)
        {
            if (valorUm < 1000 && valorDois < 1000)
                return true;
            throw new ErroDeValidacaoException("Voce inseriu um valor maior que mil");
        }
    }
}