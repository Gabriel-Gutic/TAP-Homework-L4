using Lab4Web.Services.Delegate;
using Microsoft.AspNetCore.Mvc;

namespace Lab4Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestDelegateController : ControllerBase
    {
        private readonly IDelegateService _delegateService;

        public TestDelegateController(IDelegateService delegateService)
        {
            _delegateService = delegateService;
        }

        [HttpGet("Punctul a)")]
        public string Exercise1(float x)
        {
            var callback = (float x) => { return $"sqrt({x}) = {Math.Sqrt(x)}"; };

            return _delegateService.Exercise1(x, callback);
        }

        [HttpGet("Punctul b) Introduceti un x pozitiv, apoi unul negativ")]
        public string Exercise2(float x)
        {
            var callback1 = _delegateService.SqrtFunction;
            var callback2 = _delegateService.NegativeNumber;

            return _delegateService.Exercise2(x, callback1, callback2);
        }

        [HttpGet("Punctul c)")]
        public string Exercise3(float x, float y)
        {
            return _delegateService.Exercise3(x, y);
        }
    }
}
