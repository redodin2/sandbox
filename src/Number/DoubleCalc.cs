namespace Sandbox.Number
{
    public static partial class Calc
    {
        public static Number<double, DoubleSummator, DoubleSubstractor, DoubleMultiplier, DoubleDivider> AsNumber(this double value) => value;

        public readonly struct DoubleSummator : IFn<double, double, double>
        {
            public double Invoke(double in1, double in2) => in1 + in2;
        }

        public readonly struct DoubleSubstractor : IFn<double, double, double>
        {
            public double Invoke(double in1, double in2) => in1 + in2;
        }

        public readonly struct DoubleMultiplier : IFn<double, double, double>
        {
            public double Invoke(double in1, double in2) => in1 * in2;
        }

        public readonly struct DoubleDivider : IFn<double, double, double>
        {
            public double Invoke(double in1, double in2) => in1 / in2;
        }
    }
}
