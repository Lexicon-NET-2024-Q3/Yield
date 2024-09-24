

foreach (int number in GetNumbersOrdinary().Take(10))
{
    Console.WriteLine(number);
}

foreach(int number in GetNumbersYield().Take(10))
{
    Console.WriteLine(number);
}

IEnumerable<int> GetNumbersYield()
{
    int i = 0;

    while (true)
    {
        yield return ++i; 
    }
}

IEnumerable<int> GetNumbersOrdinary()
{
    int i = 0;
    var res = new List<int>();

    while(i < 1000000)
    {
        res.Add(++i);
    }

    return res; 
}