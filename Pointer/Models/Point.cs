namespace Pointer.Models
{
    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public int Size { get; set; }

        public virtual ICollection<ColorOfPoint> ColorOfPoints { get; set; }
    }
}
