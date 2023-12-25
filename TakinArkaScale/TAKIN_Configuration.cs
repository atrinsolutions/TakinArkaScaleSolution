using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakinArkaScale
{
    public class TAKIN_Configuration
    {
        public string SerialPortName { get; set; }
        public int Baudrate { get; set; }
        public Parity Parity { get; set; }
        public StopBits StopBit { get; set; }
        public string HostIP { get; set; }
        public int TcpPort1 { get; set; }
        public int TcpPort2 { get; set; }
        public bool isTcpServer { get; set; }
        public int TcpTimeout { get; set; }
    }
}
