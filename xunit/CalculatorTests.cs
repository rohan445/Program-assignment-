using Xunit; // Using xUnit for testing framework
using Core; // Assuming the Calculator class is in the Core namespace, adjust if necessary
using System;

public class CalculatorTests
{
    private readonly Calculator calc = new();

    [Fact]
    public void Add_ShouldWork()
    {
        Assert.Equal(5, calc.Add(2, 3));
    }

    [Theory]
    [InlineData(5, 3, 2)]
    [InlineData(10, 7, 3)]
    public void Subtract_ShouldWork(int a, int b, int expected)
    {
        Assert.Equal(expected, calc.Subtract(a, b));
    }

    [Theory]
    [InlineData(2, 3, 6)]
    [InlineData(4, 5, 20)]
    public void Multiply_ShouldWork(int a, int b, int expected)
    {
        Assert.Equal(expected, calc.Multiply(a, b));
    }

    [Fact]
    public void Divide_ByZero_ShouldThrow()
    {
        Assert.Throws<DivideByZeroException>(() => calc.Divide(10, 0));
    }
}