using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_CalculadoraOrientada_a_Objetos.Classes
{
  public  class CalculadoraBásica
    {
        decimal _num1;

        public decimal Num1
        {
            get => _num1;
            set => _num1 = value;
        }
       
        decimal _num2;

        public decimal Num2 { get => _num2; set => _num2 = value; }

        private decimal _resultado;
        public decimal Resultado { get => _resultado;}
        public void Soma ()
        {
            _resultado = _num1 + _num2;
        }
        public string Subtrair()
        {
            return (_num1 - _num2).ToString();
        }
        /// <summary>
        /// Calcula a multiplicação a partir dos dois decimais.
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public string Multiplicar(decimal p1, decimal p2)
        {
            return (p1 * p2).ToString();            
        }
        public decimal Multiplicar()
        {
            return (_num1 * _num2);
        }

        public string Dividir(decimal a, decimal b)
        {
            try
            {
               if (b == 0)
                { 
                    throw new DivideByZeroException();

                }
            }
            catch (Exception ex)
            {
                if (ex is FormatException || ex is DivideByZeroException)
                {
                    return "Digite apenas números e que sejam diferentes de zero";
                }
            }
                return (a / b).ToString();
        }
    }
}
