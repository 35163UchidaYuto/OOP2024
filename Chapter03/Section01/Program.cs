using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    internal class Program {
        static void Main(string[] args) {
            var names = new List<string> {
                "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong",
            };

            IEnumerable<string> qiery = names.Where(s => s.Contains(" "))
            .Select(s=> s.ToUpper());
            foreach (string s in qiery)
                Console.WriteLine(s);

            

        }
    }
}
