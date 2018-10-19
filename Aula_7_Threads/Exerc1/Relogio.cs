using System.Threading;
using System;

namespace Threads {
    class Relogio {
        private System.Timers.Timer timer;
        public ContadorTempo counter;

        public Relogio() {
            counter = new ContadorTempo();
            setTimer();
        }

        private void setTimer() {
            timer = new System.Timers.Timer(1000);
            timer.Elapsed += event_tick;
            timer.Start();
        }

        public void event_tick(object sender, EventArgs e) {
            new Thread(() => counter.nextTick()).Start();
        }
    }
}