﻿string[] initialArray = { "яблоко", "банан", "виншя", "апельсин", "арбуз", "персик", "дыня" };
string[] resultArray = RandomSubset(initialArray);

Console.WriteLine("Initial Array: " + string.Join(", ", initialArray));
Console.WriteLine("Result Array: " + string.Join(", ", resultArray));