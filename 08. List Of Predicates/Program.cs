List<Predicate<int>> predicates = new();

int endOfRnge = int.Parse(Console.ReadLine());

HashSet<int> dividers = Console.ReadLine().Split().Select(int.Parse).ToHashSet();

int[] numbers = Enumerable.Range(1, endOfRnge).ToArray();

foreach (var item in dividers)
{
    predicates.Add(n => n % item == 0);
}


foreach (var number in numbers)
{
    bool isDivisable = true;

    foreach (var match in predicates)
    {
        if (!match(number))
        {
            isDivisable = false;
            break;
        }
    }

    if (isDivisable)
    {
        Console.Write($"{number} ");
    }

}