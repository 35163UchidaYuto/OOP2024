using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace ColorChecker {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        MyColor currentColor ;//現在設定している色情報
        MyColor[] colorsTable;//色のデータ


        public MainWindow() {
            InitializeComponent();
            //aチャンネルの初期値を設定　（起動時すぐにストックボタンが押された場合の対応）
            currentColor.Color = Color.FromArgb(255,0,0,0);
            DataContext = colorsTable = GetColorList();
        }
        private MyColor[] GetColorList() {
            return typeof(Colors).GetProperties(BindingFlags.Public | BindingFlags.Static)
                .Select(i => new MyColor() { Color = (Color)i.GetValue(null), Name = i.Name }).ToArray();
        }



        //スライドを動かすと呼ばれるイベントハンドラ
        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
            currentColor.Color = Color.FromRgb((byte)rSlider.Value, (byte)gSlider.Value, (byte)bSlider.Value);
            //currentColor.Name = GetColorList().Where(c =>c.Color.Equals(currentColor.Color)).Select(x=>x.Name).FirstOrDefault();

            int i;
            for(i = 0; i < colorsTable.Length; i++) {
                if (colorsTable[i].Color.Equals(currentColor.Color)) {
                    currentColor.Name = colorsTable[i].Name;
                    break;
                }
            }
            colorSelectComboBox.SelectedIndex = i;                      
            colorArea.Background = new SolidColorBrush(currentColor.Color);

        }

        //既に登録されている場合は登録しない
        private void stockButton_Click(object sender, RoutedEventArgs e) {
            if (!stockList.Items.Contains((MyColor)currentColor)) {
            stockList.Items.Insert(0, currentColor);
            } else {
                MessageBox.Show("既に登録済みです","ColorChechecker",MessageBoxButton.OK);
            }
            
        }

        private void stockList_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            colorArea.Background = new SolidColorBrush(((MyColor)stockList.Items[stockList.SelectedIndex]).Color);
            setSliderValue(((MyColor)stockList.Items[stockList.SelectedIndex]).Color);
        }

        //各スライダーの値を設定する
        private void setSliderValue(Color color) {
            rSlider.Value = color.R;
            gSlider.Value = color.G;
            bSlider.Value = color.B;
        }

        

        private void colorSelectComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            currentColor = (MyColor)((ComboBox)sender).SelectedItem;
            setSliderValue(currentColor.Color);
        }
    }
}

