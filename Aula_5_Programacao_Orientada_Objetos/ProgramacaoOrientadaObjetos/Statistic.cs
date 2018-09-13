using System;

namespace ProgramacaoOrientadaObjetos
{
    class Statistic : AbstractStatistic
    {
        private int Samples;
        public double SumX { get; set; }
        public double SumX2 { get; set; }

        public int GetSamples()
        {
            return Samples;
        }

        public Statistic()
        {
            Samples = 0;
            SumX = SumX2 = 0;
        }

        public override void Insert(double Value)
        {
            Samples++;
            SumX += Value;
            SumX2 += Math.Pow(Value, 2);
        }

        public override double Mean() => SumX / Samples;

        public override double StandardDeviation() => Math.Sqrt((SumX2 - (Math.Pow(SumX, 2) / Samples)) / (Samples - 1));

    }
}
