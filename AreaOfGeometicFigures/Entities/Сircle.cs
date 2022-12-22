namespace AreaOfGeometicFigures.Domain.Entities
{
    public class Сircle : AbstractGeometricEntity
    {
        private const double PHI = 3.1428;
        private double _radius;

        public Сircle(double radius)
        {
            _radius = radius;
        }

        public override double GetSquareOfFicure()
            => _radius * 2 * PHI;
    }
}
