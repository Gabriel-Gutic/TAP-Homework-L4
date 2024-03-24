namespace Lab4Web.Services.Delegate
{
    public interface IDelegateService
    {
        string Exercise1(float value, Func<float, string> sqrtCallback);
        string Exercise2(float value, Func<float, string> sqrtCallback, Func<string> negativeCallback);
        string Exercise3(float x, float y);


        string SqrtFunction(float x);
        string NegativeNumber();

        public delegate void RefDelegate(float x, float y, ref string result);

        void Sum(float x, float y, ref string result);
        void Difference(float x, float y, ref string result);
        void Product(float x, float y, ref string result);
    }
}
