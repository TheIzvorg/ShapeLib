using NUnit.Framework;
using ShapeLib;

namespace TestShapeLib
{
    public class TestTriangle
    {
        Triangle triangle;
        [SetUp]
        public void Setup()
        {
            triangle = new Triangle(3,4,5);
        }

        [Test]
        public void TestGetPerimeter()
        {
            if(triangle.GetPerimeter() != 12)
                Assert.Fail("triangle.GetPerimeter() is Failed");
            Assert.Pass("Test1 Passed!");
        }

        [Test]
        public void TestGetArea()
        {
            double area = System.Math.Sqrt(6 * (6 - 3) * (6 - 4) * (6 - 5));
            if(triangle.GetArea() != area)
                Assert.Fail("triangle.GetArea() is Failed");
            Assert.Pass("Test2 Passed!");
        }

        [Test]
        public void TestIsRight()
        {
            if(triangle.IsRight != true)
                Assert.Fail("triangle.IsRight is Failed");
            Assert.Pass("Test3 Passed!");
        }
    }
}
