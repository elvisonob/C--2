var numbers = new[] { 10, -8, 2, 12, -17 };

var positiveNumbers = GetPositiveNumbers(numbers);

foreach(var number in positiveNumbers)
{
    Console.WriteLine(number);
}

List<int> GetPositiveNumbers(int[] number)
{
    List<int> numberResult = new List<int>();
    foreach(var numbers in number)
    {
        if (numbers > 0)
        {
            numberResult.Add(numbers);
        }
    }

    return new List<int>(numberResult);
}
