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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaTriangulo tela = new TelaTriangulo();
            tela.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 tela = new Form1();
            tela.ShowDialog();
        }
    }
}
