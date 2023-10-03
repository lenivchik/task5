using WebApplication1.Interfaces;

namespace WebApplication1.Models
{
    public class DrillBlock : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime UpdateDate { get; set; }

        public List<Hole>? Holes { get; set; }
        public DrillBlockPoints DrillBlockPoints { get; set; }

    }
}
