using System;
using Retangulo.Entities;

namespace Retangulo;

    public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Informe a altura do retangulo:");
        double altura = double.Parse(Console.ReadLine());
        Console.Write("Informe a largura do retangulo:");
        double largura = double.Parse(Console.ReadLine());

        Retanguloo retangulo = new Retanguloo(altura, largura);
        double area = retangulo.Area();
        Console.WriteLine("Area = " + area.ToString("F2"));

        double perimetro = retangulo.Perimetro();
        Console.WriteLine("Perimetro = " + perimetro.ToString("F2"));
    }

}