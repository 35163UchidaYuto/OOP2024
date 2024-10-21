using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextNumberSizeChange.Framework {
    public class ITextFileService {
        void Intialize(string faname);
        void Execute(string line);
        void Terminate();

        internal void Initialize(string fileName) {
            throw new NotImplementedException();
        }
    }
}
