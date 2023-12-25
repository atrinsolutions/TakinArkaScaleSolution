using System.IO.Ports;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Application = System.Windows.Forms.Application;
using Timer = System.Windows.Forms.Timer;

namespace TakinArkaScale
{
    public partial class Form1 : Form
    {
        private int ConnectionCounter = 0;
        private byte RData;
        private int TakinServiceState, ProtocolAddress, ProtocolFunction, ProtocolDataLenght, LoopCnt, crchigh, crclow, TempVariable, crci;
        private byte[] DataPack = new byte[250];
        private int ViewWeight, TareWeight;
        private int WeightIndication;
        bool ZeroFlag;
        bool TareFlag;
        bool StableFlag;
        bool NegFlag;
        bool W2Flag;
        bool OverFlag;
        bool BatFlag;
        bool UnderFlag;
        bool SystemConnected = false;
        bool SystemDisconnected = false;
        static readonly int[] CrcTable = new int[]
        {

            0X0000, 0XC0C1, 0XC181, 0X0140, 0XC301, 0X03C0, 0X0280, 0XC241,
            0XC601, 0X06C0, 0X0780, 0XC741, 0X0500, 0XC5C1, 0XC481, 0X0440,
            0XCC01, 0X0CC0, 0X0D80, 0XCD41, 0X0F00, 0XCFC1, 0XCE81, 0X0E40,
            0X0A00, 0XCAC1, 0XCB81, 0X0B40, 0XC901, 0X09C0, 0X0880, 0XC841,
            0XD801, 0X18C0, 0X1980, 0XD941, 0X1B00, 0XDBC1, 0XDA81, 0X1A40,
            0X1E00, 0XDEC1, 0XDF81, 0X1F40, 0XDD01, 0X1DC0, 0X1C80, 0XDC41,
            0X1400, 0XD4C1, 0XD581, 0X1540, 0XD701, 0X17C0, 0X1680, 0XD641,
            0XD201, 0X12C0, 0X1380, 0XD341, 0X1100, 0XD1C1, 0XD081, 0X1040,
            0XF001, 0X30C0, 0X3180, 0XF141, 0X3300, 0XF3C1, 0XF281, 0X3240,
            0X3600, 0XF6C1, 0XF781, 0X3740, 0XF501, 0X35C0, 0X3480, 0XF441,
            0X3C00, 0XFCC1, 0XFD81, 0X3D40, 0XFF01, 0X3FC0, 0X3E80, 0XFE41,
            0XFA01, 0X3AC0, 0X3B80, 0XFB41, 0X3900, 0XF9C1, 0XF881, 0X3840,
            0X2800, 0XE8C1, 0XE981, 0X2940, 0XEB01, 0X2BC0, 0X2A80, 0XEA41,
            0XEE01, 0X2EC0, 0X2F80, 0XEF41, 0X2D00, 0XEDC1, 0XEC81, 0X2C40,
            0XE401, 0X24C0, 0X2580, 0XE541, 0X2700, 0XE7C1, 0XE681, 0X2640,
            0X2200, 0XE2C1, 0XE381, 0X2340, 0XE101, 0X21C0, 0X2080, 0XE041,
            0XA001, 0X60C0, 0X6180, 0XA141, 0X6300, 0XA3C1, 0XA281, 0X6240,
            0X6600, 0XA6C1, 0XA781, 0X6740, 0XA501, 0X65C0, 0X6480, 0XA441,
            0X6C00, 0XACC1, 0XAD81, 0X6D40, 0XAF01, 0X6FC0, 0X6E80, 0XAE41,
            0XAA01, 0X6AC0, 0X6B80, 0XAB41, 0X6900, 0XA9C1, 0XA881, 0X6840,
            0X7800, 0XB8C1, 0XB981, 0X7940, 0XBB01, 0X7BC0, 0X7A80, 0XBA41,
            0XBE01, 0X7EC0, 0X7F80, 0XBF41, 0X7D00, 0XBDC1, 0XBC81, 0X7C40,
            0XB401, 0X74C0, 0X7580, 0XB541, 0X7700, 0XB7C1, 0XB681, 0X7640,
            0X7200, 0XB2C1, 0XB381, 0X7340, 0XB101, 0X71C0, 0X7080, 0XB041,
            0X5000, 0X90C1, 0X9181, 0X5140, 0X9301, 0X53C0, 0X5280, 0X9241,
            0X9601, 0X56C0, 0X5780, 0X9741, 0X5500, 0X95C1, 0X9481, 0X5440,
            0X9C01, 0X5CC0, 0X5D80, 0X9D41, 0X5F00, 0X9FC1, 0X9E81, 0X5E40,
            0X5A00, 0X9AC1, 0X9B81, 0X5B40, 0X9901, 0X59C0, 0X5880, 0X9841,
            0X8801, 0X48C0, 0X4980, 0X8941, 0X4B00, 0X8BC1, 0X8A81, 0X4A40,
            0X4E00, 0X8EC1, 0X8F81, 0X4F40, 0X8D01, 0X4DC0, 0X4C80, 0X8C41,
            0X4400, 0X84C1, 0X8581, 0X4540, 0X8701, 0X47C0, 0X4680, 0X8641,
            0X8201, 0X42C0, 0X4380, 0X8341, 0X4100, 0X81C1, 0X8081, 0X4040
        };

        Timer GetWeighTimer;
        bool weightState = false;

        public SerialPort WeightSerial;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public static readonly List<string> SupportedBaudRates = new List<string>
{
    "300",
    "600",
    "1200",
    "2400",
    "4800",
    "9600",
    "19200",
    "38400",
    "57600",
    "115200",
    "230400",
    "460800",
    "921600"
};
        Thread readThread;
        byte stateMachine = 0;
        int weight = 0;
        string rawWeight;
        TAKIN_Configuration defaultConfig = null;
        XDocument doc = new XDocument();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon.Visible = true;
            }
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }

        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }
        delegate void SetTextWeightCallback(string text);

        private void SetTextWeight(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.lbWeight.InvokeRequired)
            {
                SetTextWeightCallback d = new SetTextWeightCallback(SetTextWeight);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.lbWeight.Text = text;
            }
        }
        delegate void SetTextTareCallback(string text);

        private void SetTextTare(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.lbTare.InvokeRequired)
            {
                SetTextTareCallback d = new SetTextTareCallback(SetTextTare);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.lbTare.Text = text;
            }
        }

        public void Read()
        {
            while (true)
            {
                try
                {
                    string message = WeightSerial.ReadLine();
                    string[] outdate = message.Split("\rwn");
                    string stringWeight;

                    if (outdate.Length > 1)
                    {
                        if (outdate[0] == "" && outdate[1] != null)
                        {
                            string[] outdate2 = outdate[1].Split("kg");
                            stringWeight = outdate2[0];
                            rawWeight = stringWeight;
                            weight = (int)(double.Parse(stringWeight) * 1000);
                            SetTextWeight(stringWeight);
                        }
                    }
                }
                catch (TimeoutException) { }
            }
        }

        private void WriteToServiceConfiguration()
        {
            string newValue = string.Empty;
            XmlDocument xmlDoc = new XmlDocument();
            string serviceConfigFile = $@"{System.AppDomain.CurrentDomain.BaseDirectory}Initializer.xml";
            XElement t = XElement.Load(serviceConfigFile);
            t.Element("Configuration").Element("SerialPortName").Value = defaultConfig.SerialPortName;
            t.Element("Configuration").Element("Baudrate").Value = defaultConfig.Baudrate.ToString();
            t.Element("Configuration").Element("Parity").Value = defaultConfig.Parity.ToString();
            t.Element("Configuration").Element("StopBit").Value = defaultConfig.StopBit.ToString();
            t.Element("Configuration").Element("HostIP").Value = defaultConfig.HostIP;
            t.Element("Configuration").Element("TcpPort1").Value = defaultConfig.TcpPort1.ToString();
            t.Element("Configuration").Element("TcpPort2").Value = defaultConfig.TcpPort2.ToString();
            t.Element("Configuration").Element("isTcpServer").Value = defaultConfig.isTcpServer.ToString();
            t.Element("Configuration").Element("TcpTimeout").Value = defaultConfig.TcpTimeout.ToString();
            t.Save(serviceConfigFile);

        }

        private XElement GetElement(XDocument doc, string elementName)
        {
            foreach (XNode node in doc.DescendantNodes())
            {
                if (node is XElement)
                {
                    XElement element = (XElement)node;
                    if (element.Name.LocalName.Equals(elementName))
                        return element;
                }
            }
            return null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string initializerFilePath = $@"{AppDomain.CurrentDomain.BaseDirectory}initializer.xml";
            try
            {
                doc = XDocument.Load(initializerFilePath);
                defaultConfig = (from element in doc.Descendants("DataContext").Elements("Configuration")
                                 select new TAKIN_Configuration
                                 {
                                     SerialPortName = element.Element("SerialPortName").Value.ToString(),
                                     Baudrate = Convert.ToInt32(element.Element("Baudrate").Value),
                                     Parity = (Parity)Enum.Parse(typeof(Parity), element.Element("Parity").Value, true),
                                     StopBit = (StopBits)Enum.Parse(typeof(StopBits), element.Element("StopBit").Value, true),
                                     HostIP = element.Element("HostIP").Value,
                                     TcpPort1 = Convert.ToInt32(element.Element("TcpPort1").Value),
                                     TcpPort2 = Convert.ToInt32(element.Element("TcpPort2").Value),
                                     isTcpServer = Convert.ToBoolean(element.Element("isTcpServer").Value),
                                     TcpTimeout = Convert.ToInt32(element.Element("TcpTimeout").Value)

                                 }).FirstOrDefault();

            }
            catch(Exception ex)
            {
                MessageBox.Show(initializerFilePath);
            }













            this.BackColor = Color.LimeGreen;
            this.TransparencyKey = Color.LimeGreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            lbWeight.Text = ((double)0 / (double)1000).ToString("0.000");
            lbTare.Text = ((double)0 / (double)1000).ToString("0.000");

            zero.FlatStyle = FlatStyle.Flat;
            zero.BackColor = Color.Transparent;
            zero.FlatAppearance.MouseDownBackColor = Color.Transparent;
            zero.FlatAppearance.MouseOverBackColor = Color.Transparent;

            tare.FlatStyle = FlatStyle.Flat;
            tare.BackColor = Color.Transparent;
            tare.FlatAppearance.MouseDownBackColor = Color.Transparent;
            tare.FlatAppearance.MouseOverBackColor = Color.Transparent;


            clearTare.FlatStyle = FlatStyle.Flat;
            clearTare.BackColor = Color.Transparent;
            clearTare.ForeColor = Color.Transparent;
            clearTare.FlatAppearance.MouseDownBackColor = Color.Transparent;
            clearTare.FlatAppearance.MouseOverBackColor = Color.Transparent;

            btnZero.BackColor = Color.LightGreen;
            btnNet.BackColor = Color.LightGray;
            btnStable.BackColor = Color.LightGray;

            ContextMenuStrip menu = new ContextMenuStrip();
            ToolStripMenuItem menuItemA = new ToolStripMenuItem("Setting");
            menu.Items.Add(menuItemA);
            ToolStripMenuItem menuItemB = new ToolStripMenuItem("Quit");
            menuItemB.Click += QuitApp;
            menu.Items.Add(menuItemB);
            ToolStripMenuItem menuItemC = new ToolStripMenuItem("Apply Setting");
            menuItemC.Click += ApplySetting;
            menu.Items.Add(menuItemC);

            ToolStripMenuItem menuItemA1 = new ToolStripMenuItem("ComPort");
            menuItemA.DropDownItems.Add(menuItemA1);
            ToolStripMenuItem menuItemA2 = new ToolStripMenuItem("Baudrate");
            menuItemA.DropDownItems.Add(menuItemA2);
            ToolStripMenuItem menuItemA3 = new ToolStripMenuItem("First TCP port");
            menuItemA3.Click += firstPortSelection;
            menuItemA.DropDownItems.Add(menuItemA3);
            ToolStripMenuItem menuItemA4 = new ToolStripMenuItem("Second TCP Port");
            menuItemA4.Click += secondPortSelection;
            menuItemA.DropDownItems.Add(menuItemA4);

            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                ToolStripMenuItem menuItemCom = new ToolStripMenuItem(port);
                menuItemCom.Click += setPortName;
                menuItemA1.DropDownItems.Add(menuItemCom);

            }
            
            foreach (string baudrates in SupportedBaudRates)
            {
                ToolStripMenuItem menuItemBaudrates = new ToolStripMenuItem(baudrates);
                menuItemBaudrates.Click += setPortBaudrate;
                menuItemA2.DropDownItems.Add(menuItemBaudrates);
            }
            this.contextMenuStrip1 = menu;



            WeightSerial = new SerialPort();
            bool IsPortExist = ports.Where(n => n == defaultConfig.SerialPortName).Any();
            if (IsPortExist)
            {
                try
                {
                    WeightSerial.BaudRate = defaultConfig.Baudrate;
                    WeightSerial.Parity = defaultConfig.Parity;
                    WeightSerial.StopBits = defaultConfig.StopBit;
                    WeightSerial.Handshake = Handshake.None;
                    WeightSerial.DataBits = 8;
                    WeightSerial.PortName = defaultConfig.SerialPortName;
                    this.WeightSerial.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
                    WeightSerial.Open();
                    GetWeighTimer = new Timer();
                    GetWeighTimer.Interval = (100); // 45 mins
                    GetWeighTimer.Tick += new EventHandler(GetWeighTimer_Tick);
                    GetWeighTimer.Start();


                }
                catch
                {
                    MessageBox.Show("پورت سخت افزاری باز است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("پورت سخت افزاری موجود نیست", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void GetWeighTimer_Tick(object sender, EventArgs e)
        {


            if (SystemConnected == false)
            {
                ConnectionCounter++;
                if (ConnectionCounter > 10 && ConnectionCounter < 20)
                {
                    byte[] IsOnlinePacket = { 0x01, 0x16, 0x01, 0x00, 0x94, 0x91 };
                    WeightSerial.Write(IsOnlinePacket, 0, IsOnlinePacket.Length);
                    byte[] ZeroPacket = { 0x01, 0x27, 0x01, 0x00, 0x5b, 0xc0 };
                    WeightSerial.Write(ZeroPacket, 0, ZeroPacket.Length);

                }
                if (ConnectionCounter == 20)
                {
                    this.Invoke(new EventHandler(UpdateConnectionLabel));
                    ConnectionCounter = 11;
                }
            }
            else
            {
                if (WeightSerial.IsOpen)
                {
                    byte[] WeightPacket = { 0x01, 0x13, 0x01, 0x00, 0x95, 0x81 };
                    WeightSerial.Write(WeightPacket, 0, WeightPacket.Length);
                    byte[] getTareValue = { 0x01, 0x24, 0x01, 0x00, 0x5B, 0x30 };
                    WeightSerial.Write(getTareValue, 0, getTareValue.Length);
                }
                if (ConnectionCounter++ > 5)
                {
                    ConnectionCounter = 0;
                    SystemConnected = false;
                    this.Invoke(new EventHandler(UpdateConnectionLabel));
                }
            }
        }


        int crccheck(int DataLenght)
        {
            int crc = 0xFFFF;
            int LoopCnti;
            for (LoopCnti = 0; LoopCnti < DataLenght; LoopCnti++)
            {
                crc = (int)((crc >> 8) ^ CrcTable[(crc ^ DataPack[LoopCnti]) & 0xFF]);
            }
            return crc;
        }

        void GetMyWeight()
        {
            string formIdList;
            List<int> ids;

            /*  if (DataPack[2]=='-')
              {
                  if(DataPack[3]=='4')
                  {
                      formIdList = System.Text.Encoding.UTF8.GetString(DataPack, 4, ProtocolDataLenght);
                      ids = formIdList.Split(',').Select(int.Parse).ToList();
                      weightState = true;
                  }
                  else
                  {
                      formIdList = System.Text.Encoding.UTF8.GetString(DataPack, 2, ProtocolDataLenght);
                      ids = formIdList.Split(',').Select(int.Parse).ToList();
                  }
              }
              else
              {
                  formIdList = System.Text.Encoding.UTF8.GetString(DataPack, 2, ProtocolDataLenght);
                  ids = formIdList.Split(',').Select(int.Parse).ToList();
              }*/

            formIdList = System.Text.Encoding.UTF8.GetString(DataPack, 2, ProtocolDataLenght);
            ids = formIdList.Split(',').Select(int.Parse).ToList();

            ViewWeight = ids[0];
            TareWeight = ids[1];
            WeightIndication = ids[3];
            ZeroFlag = (WeightIndication & 0x01) > 0;
            WeightIndication >>= 1;
            TareFlag = (WeightIndication & 0x02) > 0;
            WeightIndication >>= 1;
            StableFlag = (WeightIndication & 0x04) > 0;
            WeightIndication >>= 1;
            NegFlag = (WeightIndication & 0x08) > 0;
            WeightIndication >>= 1;
            W2Flag = (WeightIndication & 0x10) > 0;
            WeightIndication >>= 1;
            OverFlag = (WeightIndication & 0x20) > 0;
            WeightIndication >>= 1;
            BatFlag = (WeightIndication & 0x40) > 0;
            WeightIndication >>= 1;
            UnderFlag = (WeightIndication & 0x80) > 0;
        }

        void GetTare()
        {
            string formIdList = System.Text.Encoding.UTF8.GetString(DataPack, 2, ProtocolDataLenght);
            List<int> ids = formIdList.Split(',').Select(int.Parse).ToList();
            TareWeight = ids[0];
        }

        private void clearTare_Click(object sender, EventArgs e)
        {
            byte[] IsOnlinePacket = { 0x01, 0x25, 0x01, 0x00, 0x9b, 0x61 };
            WeightSerial.Write(IsOnlinePacket, 0, IsOnlinePacket.Length);
        }

        private void zero_Click(object sender, EventArgs e)
        {
            byte[] IsOnlinePacket = { 0x01, 0x27, 0x01, 0x00, 0x5b, 0xc0 };
            WeightSerial.Write(IsOnlinePacket, 0, IsOnlinePacket.Length);
        }

        private void tare_Click(object sender, EventArgs e)
        {
            byte[] IsOnlinePacket = { 0x01, 0x26, 0x01, 0x00, 0x9b, 0x91 };
            WeightSerial.Write(IsOnlinePacket, 0, IsOnlinePacket.Length);
        }

        private void ShowData()
        {
            SetTextTare(((float)TareWeight / 1000).ToString("0.000"));
            if (OverFlag == false && UnderFlag == false && NegFlag == false)
            {
                SetTextWeight(((float)ViewWeight / 1000).ToString("0.000"));
            }
            else
            {
                if (NegFlag == true)
                    SetTextWeight("------");
                else
                    SetTextWeight(((float)ViewWeight / 1000).ToString("0.000"));
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            for (int Cnt = 0; Cnt < WeightSerial.BytesToRead; Cnt++)
            {
                RData = (byte)WeightSerial.ReadByte();
                if (TakinServiceState == 0 && RData == 0x01)
                {
                    TakinServiceState = 1;
                    ProtocolAddress = RData;
                }
                else
                if (TakinServiceState == 1)
                {
                    TakinServiceState = 2;
                    ProtocolFunction = RData;
                    DataPack[0] = RData;

                }
                else
                if (TakinServiceState == 2)
                {
                    TakinServiceState = 3;
                    ProtocolDataLenght = RData;
                    DataPack[1] = RData;
                    LoopCnt = 2;
                }
                else
                if (TakinServiceState == 3)
                {
                    DataPack[LoopCnt] = RData;
                    LoopCnt++;
                    if (LoopCnt == ProtocolDataLenght + 2)
                        TakinServiceState = 4;
                }
                else
                if (TakinServiceState == 4)
                {
                    TakinServiceState = 5;
                    crchigh = RData;

                }
                else
                if (TakinServiceState == 5)
                {
                    TakinServiceState = 0;
                    crclow = RData;
                    TempVariable = crchigh;
                    TempVariable <<= 8;
                    TempVariable |= crclow;

                    crci = crccheck(ProtocolDataLenght + 2);

                    if (TempVariable == crci)
                    {
                        switch (ProtocolFunction)
                        {
                            case 0x13:
                                GetMyWeight();
                                ShowData();
                                ConnectionCounter = 0;
                                break;
                            case 0x16:
                                SystemConnected = true;
                                this.Invoke(new EventHandler(UpdateConnectionLabel));
                                ConnectionCounter = 0;
                                break;
                        }
                    }
                    else
                    {
                        TakinServiceState = 0;
                    }
                }
                else
                {
                    TakinServiceState = 0; //09124816051 maraghi
                }

            }
        }
        private void UpdateConnectionLabel(object sender, EventArgs e)
        {
            if (SystemConnected == true)
            {
                this.lblConnection.BackColor = Color.Green;
            }
            else
            {
                this.lblConnection.BackColor = Color.Red;
            }
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void QuitApp(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void ApplySetting(object sender, EventArgs e)
        {
            WriteToServiceConfiguration();
            if(WeightSerial.IsOpen == true)
            {
                WeightSerial.Close();
            }
            Application.Restart();
            Environment.Exit(0);
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        void firstPortSelection(object sender, EventArgs e)
        {
            defaultConfig.TcpPort1= int.Parse(Microsoft.VisualBasic.Interaction.InputBox("تنظیم شماره پورت یک", "شماره پورت", "9990"));
        }

        private void setPortName(object sender, EventArgs e)
        {
            defaultConfig.SerialPortName = sender.ToString();
        }
        private void setPortBaudrate(object sender, EventArgs e)
        {
            defaultConfig.Baudrate = int.Parse(sender.ToString());
        }
        private void secondPortSelection(object sender, EventArgs e)
        {
            defaultConfig.TcpPort2 = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("تنظیم شماره پورت دو", "شماره پورت", "9991"));
        }
    }
}