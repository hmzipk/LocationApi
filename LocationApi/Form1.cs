using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace LocationApi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            XmlTextReader okuyucum = new XmlTextReader("http://ip-api.com/xml");
            while(okuyucum.Read())
            {
                if(okuyucum.NodeType == XmlNodeType.Element)
                { 
                    if(okuyucum.Name == "country")
                    {
                        okuyucum.Read();
                        richTextBox1.Text += "Ülke:" + okuyucum.Value.ToString() + "\n";
                    }
                    if (okuyucum.Name == "regionName")
                    {
                        okuyucum.Read();
                        richTextBox1.Text += "Sehir:" + okuyucum.Value.ToString() + "\n";

                    }
                    if (okuyucum.Name == "query")
                    {
                        okuyucum.Read();
                        richTextBox1.Text += "IP:" + okuyucum.Value.ToString() + "\n";

                    }
                    if (okuyucum.Name == "timezone")
                    {
                        okuyucum.Read();
                        richTextBox1.Text += "TimeZone:" + okuyucum.Value.ToString() + "\n";

                    }
                    if (okuyucum.Name == "isp")
                    {
                        okuyucum.Read();
                        richTextBox1.Text += "Internet Servis Saglayici:" + okuyucum.Value.ToString() + "\n";

                    }
                }
            }
            okuyucum.Close();
        }
    }
}
