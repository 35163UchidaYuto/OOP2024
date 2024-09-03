using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RSSReader {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btGet_Click(object sender, EventArgs e) {
            using (var wc = new WebClient()) {
                var url = wc.OpenRead(tbRssUrl.Text);
                var xdoc = XDocument.Load(url);

                var xtitle = xdoc.Root.Descendants("item").
                    Select(x => new {
                    Title = (string)x.Attribute("title"),
                    LinkArea = (string)x.Attribute("link"),
                    });
                    //Select(item=>item.Element("title").Value);
                
                foreach (var title in xtitle) {
                    lbRssTitle.Items.Add(title);

                }

                
            }
        }
    }
}
