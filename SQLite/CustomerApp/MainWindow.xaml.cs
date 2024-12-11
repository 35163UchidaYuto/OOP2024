using CustomerApp.Objects;
using Microsoft.Win32;
using SQLite;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace CustomerApp {
    public partial class MainWindow : Window {
        List<Customer> _customers;

        public MainWindow() {
            InitializeComponent();
            InitializeDatabase();
            ReadDatabase();
        }

        private void InitializeDatabase() {
            using (var connection = new SQLiteConnection(App.datebasePass)) {
                connection.CreateTable<Customer>();
            }
        }

        // 保存処理
        private void RegistButton_Click(object sender, RoutedEventArgs e) {
            byte[] ShowImage = this.ShowImage.Source != null
                ? ConvertImageToByteArray((BitmapImage)this.ShowImage.Source)
                : null;
            var customer = new Customer() {
                Name = NameTextBox.Text,
                Phone = PhoneTextBox.Text,
                Address = AddressTextBox.Text,
                Picture = ShowImage
            };

            if (Name == null) {
                MessageBox.Show("名前を入力してください");
                return;
            }
            


            using (var connection = new SQLiteConnection(App.datebasePass)) {
                connection.Insert(customer);
            }

            ReadDatabase();
            ClearText();
        }

        // BitmapImage を byte[] に変換
        private byte[] ConvertImageToByteArray(BitmapImage bitmapImage) {
            using (var memoryStream = new MemoryStream()) {
                BitmapEncoder encoder = new JpegBitmapEncoder();
                encoder.Frames.Add(BitmapFrame.Create(bitmapImage));
                encoder.Save(memoryStream);
                return memoryStream.ToArray();
            }
        }

        // byte[] を BitmapImage に変換
        private BitmapImage ConvertByteArrayToImage(byte[] imageData) {
            if (imageData == null || imageData.Length == 0) return null;

            using (var memoryStream = new MemoryStream(imageData)) {
                var bitmapImage = new BitmapImage();
                bitmapImage.BeginInit();
                bitmapImage.StreamSource = memoryStream;
                bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapImage.EndInit();
                return bitmapImage;
            }
        }

        // 修正処理
        private void UpgateButton_Click(object sender, RoutedEventArgs e) {
            var item = CustomerListView.SelectedItem as Customer;
            if (item == null) {
                MessageBox.Show("行を選択してください");
                return;
            }

            item.Name = NameTextBox.Text;
            item.Phone = PhoneTextBox.Text;
            item.Address = AddressTextBox.Text;

            using (var connection = new SQLiteConnection(App.datebasePass)) {
                connection.Update(item);
            }

            ReadDatabase();
            ClearText();
        }

        // テキストボックスをクリア
        private void ClearText() {
            NameTextBox.Clear();
            PhoneTextBox.Clear();
            AddressTextBox.Clear();
            ShowImage.Source = null;
        }

        // データベース読み込み
        private void ReadDatabase() {
            using (var connection = new SQLiteConnection(App.datebasePass)) {
                _customers = connection.Table<Customer>().ToList();
            }

            CustomerListView.ItemsSource = _customers;
        }

        // 検索
        private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e) {
            var filteredList = _customers.Where(x => x.Name.Contains(SearchTextBox.Text)).ToList();
            CustomerListView.ItemsSource = filteredList;
        }

        // 削除
        private void DeleteButton_Click(object sender, RoutedEventArgs e) {
            var item = CustomerListView.SelectedItem as Customer;
            if (item == null) {
                MessageBox.Show("削除する行を選択してください");
                return;
            }

            using (var connection = new SQLiteConnection(App.datebasePass)) {
                connection.Delete(item);
            }

            ReadDatabase();
        }

        // 画像を開く
        private void OpenButton_Click(object sender, RoutedEventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.png;*.jpeg;*.jpg)|*.png;*.jpeg;*.jpg";
            if (openFileDialog.ShowDialog() == true) {
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(openFileDialog.FileName);
                bitmap.CacheOption = BitmapCacheOption.OnLoad;
                bitmap.EndInit();
                ShowImage.Source = bitmap;
            }
        }

        // 画像をクリア
        private void ClearButton_Click(object sender, RoutedEventArgs e) {
            ShowImage.Source = null;
        }

        // 選択された顧客の画像を表示
        private void CustomerListView_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            if (CustomerListView.SelectedItem is Customer selectedCustomer) {
                NameTextBox.Text = selectedCustomer.Name;
                PhoneTextBox.Text = selectedCustomer.Phone;
                AddressTextBox.Text = selectedCustomer.Address;
                ShowImage.Source = selectedCustomer.Picture != null
                    ? ConvertByteArrayToImage(selectedCustomer.Picture)
                    : null;
            }
        }
    }

}