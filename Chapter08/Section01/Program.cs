using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("生年月日を入力");
            Console.Write("年");
            int year = int.Parse(Console.ReadLine());
            Console.Write("月");
            int month = int.Parse(Console.ReadLine());
            Console.Write("日");
            int day = int.Parse(Console.ReadLine());
            var birthday = new DateTime(year, month, day);
            DayOfWeek dayOfWeek = birthday.DayOfWeek;



            //あなたは平成〇〇年〇月〇日〇曜日に生まれました。
            var culture = new CultureInfo("ja-JP");
            culture.DateTimeFormat.Calendar = new JapaneseCalendar();
            var era = culture.DateTimeFormat.Calendar.GetEra(birthday);
            var eraName = culture.DateTimeFormat.GetEraName (era);
            var str = birthday.ToString(eraName + "yyyy年,MM月,dd日,dddd", culture);
            Console.WriteLine(str+ "に生まれました");
            //あなたは生まれてから今日は何日目ですか
            var today = DateTime.Today;
            TimeSpan diff = today - birthday;
            Console.WriteLine("私は、生まれてから{0}日目です", diff.Days+1);
        }
    }
}
