using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2 {
    internal class Program {
        static void Main(string[] args) {
            if (args.Length >= 1 && args[0] == "-tom") {
                //インチからメートルへの対応表を出力
                PrintInchToMeterList(int.Parse(args[1]), int.Parse(args[2]));
            } else {
                //メートルからインチへの対応表を出力
                PrintMeterToInchList(int.Parse(args[1]), int.Parse(args[2]));

            }
        }
        private static void PrintMeterToInchList(int stert, int stop) {
            for (int meter = stert; meter <= stop; meter++) {
                double inch = InchConverter.ToMeter(meter);
                Console.WriteLine("{0} m = {1:0.0000} in", meter, inch);
            }
        }

        private static void PrintInchToMeterList(int stert, int stop) {
            for (int inch = stert; inch <= stop; inch++) {
                double meter = InchConverter.FromMeter(inch);
                Console.WriteLine("{0} in = {1:0.0000} m", inch, meter);
            }
        }
    }
}
