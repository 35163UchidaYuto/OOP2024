using Section01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section {
    internal class Program {
        static void Main(string[] args) {

            var greetings = new List<GreetingBase> {
                new GreetingMorning(),
                new GreetingAfternoon(),
                new GreetingEvening(),
            };

            foreach (var greeting in greetings) {
                string msg = greeting.GetMessage();
                Console.WriteLine(msg);
            }
            Console.ReadLine();
        }
    }
}
