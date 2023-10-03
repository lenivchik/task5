using WebApplication1.Contexts;
using WebApplication1.Models;

namespace WebApplication1.Repos
{

    public class DrillBlockPointsRep : EfCoreRepository<DrillBlockPoints, EFContext>
    {
        public DrillBlockPointsRep(EFContext context) : base(context)
        {

        }
    }

}
