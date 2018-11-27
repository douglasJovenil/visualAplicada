namespace ImagemMonocromatica
{
    public struct PointHistoric
    {
        public int Value { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public PointHistoric(int Value_P, int X_P, int Y_P)
        {
            Value = Value_P;
            X = X_P;
            Y = Y_P;
        }
    }
}
