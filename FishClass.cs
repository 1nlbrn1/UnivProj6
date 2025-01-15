using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnivLabProj6 {
    class Fish:IMeowable {
        string name;

        public Fish(string name) {
            this.name = name;
        }

        public void meow() {
            Console.WriteLine($"{name}: ...");
        }
        public void meow(int n) {
            Console.WriteLine($"{name}: ...");
        }
    }
}
