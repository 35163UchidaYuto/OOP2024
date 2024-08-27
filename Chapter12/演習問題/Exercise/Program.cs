using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Exercise {
    internal class Program {
        static void Main(string[] args) {
            Exercise1_1("employee.xml");

            // これは確認用
            Console.WriteLine(File.ReadAllText("employee.xml"));
            Console.WriteLine();

            Exercise1_2("employees.xml");
            Exercise1_3("employees.xml");
            Console.WriteLine();

            Exercise1_4("employees.json");

            // これは確認用
            Console.WriteLine(File.ReadAllText("employees.json"));
        }

        private static void Exercise1_1(string outfile) {
            var employee = new Employee {
                Id = 1,
                Name = "Test",
                HireDate = DateTime.Now,
            };

            using (var writer = XmlWriter.Create("employee.xml")) {
                var serializer = new XmlSerializer(employee.GetType());
                serializer.Serialize(writer, employee);
            }

            using (var reader = XmlReader.Create("employee.xml")) {
                var serializer = new XmlSerializer(typeof(Employee));
                var employee1 = serializer.Deserialize(reader) as Employee;
            }

        }

        private static void Exercise1_2(string outfile) {

        }

        private static void Exercise1_3(string file) {

        }

        private static void Exercise1_4(string file) {

        }
    }
}
