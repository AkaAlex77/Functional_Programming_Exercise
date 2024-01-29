int[] range = Console.ReadLine().Split().Select(int.Parse).ToArray();
string command = Console.ReadLine();

Func<int, int, List<int>> generateRange = (start, end) =>
{
    List<int> range = new();

    for (int i = start; i <= end; i++)
    {
        range.Add(i);
    }
    return range;
};

List<int> numbers = generateRange(range[0], range[1]);

Predicate<int> match;

if (command == "even")
{
    match = number => number % 2 == 0;
}
else
{
    match = number => number % 2 != 0;
}

foreach (var item in numbers)
{
    if (match(item))
    {
        Console.Write($"{item} ");
    }
}   