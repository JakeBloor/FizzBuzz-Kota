namespace FizzBuzz.Tests;

public class FizzBuzzerTests
{
    private readonly IFizzBuzzer _fizzBuzzer;

    public FizzBuzzerTests()
    {
        _fizzBuzzer = new FizzBuzzer();
    }

    [Fact]
    public void FizzBuzz_ShouldHaveLenthOf100()
    {
        var results = _fizzBuzzer.FizzBuzz();
        results.Length.Should().Be(100);
    }

    [Fact]
    public void FizzBuzz_ShouldFizzAt3()
    {
        var results = _fizzBuzzer.FizzBuzz();
        results[2].Should().Be("Fizz");
    }

    [Fact]
    public void FizzBuzz_ShouldBuzzAt5()
    {
        var results = _fizzBuzzer.FizzBuzz();
        results[4].Should().Be("Buzz");
    }

    [Fact]
    public void FizzBuzz_ShouldFizzBuzzAt15()
    {
        var results = _fizzBuzzer.FizzBuzz();
        results[14].Should().Be("FizzBuzz");
    }

    [Fact]  
    public void FizzBuzz_ShouldFizzBuzzAt53()
    {
        var results = _fizzBuzzer.FizzBuzz();
        results[52].Should().Be("FizzBuzz");
    }

    [Fact]
    public void FizzBuzz_ShouldFizzAt23()
    {
        var results = _fizzBuzzer.FizzBuzz();
        results[22].Should().Be("Fizz");
    }

    [Fact]
    public void FizzBuzz_ShouldBuzzAt25()
    {
        var results = _fizzBuzzer.FizzBuzz();
        results[24].Should().Be("Buzz");
    }

    [Fact]
    public void FizzBuzz_ShouldReturnNumberAsString()
    {
        var results = _fizzBuzzer.FizzBuzz();
        results[0].Should().Be("1");
    }
}