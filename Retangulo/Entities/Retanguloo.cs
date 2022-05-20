namespace Retangulo.Entities
{
    public class Retanguloo
    {
        public double Altura { get; set; }
        public double Largura { get; set; }

        public Retanguloo(double altura, double largura)
        {
            Altura = altura;
            Largura = largura;
        }

        public double Area()
        {
            double area = Altura * Largura;
            return area;
        }

        public double Perimetro()
        {
            double perimetro = Altura * 2 + Largura * 2;
            return perimetro;
        }
    }
}
