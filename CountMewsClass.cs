using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnivLabProj6 {
    class CountCatMews : IMeowable{
        Cat cat;
        int meowcount;
        public CountCatMews(Cat cat) {
            this.cat = cat;
        }
        public void meow() {
            cat.meow();
            meowcount += 1;
        }
        public void meow(int n) {
            cat.meow(n);
            meowcount += n;
        }
        public string getmeows() {
            return $"кот мяукал : {meowcount} раз";
        }
    }
}
