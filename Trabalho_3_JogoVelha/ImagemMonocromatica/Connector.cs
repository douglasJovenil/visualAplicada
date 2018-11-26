using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Forms;
using System.Diagnostics;

namespace ImagemMonocromatica
{
    class Connector : SerialPort
    {
        public string HostAddress { get; set; }

        public Connector()
        {
            HostAddress = Process.GetCurrentProcess().Id.ToString();
        }

        public new string[] GetPortNames()
        {
            return SerialPort.GetPortNames();
        }
    }
}
