using AreaOfGeometicFigures.Domain.Inerfaces;

namespace AreaOfGeometicFigures.Domain.Entities
{
    public class Triangle : AbstractGeometricEntity, IGeometricEntity
    {
        private double _sideA { get; init; }
        private double _sideB { get; init; }
        private double _sideC { get; init; }
        public bool IsRightTriangle { get; init; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            _sideA = CheckForPositiveInputValue(sideA);
            _sideB = CheckForPositiveInputValue(sideB);
            _sideC = CheckForPositiveInputValue(sideC);
            IsRightTriangle = IsRightTriangleChecker(sideA, sideB, sideC);
        }

        public override double GetSquareOfFigure()
        {
            var p = HalfPerimetr();
            return Math.Sqrt((p * (p - _sideA)) * (p * (p - _sideB)) * (p * (p - _sideC)));
        }

        private double HalfPerimetr()
            => (_sideA + _sideB + _sideC) / 2;

        private double CheckForPositiveInputValue(double value)
            => value > 0 
                ? value 
                : throw new Exception("Значение стороны треугольника отрицательное.");

        private bool IsRightTriangleChecker(double sideA, double sideB, double sideC)
            => sideA * sideA + sideB * sideB == sideC * sideC
                || sideC * sideC + sideB * sideB == sideA * sideA
                || sideA * sideA + sideC * sideC == sideB * sideB;

        public double GetSquare()
        {
            throw new NotImplementedException();
        }
    }           
}
