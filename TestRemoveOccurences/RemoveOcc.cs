using RemovePairOccurrences;
using Xunit;

namespace TestRemoveOccurences
{
    public class RemoveOcc
    {
        
       
            [Fact]
            public void Test_RemoveEvenOccurrences_Example1()
            {
                var input = new int[] { 1, 1, 0, 2, 2 };
                var expected = new int[] { 0 };

                var result = ManipulateArray.RemoveOccurrences(input);

                Assert.Equal(expected, result);
            }

            [Fact]
            public void Test_RemoveEvenOccurrences_Example2()
            {
                var input = new int[] { 3, 4, 5 };
                var expected = new int[] { 3, 4, 5 };

                var result = ManipulateArray.RemoveOccurrences(input);

                Assert.Equal(expected, result);
            }

            [Fact]
            public void Test_RemoveEvenOccurrences_Example3()
            {
                var input = new int[] { 2, 2, 2 };
                var expected = new int[] { 2, 2, 2 };

                var result = ManipulateArray.RemoveOccurrences(input);

                Assert.Equal(expected, result);
            }

            [Fact]
            public void Test_RemoveEvenOccurrences_Example4()
            {
                var input = new int[] { 2, 2 };
                var expected = new int[] { };

                var result = ManipulateArray.RemoveOccurrences(input);

                Assert.Equal(expected, result);
            }
        
    }
}