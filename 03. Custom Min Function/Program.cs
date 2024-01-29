HashSet<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToHashSet();

Func<HashSet<int>, int> min = numbers =>
{
    int min = int.MaxValue;

    foreach (var number in numbers)
    {
        if (number < min)
        {
            min = number;
        }
    }

    return min;
};

Console.WriteLine(min(numbers));