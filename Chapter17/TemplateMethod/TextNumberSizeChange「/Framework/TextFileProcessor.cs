using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextNumberSizeChange.Framework {
    internal class TextFileProcessor {
        public TextFileProcessor(ITextFileService service) {
            _service = service;
        }
        public void Run(string fileName) {
            _service.Initialize(fileName);
            using(var sr = new StreamReader(fileName)) {
                while (!sr.EndOfStream) {
                    string line = sr.ReadLine();
                    _service.Execute(line);
                }
            }
            _service.Terminate();
        }
    }
}
