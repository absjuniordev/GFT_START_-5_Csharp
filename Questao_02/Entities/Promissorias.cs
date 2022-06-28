namespace Questao_02.Entities
{
    public class Promissorias
    {
          public double calcularValorRecebivel(double valor, int dias)
        {
            double valorFinal = 0;
            if (dias >= 30 && dias < 60)
            {
                valorFinal = valor - 4 / 100;
            }
            else if (dias >= 60 && dias <= 90)
            {
                valorFinal = valor - 6.5 / 100;
            }
            else if ((dias == 90))
            {
                valorFinal = valor - 8.5 / 100;
            }
            else if( dias > 90)
            {
               // valorFinal = valor - 7.5 / 100;
            }

            return valorFinal;
        }
    }
}