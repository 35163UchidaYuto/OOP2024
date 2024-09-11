using Microsoft.Web.WebView2.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Windows.UI.Xaml.Controls;

namespace RSSReader {


    public partial class Form1 : Form {
        List<ItemData> items;
        public Form1() {
            InitializeComponent();
        }

        private void btGet_Click(object sender, EventArgs e) {
            using (var wc = new WebClient()) {
                var url = wc.OpenRead(cb1.Text);
                var xdoc = XDocument.Load(url);

                items = xdoc.Root.Descendants("item").
                   Select(item => new ItemData {
                       Title = item.Element("title").Value,
                       Link = item.Element("link").Value
                   }).ToList();


                foreach (var item in items) {
                    lbRssTitle.Items.Add(item.Link);
                    lbRssTitle.Items.Add(item.Title);
                }
            }
        }

        private void lbRssTitle_SelectedIndexChanged(object sender, EventArgs e) {
            if (webView2 != null && webView2.CoreWebView2 != null) {
                webView2.CoreWebView2.Navigate(lbRssTitle.Text);
            }
        }



        private void AddName(string tbName) {
            if (!cb1.Items.Contains(tbName))
                cb1.Items.Add(tbName);
        }


        //データ格納用のクラス
        public class ItemData {
            public string Title { get; set; }
            public string Link { get; set; }
        }

        private void btRegistration_Click(object sender, EventArgs e) {
            //AddName();
        }
    }
}
