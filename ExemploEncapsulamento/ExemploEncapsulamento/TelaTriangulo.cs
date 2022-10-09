using ExemploEncapsulamento.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploEncapsulamento
{
    public partial class TelaTriangulo : Form
    {
        private decimal ladoA;
        private decimal ladoB;
        private decimal ladoC;

        public TelaTriangulo()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            List<string> ListaErros = new List<string>();
            double Hipotenusa = 0, CatetoA = 0, CatetoB = 0, Altura = 0;

            if (string.IsNullOrEmpty(ttbHipotenusa.Text))
                ListaErros.Add("O campo Base deve ser preenchido");
            else
            {
                try
                {
                    Hipotenusa = double.Parse(ttbHipotenusa.Text);
                }
                catch
                {
                    ListaErros.Add("\nDigitação inválida do campo Base!");
                }
            }

            if (string.IsNullOrEmpty(ttbCatetoA.Text))
                ListaErros.Add("O campo Cateto A deve ser preenchido");
            else
            {
                try
                {
                    CatetoA = double.Parse(ttbCatetoA.Text);
                }
                catch
                {
                    ListaErros.Add("\nDigitação inválida do campo Cateto A!");
                }
            }

            if (string.IsNullOrEmpty(ttbCatetoB.Text))
                ListaErros.Add("O campo Cateto B deve ser preenchido");
            else
            {
                try
                {
                    CatetoB = double.Parse(ttbCatetoB.Text);
                }
                catch
                {
                    ListaErros.Add("\nDigitação inválida do campo Cateto B!");
                }
            }

            if (ttbAltura.Text != "")
            {
                try
                {
                    Altura = double.Parse(ttbAltura.Text);
                }
                catch
                {
                    ListaErros.Add("\nDigitação inválida do campo Altura!");
                }
            }

            if (ListaErros.Count > 0)
            {
                string erros = "";
                foreach (string item in ListaErros)
                    erros = erros + item;

                MessageBox.Show(erros);
                return;
            }

            Triangulo triangulo = new Triangulo(Hipotenusa, CatetoA, CatetoB, Altura);

            triangulo.TipoTriangulo();
        }

        private void retanguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 tela = new Form1();
            tela.ShowDialog();
        }
    }
}
