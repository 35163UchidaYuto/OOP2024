using System;
using System.ComponentModel;
using System.Linq;
using System.Net.Sockets;

namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            Exercise1_2();
            Console.WriteLine();
            Exercise1_3();
            Console.WriteLine();
            Exercise1_4();
            Console.WriteLine();
            Exercise1_5();
            Console.WriteLine();
            Exercise1_6();
            Console.WriteLine();
            Exercise1_7();
            Console.WriteLine();
            Exercise1_8();

            Console.ReadLine();
        }

        private static void Exercise1_2() {
            var max = Library.Books.Max(x => x.Price);
            var book = Library.Books.First(x => x.Price==max);

            Console.WriteLine(book);
        }

        private static void Exercise1_3() {
            var query = Library.Books
                .GroupBy(b => b.PublishedYear)
                .Select(g => new { PublishedYear = g.Key, Count = g.Count() })
                .OrderByDescending(g => g.PublishedYear);    

            foreach(var item in query) {
                Console.WriteLine("{0}年 {1}冊,",item.PublishedYear,item.Count);
            }

        }
        private static void Exercise1_4() {
            var query = Library.Books.Join(Library.Categories,//結合する2番目のシーケンス
                                           Book => Book.CategoryId,//対象シーケンスの結合
                                           Category => Category.Id,//２番目のシーケンスの結合キー 
                                           (book, Category) => new {
                                               book.Title,
                                               book.PublishedYear,
                                               book.Price,
                                               CategoryName = Category.Name,
                                           }).OrderByDescending(x=>x.PublishedYear)
                                           .ThenByDescending(x=>x.Price);                                      
           
            foreach(var item in query) {
                Console.WriteLine("{0}年 {1}円 {2} {3}",item.PublishedYear,
                                                        item.Price,
                                                        item.Title,
                                                        item.CategoryName
                                                        );
            }
            
        }

        private static void Exercise1_5() {
            var query = Library.Books.Where(b => b.PublishedYear == 2016)
                .Join(Library.Categories, 
                book => book.CategoryId,
                category => category.Id,
                (book, category) => category.Name).Distinct();

            foreach(var item in query) {
                Console.WriteLine(item);
            }
        }

        private static void Exercise1_6() {
            var query = Library.Books.Join(Library.Categories,
               book => book.CategoryId,
               category => category.Id,
               (book, category) => new {
                   book.Title,
                   CategoryName = category.Name,
               })
                .GroupBy(x => x.CategoryName)
                .OrderBy(x => x.Key);

            foreach(var guroup in query) {
                Console.WriteLine("#{0}",guroup.Key);
                foreach (var item in guroup) {
                    Console.WriteLine("#{0}",item.Title);
                }
            }
        }

        private static void Exercise1_7() {
            var CategorysId = Library.Categories.Single(c => c.Name == "Development").Id;
            var query = Library.Books.Where(b => b.CategoryId == CategorysId)
                                      .GroupBy(b=>b.PublishedYear)
                                      .OrderBy(b=>b.Key);

            foreach (var guroup in query) {
                Console.WriteLine("#{0}", guroup.Key);
                foreach (var item in guroup) {
                    Console.WriteLine("#{0}", item.Title);
                }
            }
        }

        private static void Exercise1_8() {
            var query = Library.Categories
                               .GroupJoin(Library.Books,
                                          c => c.Id,
                                          b => b.CategoryId,
                                         (c, b) => new {
                                             categoryName = c.Name,
                                             Count = b.Count()
                                         })
                               .Where(x => x.Count >= 4);

            foreach (var guroup in query) {
                Console.WriteLine(guroup.categoryName + "("+guroup.Count+")");
            }
        }
    }
}
