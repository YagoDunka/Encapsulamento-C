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
            decimal LadoA = 0, LadoB = 0, LadoC = 0;

            if (string.IsNullOrEmpty(ttbLadoA.Text))
                ListaErros.Add("O campo Lado A deve ser preenchido");
            else
            {
                try
                {
                    LadoA = decimal.Parse(ttbLadoA.Text);
                }
                catch
                {
                    ListaErros.Add("\nDigitação inválida do campo Lado A!");
                }
            }

            if (string.IsNullOrEmpty(ttbLadoB.Text))
                ListaErros.Add("O campo Lado B deve ser preenchido");
            else
            {
                try
                {
                    LadoB = decimal.Parse(ttbLadoB.Text);
                }
                catch
                {
                    ListaErros.Add("\nDigitação inválida do campo Lado B!");
                }
            }

            if (string.IsNullOrEmpty(ttbLadoC.Text))
                ListaErros.Add("O campo Lado C deve ser preenchido");
            else
            {
                try
                {
                    LadoC = decimal.Parse(ttbLadoC.Text);
                }
                catch
                {
                    ListaErros.Add("\nDigitação inválida do campo Lado C!");
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

            Triangulo triangulo = new Triangulo(LadoA, LadoB, LadoC);

            triangulo.TipoTriangulo();
      


        }

        private void retanguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 tela = new Form1();
            tela.ShowDialog();
        }
    }
}
