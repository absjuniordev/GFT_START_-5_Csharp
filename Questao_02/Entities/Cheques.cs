using Questao_02.Entities.Interface;

namespace Questao_02.Entities
{

    public class Cheques : IRecebivel
    {
        public double calcularValorRecebivel(double valor, int dias)
        {
            double valorFinal = 0;
            if (dias >= 30 && dias < 60)
            {
                valorFinal = valor - 5 / 100;
            }
            else if (dias >= 60 && dias <= 90)
            {
                valorFinal = valor - 7.5 / 100;
            }
            else if ((dias == 90))
            {
                valorFinal = valor - 10 / 100;
            }
            else if( dias > 90)
            {
                valorFinal = valor - 7.5 / 100;
            }

            return valorFinal;
        }

      
    }

}