LimitedList list = new((s) => !s.StartsWith("s"));

list.TryAdd("splendorous");
list.TryAdd("distinguished");
list.TryAdd("distinguished");
list.TryAdd("splendorous");
list.TryAdd("distinguished");
list.TryAdd("distinguished");
list.TryAdd("distinguished");
list.TryAdd("splendorous");
list.TryAdd("distinguished");
list.TryAdd("distinguished");

list.PrintAll();
class LimitedList
{
    List<string> _list = new();
    Func<string, bool> _check;
    public event Func<string, string> ListItemAdded; 

    public LimitedList(Func<string, bool> predicate)
    {
        _check = predicate;
        ListItemAdded += PrintChange;
    }

    public bool TryAdd(string value)
    {
        if (!_check.Invoke(value))
            return false;

        _list.Add(value);
        ListItemAdded?.Invoke(value);
        return true;
    }

    public void PrintAll()
    {
        foreach (var item in _list)
        {
            Console.WriteLine(item);
        }
    }

    public string PrintChange(string item)
    {
        Console.WriteLine($"{item} was added");
        return item;
    }
}