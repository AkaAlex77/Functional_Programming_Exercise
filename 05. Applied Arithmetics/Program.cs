List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

string command;

Func<string, List<int>, List<int>> calculate = (command, numbers) =>
{
    List<int> result = new();
    foreach (var item in numbers)
    {
        switch (command)
        {
            case "add":
                result.Add(item + 1);
                break;
            case "multiply":
                result.Add(item * 2);
                break;
            case "subtract":
                result.Add(item - 1);
                break;
        }
    }

    return result;
};

Action<List<int>> print = numbers => Console.WriteLine(string.Join(" ", numbers));


while ((command = Console.ReadLine()) != "end")
{
    if (command == "print")
    {
        print(numbers);
    }
    else
    {
        numbers = calculate(command, numbers);
    }
}

