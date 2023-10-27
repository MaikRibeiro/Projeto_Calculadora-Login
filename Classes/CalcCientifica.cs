using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_CalculadoraOrientada_a_Objetos.Classes
{
    public class CalcCientifica:CalculadoraBásica
    {
        public string Comparar(decimal a, decimal b)
        {
            //lógica de comparação
            if (a > b)
            {
                string texto = $"{a} é maior que {b}";
                return texto;
            }
            else if (a < b)
            {
                string texto = $"{a} é menor que {b}";
                return texto;
            }
            else
            {
                string texto = $"Os Numeros são iguais";
                return texto;
            }
        }
        public string Par_Impar()
        {
            bool num1Par = Num1 % 2 == 0;
            bool num2Par = Num2 % 2 == 0;

            if (num1Par == num2Par)
            {
                if (num1Par)
                {
                    return "Os dois números são Pares";
                }
                else
                {
                    return "Os dois números são Ímpares";
                }
            }
            else
            {
                return $"{Num1} é {(num1Par ? "Par" : "Ímpar")} e {Num2} é {(num2Par ? "Par" : "Ímpar")}";
            }

        }
        public string Potenciacao()
        {
            return Math.Pow(Convert.ToDouble(Num1), Convert.ToDouble(Num2)).ToString();
        }

        public string Potenciacao(decimal a, decimal b)
        {
            return Math.Pow(Convert.ToDouble(a), Convert.ToDouble(b)).ToString();

        }
    }
}
