using System;
using System.Collections.Generic;

//void doMeow(UnivLabProj6.IMeowable n) {
//    n.meow();
//}


namespace UnivLabProj6 {
    class Program {
        static void Main(string[] args) {
            // task 1.1
            Console.WriteLine("task 1.1");
            Cat bars = new Cat("Барсик");
            bars.meow();
            bars.meow(3);
            Console.WriteLine();


            // task 1.2
            Console.WriteLine("task 1.2");
            Cat step = new Cat("Степан");
            Funcs.doMeow(step);
            List<IMeowable> meowables = new List<IMeowable>();
            meowables.Add(bars);
            meowables.Add(step);
            Funcs.doMeow(meowables);
            Fish nik = new Fish("Николай");
            Funcs.doMeow(nik);
            Console.WriteLine();


            // task 1.3
            Console.WriteLine("task 1.3");
            CountCatMews c_mewable = new CountCatMews(step);
            Funcs.doMeow(c_mewable);
            Funcs.doMeow(c_mewable);
            Funcs.doMeow(c_mewable);
            Funcs.doMeow(c_mewable);
            Funcs.doMeow(c_mewable);
            Console.WriteLine(c_mewable.getmeows());
            Console.WriteLine();

            // task 2.1
            Console.WriteLine("task 2.1");
            Fraction f1 = new Fraction(1, 3);
            Fraction f2 = new Fraction(2, 3);
            Console.WriteLine("f1: 1/3, f2: 2/3");
            Console.WriteLine("1/3 * 2/3 = " + (f1 * f2));
            Console.WriteLine("1/3 + 2/3 = " + (f1 + f2));
            Console.WriteLine("1/3 - 2/3 = " + (f1 - f2));
            Console.WriteLine("1/3 / f2 = " + (f1 / f2));
            Console.WriteLine("2/3 * 1/3 = " + (f2 * f1));
            Console.WriteLine("2/3 + 1/3 = " + (f2 + f1));
            Console.WriteLine("2/3 - 1/3 = " + (f2 - f1));
            Console.WriteLine("2/3 / 1/3 = " + (f2 / f1));
            Console.WriteLine("1/3 * 2 = " + (f1 * 2));
            Console.WriteLine("1/3 + 2 = " + (f1 + 2));
            Console.WriteLine("1/3 - 2 = " + (f1 - 2));
            Console.WriteLine("1/3 / 2 = " + (f1 / 2));
            Console.WriteLine("2 * 2/3 = " + (2 * f2));
            Console.WriteLine("2 + 2/3 = " + (2 + f2));
            Console.WriteLine("2 - 2/3 = " + (2 - f2));
            Console.WriteLine("2 / 2/3 = " + (2 / f2));
            Fraction f3 = new Fraction(2, 5);
            Console.WriteLine("f3: 2/5");
            Console.WriteLine("(f1 + f2) / f3 - 5: " + ((f1 + f2) / f3 - 5));
            Console.WriteLine();
            // task 2.2
            Console.WriteLine("task 2.2");
            Fraction f5 = new Fraction(3, 4);
            Fraction f6 = new Fraction(3, 4);
            Console.WriteLine("f5: 3/4, f6: 3/4");
            Console.WriteLine("f5 == f6: " + (f5 == f6));
            Console.WriteLine("f1 == f2: " + (f1 == f2));
            Console.WriteLine();

            // task 2.3
            Console.WriteLine("task 2.3");
            object o = f1.Clone();
            Fraction f4 = o as Fraction;
            Console.WriteLine("f4 = f1.Clone()");
            Console.WriteLine("f1: " + f1.ToString() + " f4: " + f4.ToString());
            Console.WriteLine();

            // task 2.4
            Console.WriteLine("task 2.4");
            Console.WriteLine("f1.GetValue(): " + f1.GetValue());
            f1.SetNumDenum(1, 10);
            Console.WriteLine("f1.SetNumDenum(1, 10)");
            Console.WriteLine("f1: " + f1.GetValue());

        }
    }
}
