using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnivLabProj6 {
    static class Funcs {
        static public void doMeow(IMeowable mew) {
            mew.meow();
        }
        static public void doMeow(IEnumerable<IMeowable> mews) {
            foreach(IMeowable mew in mews) {
                mew.meow();
            }
        }
    }
}
