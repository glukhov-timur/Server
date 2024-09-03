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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Server.Views
{
    public partial class MainForm : Form
    {
        public XmlModel XmlModel { get; set; }

        public MainForm()
        {
            InitializeComponent();
        }

        private void OpenFileBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            
            string filePath = openFileDialog1.FileName;
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

        }
    }
}
