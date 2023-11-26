

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
        if (IsFizz(number) && IsBuzzz(number))
        {
            return "FizzBuzz";
        }
        else if (IsFizz(number))
        {
            return "Fizz";
        }
        else if (IsBuzzz(number))
        {
            return "Buzz";
        }
        else if (ContainsThree(number) && ContainsFive(number))
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
        else
        {
            return number.ToString();
        }
    }

    private static bool IsFizz(int number)
    {
        return number % 3 == 0;
    }

    private static bool IsBuzzz(int number)
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
