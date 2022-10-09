using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploEncapsulamento.Modelos
{
    public class Triangulo
    {
        public decimal LadoA { get; private set; }
        public decimal LadoB { get; private set; }
        public decimal LadoC { get; private set; }

        public Triangulo()
        {

        }

        public Triangulo(decimal ladoA, decimal ladoB, decimal ladoC)
        {
            LadoA = ladoA;
            LadoB = ladoB;
            LadoC = ladoC;
        }

        public decimal TipoTriangulo()
        {
            if (LadoA == LadoB)
            {
                if (LadoA == LadoC)
                {
                    MessageBox.Show("Triangulo Equilatero!");
                   
                }
                else
                {
                    MessageBox.Show("Triangulo Escaleno!");
                }
            }
            else
            {
                if (LadoB != LadoC)
                {
                    //Escaleno
                    MessageBox.Show("Triangulo Escaleno!");
                }
                else
                {
                    //Retangulo
                    MessageBox.Show("Triangulo Retangulo!");
                }
            }
            return 0;
        }
    }
}
