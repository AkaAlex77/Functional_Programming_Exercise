List<string> people = Console.ReadLine().Split().ToList();

string command;

while ((command = Console.ReadLine()) != "Party!")
{
    string[] tokens = command.Split();

    string action = tokens[0];
    string filter = tokens[1];
    string value = tokens[2];

    if (action == "Remove")
    {
        people.RemoveAll(GetPredicate(filter, value));

    }
    else
    {

        List<string> peopleToDouble = people.FindAll(GetPredicate(filter, value));

        foreach (var item in peopleToDouble)
        {
            int index = people.FindIndex(p => p == item);
            people.Insert(index, item);
        }
    }

}

if (people.Any())
{
    Console.WriteLine($"{string.Join(" ", people)} are going to the party!");
}
else
{
    Console.WriteLine("Nobody is going to the party!");
}

    static Predicate<string> GetPredicate(string filter, string value)
    {
        switch (filter)
        {
            case "StartsWith":
                return s => s.StartsWith(value);
            case "EndWith":
                return s => s.StartsWith(value);
            case "Length":
                return s => s.Length == int.Parse(value);
            default:
                return default;
        }
    }