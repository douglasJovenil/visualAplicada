using System;

namespace ProgramacaoOrientadaObjetos
{
    class Complex : AbstractComplex
    {
        public float Imaginary { get; set; }
        public float Real { get; set; }
        
        public Complex() { }

        public Complex(float Real, float Imaginary)
        {
            this.Real = Real;
            this.Imaginary = Imaginary;
        }

        public override void SetComplex(float Real, float Imaginary)
        {
            this.Real = Real;
            this.Imaginary = Imaginary;
        }

        public override double GetModule()
        {
            return Math.Sqrt(Math.Pow(this.Real, 2) + Math.Pow(this.Imaginary, 2));
        }
    }
}
