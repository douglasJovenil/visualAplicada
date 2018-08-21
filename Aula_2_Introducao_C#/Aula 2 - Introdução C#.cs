using System;
using System.Linq;

namespace Aula02{
    class Program{
        static void Main(string[] args){
            Exerc10();
        }
        static void Exerc1(){
            Console.WriteLine("AUT0218 - Programação Visual Aplicada");
        }
        static void Exerc2(){
            int value;
            Console.WriteLine("Informe em Km: ");
            value = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Em metros: " + value / 3.6);
        }
        static void Exerc3(){
            int baseTri, alturaTri;
            Console.Write("Informe a base: ");
            baseTri = Convert.ToInt32(Console.ReadLine());
            Console.Write("Informe a altura: ");
            alturaTri = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Área: " + baseTri * alturaTri / 2);
        }
        static void Exerc4(){
            int[] values = new int[5];
            for (int i=0; i<values.Length; i++){
                Console.Write("Informe um valor: ");
                values[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Média: " + values.Average());

        }
        static void Exerc5(){
            for (int i = 1; i <= 50; i++) Console.WriteLine(i);
            for (int i = 50; i >= 1; i--) Console.WriteLine(i);
        }
        static void Exerc6(){
            int value;

            Console.Write("Informe um valor: ");
            value = Convert.ToInt32(Console.ReadLine());
            while (value <= 100){
                Console.WriteLine(value);
                value *= 3;
            }
            Console.WriteLine(value);
        }
        static void Exerc7(){
            for (int i = 1; i <= 10; i++) Console.WriteLine(i * 9);
        }
        static void Exerc8(){
            int value;
            Console.Write("Informe um valor: ");
            value = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i<=value; i++){
                for (int j = 1; j <= i; j++){
                    Console.Write(i * j);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
        static void Exerc9(){
            int[] values = new int[10];
            for (int i = 0; i < values.Length; i++){
                Console.Write("Informe um valor: ");
                values[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Maior: " + values.Max());
            Console.WriteLine("Menor: " + values.Min());

        }
        static void Exerc10(){
            int[] values = new int[10];
            for (int i = 0; i < values.Length; i++){
                Console.Write("Informe um valor: ");
                values[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(values.Average());
        }

    }
}
