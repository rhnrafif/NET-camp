using System.Xml.Serialization;

namespace BelajarUnitTest
{
    public class UnitTest1
    {
        //method unit test dibuat sebanyak method yg akan di testing.
        //berlaku juga untuk if else atau switch, maka harus membuat method untuk unit test sebanyak case pada switch tersebut
        //


        [Fact] //Fakta
        public void Test1()
        {
            int c = 1 + 2;
            Assert.Equal(3, c);
        }

        [Fact]
        public void Test2()
        {
            int c = 1 + 3;
            Assert.NotEqual(2, c);
        }

        [Fact]
        public void Test3()
        {
            var a = 1;
            Assert.NotNull(a); //check value atau object tidak sama dengan null
        }

        [Fact]
        public void Test4()
        {
            string a = null;
            Assert.Null(a);
        }

        [Fact]
        public void Test5()
        {
            int a = 5;
            int b = 10;
            Assert.True(b > a);
        }

        [Fact]
        public void Test6()
        {
            int a = 5;
            int b = 10;
            Assert.False(b < a);
        }

        [Fact]
        public void Test7() //boleh membuat multiple assert di unit testing
        {
            string expected = "This is Sparta !";
            string actual = "this is sparta !";

            Assert.False(actual == expected);
            Assert.NotEqual(expected, actual);
            Assert.Equal(expected, actual, StringComparer.CurrentCultureIgnoreCase);
        }

        [Theory] //
        [InlineData(1)] //initial nilai yg akan dikirim ke paramter a;
        public void Test8(int a)
        {
            int b = 2;
            int c = a + b;

            Assert.Equal(3, c);
        }

        [Theory]
        [InlineData(3)] //intial value ada 3, maka unit testnya ada 3 hasil
        [InlineData(5)] //iline data dipakai dalam [Theory]
        [InlineData(6)]
        public void Test9(int value)
        {
            Assert.True(IsOdd(value));
        }

        bool IsOdd(int value)
        {
            return value % 2 == 1;
        }

        [Fact]
        public void Test10()
        {
            var ex = Assert.Throws<NotImplementedException>(ThrowMethod);
            Assert.IsType<NotImplementedException>(ex);
        }
        void ThrowMethod()
        {
            throw new NotImplementedException();
        }

        [Fact]
        public void Test11()
        {
            var list = new List<int> { 42, 212 };

            Assert.Collection(list, 
                item => Assert.Equal(42, item),
                item => Assert.Equal(212, item)
                );
        }

        [Fact]
        public void Test12()
        {
            Assert.Contains("text", "This is text");
        }

        [Theory]
        [InlineData("This is Brazil")]
        [InlineData("This America")]
        public void Test13(string value)
        {
            Assert.Contains("Brazil", value);
        }

        [Fact]
        public void Test14()
        {
            var names = new List<string> { "Maki", "Malkan" };
            Assert.Contains(names, n => n == "Maki"); //dia akan melakukan loop list sendiri
        }

        [Fact]
        public void Test15()
        {
            Assert.DoesNotContain("mk", "Malkan");
        }

        [Fact]
        public void Test16()
        {
            Assert.StartsWith("This","This is Sparta");
        }

        [Fact]
        public void Test17()
        {
            Assert.EndsWith("End", "This the End");
        }

        [Fact]
        public void Test18()
        {
            var set1 = new HashSet<int> { 1, 2, 3, 4, 5, 6};
            var set2 = new HashSet<int> { 3, 4};

            Assert.Subset(set1, set2); //cek subset yang ada di set lain. 3 dan 4 bagian dari set 1
        }

        [Fact]
        public void Test19()
        {
            var set1 = new HashSet<int> { 1, 2, 3, 4, 5, 6, 7 };
            var set2 = new HashSet<int> { 3, 4, 5, };

            Assert.ProperSubset(set1, set2); //exspexted adalah nilai yg diharapkan atau dicari //actual adalah nilai yg jadi obnject perbdangingannya
                                             //properset adalah turunan dari set induk. dlm hal ini set 2 merupakan trunan set1
        }

        [Fact]
        public void Test20()
        {
            var set1 = new HashSet<int> { 1, 2, 3, 4, 5, 6, 7 };
            var set2 = new HashSet<int> { 3, 4, 5, };

            Assert.Superset(set2, set1); //superset adalah induk dari set. dlm hal ini set 1 merupakan induk dari set2
        }

        [Fact]
        public void Test21()
        {
            var list = new List<int> { };

            Assert.Empty(list);
        }

        [Fact]
        public void Test22()
        {
            var list = new List<int> { 1 };

            Assert.NotEmpty(list);
        }

        [Fact]
        public void Test23()
        {
            var list = new List<int> { 1 };
            Assert.Single(list); //utk cek coll hanya berisi satu element
        }

        [Fact]
        public void Test24()
        {
            var obj1 = new object();
            var obj2 = obj1;
            var obj3 = new object();

            Assert.Same(obj1, obj2);
            Assert.NotSame(obj1, obj3);
        }
    }
}