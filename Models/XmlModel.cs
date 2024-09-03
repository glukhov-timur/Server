using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Models
{
    public class XmlModel
    {
        public string FormatVersion { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string Id { get; set; }
        public Color Color { get; set; }
        public string Text { get; set; }
        public Image Image { get; set; }
    }
}
