using AreaOfGeometicFigures.Domain.Entities;
using NUnit.Framework;

namespace AreaOfGeometricFigures.Tests
{
    [TestFixture]
    internal class AreaOfGeometricFiguresEntitiesTests
    {
        [Test]
        public void CreateCircleWithData_CreateWithRadius5_ReturnCircleSquareRadius5()
        {
            //Arrenge
            var circle = new Сircle(5);
            var expected = 2 * 3.1428 * 5;

            //Act
            var actual = circle.GetSquareOfFigure();

            //Assert
            Assert.AreEqual(expected,actual);
        }

        [Test]
        public void CreateTriangleWithData_CreateWithSide5_5_5_ReturnTiangeSquare()
        {
            //Arrange
            var triangle = new Triangle(5, 5, 5);
            var expected = 10.8253;
            //Act

            var triangleSquare = Math.Round( triangle.GetSquareOfFigure(), 4);

            //Assert
            Assert.IsFalse(triangle.IsRightTriangle);
            Assert.AreEqual(expected,triangleSquare);
        }

        [Test]
        public void CreateTriangleWithData_CreateRectangularTriangle_3_4_5_ReturnTriangeSquare()
        {
            //Arrenge
            var rectangularTriangle = new Triangle(3, 4, 5);
            //Act
            var isRectangularTriangle = rectangularTriangle.IsRightTriangle;
            //Assert
            Assert.IsTrue(isRectangularTriangle);
        }
    }
}