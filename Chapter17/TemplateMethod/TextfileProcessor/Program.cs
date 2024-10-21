using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace TextfileProcessor {
    internal class Program {
        static void Main(string[] args) {
            //TextProcessor.Run<LineCounterProcessor>(args[0]);

            var processor = new Framework.TextfileProcessor(new ToHankakuProcessor());
            processor.Run(args[0]);
        }
    }
}
