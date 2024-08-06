bool isParsingSuccessful;
do
{
    Console.WriteLine("Enter a number:");
    var userInput = Console.ReadLine();
    isParsingSuccessful = int.TryParse(userInput, out int number);
    if (isParsingSuccessful)
    {
        Console.WriteLine("Parsing is successful " + number);
    }
    else
    {
        Console.WriteLine("Parsing was not successful");
    }
} while (!isParsingSuccessful);

Console.ReadKey();
