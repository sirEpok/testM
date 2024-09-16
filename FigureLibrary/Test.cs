using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FigureLibrary
{
    [TestClass]
    class Test
    {
        double calc = new Circle(4);
        double result = calc.GetArea();
        Assert.AreEqual(50.24, result);
    }
}
