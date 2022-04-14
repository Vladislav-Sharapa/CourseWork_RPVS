using System;

namespace CourseWork_RPVS {
    abstract class Function {
        public abstract double GetFunction(double x, double y);
    }
    class FirstFunction : Function {

        public override double GetFunction(double x, double y) {
            return Math.Sin(x) + Math.Cos(y);
        }
    }
    class SecondFunction : Function {

        public override double GetFunction(double x, double y) {
            return Math.Pow(Math.Cos(x), 2) - Math.Sin(y);
        }
    }
    class ThirdFunction : Function {

        public override double GetFunction(double x, double y) {
            return Math.Cos(x) + y;
        }
    }

}
