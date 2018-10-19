using System.Threading;
using System;

namespace Threads {
    class Cronometro : ContadorTempo{
        public void callNextTick(){
            new Thread(() => nextTick());
        }
    }
}