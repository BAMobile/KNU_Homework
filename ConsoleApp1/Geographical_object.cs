namespace ConsoleApp1;

public interface IGeographical_object
{
    string X { get; }
    string Y { get; }
    string Name { get; }
    string Desc { get; }
    void GetInfo();
}

public class River : IGeographical_object
{
    private string _x = "";
    private string _y = "";
    private string _name = "";
    private string _desc = "";
    private decimal _flow_rate;
    private decimal _total_length;

    public string x
    {
        get { return _x; }
        set { _x = value; }
    }

    public string y
    {
        get { return _y; }
        set { _y = value; }
    }

    public string desc
    {
        get { return _desc; }
        set { _desc = value; }
    }

    public string name
    {
        get { return _name; }
        set { _name = value; }
    }

    public River(string x, string y, string name, string desc, decimal flowRate, decimal totalLength)
    {
        this.x = x;
        this.y = y;
        this.name = name;
        this.desc = desc;
        _flow_rate = flowRate;
        _total_length = totalLength;
    }

    public void GetInfo()
    {
        Console.WriteLine("Географічний об'єкт: Річка");
        Console.WriteLine($"Координата Х: {x}");
        Console.WriteLine($"Координата У: {y} ");
        Console.WriteLine($"Назва: {name}");
        Console.WriteLine($"Опис: {desc}");

        Console.WriteLine($"Швидкість течії (см/с): {_flow_rate} ");
        Console.WriteLine($"Загальна довжина: {_total_length} км");
        Console.WriteLine("");
    }
}

public class Mountain : IGeographical_object
{
    private string _x = "";
    private string _y = "";
    private string _name = "";
    private string _desc = "";
    public decimal _peak;

    public string x
    {
        get { return _x; }
        set { _x = value; }
    }

    public string y
    {
        get { return _y; }
        set { _y = value; }
    }

    public string desc
    {
        get { return _desc; }
        set { _desc = value; }
    }

    public string name
    {
        get { return _name; }
        set { _name = value; }
    }

    public Mountain(string x, string y, string name, string desc, decimal peak)
    {
        this.x = x;
        this.y = y;
        this.name = name;
        this.desc = desc;
        _peak = peak;
    }

    public void GetInfo()
    {
        Console.WriteLine("Географічний об'єкт: Гора");
        Console.WriteLine($"Координата Х: {x}");
        Console.WriteLine($"Координата У: {y} ");
        Console.WriteLine($"Назва: {name}");
        Console.WriteLine($"Опис: {desc}");

        Console.WriteLine($"Найвища точка: {_peak} метрів");
        Console.WriteLine("");
    }
}
