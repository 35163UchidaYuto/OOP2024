using CustomerApp.Objects;
using SQLite;
using System;
using System.Collections.Generic;
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
            };

            using (var connection = new SQLiteConnection(App.datebasePass)) {
                connection.CreateTable<Customer>();
                connection.Insert(customer);
                ReadDatabase();//ListView表示
            }
        }

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
            }
        }

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
            NameTextBox.Text = _customers[CustomerListView.SelectedIndex].Name;
            PhoneTextBox.Text = _customers[CustomerListView.SelectedIndex].Phone;
            AddressTextBox.Text = _customers[CustomerListView.SelectedIndex].Address;
        }
    }
}
