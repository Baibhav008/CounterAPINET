using CounterAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace CounterAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CountController : Controller
    {
        private readonly SingletonService _singletonService;
        private readonly ScopedService _scopedService;
        private readonly TransientService _transientService;

        public CountController(SingletonService singletonService, ScopedService scopedService, TransientService transientService)
        {
            _singletonService = singletonService;
            _scopedService = scopedService;
            _transientService = transientService;
        }

        [HttpGet("singleton")]
        public IActionResult GetSingletonCount()
        {
            var singletonCount = _singletonService.GetCount();
            return Ok(singletonCount);
        }

        [HttpGet("scoped")]
        public IActionResult GetScopedCount()
        {
            var scopedCount = _scopedService.GetCount();
            return Ok(scopedCount);
        }

        [HttpGet("transient")]
        public IActionResult GetTransientCount()
        {
            var transientCount = _transientService.GetCount();
            return Ok(transientCount);
        }
    }
}
