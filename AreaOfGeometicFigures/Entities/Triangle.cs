namespace AreaOfGeometicFigures.Domain.Entities
{
    public class Triangle : AbstractGeometricEntity
    {
        private double _sideA { get; init; }
        private double _sideB { get; init; }
        private double _sideC { get; init; }
        public Triangle(double sideA, double sideB, double sideC)
        {
            _sideA = CheckForPositiveInputValue(sideA);
            _sideB = CheckForPositiveInputValue(sideB);
            _sideC = CheckForPositiveInputValue(sideC);
        }

        public override double GetSquareOfFicure()
        {
            var p = HalfPerimetr();
            return Math.Sqrt((p * (p - _sideA)) * (p * (p - _sideB)) * (p * (p - _sideC)));
        }

        private double HalfPerimetr()
            => (_sideA + _sideB + _sideC) / 2;

        private double CheckForPositiveInputValue(double value)
            => value > 0 ? value : throw new Exception("Значение стороны треугольника отрицательное.");
    }
}
