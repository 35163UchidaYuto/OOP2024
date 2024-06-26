using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Exercise01 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btEx8_1_Click(object sender, EventArgs e) {
            var dateTime = DateTime.Now;
            // 2024/6/25 11:58 
            var str1 = string.Format("{0:yyyy/M/d HH:mm}", dateTime);
            tbDisp.Text = str1 + "\r\n";

            // 2024年06月25日 11時58分32秒 
            var str2 = dateTime.ToString("yyyy年MM月dd日 HH時mm分ss秒");
            tbDisp.Text += str2 + "\r\n";

            // 令和6年 6月25日(火曜日)
            var culture = new CultureInfo("ja-JP");
            culture.DateTimeFormat.Calendar = new JapaneseCalendar();

            var datestr = dateTime.ToString("ggyy", culture);
            var dayOfWeek = culture.DateTimeFormat.GetDayName(dateTime.DayOfWeek);

            var str3 = string.Format("{0}年{1,2}月{2,2}日({3})", datestr, dateTime.Month, dateTime.Day, dayOfWeek);
            tbDisp.Text += str3;
        }

        private void btEx8_2_Click(object sender, EventArgs e) {

            var dateTime = DateTime.Today;

            foreach (var dayofweek in Enum.GetValues(typeof(DayOfWeek))) {

                var str1 = string.Format("{0:yy/MM/dd}の次週の{1}: ", dateTime, (DayOfWeek)dayofweek);
                //来週の日付を取得
                var str2 = string.Format("{0:yy/MM/dd(ddd)} ", NextWeek(dateTime, (DayOfWeek)dayofweek));
                tbDisp.Text += str1 + str2 + "\r\n";
            }
        }

        //第１引数で指定した日付の翌週のインスタンスを返却する。
        public static DateTime NextWeek(DateTime date, DayOfWeek dayOfWeek) {
            var nextweek = date.AddDays(7);
            var day = (int)dayOfWeek - (int)date.DayOfWeek;
            return nextweek.AddDays(day);
        }

        private void btEx8_3_Click(object sender, EventArgs e) {
            var tw = new TimeWatch();
            tw.Start();
            Thread.Sleep(1000);
            TimeSpan duration = tw.Stop();
            var str = String.Format("処理時間は{0}ミリ秒でした", duration.TotalMilliseconds);
            tbDisp.Text = str;
        }
    }

    class TimeWatch {
        private DateTime _time;

        public void Start() {
            _time = DateTime.Now;
        }

        public TimeSpan Stop() {
            return DateTime.Now - _time;
        }

    }
}
