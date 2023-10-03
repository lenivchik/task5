using WebApplication1.Contexts;
using WebApplication1.Models;

namespace WebApplication1.Repos
{
    public class HoleRep : EfCoreRepository<Hole, EFContext>
    {
        public HoleRep(EFContext context) : base(context)
        {

        }
    }
}
