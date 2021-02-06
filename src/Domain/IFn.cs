namespace Sandbox.Number
{
    public interface IFn<TIn, TOut>
    {
        TOut Invoke(TIn @in);
    }

    public interface IFn<TIn1, TIn2, TOut>
    {
        TOut Invoke(TIn1 in1, TIn2 in2);
    }
}
