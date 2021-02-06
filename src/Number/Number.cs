namespace Sandbox.Number
{
    public readonly ref struct Number<T, TAdd, TSub, TMul, TDiv>
        where TAdd : struct, IFn<T, T, T>
        where TSub : struct, IFn<T, T, T>
        where TMul : struct, IFn<T, T, T>
        where TDiv : struct, IFn<T, T, T>
    {
        Number(T value) => Value = value;

        public T Value { get; }

        public static Number<T, TAdd, TSub, TMul, TDiv> operator +(
            Number<T, TAdd, TSub, TMul, TDiv> left,
            Number<T, TAdd, TSub, TMul, TDiv> right
        ) => default(TAdd).Invoke(left, right);

        public static Number<T, TAdd, TSub, TMul, TDiv> operator -(
            Number<T, TAdd, TSub, TMul, TDiv> left,
            Number<T, TAdd, TSub, TMul, TDiv> right
        ) => default(TSub).Invoke(left, right);

        public static Number<T, TAdd, TSub, TMul, TDiv> operator *(
            Number<T, TAdd, TSub, TMul, TDiv> left,
            Number<T, TAdd, TSub, TMul, TDiv> right
        ) => default(TMul).Invoke(left, right);

        public static Number<T, TAdd, TSub, TMul, TDiv> operator /(
            Number<T, TAdd, TSub, TMul, TDiv> left,
            Number<T, TAdd, TSub, TMul, TDiv> right
        ) => default(TDiv).Invoke(left, right);

        public static implicit operator Number<T, TAdd, TSub, TMul, TDiv>(T value) => new Number<T, TAdd, TSub, TMul, TDiv>(value);
        public static implicit operator T(Number<T, TAdd, TSub, TMul, TDiv> number) => number.Value;
    }
}
