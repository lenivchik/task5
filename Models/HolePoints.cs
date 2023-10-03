using WebApplication1.Interfaces;

namespace WebApplication1.Models
{
    public class HolePoints : IEntity
    {
        public int Id { get; set; }
        public int HoleId { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
    }
}
