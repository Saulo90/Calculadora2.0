using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCalcRevisão
{
    class Calculadora
    {
        public double v1 { get; set; }
        public double v2 { get; set; }
        public double resultado { get; set; }
        public char opera { get; set; }

        public void Calcular()
        {
            switch (opera)
            {
                case '+':
                    resultado = v1 + v2; 
                    break;
                case '-':
                    resultado = v1 - v2;
                    break;
                case '*':
                    resultado = v1 * v2;
                    break;
                case '/':
                    resultado = v1 / v2;
                    break;
            }


        }
    }
}
