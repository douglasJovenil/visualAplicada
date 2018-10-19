using System.Threading;
using System;

namespace Threads {
    class Program {
        static void Main(string[] args) {
            Cronometro cronometer = new Cronometro();
            cronometer.callNextTick();
        }
    }
}