using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelajarUnitTest.CustomAssert
{
    public static class BooleanAssertionExtentions
    {
        public static void ShouldBeFalse(this bool condition)
        {
            Assert.False(condition);
        }

        public static void ShouldBeFalse(this bool condition, string message)
        {
            Assert.False(condition, message);
        }

        public static void ShouldBeTrue(this bool condition)
        {
            Assert.True(condition);
        }
        public static void ShouldBeTrue(this bool condition, string message)
        {
            Assert.True(condition, message);
        }


    }
}
