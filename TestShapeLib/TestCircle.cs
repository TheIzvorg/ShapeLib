using NUnit.Framework;
using ShapeLib;

namespace TestShapeLib
{
    public class TestCircle
    {
        Circle circle;
        [SetUp]
        public void Setup()
        {
            circle = new Circle(4);
        }

        [Test]
        public void TestGetArea()
        {
            if(circle.GetArea() != System.Math.PI * 16)
                Assert.Fail("cirle.GetArea() is Failed");
            Assert.Pass("Test1 Passed!");
        }

        [Test]
        public void TestGetPerimeter()
        {
            if(circle.GetPerimeter() != System.Math.PI * 8)
                Assert.Fail("cirle.GetPerimeter() is Failed");
            Assert.Pass("Test2 Passed!");
        }
    }
}