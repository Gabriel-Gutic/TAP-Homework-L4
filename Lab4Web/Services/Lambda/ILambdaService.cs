namespace Lab4Web.Services.Lambda
{
    public interface ILambdaService
    {
        string ExerciseA1();
        string ExerciseA2(float x);
        string ExerciseA3(float x, float y);
        string ExerciseA4(float x, float y);
        string ExerciseA5(float x, string y);
        string ExerciseA6(float x, float y, float z);
        Task<string> ExerciseBAsync(float x);
    }
}
