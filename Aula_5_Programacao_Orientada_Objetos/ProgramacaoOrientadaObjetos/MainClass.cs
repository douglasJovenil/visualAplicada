using System;

namespace ProgramacaoOrientadaObjetos
{
    class MainClass
    {
        static void Main(string[] args)
        {
            TestHash();
            Console.ReadKey();
        }

        static void TestHash()
        {
            Hash MyHash = new Hash();
            
            while(MyHash.NumberPlays <= 9)
            {
                char play;
                int row;
                int column;

                MyHash.GetBoard();
                Console.Write("Informe a jogada: ");
                play = char.Parse(Console.ReadLine());
                Console.Write("Informe a linha: ");
                row = int.Parse(Console.ReadLine());
                Console.Write("Informe a coluna: ");
                column = int.Parse(Console.ReadLine());
                MyHash.SetBoard(play, row, column);
                Console.ReadKey();
                Console.Clear();
            }

        }

        static void TestStatistic()
        {
            Statistic MyStatistic = new Statistic();
            Random RandomGenerator = new Random();
            double TmpValue;

            Console.Write("Valores: ");
            for (int i = 0; i <= 10; i++)
            {
                TmpValue = RandomGenerator.NextDouble() * 100;
                MyStatistic.Insert(TmpValue);
                Console.Write($"{TmpValue.ToString("0.00")} ");
            }
            Console.WriteLine($"\nMédia: {MyStatistic.Mean()}");
            Console.WriteLine($"Desvio Padrão: {MyStatistic.StandardDeviation()}");

        }

        static void TestGeometricFigure()
        {
            GeometricFigure MyGeometricFigure = new GeometricFigure(3, 2, 3, 3, 3, 1);
            Console.WriteLine($"Tipo de Trinâgulo: {MyGeometricFigure.TriangleType()}");
            Console.WriteLine($"Ângulo: {MyGeometricFigure.AngleType()}");

        }

        static void TestPoint()
        {
            Point MyPoint = new Point(3, 2);
            Console.WriteLine(MyPoint.ToString());
        }

        static void TestAccount()
        {
            Account MyAccount = new Account();
            MyAccount.AddMoney(1000);
            MyAccount.GetMoney(200);
            MyAccount.AddMoney(500);
            Console.WriteLine($"Saldo da conta: {MyAccount.AccountBalance}");
        }

        static void TestHour()
        {
            Hour MyHour = new Hour(13, 20, 45);

            Console.WriteLine($"Hour: {MyHour.CurrentHour()}");
            MyHour.NextSecond();
            Console.WriteLine($"Next second: {MyHour.CurrentHour()}");
            for (int i = 0; i <= 1; i++) MyHour.PreviousSecond();
            Console.WriteLine($"Previous seconds * 2: {MyHour.CurrentHour()}");
            MyHour.AddSecond(125);
            Console.WriteLine($"Current hour + 125 seconds: {MyHour.CurrentHour()}");
            Console.WriteLine($"Elapsed time: {MyHour.ElapsedTime()}");
            Console.WriteLine($"Elapsed time in seconds: {MyHour.ElapsedTimeSeconds()}");
        }

        static void TestComplex()
        {
            Complex MyComplex = new Complex(3, 5);

            Console.WriteLine($"Real: {MyComplex.Real} Imaginary: {MyComplex.Imaginary} Module: {MyComplex.GetModule().ToString(".00")}");
        }

        static void TestSquare()
        {
            Square MySquare = new Square(3, 4);
            Console.WriteLine($"Width: {MySquare.Width} Height: {MySquare.Height}");
            Console.Write($"Area: {MySquare.GetArea()} Perimeter: {MySquare.GetPerimeter()}");
        }
    }
}
