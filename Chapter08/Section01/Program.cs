using System;
using System.Collections.Generic;
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

            Console.WriteLine(birthday.ToString("dddd"));

            switch (dayOfWeek) {
                case DayOfWeek.Sunday:
                    Console.WriteLine(birthday + "は日曜日");
                    break;
                case DayOfWeek.Monday:
                    Console.WriteLine(birthday + " は月曜日");
                    break;
                case DayOfWeek.Tuesday:
                    Console.WriteLine(birthday + "は火曜日");
                    break;
                case DayOfWeek.Wednesday:
                    Console.WriteLine(birthday + "は水曜日");
                    break;
                case DayOfWeek.Thursday:
                    Console.WriteLine(birthday + "は木曜日");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine(birthday + "は金曜日");
                    break;
                case DayOfWeek.Saturday:
                    Console.WriteLine(birthday + "は土曜日");
                    break;
            }

            if (dayOfWeek == DayOfWeek.Sunday) {
                Console.WriteLine(birthday+"は日曜日");
            }
            if (dayOfWeek == DayOfWeek.Monday) {
                Console.WriteLine(birthday + " は月曜日");
            }
            if (dayOfWeek == DayOfWeek.Tuesday) {
                Console.WriteLine(birthday + "は火曜日");
            }
            if (dayOfWeek == DayOfWeek.Wednesday) {
                Console.WriteLine(birthday + "は水曜日");
            }
            if (dayOfWeek == DayOfWeek.Tuesday) {
                Console.WriteLine(birthday + "は木曜日");
            }
            if (dayOfWeek == DayOfWeek.Friday) {
                Console.WriteLine(birthday + "は金曜日");
            }
            if (dayOfWeek == DayOfWeek.Saturday) {
                Console.WriteLine(birthday + "は土曜日");
            }
        }
    }
}
