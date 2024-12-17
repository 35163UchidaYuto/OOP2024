using CustomerApp.Objects;
using Microsoft.Win32;
using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
 
namespace CustomerApp {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        List<Customer> _customers;
        public MainWindow() {
            InitializeComponent();
            ReadDatabase();
 
 
        }
 
        private void SaveButton_Click(object sender, RoutedEventArgs e) {
            var customer = new Customer() {
                Name = NameTextBox.Text,
                Phone = PhoneTextBox.Text,
                Address = AddressTextBox.Text,
                Image = CustomerImage.Source != null ? ImageToByteArray(CustomerImage.Source as BitmapImage) : null  // バイト配列に変換
            };
 
            using (var connection = new SQLiteConnection(App.databasePass)) {
                connection.CreateTable<Customer>();
                connection.Insert(customer);
 
                TextBox_Clear();
            }
            ReadDatabase(); // ListView更新
        }
 
 
        private void ReadDatabase() {
            using (var connection = new SQLiteConnection(App.databasePass)) {
                connection.CreateTable<Customer>();
                _customers = connection.Table<Customer>().ToList();
                CustomerListView.ItemsSource = _customers;
 
            }
        }
 
        private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e) {
            var fiterList = _customers.Where(x => x.Name.Contains(SearchTextBox.Text)).ToList();
            CustomerListView.ItemsSource = fiterList;
        }
 
        private void TextBox_Clear() {
            NameTextBox.Text = "";
            AddressTextBox.Text = "";
            PhoneTextBox.Text = "";
            CustomerImage.Source = null;
        }
 
        private void DeleteButton_Click(object sender, RoutedEventArgs e) {
            var item = CustomerListView.SelectedItem as Customer;
            if (item == null) {
                MessageBox.Show("削除する行を選択してください");
                return;
            }
 
            using (var connection = new SQLiteConnection(App.databasePass)) {
                connection.CreateTable<Customer>();
                connection.Delete(item);  // 画像も一緒に削除される
                TextBox_Clear();
            }
 
            ReadDatabase();  // ListView更新
        }
 
 
        private void UpdateButton_Click(object sender, RoutedEventArgs e) {
            var item = CustomerListView.SelectedItem as Customer;
            if (item != null) {
                // ユーザーが入力した新しい情報を反映
                item.Name = NameTextBox.Text;
                item.Phone = PhoneTextBox.Text;
                item.Address = AddressTextBox.Text;
 
                // 画像が変更された場合、画像を更新
                if (CustomerImage.Source != null) {
                    // 画像をバイト配列に変換してセット
                    item.Image = ImageToByteArray(CustomerImage.Source as BitmapImage);
                }
 
                // SQLiteデータベースで更新を行う
                using (var connection = new SQLiteConnection(App.databasePass)) {
                    connection.CreateTable<Customer>();
                    connection.Update(item);  // 顧客情報を更新
                    TextBox_Clear();
 
                    // ListViewを再読み込みして更新されたデータを表示
                    ReadDatabase();
                }
            }
        }
 
        private void CustomerListView_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            var item = CustomerListView.SelectedItem as Customer;
            if (item != null) {
                NameTextBox.Text = item.Name;
                PhoneTextBox.Text = item.Phone;
                AddressTextBox.Text = item.Address;
 
                // バイト配列から画像に変換して表示
                if (item.Image != null && item.Image.Length > 0) {
                    CustomerImage.Source = ByteArrayToImage(item.Image);
                }
            }
        }
 
 
        //画像の選択
        private void PicSaveButton_Click(object sender, RoutedEventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "画像ファイル(*.jpg;*.jpeg;*.png;)|*.jpg;*.jpeg;*.png";
 
            if (openFileDialog.ShowDialog() == true) {
                string filePath = openFileDialog.FileName;
                // 画像を表示する
                CustomerImage.Source = new BitmapImage(new Uri(filePath));
            }
        }
 
        private void PicDeleteButton_Click(object sender, RoutedEventArgs e) {
            CustomerImage.Source = null;
        }
 
        public static byte[] ImageToByteArray(BitmapImage bitmapImage) {
            if (bitmapImage == null) return null;
 
            using (var ms = new MemoryStream()) {
                PngBitmapEncoder encoder = new PngBitmapEncoder();
                encoder.Frames.Add(BitmapFrame.Create(bitmapImage));
                encoder.Save(ms);
                return ms.ToArray();  // バイト配列を返す
            }
        }
 
        public static ImageSource ByteArrayToImage(byte[] byteArray) {
            if (byteArray == null || byteArray.Length == 0) {
                return null;  // バイト配列が空またはnullの場合はnullを返す
            }
 
            using (var ms = new MemoryStream(byteArray)) {
                BitmapImage bitmapImage = new BitmapImage();
                bitmapImage.BeginInit();
                bitmapImage.StreamSource = ms;
                bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapImage.EndInit();
                return bitmapImage;
            }
        }
 
    }
}