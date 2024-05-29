using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    internal class Program {
        static void Main(string[] args) {
            #region null合体演算子
            //string code = "12345";
            //var message = GetMessage(code) ?? DefultMessage();
            //Console.WriteLine(message);
            #endregion

            #region null条件演算子
            // Sale sale = new Sale {
            //   Amount = 1000,
            //};
            //Sale sale = null;

            //「int?」はnull許容型、「?.」はnull条件演算子
            //int? ret = sale?.Amount;
            //Console.WriteLine(ret);
            #endregion


            Console.Write("整数を入力：");
            string inputNum = Console.ReadLine();

            int num = int.Parse(inputNum);
            Console.WriteLine("整数に変換した値：" + num);

            if (int.TryParse(inputNum, out num)) {
                //変換に成功した時の処理
                Console.WriteLine("せいこう");
            }else {
                //変換に失敗したときの処理
                Console.WriteLine("失敗");
            }

        }
        private static object GetMessage(string code) {
            return null;
        }

        private static object DefultMessage() {
            return "Default Message";
        }

        
    }
        public class Sale {
            //店舗名
            public string ShopName { get; set; }
            //商品カテゴリ
            public string ProductCategory { get; set; }
            //売上高
            public int Amount { get; set; }
        }

    }


