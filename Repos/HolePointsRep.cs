using WebApplication1.Contexts;
using WebApplication1.Models;

namespace WebApplication1.Repos
{
    public class HolePointsRep : EfCoreRepository<HolePoints, EFContext>
    {
        public HolePointsRep(EFContext context) : base(context)
        {

        }
    }
}
