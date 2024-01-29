
string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

Action<string[]> print = names =>
{
    foreach (var item in names)
    {
        Console.WriteLine($"Sir {item}");
    }
};

print(names);


