using CustomerApp.Objects;
using Microsoft.Win32;
using SQLite;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
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
using static System.Net.Mime.MediaTypeNames;



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

        BitmapImage bitmap = new BitmapImage();

        public void Convart() {
            Bitmap bmp = new Bitmap(bitmap);
            MemoryStream ms = new MemoryStream();
            bmp.Save(ms, ImageFormat.Jpeg);
            byte[] binaryData = ms.ToArray();
        }



        //保存
        private void RegistButton_Click(object sender, RoutedEventArgs e) {
            var customer = new Customer() {
                Name = NameTextBox.Text,
                Phone = PhoneTextBox.Text,
                Address = AddressTextBox.Text,
            };

            using (var connection = new SQLiteConnection(App.datebasePass)) {
                connection.CreateTable<Customer>();
                connection.Insert(customer);
                ReadDatabase();//ListView表示
                ClearText();
            }
        }
        //修正
        private void UpgateButton_Click(object sender, RoutedEventArgs e) {

            var Item = CustomerListView.SelectedItem as Customer;
            if (Item == null) {
                MessageBox.Show("行を決めてください");
                return;
            }
            Item.Name = NameTextBox.Text;
            Item.Phone = PhoneTextBox.Text;
            Item.Address = AddressTextBox.Text;

            using (var connection = new SQLiteConnection(App.datebasePass)) {
                connection.CreateTable<Customer>();
                connection.Update(Item);
                ReadDatabase();
                ClearText();
            }
        }
        //テキストボックス内クリア
        private void ClearText() {
            var customer = new Customer() {
                Name = NameTextBox.Text,
                Phone = PhoneTextBox.Text,
                Address = AddressTextBox.Text,
            };
            NameTextBox.Clear();
            PhoneTextBox.Clear();
            AddressTextBox.Clear();
        }

        //読み込み
        private void ReadDatabase() {
            using (var connection = new SQLiteConnection(App.datebasePass)) {
                connection.CreateTable<Customer>();
                _customers = connection.Table<Customer>().ToList();

                CustomerListView.ItemsSource = _customers;
            }
        }

        private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e) {
            var filterList = _customers.Where(x => x.Name.Contains(SearchTextBox.Text)).ToList();
            CustomerListView.ItemsSource = filterList;
        }
        //削除
        private void DeleteButton_Click(object sender, RoutedEventArgs e) {
            var Item = CustomerListView.SelectedItem as Customer;
            if (Item == null) {
                MessageBox.Show("削除する行を決めてください");
                return;
            }
            using (var connection = new SQLiteConnection(App.datebasePass)) {
                connection.CreateTable<Customer>();
                connection.Delete(Item);


                ReadDatabase();//ListView表示
            }

        }
        private void CustomerListView_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            if (CustomerListView.SelectedIndex != -1) {
                NameTextBox.Text = _customers[CustomerListView.SelectedIndex].Name;
                PhoneTextBox.Text = _customers[CustomerListView.SelectedIndex].Phone;
                AddressTextBox.Text = _customers[CustomerListView.SelectedIndex].Address;
            }

        }



        private void OpenButton_Click(object sender, RoutedEventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog(); // OpenFileDialogのインスタンス化
            openFileDialog.Filter = "Image files (*.png;*.jpeg;*.jpg)|*.png;*.jpeg;*.jpg";
            if (openFileDialog.ShowDialog() == true) {

                BitmapImage bitmap = new BitmapImage(new Uri(openFileDialog.SafeFileName));
                ShowImage.Source = bitmap;


            }
        }



        private void ClearButton_Click(object sender, RoutedEventArgs e) {
            ShowImage.Source = null;
        }
    }
}