namespace AreaOfGeometicFigures.Domain.Entities
{
    public class Сircle : AbstractGeometricEntity
    {
        private const double PI = 3.1428;
        private double _radius;

        public Сircle(double radius)
        {
            _radius = radius;
        }

        public override double GetSquareOfFigure()
            => _radius * 2 * PI;
    }
}
