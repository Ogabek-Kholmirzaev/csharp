using CalculatorLib;

namespace CalculatorLibUnitTests;

public class CalculatorUnitTests
{
    [Fact]
    public void TestAdding2And2()
    {
        // Arrange: Set up the inputs and the unit under test
        double a = 2, b = 2, expected = 4;
        Calculator calculator = new();

        // Act: Execute the function to test
        double actual = calculator.Add(a, b);

        // Assert: Make assertions to compare expected to actual results
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestAdding2And3()
    {
        // Arrange
        double a = 2, b = 3, expected = 5;
        Calculator calc = new();

        // Act
        double actual = calc.Add(a, b);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(2, 2, 4)]
    [InlineData(2, 3, 5)]
    public void TestAdding(double a, double b, double expected)
    {
        // Arranges: Set up the unit (method) under test
        Calculator calculator = new();

        // Act: Execute the function to test
        double actual = calculator.Add(a, b);

        // Assert: Make assertions to compare expected to actual results
        Assert.Equal(expected, actual);
    }
}
