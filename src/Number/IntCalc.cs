namespace Sandbox.Number
{
    public static partial class Calc
    {
        public static Number<int, IntSummator, IntSubstractor, IntMultiplier, IntDivider> AsNumber(this int value) => value;
        
        public readonly struct IntSummator : IFn<int, int, int>
        {
            public int Invoke(int in1, int in2) => in1 + in2;
        }

        public readonly struct IntSubstractor : IFn<int, int, int>
        {
            public int Invoke(int in1, int in2) => in1 - in2;
        }

        public readonly struct IntMultiplier : IFn<int, int, int>
        {
            public int Invoke(int in1, int in2) => in1 * in2;
        }

        public readonly struct IntDivider : IFn<int, int, int>
        {
            public int Invoke(int in1, int in2) => in1 / in2;
        }
    }
}
