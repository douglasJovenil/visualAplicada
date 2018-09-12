using System;

namespace ProgramacaoOrientadaObjetos
{
    class MainClass
    {
        static void Main(string[] args)
        {
            TestPoint();
            Console.ReadKey();
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
