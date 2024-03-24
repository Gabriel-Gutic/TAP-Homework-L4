using Lab4Web.Services.Linq;
using Microsoft.AspNetCore.Mvc;

namespace Lab4Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestLinqController : ControllerBase
    {
        private readonly ILinqService _linqService;

        public TestLinqController(ILinqService linqService)
        {
            _linqService = linqService;
        }

        [HttpGet("Punctul c) Subpunctul i)")]
        public List<User> Get(char initialLetter)
        {
            return _linqService.ExerciseC1(initialLetter);
        }

        [HttpGet("Punctul c) Subpunctul ii)")]
        public List<string> Get()
        {
            return _linqService.ExerciseC2();
        }

        [HttpGet("Punctul c) Subpunctul iii)")]
        public int GetCount()
        {
            return _linqService.ExerciseC3();
        }

        [HttpGet("Punctul d)")]
        public string GetD()
        {
            return _linqService.ExerciseD();
        }
    }
}
