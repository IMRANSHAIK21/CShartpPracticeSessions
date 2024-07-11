using ClassLibraryForUnitTesting;

namespace ClassLibraryUnitTests
{
    public class CalculatorUnitTest
    {
        [Fact]
        public void TestAdding10And10()
        {
            // Arrange: Set up the inputs and the unit under test.
            double a = 10; double b = 10;
            double expected = 20;
            Calculator calc = new();

            // Act: Execute the fucntion to test 
            double actual = calc.Add(a, b);

            // Assert: Make assertions to compare expected to actual result

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestAdding2And3()
        {
            double a = 2;
            double b = 3;
            double expected = 5;
            Calculator calc = new();
            double actual = calc.Add(a, b);
            Assert.Equal(expected, actual);
        }

    }
}