using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnivLabProj6 {
    public interface IFraction {
        double GetValue();
        void SetNumDenum(int numerator, int denumerator);
    }
    public class NegativeDenum : Exception {
        public NegativeDenum() {
        }

        public NegativeDenum(string message)
            : base(message) {
        }

        public NegativeDenum(string message, Exception inner)
            : base(message, inner) {
        }
    }
    public class Fraction : ICloneable, IFraction {
        int num;
        int den;
        double? cachedValue = null;
        bool isCached = false;

        public Fraction(int numerator, int denominator) {
            if(denominator == 0) {
                throw new ArgumentException("Denominator cannot be zero.", nameof(denominator));
            }
            num = numerator;
            den = denominator;
        }

        public static Fraction operator +(Fraction a) => a;
        public static Fraction operator -(Fraction a) => new Fraction(-a.num, a.den);

        public static Fraction operator +(Fraction a, Fraction b)
            => new Fraction(a.num * b.den + b.num * a.den, a.den * b.den);
        public static Fraction operator +(int a, Fraction b)
           => new Fraction(a * b.den + b.num, b.den);
        public static Fraction operator +(Fraction a, int b)
           => new Fraction(a.num + a.den * b, a.den);

        public static Fraction operator -(Fraction a, Fraction b)
            => a + (-b);
        public static Fraction operator -(int a, Fraction b)
            => a + (-b);
        public static Fraction operator -(Fraction a, int b)
            => a + (-b);

        public static Fraction operator *(Fraction a, Fraction b)
            => new Fraction(a.num * b.num, a.den * b.den);
        public static Fraction operator *(int a, Fraction b)
            => new Fraction(a * b.num, b.den);
        public static Fraction operator *(Fraction a, int b)
            => new Fraction(a.num * b, a.den);

        public static Fraction operator /(Fraction a, Fraction b) {
            if(b.num == 0) {
                throw new DivideByZeroException();
            }
            return new Fraction(a.num * b.den, a.den * b.num);
        }
        public static Fraction operator /(int a, Fraction b) {
            if(b.num == 0) {
                throw new DivideByZeroException();
            }
            return new Fraction(a * b.den,  b.num);
        }
        public static Fraction operator /(Fraction a, int b) {
            if(b == 0) {
                throw new DivideByZeroException();
            }
            return new Fraction(a.num, a.den * b);
        }
        public static bool operator ==(Fraction a, Fraction b) {
            return (a.num == b.num) && (a.den == b.den);
        }
        public static bool operator !=(Fraction a, Fraction b) {
            return (a.num != b.num) && (a.den != b.den);
        }
        public static bool operator >(Fraction a, Fraction b) {
            return (a.num > b.num) && (a.den <= b.den);
        }
        public static bool operator <(Fraction a, Fraction b) {
            return (a.num < b.num) && (a.den >= b.den);
        }

        public override string ToString() => $"{num}/{den}";

        /*public override bool Equals(object obj) {
            if(ReferenceEquals(this, obj)) {
                return true;
            }

            if(ReferenceEquals(obj, null)) {
                return false;
            }

            throw new NotImplementedException();
        }
        */

        public object Clone() {
            return new Fraction(num, den);
        }

        public double GetValue() {
            if(!isCached) {
                cachedValue = (double)num / den;
                isCached = true;
            }
            return cachedValue.Value;
        }
        public void SetNumDenum(int numerator, int denominator) {
            if(denominator == 0) {
                throw new ArgumentException("Denominator cannot be zero.", nameof(denominator));
            }
            num = numerator;
            den = denominator;
            isCached = false;
        }
    }
}
