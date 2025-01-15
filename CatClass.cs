using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnivLabProj6 {
    class Cat : IMeowable {
        string name;
        public Cat(string name) {
            this.name = name;
        }
        public void meow() {
            Console.WriteLine($"{name}: мяу!");
        }
        public void meow(int n) { 
            if(n==1){
                Console.Write($"{name}: мяу!\n");
            }
            if(n > 1) {
                Console.Write($"{name}: мяу");
            }
            for(int i = 1; i < n-1; ++i) {
                Console.Write("-мяу");
            }
            if(n > 1) {
                Console.Write("-мяу!\n");
            }
        }
        public override string ToString() {
            return $"кот: {name}";
        }

    }
}
