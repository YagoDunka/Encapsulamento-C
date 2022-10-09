namespace ExemploEncapsulamento.Modelos
{
    public class Retangulo
    {
        //Atributos da classe
        public decimal Altura { get; private set; }
        public decimal Largura { get; private set; }
        public decimal Area { get; private set; }


        //Construtores de classe
        //Deixar sempre um construtor vazio por padrão
        public Retangulo()
        {

        }


        //Declaração de construtores do menos para o mais específico
        public Retangulo(decimal altura, decimal largura)
        {
            Altura = altura;
            Largura = largura;
        }

        public Retangulo(decimal altura, decimal largura, decimal area)
        {
            Altura = altura;
            Largura = largura;
            Area = area;
        }

        //Metodos de processo e verificação do objeto
        public bool EhRetangulo()
            => Altura != Largura;

        public decimal CalculaArea()
        {
            Area = Altura * Largura;
            return Area;
        }
    }
}
