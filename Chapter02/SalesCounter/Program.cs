using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SalesCounter {
    internal class Program {
        public static void Main(string[] args) {
            SalesCounter sales = new SalesCounter(@"date\Sales.csv");
            IDictionary<string, int> amountPerStore = sales.GetStoreSales();
            foreach (KeyValuePair<string, int> obj in amountPerStore) {
                Console.WriteLine("{0}{1}", obj.Key, obj.Value);
            }
        }
    }
}