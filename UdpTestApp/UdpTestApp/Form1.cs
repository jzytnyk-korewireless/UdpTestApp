using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UdpTestApp
{
    public partial class Form1 : Form
    {
        private Socket _radiusSocket;
        private const int SIXTEEN_MEGABYTES = 16777216;
        private IPAddress _radiusServerIp = IPAddress.Any;
        private int _radiusPort = 1812;


        public Form1()
        {
            InitializeComponent();
        }

        private void btn_SendUdpPacket_Click(object sender, EventArgs e)
        {

            try
            {
                if (_radiusSocket != null)
                {
                    _radiusSocket.Close();
                }
            }
            catch (Exception ex)
            {

            }

            try
            {
                _radiusSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                _radiusSocket.SendBufferSize = SIXTEEN_MEGABYTES;
                _radiusSocket.ReceiveBufferSize = SIXTEEN_MEGABYTES;
                //_radiusSocket.Bind(new IPEndPoint(_radiusServerIp, _radiusPort));

                //uint IOC_IN = 0x80000000;
                //uint IOC_VENDOR = 0x18000000;
                //uint SIO_UDP_CONNRESET = IOC_IN | IOC_VENDOR | 12;

                string testString = "Giggle";

                IPAddress serverAddr = IPAddress.Parse("172.31.100.156");

                IPEndPoint endPoint = new IPEndPoint(serverAddr, 1812);

                var sendData = Encoding.Default.GetBytes(testString);

                // _radiusSocket.IOControl((int)SIO_UDP_CONNRESET, new[] { Convert.ToByte(false) }, null);

                _radiusSocket.SendTo(sendData, 0, testString.Length, SocketFlags.None, endPoint);
            }
            catch (Exception)
            {


            }

        }

    }
}
