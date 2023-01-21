using BelajarUnitTest.CustomAssert;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelajarUnitTest
{
    public class CustomAssertTest
    {
        public class BooleanFact
        {
            [Fact]
            public void ShouldBeTrue()
            {
                Boolean val = true;

                val.ShouldBeTrue();
            }

            [Fact]
            public void ShouldBeFalse()
            {
                Boolean val = false;
                val.ShouldBeFalse();
            }

            [Fact]
            public void ShouldBeTrueWithMessage()
            {
                Boolean val = false;
                Exception exception = Record.Exception(() => val.ShouldBeTrue("Should be true"));

                Assert.StartsWith("Should be true", exception.Message);
            }

            [Fact]
            public void ShouldBeFalseWithMessage()
            {
                Boolean val = true;
                Exception exception = Record.Exception(() => val.ShouldBeFalse("Should be false"));

                Assert.StartsWith("Should be false", exception.Message);
            }
        }
    }
}
