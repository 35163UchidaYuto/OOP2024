﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03 {
    internal class Program {
        static void Main(string[] args) {
            var text = "Jackdaws love my big sphinx of quartz";
            #region
            Exercise3_1(text);
            Console.WriteLine("-----");

            Exercise3_2(text);
            Console.WriteLine("-----");

            Exercise3_3(text);
            Console.WriteLine("-----");

            Exercise3_4(text);
            Console.WriteLine("-----");

            Exercise3_5(text);
        }
        #endregion
        private static void Exercise3_1(string text) {

            var spaces = text.Count(c => c == ' ');
            Console.WriteLine("空白数 :{0}", spaces);
        }

        private static void Exercise3_2(string text) {
            var replaces = text.Replace("big", "small");
            Console.WriteLine(replaces);
        }

        private static void Exercise3_3(string text) {
            int count = text.Split(' ').Length;
            Console.WriteLine("単語数：{0}", count);
        }

        private static void Exercise3_4(string text) {
            var words = text.Split(' ').Where(s => s.Length <= 4);
            foreach (var word in words) {
                Console.WriteLine(word);
            }
        }

        private static void Exercise3_5(string text) {
            var array = text.Split(' ').ToArray();
            if (array.Length > 0) {
                StringBuilder sb = new StringBuilder(array[0]);
                foreach (var word in array.Skip(1)) {
                    sb.Append(word);
                    sb.Append(' ');
                }
                Console.WriteLine(sb);
            }

        }
        private static void Exercise3_6(string text) {
            var array = text.Split(' ',',','-','_').ToArray();
            foreach (var word in array) {
                Console.WriteLine(word);
            }
        }

    }
}

