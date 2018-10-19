using System;

namespace Threads {
    class ContadorTempo {
        public int tick {get; set;}

        public ContadorTempo() {
            tick = 0;
        }

        public void nextTick() {
            tick++;
            Console.WriteLine(tick);
        }
    }
}