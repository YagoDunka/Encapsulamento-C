using ExemploEncapsulamento.Modelos;

namespace ExemploEncapsulamento
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            List<string> ListaErros = new List<string>();
            decimal altura = 0, largura = 0, area = 0;

            if (string.IsNullOrEmpty(ttbAltura.Text))
                ListaErros.Add("\nO campo altura precisa ser preenchido!");
            else
            {
                try
                {
                    altura = decimal.Parse(ttbAltura.Text);
                }
                catch
                {
                    ListaErros.Add("\nDigitação inválida do campo altura!");
                }
            }

            if (string.IsNullOrEmpty(ttbLargura.Text))
                ListaErros.Add("\nO campo largura precisa ser preenchido!");
            else
            {
                try
                {
                    largura = decimal.Parse(ttbLargura.Text);
                }
                catch
                {
                    ListaErros.Add("\nDigitação inválida do campo largura!");
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

            //Utilizando construtor declarado na classe retangulo
            //passando a parametrização de altura e largura
            Retangulo retangulo = new Retangulo(altura, largura);

            //Depois
            if (retangulo.EhRetangulo())
                MessageBox.Show("\nArea do retangulo = " + retangulo.CalculaArea().ToString());
            else
                MessageBox.Show("\nEntradas correspondem a um quadrado!");
        }

        private void trianguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaTriangulo tela = new TelaTriangulo();
            tela.ShowDialog();
        }
    }
}