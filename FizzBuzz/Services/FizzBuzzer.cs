

namespace FizzBuzz.Services;
internal class FizzBuzzer : IFizzBuzzer
{
    public string[] FizzBuzz()
    {
        var results = new List<string>();

        for (int i = 1; i <= 100; i++)
        {
            results.Add(GetFizzBuzz(i));
        }

        return results.ToArray();
    }

    private string GetFizzBuzz(int number)
    {
        if (IsMultiple3(number) && IsMultiple5(number))
        {
            return "FizzBuzz";
        }
        else if (IsMultiple3(number))
        {
            return "Fizz";
        }
        else if (IsMultiple5(number))
        {
            return "Buzz";
        }
        
        if (ContainsThree(number) && ContainsFive(number))
        {
            return "FizzBuzz";
        }
        else if (ContainsThree(number))
        {
            return "Fizz";
        }
        else if (ContainsFive(number))
        {
            return "Buzz";
        }
        
        return number.ToString();
    }

    private static bool IsMultiple3(int number)
    {
        return number % 3 == 0;
    }

    private static bool IsMultiple5(int number)
    {
        return number % 5 == 0;
    }

    private static bool ContainsThree(int number)
    {
        return number.ToString().Contains("3");
    }

    private static bool ContainsFive(int number)
    {
        return number.ToString().Contains("5");
    }
}
