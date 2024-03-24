namespace Lab4Web.Services.Delegate
{
    public class DelegateService : IDelegateService
    {
        public string Exercise1(float value, Func<float, string> sqrtCallback)
        {
            return sqrtCallback(value);
        }

        public string Exercise2(float x, Func<float, string> sqrtCallback, Func<string> negativeCallback)
        {
            if (x >= 0)
            {
                return sqrtCallback(x);
            }
            return negativeCallback();
        }

        public string Exercise3(float x, float y)
        {
            IDelegateService.RefDelegate sum = Sum;
            IDelegateService.RefDelegate difference = Difference;
            IDelegateService.RefDelegate product = Product;
            var callback = sum + difference + product;

            string result = "";
            callback(x, y, ref result);
            return result;
        }

        public string SqrtFunction(float x)
        {
            return $"sqrt({x}) = {Math.Sqrt(x)}";
        }
        public string NegativeNumber()
        {
            return "Sqrt can only be calculated for positive numbers!";
        }

        public void Sum(float x, float y, ref string result)
        {
            result += $"{x} + {y} = {x + y}\n";
        }
        public void Difference(float x, float y, ref string result)
        {
            result += $"{x} - {y} = {x - y}\n";
        }

        public void Product(float x, float y, ref string result)
        {
            result += $"{x} * {y} = {x * y}\n";
        }
    }
}
