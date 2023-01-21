using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelajarUnitTest
{
    public class KalkulatorTest //naming convention untuk class test disarankan mengandung kata Test nya
    {
        [Fact] //decorator
        public void AddOperation()
        {
            //Arrange -- inisial value nya
            int a = 1;
            int b = 2;
            int expectedValue = 3;

            //Act
            //Action yg akan di jalankan oleh method yg akan ditest
            var result = Kalkulator.Add(a, b);

            //Assert -- unit testing yg akan menguji method dengan exspected value nya
            Assert.Equal(expectedValue, result);
        }

        [Fact]
        public void SubstractOperation()
        {
            //Arrange
            int a = 5;
            int b = 3;
            int expectedValue = 2;

            //Act
            var result = Kalkulator.Substract(a, b);

            //Assert
            Assert.Equal(expectedValue, result);
        }
        [Fact]
        public void MultplyOperation()
        {
            //Arrange
            int a = 5;
            int b = 2;
            int expectedValue = 10;

            //Act
            var result = Kalkulator.Multiply(a, b);

            //Assert
            Assert.Equal(expectedValue, result);
        }

        [Fact]
        public void DivideOperation()
        {
            //Arrange
            int a = 10;
            int b = 5;
            int expectedValue = 2;

            //Act
            var result = Kalkulator.Divide(a, b);

            //Assert
            Assert.Equal(expectedValue, result);
        }

        [Fact]
        public void DivideByZero()
        {
            //Arrange
            int a = 10;
            int b = 0;

            //Act

            //Assert
            Assert.Throws<DivideByZeroException>(() => Kalkulator.Divide(a, b));

        }

        [Theory]
        [InlineData(1, 2)]
        public void AddOperationInline(int a, int b)
        {
            //Arrange

            //Act
            var result = Kalkulator.Add(a, b);

            //Assert
            Assert.Equal(3, result);
        }

    }
}
