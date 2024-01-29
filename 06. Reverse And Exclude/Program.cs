List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

int divider = int.Parse(Console.ReadLine());


Func<List<int>, List<int>> reverse = numbers =>
{
    List<int> result = new();
    for (int i = numbers.Count - 1; i >= 0; i--)
    {
        result.Add(numbers[i]);
    }

    return result;
};


Func<List<int>, Predicate<int>, List<int>> exludeDivisible = (numbers, match) =>
{
    List<int> result = new();

    foreach (var item in numbers)
    {
        if (match(item))
        {
            result.Add(item);
        }
    }


    return result;
};

numbers = exludeDivisible(numbers, n => n % divider != 0);
numbers = reverse(numbers);


Console.WriteLine(string.Join(" ", numbers));
