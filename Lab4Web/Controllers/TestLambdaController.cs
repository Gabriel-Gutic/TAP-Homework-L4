using Lab4Web.Services.Lambda;
using Microsoft.AspNetCore.Mvc;

namespace Lab4Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestLambdaController : ControllerBase
    {
        private readonly ILambdaService _lambdaService;

        public TestLambdaController(ILambdaService lambdaService)
        {
            _lambdaService = lambdaService;
        }

        [HttpGet("Punctul a) Subpunctul i)")]
        public string ExerciseA1()
        {
            return _lambdaService.ExerciseA1();
        }

        [HttpGet("Punctul a) Subpunctul ii)")]
        public string ExerciseA2(float x)
        {
            return _lambdaService.ExerciseA2(x);
        }

        [HttpGet("Punctul a) Subpunctul iii)")]
        public string ExerciseA3(float x, float y)
        {
            return _lambdaService.ExerciseA3(x, y);
        }

        [HttpGet("Punctul a) Subpunctul iv)")]
        public string ExerciseA4(float x, float y)
        {
            return _lambdaService.ExerciseA4(x, y);
        }

        [HttpGet("Punctul a) Subpunctul v) Incercati pentru y o valoare care nu e numar")]
        public string ExerciseA5(float x, string y)
        {
            return _lambdaService.ExerciseA5(x, y);
        }

        [HttpGet("Punctul a) Subpunctul vi)")]
        public string ExerciseA6(float x, float y, float z)
        {
            return _lambdaService.ExerciseA6(x, y, z);
        }

        [HttpGet("Punctul b)")]
        public string ExerciseB(float x)
        {
            return _lambdaService.ExerciseBAsync(x).Result;
        }
    }
}
