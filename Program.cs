string[] initialArray = { "яблоко", "банан", "виншя", "апельсин", "арбуз", "персик", "дыня" };
string[] resultArray = RandomSubset(initialArray);

Console.WriteLine("Initial Array: " + string.Join(", ", initialArray));
Console.WriteLine("Result Array: " + string.Join(", ", resultArray));

static string[] RandomSubset(string[] inputArray)
{
    Random random = new Random();
    int subsetLength = random.Next(0, 4);
    List<string> randomSubset = new List<string>();

    for (int i = 0; i < subsetLength; i++)
    {
        if (inputArray.Length > 0)
        {
            int randomIndex = random.Next(0, inputArray.Length);
            randomSubset.Add(inputArray[randomIndex]);
        }
    }

      return randomSubset.ToArray();
}