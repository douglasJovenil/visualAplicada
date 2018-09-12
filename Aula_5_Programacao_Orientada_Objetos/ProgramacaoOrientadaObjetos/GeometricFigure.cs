using System;

namespace ProgramacaoOrientadaObjetos
{
    class GeometricFigure : Point
    {
        public Point P1 { get; set; }
        public Point P2 { get; set; }
        public Point P3 { get; set; }

        public GeometricFigure(int PX1, int PY1, int PX2, int PY2, int PX3, int PY3) : base(PX1, PY1, PX2, PY2, PX3, PY3)
        {
            P1 = new Point(PX1, PY1);
            P2 = new Point(PX2, PY2);
            P3 = new Point(PX3, PY3);
        }

        public Double GetDistance(Point P1, Point P2) => Math.Sqrt(Math.Pow(P1.X - P2.X, 2) + Math.Pow(P1.Y - P2.Y, 2));

        public string TriangleType(Point P1, Point P2, Point P3)
        {
            if (GetDistance(P1, P2) == GetDistance(P2, P3) && GetDistance(P1, P2) == GetDistance(P3, P1))
            {
                return "Equilátero";
            } else if (GetDistance(P1, P2) == GetDistance(P2, P3) || GetDistance(P1, P2) == GetDistance(P3, P1))
            {
                return "Isósceles";
            } 

            return "Escaleno";
        }

        public string AngleType(Point P1, Point P2, Point P3) // Terminar
        {
            int[] BiggerP1 = { 1, 2, 3 };



            return "0.0f";
        }
    }
}
