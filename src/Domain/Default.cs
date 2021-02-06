namespace Sandbox.Number
{
    public readonly struct Default<T> : IFn<T, T>,  IFn<T, T, T>
    {
        public T Invoke(T in1) => default;
        public T Invoke(T in1, T in2) => default;
    }
}
