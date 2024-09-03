using Server.DTO;
using Server.Models;
using Server.Other;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using static System.Net.WebRequestMethods;

namespace Server.Views
{
    public partial class MainForm : Form
    {
        private const string LOCALHOST = "127.0.0.1";

        private TcpListener _tcpListener;
        public XmlModel XmlModel { get; private set; }
        public IpPortDTO IpPortDTO { get; private set; }

        public MainForm()
        {
            InitializeComponent();
        }

        private void OpenFileBtn_Click(object sender, EventArgs e)
        {
            openXmlFileDialog.Filter = "XML Files (*.xml)|*.xml";
            openXmlFileDialog.DefaultExt = "xml";
            if (openXmlFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string filePath = openXmlFileDialog.FileName;
            try
            {
                XmlModel = ParseXml(filePath);
                ShowCurrentXml();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка парсинга xml");
                return;
            }

        }

        private void ShowCurrentXml()
        {
            pictureBox.Image = XmlModel.Image;
            StringBuilder text = new StringBuilder();
            text.Append("FormatVersion: ");
            text.AppendLine(XmlModel.FormatVersion);

            text.Append("from: ");
            text.AppendLine(XmlModel.From);

            text.Append("to: ");
            text.AppendLine(XmlModel.To);

            text.Append("id: ");
            text.AppendLine(XmlModel.Id);

            XmlTB.Text = text.ToString();
            RichTextBoxExtensions.AppendText(this.XmlTB, "text: " + XmlModel.Text, XmlModel.Color);
        }

        private XmlModel ParseXml(string filePath)
        {
            XmlModel xmlModel = new XmlModel();
            XmlDocument doc = new XmlDocument();
            doc.Load(filePath);

            XmlNode messageNode = doc.DocumentElement.SelectSingleNode("/root/Message");
            xmlModel.FormatVersion = messageNode.Attributes["FormatVersion"]?.InnerText;
            xmlModel.From = messageNode.Attributes["from"]?.InnerText;
            xmlModel.To = messageNode.Attributes["to"]?.InnerText;

            XmlNode msgNode = doc.DocumentElement.SelectSingleNode("/root/Message/msg");
            xmlModel.Id = msgNode.Attributes["id"]?.InnerText;

            XmlNode textNode = doc.DocumentElement.SelectSingleNode("/root/Message/msg/text");
            xmlModel.Text = textNode.InnerText;
            int argb = Int32.Parse(textNode.Attributes["color"]?.InnerText, NumberStyles.HexNumber);
            xmlModel.Color = Color.FromArgb(argb);

            XmlNode imageNode = doc.DocumentElement.SelectSingleNode("/root/Message/msg/image");
            xmlModel.Image = Base64ToImage(imageNode.InnerText);

            return xmlModel;
        }

        private Image Base64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                return Image.FromStream(ms, true);
            }
        }

        private void ConnectBtn_Click(object sender, EventArgs e)
        {
            InitListenerAsync();
        }

        private void LocalhostCB_CheckedChanged(object sender, EventArgs e)
        {
            if (LocalhostCB.Checked)
                IpTB.Text = LOCALHOST;
            else
                IpTB.Text = String.Empty;
        }

        private async Task InitListenerAsync()
        {
            if (!ValidateIpAndPort())
                return;

            _tcpListener = new TcpListener(IpPortDTO.Ip, IpPortDTO.Port);
            try
            {
                _tcpListener.Start();    // запускаем сервер
                Console.WriteLine("Сервер запущен. Ожидание подключений... ");

                while (true)
                {
                    // получаем подключение в виде TcpClient
                    var tcpClient = await _tcpListener.AcceptTcpClientAsync();

                    // создаем новую задачу для обслуживания нового клиента
                    Task.Run(async () => await ProcessClientAsync(tcpClient));
                }
            }
            finally
            {
                _tcpListener.Stop();
            }
        }

        async Task ProcessClientAsync(TcpClient tcpClient)
        {
            //TODO:
            //ClientIpLabel.Text = tcpClient.Client.RemoteEndPoint.AddressFamily.
            var stream = tcpClient.GetStream();
            var modelByteArray = Serialize(XmlModel);
            await stream.WriteAsync(modelByteArray, 0, modelByteArray.Length);
            tcpClient.Close();
        }

        public byte[] Serialize(object anySerializableObject)
        {
            using (var memoryStream = new MemoryStream())
            {
                (new BinaryFormatter()).Serialize(memoryStream, anySerializableObject);
                return memoryStream.ToArray();
            }
        }

        private bool ValidateIpAndPort()
        {
            IpPortDTO = new IpPortDTO();
            try
            {
                IpPortDTO.Ip = IPAddress.Parse(IpTB.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка ip адреса");
                return false;
            }

            bool success = int.TryParse(PortTB.Text, out int number);
            if (success)
            {
                IpPortDTO.Port = number;
            }
            else
            {
                MessageBox.Show("Ошибка порта");
                return false;
            }

            return true;
        }

        private void IpTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void PortTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
