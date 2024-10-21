using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextFileProcessor;
using TextNumberSizeChange.Framework;

namespace LineCounter {
    class LineCounterProcessor : ITextFileService {
        private int _count;
        string _text;

        protected  void Initialize(string line) {
            _count = 0;

        }

        protected  void Execute(string fname) {
            _count++;
        }

        protected  void Terminate() {
            Console.WriteLine("{0}行", _count);
        }
    }
}
