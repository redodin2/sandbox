namespace Sandbox.Number
{
    public static partial class Calc
    {
        public static Number<float, FloatSummator, FloatSubstractor, FloatMultiplier, FloatDivider> AsNumber(this float value) => value;

        public readonly struct FloatSummator : IFn<float, float, float>
        {
            public float Invoke(float in1, float in2) => in1 + in2;
        }

        public readonly struct FloatSubstractor : IFn<float, float, float>
        {
            public float Invoke(float in1, float in2) => in1 - in2;
        }

        public readonly struct FloatMultiplier : IFn<float, float, float>
        {
            public float Invoke(float in1, float in2) => in1 * in2;
        }

        public readonly struct FloatDivider : IFn<float, float, float>
        {
            public float Invoke(float in1, float in2) => in1 / in2;
        }
    }
}
