using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Net.Sockets;
using System.Net;

namespace ClientExam
{
    public partial class Form1 : Form
    {
        private TcpListener _tcpListener;
        private TcpClient _tcpClient;
        private Thread _thread;
        private int _port;
        private int _myPort;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buttonSend.Enabled = true;
            _thread = new Thread(Start);
            if (int.TryParse(portTextBox.Text, out _port))
            {
                if (int.TryParse(myPortTextBox.Text, out _myPort))
                {
                    _thread.Start();
                    buttonStart.Enabled = false;
                    nameTextBox.ReadOnly = true;
                    addressTextBox.ReadOnly = true;
                    portTextBox.ReadOnly = true;
                    myPortTextBox.ReadOnly = true;
                }
            }
        }

        private void Start()
        {
            Socket socket;
            StreamReader reader;
            NetworkStream stream;
            _tcpListener = new TcpListener(IPAddress.Any, _myPort);
            _tcpListener.Start();
            while (true)
            {
                try
                {
                    socket = _tcpListener.AcceptSocket();
                    if (socket.Connected)
                    {
                        stream = new NetworkStream(socket);
                        reader = new StreamReader(stream);
                        receiveTextBox.Text += reader.ReadToEnd() + "\n";
                        reader.Close();
                        stream.Close();
                        socket.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                _tcpListener?.Stop();
                _thread?.Abort();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            try
            {
                _tcpClient = new TcpClient(addressTextBox.Text, _port);
                NetworkStream stream;
                StreamWriter writer;
                if (_tcpClient.Connected)
                {
                    stream = _tcpClient.GetStream();
                    writer = new StreamWriter(stream);
                    var message = $"{DateTime.Now.ToString("hh:mm:ss")}:{nameTextBox.Text}: {messageTextBox.Text}";
                    receiveTextBox.Text += message + "\n";
                    writer.Write(message);
                    messageTextBox.Clear();
                    writer.Flush();
                    writer.Close();
                    stream.Close();
                    _tcpClient.Close();
                }
            }
            catch (Exception ex)
            {
                _tcpClient?.Close();
                MessageBox.Show(ex.Message);
            }
        }
    }
}
