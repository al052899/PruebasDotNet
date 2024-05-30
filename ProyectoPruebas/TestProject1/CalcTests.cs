using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    [TestClass]
    public class CalcTests
    {
        [TestMethod]
        public void Sum_ShouldCalcAndReturnSameValue()
        {
            //Arrange
            int a = 4;
            int b= 4;
            int expected = 8;

            //Act
            int actual = Calcs.Sum(a, b);

            //Assert
            Assert.Equals(expected, actual);
        }
    }
}
