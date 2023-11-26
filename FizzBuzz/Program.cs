Console.WriteLine("Welcome to FizzBuzz");

IFizzBuzzer fizzBuzzer = new FizzBuzzer();

var results = fizzBuzzer.FizzBuzz();

Console.WriteLine(
    string.Join(
               Environment.NewLine,
                      results
                         ));

Console.WriteLine("Press any key to exit");
Console.ReadLine();