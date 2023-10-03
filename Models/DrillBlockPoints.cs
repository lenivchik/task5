using WebApplication1.Interfaces;

namespace WebApplication1.Models
{
    public class DrillBlockPoints : IEntity
    {
        public int Id { get; set; }
        public int DrillBlockId { get; set; }
        public string Sequence { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
    }
}
