using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Contexts;
using WebApplication1.Models;
using WebApplication1.Repos;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HoleController : CoreController<Hole, HoleRep>
    {
        public HoleController(HoleRep rep) : base(rep) { }

    }
}
