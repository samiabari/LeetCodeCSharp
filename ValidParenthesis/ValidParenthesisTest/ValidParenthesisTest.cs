using ValidParenthesis;

namespace ValidParenthesisTest
{
    public class ValidParenthesisTest
    {
        [Fact]
        public void Test1()
        {
            string s = "()";
            bool result = Program.IsValid(s);
            bool expected = true;
            Assert.Equal(expected,result);
        }
        [Fact]
        public void Test2()
        {
            string s = "(";
            bool result = Program.IsValid(s);
            bool expected = false;
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test3()
        {
            string s = "()[]{}";
            bool result = Program.IsValid(s);
            bool expected = true;
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test4()
        {
            string s = "(]";
            bool result = Program.IsValid(s);
            bool expected = false;
            Assert.Equal(expected, result);
        }
    }
}