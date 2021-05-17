using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace GraphicDesigner
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Poligono> desenho = new List<Poligono>();

            desenho.Add(new Retangulo() { X = 10, Y = 15 });
            desenho.Add(new Retangulo() { X = 12, Y = 17 });

            Retangulo q = new Quadrado() { X = 19, Y = 25, Height = 20 };
            q.Height = 10;

            Trace.WriteLine(((Quadrado)q).Height);

            desenho.Add(q);

            desenho.Add(new Circulo() { X = 14, Y = 23 });
            desenho.Add(new Circulo() { X = 14, Y = 23 });
            desenho.Add(new Circulo() { X = 14, Y = 23 });

            foreach (var poligono in desenho)
            {
                poligono.Draw();
            }
            Console.WriteLine("Hello World!");
        }
    }
}
