using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    internal class Program {
        static void Main(string[] args) {
            var line = Console.ReadLine();
            int num;
            if (int.TryParse(line, out num)) {
                //変換成功
                Console.WriteLine($"{num:#,#}");
                //Console.WriteLine("{0:#,#}",num);
            } else {
                //変換失敗
                Console.WriteLine("数字文字列ではありません");
            }



        }
    }
}
