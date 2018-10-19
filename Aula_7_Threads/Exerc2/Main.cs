using System.Threading;
using System;

namespace PrinterPrime {
    class Program {

        static void Main(string[] args) {
            for (int i = 0; i <= 100000; i++){
                if (isPrime(i)){
                    Console.WriteLine(i);
                    if (i / 10000 == 1) {
                        Thread t = new Thread(() => Console.WriteLine(i));
                        t.Start();
                        t.Join();
                    } 
                }
            }
        }

        static bool isPrime(int num){
            int count = 0;
            for (int i = 1; i <= num; i++) if (num % i == 0) count++;
            if (num == 1 || count == 2) return true;
            else return false;
        }
    }
}