using NUnit.Framework;

namespace Sandbox.Number.Tests
{
    public class NumberSquareSumTests
    {
        public Number<T, TAdd, Default<T>, TMul, Default<T>> SquareSum<T, TAdd, TMul>(
            Number<T, TAdd, Default<T>, TMul, Default<T>> a,
            Number<T, TAdd, Default<T>, TMul, Default<T>> b
        )
            where TAdd : struct, IFn<T, T, T>
            where TMul : struct, IFn<T, T, T> => a * a + b * b;

        [TestCase(0, 0, ExpectedResult = 0)]
        [TestCase(1, 1, ExpectedResult = 2)]
        [TestCase(2, 3, ExpectedResult = 13)]
        [TestCase(-2, 3, ExpectedResult = 13)]
        public int IntTest(int a, int b) => SquareSum<int, Calc.IntSummator, Calc.IntMultiplier>(a, b);

        [TestCase(0, 0, ExpectedResult = 0)]
        [TestCase(1.5f, 1, ExpectedResult = 3.25f)]
        [TestCase(-2.5f, 3.5f, ExpectedResult = 18.5f)]
        public float FloatTest(float a, float b) => SquareSum<float, Calc.FloatSummator, Calc.FloatMultiplier>(a, b);

        [TestCase(0, 0, ExpectedResult = 0)]
        [TestCase(1.5, 1, ExpectedResult = 3.25f)]
        [TestCase(-2.5, 3.5, ExpectedResult = 18.5)]
        public double DoubleTest(double a, double b) => SquareSum<double, Calc.DoubleSummator, Calc.DoubleMultiplier>(a, b);
    }
}
