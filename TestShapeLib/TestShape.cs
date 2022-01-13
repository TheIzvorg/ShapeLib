using NUnit.Framework;
using ShapeLib;

namespace TestShapeLib
{
    class TestShape
    {
        Shape triangle;
        Shape circle;

        [SetUp]
        public void Setup()
        {
            triangle = new Triangle(3, 4, 5);
            circle = new Circle(4);
        }

        [Test]
        public void TestGetArea()
        {
            if (triangle.GetPerimeter() != 12)
                Assert.Fail("triangle.GetPerimeter() is Failed");

            if (circle.GetArea() != System.Math.PI * 16)
                Assert.Fail("cirle.GetArea() is Failed");

            Assert.Pass("Test1 Passed!");
        }

        [Test]
        public void TestGetPerimeter()
        {
            double area = System.Math.Sqrt(6 * (6 - 3) * (6 - 4) * (6 - 5));
            if (triangle.GetArea() != area)
                Assert.Fail("triangle.GetArea() is Failed");

            if (circle.GetPerimeter() != System.Math.PI * 8)
                Assert.Fail("cirle.GetPerimeter() is Failed");

            Assert.Pass("Test2 Passed!");
        }
    }
}
