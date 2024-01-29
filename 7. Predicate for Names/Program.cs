int n = int.Parse(Console.ReadLine());
string[] names = Console.ReadLine().Split();

Action<string[], Predicate<string>> printNames = (names, match) =>
{
    foreach (var item in names)
    {
        if (match(item))
        {
            Console.WriteLine(item);
        }
    }
};

Predicate<string> match = name => name.Length <= n;


printNames(names,match);

