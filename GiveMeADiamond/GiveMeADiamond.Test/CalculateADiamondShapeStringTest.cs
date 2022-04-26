using GiveMeADiamond.App;
using System.Text;
using Xunit;

namespace GiveMeADiamond.Test
{
    public class CalculateADiamondShapeStringTest
    {
        [Fact]
        public void printDiamondShapeStringTest1_ShouldReturnNull_NegativeInt()
        {
            //Arrange
            ICalculateADiamondShapeString calculateADiamondShapeString = new CalculateADiamondShapeString();
            int n = -2;

            //Act
            var actual = calculateADiamondShapeString.printDiamondShapeString(n);

            //Assert
            Assert.Null(actual);
        }

        [Fact]
        public void printDiamondShapeStringTest2_ShouldReturnNull_IntIsNull()
        {
            //Arrange
            ICalculateADiamondShapeString calculateADiamondShapeString = new CalculateADiamondShapeString();
            int n = 0;

            //Act
            var actual = calculateADiamondShapeString.printDiamondShapeString(n);

            //Assert
            Assert.Null(actual);
        }

        [Fact]
        public void printDiamondShapeStringTest3_ShouldReturnNull_IntIsEven()
        {
            //Arrange
            ICalculateADiamondShapeString calculateADiamondShapeString = new CalculateADiamondShapeString();
            int n = 2;

            //Act
            var actual = calculateADiamondShapeString.printDiamondShapeString(n);

            //Assert
            Assert.Null(actual);
        }

        [Fact]
        public void printDiamondShapeStringTest4_Successful()
        {
            //Arrange
            ICalculateADiamondShapeString calculateADiamondShapeString = new CalculateADiamondShapeString();
            int n = 1;
            var expected = new StringBuilder();
            expected.Append("*\n");

            //Act
            var actual = calculateADiamondShapeString.printDiamondShapeString(n);

            //Assert
            Assert.Equal(expected.ToString(), actual);
        }

        [Fact]
        public void printDiamondShapeStringTest5_Successful()
        {
            //Arrange
            ICalculateADiamondShapeString calculateADiamondShapeString = new CalculateADiamondShapeString();
            int n = 3;
            var expected = new StringBuilder();
            expected.Append(" *\n");
            expected.Append("***\n");
            expected.Append(" *\n");

            //Act
            var actual = calculateADiamondShapeString.printDiamondShapeString(n);

            //Assert
            Assert.Equal(expected.ToString(), actual);
        }

        [Fact]
        public void printDiamondShapeStringTest6_Successful()
        {
            //Arrange
            ICalculateADiamondShapeString calculateADiamondShapeString = new CalculateADiamondShapeString();
            int n = 5;
            var expected = new StringBuilder();
            expected.Append("  *\n");
            expected.Append(" ***\n");
            expected.Append("*****\n");
            expected.Append(" ***\n");
            expected.Append("  *\n");

            //Act
            var actual = calculateADiamondShapeString.printDiamondShapeString(n);

            //Assert
            Assert.Equal(expected.ToString(), actual);
        }
    }
}
