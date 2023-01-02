using AreaOfGeometicFigures.Domain.EasyTransformClasses;
using AreaOfGeometicFigures.Domain.EasyTransformInterfaces;

namespace AreaOfGeometicFigures.Domain.Entities
{
    public class EquilateralTriangle : IGeometricFigure, ICalculatePerimeter, ICalculateSquare
    {
        //композиция.
        private ICalculation _calculateSquare;
        private ICalculation _calculatePerimetr;

        public EquilateralTriangle()
        {
            _calculateSquare = new SideLenghtMethod();
            _calculatePerimetr = new TrianglePerimetr();
        }
        public double CalculatePerimeter(params double[] values)
            => _calculatePerimetr.Calculate(values);

        public double CalculateSquare(params double[] values)
            => _calculateSquare.Calculate(values);
    }
}
