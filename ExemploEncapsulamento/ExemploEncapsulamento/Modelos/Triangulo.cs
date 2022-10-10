using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ExemploEncapsulamento.Modelos
{
    public class Triangulo
    {
        public double Hipotenusa { get; private set; }
        public double CatetoA { get; private set; }
        public double CatetoB { get; private set; }
        public double Altura { get; private set; }

        public Triangulo()
        {

        }

        public Triangulo (double Hipot, double catetoA, double catetoB, double altura)
        {
            Hipotenusa = Hipot;
            CatetoA = catetoA;
            CatetoB = catetoB;
            Altura = altura;
        }

        public void TipoTriangulo()
        {
            //Equilatero
            if (Hipotenusa == CatetoA && Hipotenusa == CatetoB)
            {
                MessageBox.Show("Triângulo Equilatero!\nÁrea do Triangulo: " + Math.Round(Math.Pow(CatetoA, 2) * Math.Sqrt(3)) / 4 + "cm²", "Resultado", MessageBoxButtons.OK);
            }
            else
            {
                //Retangulo
                if ((Hipotenusa > CatetoA && Hipotenusa > CatetoB) && (CatetoA == Altura || CatetoB == Altura))
                {
                    MessageBox.Show("Triângulo Retângulo!\nÁrea do Triangulo: " + CatetoA * CatetoB / 2 + "cm²", "Resultado", MessageBoxButtons.OK);
                }
                else
                {
                    //Escaleno
                    double p = (Hipotenusa + CatetoA + CatetoB) / 2;
                    MessageBox.Show("Triângulo Escaleno!\nÁrea: " + Math.Round(Math.Sqrt(p * (p - CatetoA) * (p - CatetoB) * (p - Hipotenusa))) + "cm²", "Resultado", MessageBoxButtons.OK);
                }
            }
        }
    }
}
