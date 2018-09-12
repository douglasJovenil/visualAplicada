using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramacaoOrientadaObjetos
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        protected Point(int PX1, int PY1, int PX2, int PY2, int PX3, int PY3) { }
        public Point(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public override string ToString()=> $"({X}, {Y})";
    }
}
