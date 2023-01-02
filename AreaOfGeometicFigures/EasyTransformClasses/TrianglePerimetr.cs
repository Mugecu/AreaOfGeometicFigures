using AreaOfGeometicFigures.Domain.EasyTransformInterfaces;

namespace AreaOfGeometicFigures.Domain.EasyTransformClasses
{
    public class TrianglePerimetr : ICalculation
    {
        public double Calculate(params double[] values)
        {
            // всякие проверки.
            return (values[0] + values[0] + values[0])/2;
        }
    }
}
