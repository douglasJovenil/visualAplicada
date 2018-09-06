using System;

namespace ProgramacaoOrientadaObjetos
{
    class Square : AbstractSquare
    {
        public float Width { get; set; }
        public float Height { get; set; }

        public Square() { }
        public Square(float Width, float Height)
        {
            this.Width = Width;
            this.Height = Height;
        }

        public override float GetArea()
        {
            return this.Width * this.Height;
        }

        public override float GetPerimeter()
        {
            return 2 * (this.Width * this.Height);
        }
    }
}
