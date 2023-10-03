using WebApplication1.Contexts;
using WebApplication1.Models;

namespace WebApplication1.Repos
{
    public class DrillBlockRep : EfCoreRepository<DrillBlock, EFContext>
    {
        public DrillBlockRep(EFContext context) : base(context)
        {

        }
    }

}
