using AreaOfGeometicFigures.Domain.EasyTransformInterfaces;

namespace AreaOfGeometicFigures.Domain.EasyTransformClasses
{
    public class SideLenghtMethod : ICalculation
    {
        //Передать параметрезированый массив IParam[] (Side : IParam, Radius: IParam, где Side и Radius => ValueObject) 
        public double Calculate(params double[] values)
        {
            if (values == null || values.Length == 0 || values.Count() != 1)
                throw new Exception("Для равностороннего треугольника предеайте только одну сторону.");
            var side = values.First();
            if (side <= 0)
                throw new Exception("Передайте положительное число.");
            return (Math.Sqrt(3) * Math.Pow(side, 2)) / 4;
        }
    }
}
