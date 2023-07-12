using System;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UdpTrafficGenerator
{
    public partial class Form1 : Form
    {
        private UdpClient udpClient;
        private Thread sendThread;
        private Thread receiveThread;
        private bool running;
        private int sentPackets;
        private int receivedPackets;
        private int lostPackets;

        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            // ��������� ������������ ��������� ����������
            if (!IPAddress.TryParse(ipTextBox.Text, out var ipAddress))
            {
                MessageBox.Show("Invalid IP address");
                return;
            }

            if (!PhysicalAddress.TryParse(macTextBox.Text, out var macAddress))
            {
                MessageBox.Show("Invalid MAC address");
                return;
            }

            if (!int.TryParse(bitrateTextBox.Text, out var bitrate)
                || bitrate < 1_000_000 || bitrate > 1_000_000_000)
            {
                MessageBox.Show("Invalid bitrate (should be between 1 Mb/s and 1 Gb/s)");
                return;
            }

            if (!int.TryParse(packetSizeTextBox.Text, out var packetSize) || packetSize < 1)
            {
                MessageBox.Show("Invalid packet size");
                return;
            }

            // ������� UDP ����� ��� �������� � ������ ������
            udpClient = new UdpClient();
            udpClient.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            udpClient.ExclusiveAddressUse = false;
            udpClient.Client.Bind(new IPEndPoint(IPAddress.Any, 1234));

            // ��������� ����� ��� �������� UDP �������
            running = true;
            sentPackets = 0;
            lostPackets = 0;
            int packetsPerSecond = bitrate / packetSize;
            int interval = 1000 / packetsPerSecond;
            sendThread = new Thread(() =>
            {
                byte[] packetData = new byte[packetSize];
                var endPoint = new IPEndPoint(ipAddress, 1234);
                while (running)
                {
                    try
                    {
                        udpClient.Send(packetData, packetData.Length, endPoint);
                        sentPackets++;
                    }
                    catch (SocketException ex)
                    {
                        lostPackets++;
                    }
                    Thread.Sleep(interval);
                }
            });
            sendThread.Start();

            // ��������� ����� ��� ������ UDP �������
            receivedPackets = 0;
            receiveThread = new Thread(() =>
            {
                while (running)
                {
                    try
                    {
                        var endPoint = new IPEndPoint(IPAddress.Any, 0);
                        var receivedData = udpClient.Receive(ref endPoint);
                        var receivedMac = GetMACFromARPTable(endPoint.Address);
                        if (macAddress.Equals(receivedMac))
                        {
                            receivedPackets++;
                        }
                    }
                    catch (SocketException ex)
                    {
                        // do nothing
                    }
                }
            });
            receiveThread.Start();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            // ������������� ������ �������� � ������ ������
            running = false;
            sendThread.Join();
            receiveThread.Join();

            // ��������� �����
            udpClient.Close();
            udpClient = null;

            // ������� ����������
            MessageBox.Show($"Sent: {sentPackets}\nReceived: {receivedPackets}\nLost: {lostPackets}");
        }

        private PhysicalAddress GetMACFromARPTable(IPAddress ipAddress)
        {
            foreach (var nic in System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces())
            {
                if (nic.NetworkInterfaceType == System.Net.NetworkInformation.NetworkInterfaceType.Ethernet &&
                    nic.OperationalStatus == System.Net.NetworkInformation.OperationalStatus.Up)
                {
                    return nic.GetPhysicalAddress();
                }
            }

            return null;
        }
    }
}
