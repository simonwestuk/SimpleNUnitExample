using NUnit.Framework;
using Principles;

namespace UnitTests
{
    public class Tests
    {
     
        [Test]
        [TestCase(new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, ExpectedResult = 55.0)]
        [TestCase(new double[] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 }, ExpectedResult = 550.0)]
        public double SumOfNumsTest(double[] nums)
        {
            //Arrange

            Dry testDry = new Dry();

            //Act

            double totalNums = testDry.SumOfNums(nums);
  
            //Assert

            return totalNums;

        }
    }
}