using WebApplication1.Interfaces;

namespace WebApplication1.Models
{
    public class Hole : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DrillBlockId { get; set; }
        public float Depth { get; set; }

        public HolePoints HolePoints { get; set; }

    }
}
