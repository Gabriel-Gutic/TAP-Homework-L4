namespace Lab4Web.Services.Lambda
{
    public class LambdaService : ILambdaService
    {
        public string ExerciseA1()
        {
            Func<string> function = () => "This is a lambda with no parameters."; 

            return function();
        }

        public string ExerciseA2(float x)
        {
            Func<float, string> function = (float x) => 
            { 
                return $"sqrt({x}) = {Math.Sqrt(x)}"; 
            };

            return function(x);
        }

        public string ExerciseA3(float x, float y)
        {
            var function = (float x, float y) =>
            {
                return $"{x} + {y} = {x + y}";
            };
            return function(x, y);
        }

        public string ExerciseA4(float x, float y)
        {
            var function = (float x, float _) =>
            {
                return $"{x}^2 = {x * x}";
            };
            return function(x, y);
        }

        public string ExerciseA5(float x, string y)
        {
            var function = (float x, float y = 3) =>
            {
                return $"{x} + {y} = {x + x}";
            };

            if (float.TryParse(y, out float y1))
            {
                return function(x, y1);
            }
            return function(x);
        }

        public string ExerciseA6(float x, float y, float z)
        {
            Func<Tuple<float, float, float>, string> function =
                (Tuple<float, float, float> triple) =>
                {
                    return $"{triple.Item1} + {triple.Item2} + {triple.Item3} = {triple.Item1 + triple.Item2 + triple.Item3}";
                };

            return function(new Tuple<float, float, float>(x, y, z));
        }

        public async Task<string> ExerciseBAsync(float x)
        {
            var function = async (float x) =>
            {
                await Delay();
                return $"sqrt({x}) = {Math.Sqrt(x)}";
            };

            return await function(x);
        }

        public Task Delay()
        {
            return Task.Delay(10000);
        }
    }
}
