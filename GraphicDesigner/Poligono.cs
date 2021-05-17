using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicDesigner
{
    public abstract class Poligono
    {
        public virtual int X { get; set; }
        public virtual int Y { get; set; }

        public abstract void Draw();
    }

    public class Retangulo : Poligono
    {
        public virtual int Height { get; set; }
        public virtual int Bottom { get; set; }

        public virtual int Width { get; set; }
        public virtual int Right { get; set; }

        public override void Draw()
        {
            Trace.WriteLine("Vou desenhar um retangulo");
        }
    }

    public class Quadrado : Retangulo
    {
        public override int Height { get { return base.Height; } set { base.Height = value; base.Width = value; } }

        public override int Width { get { return Height; } set { this.Height = value; } }

        public override void Draw()
        {
            base.Draw();

            Trace.WriteLine("afinal foi um quadrado");
        }
    }

    public class Circulo : Poligono
    {
        public int Raio { get; set; }

        public int Diametro { get; set; }

        public override void Draw()
        {
            Trace.WriteLine("Vou desenhar um circulo");
        }
    }
}
