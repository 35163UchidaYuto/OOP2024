namespace Exercise01 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btEx8_1_Click(object sender, EventArgs e) {

            var date = new DateTime(2019, 1, 15, 19, 48, 32);
            tbDisp.Text = date.ToString("yyyy/M/dd hh:mm\r\n");
            tbDisp.Text += date.ToString("yyyy年MM月dd日 hh時mm分ss秒\r\n");
            tbDisp.Text += date.ToString("ggyy年 M月dd日 (dddd)");
        }

        private void btEx8_2_Click(object sender, EventArgs e) {
            var days = (int)DayOfWeek - (int)(DateBoldEventArgs.DayOfWeek);
            if(days > 0) {
                days += 7;
                return DateBoldEventArgs.AddDays(days);
            }
        }
    }
}
