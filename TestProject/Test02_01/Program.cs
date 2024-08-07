﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Test02 {

    class Person {
        public string Name { get; set; }  //名前
        public int Age { get; set; }      //年齢
        public int Height { get; set; }   //身長
        public int Weight { get; set; }   //体重
    }

    class Program {
        static void Main(string[] args) {
            var numbers = new List<int> {
                    12, 87, 94, 14, 53, 20, 40, 35, 76, 91, 31, 17, 48
                };

            var persons = new List<Person> {
                new Person{Name = "峰博史",Age = 38, Height=170,Weight=68},
                new Person{Name = "片桐鉄也",Age = 29, Height=173,Weight=74},
                new Person{Name = "沖田宏",Age = 28, Height=168,Weight=59},
                new Person{Name = "池中裕次",Age = 21, Height=184,Weight=82},
                new Person{Name = "片山新之助",Age = 35, Height=176,Weight=65},
            };
            #region テスト用ドライバ
            Console.WriteLine("問題１：平均値を表示");
            Exercise01(numbers);
            Console.WriteLine("\n-----");

            Console.WriteLine("問題２：奇数の最小値を表示");
            Exercise02(numbers);
            Console.WriteLine("\n-----");

            Console.WriteLine("問題３：偶数のみを昇順に並べて表示");
            Exercise03(numbers);
            Console.WriteLine("\n-----");

            Console.WriteLine("問題４：0以上30未満の数字のみを表示");
            Exercise04(numbers);
            Console.WriteLine("\n-----");

            Console.WriteLine("問題５：最高年齢を表示");
            Exercise05(persons);
            Console.WriteLine("\n-----");

            Console.WriteLine("問題６：年齢20代だけの平均身長を表示");
            Exercise06(persons);
            Console.WriteLine("\n-----");

            Console.WriteLine("問題７：身長170cm以上の「名前と年齢と体重」を全員表示");
            Exercise07(persons);
            Console.WriteLine("\n-----");

            Console.WriteLine("問題８：名前の漢字４文字の人を全て表示");
            Exercise08(persons);
            Console.WriteLine("\n-----");
            #endregion
        }

        //---------------------------------------
        // 以下の問題に書かれている内容を満たすようにプログラムを作成せよ。
        // 必要であればラムダ式とLINQを使用すること
        //---------------------------------------

        //問題１　平均値を表示
        private static void Exercise01(List<int> numbers) {
            var avg = numbers.Average();
            Console.Write(avg);

        }

        //問題２　奇数の最小値を表示
        private static void Exercise02(List<int> numbers) {
            var min = numbers.Where(n => n % 2 ==1).Min();
            Console.Write(min);
        }
        //問題３　偶数のみを昇順に並べて表示（遅延実行とする）
        private static void Exercise03(List<int> numbers) {
            IEnumerable<int> qeary = numbers.Where(n => n % 2 == 0).OrderBy(n => n);
            foreach (var q in qeary)
                Console.Write(q+" ");

        }

        //問題４　0以上30未満の数字のみを表示（即時実行でも可とする）
        private static void Exercise04(List<int> numbers) {
            IEnumerable<int> qeary = numbers.Where(n => n >= 0 && n < 30);
            foreach (var q in qeary)
                Console.Write(q+" ");

        }

        //問題５　最高年齢を表示
        private static void Exercise05(List<Person> persons) {
            var maxage = persons.Max(n => n.Age);
            Console.Write(maxage+"才");

        }

        //問題６　年齢20代だけの平均身長を表示
        private static void Exercise06(List<Person> persons) {
            var age = persons.Where(n => n.Age >= 20 && n.Age <= 29).Average(n => n.Height);
            Console.WriteLine(age +"cm");

        }

        //問題７　身長170cm以上の「名前と年齢と体重」を全員表示
        private static void Exercise07(List<Person> persons) {
            IEnumerable<Person> qeary = persons.Where(n => n.Height >= 170);
            foreach (var person in qeary)
                     Console.WriteLine($"{person.Name}{person.Age}才 {person.Weight}kg");


        }

        //問題８　名前の漢字４文字の人を全て表示
        private static void Exercise08(List<Person> persons) {
            IEnumerable<Person> qeary = persons.Where(n => n.Name.Contains(""));
            foreach (var person in qeary)
                Console.WriteLine($"{person.Name}");

        }
    }
}
