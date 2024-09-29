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
        Dictionary<string, string> source = new Dictionary<string, string> {
            {"主要","https://news.yahoo.co.jp/rss/topics/top-picks.xml" },
            {"国内","https://news.yahoo.co.jp/rss/topics/domestic.xml" },
            {"国際","https://news.yahoo.co.jp/rss/topics/world.xml" },
            {"経済","https://news.yahoo.co.jp/rss/topics/business.xml" },
            {"エンタメ","https://news.yahoo.co.jp/rss/topics/entertainment.xml" },
            {"スポーツ","https://news.yahoo.co.jp/rss/topics/sports.xml" },
            {"IT","https://news.yahoo.co.jp/rss/topics/it.xml" },
            {"科学","https://news.yahoo.co.jp/rss/topics/science.xml" },
            {"地域","https://news.yahoo.co.jp/rss/topics/local.xml" }
        };

        List<ItemData> items;
        private EventHandler<CoreWebView2InitializationCompletedEventArgs> webView2_CoreWebView2InitializationCompleted;
        public Form1() {
            InitializeComponent();
            webView2.CoreWebView2InitializationCompleted += webView2_CoreWebView2InitializationCompleted;

            webView2.EnsureCoreWebView2Async(null);
            source.Add(tbName.Text, cbFavorite.Text);
            cbFavorite.DataSource = new BindingSource(source, null);
            cbFavorite.DisplayMember = "Key";
            cbFavorite.ValueMember = "Value";
            this.Resize += new System.EventHandler(this.Form_Resize);

            cbFavorite.SelectedIndex = -1;

        }

        private void Form_Resize(object sender, EventArgs e) {
            webView2.Size = this. ClientSize - new System.Drawing.Size(webView2.Location);
        }

        //取得ボタン
        private void btGet_Click(object sender, EventArgs e) {
            lbRssTitle.Items.Clear();
            var cbBoxinput = cbFavorite.Text;

            if (cbFavorite.Text.Contains("news.yahoo.co.jp/rss/")) {
                using (var wc = new WebClient()) {
                    var rssurl = wc.OpenRead(cbFavorite.Text);
                    var xdoc = XDocument.Load(rssurl);

                    items = xdoc.Root.Descendants("item")
                            .Select(item => new ItemData {
                                Title = item.Element("title").Value,
                                Link = item.Element("link").Value
                            }).ToList();

                    foreach (var item in items) {
                        lbRssTitle.Items.Add(item.Title);
                    }
                }
            } else if (source.ContainsKey(cbBoxinput)) {
                var selectedCategory = (KeyValuePair<string, string>)cbFavorite.SelectedItem;
                var url = selectedCategory.Value;

                using (var wc = new WebClient()) {
                    var rssurl = wc.OpenRead(url);
                    var xdoc = XDocument.Load(rssurl);

                    items = xdoc.Root.Descendants("item")
                            .Select(item => new ItemData {
                                Title = item.Element("title").Value,
                                Link = item.Element("link").Value
                            }).ToList();

                    foreach (var item in items) {
                        lbRssTitle.Items.Add(item.Title);
                    }
                }
            } else {
                MessageBox.Show("正しいＵＲＬを入力してください", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //ウェブビュアーに表示
        private void lbRssTitle_SelectedIndexChanged(object sender, EventArgs e) {
            if (webView2 != null && webView2.CoreWebView2 != null) {
                webView2.CoreWebView2.Navigate(items[lbRssTitle.SelectedIndex].Link);
            }
        }
        //登録ボタン
        private void btRegistration_Click(object sender, EventArgs e) {
            if (tbName.Text != null && cbFavorite.Text.Contains("news.yahoo.co.jp/rss/")) {
                source.Add(tbName.Text, cbFavorite.Text);
                cbFavorite.DataSource = new BindingSource(source, null);
                cbFavorite.DisplayMember = "Key";
                cbFavorite.ValueMember = "Value";
            } else {
                MessageBox.Show("名前とＵＲＬを入力してください", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            tbName.Clear();
            cbFavorite.SelectedIndex = -1;
        }

        //データ格納用のクラス
        public class ItemData {
            public string Title { get; set; }
            public string Link { get; set; }
        }
    }
}
