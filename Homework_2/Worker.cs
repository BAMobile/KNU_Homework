using System.ComponentModel;

namespace Homework_2;
public abstract class Worker
{
    public string Name { get; }
    public string Position { get; protected set; }
    public List<string> WorkDay { get; private set; }
    protected Worker(string name)
    {
        Name = name;
        WorkDay = new List<string>();
    }

    protected void Call()
    {
        WorkDay.Add("Call");
        
    }

    protected void WriteCode()
    {
        WorkDay.Add("WriteCode");
    }

    protected void Relax()
    {
        WorkDay.Add("Relax");
    }
    public abstract void FillWorkDay();
}

public class Developer : Worker
{
    private Random rand = new Random();
    public Developer(string name) : base(name)
    {
        Position = "Розробник";
        FillWorkDay();
    }
/*перевизначення метода FillWorkDay(), в якому послідовно викликаються методи:
WriteCode() викликається рандомну кількість разів (від 1 до 3),
Call(),
Relax(),
WriteCode() викликається рандомну кількість разів (від 2 до 5).
*/
    public override void FillWorkDay()
    {
        for(int i=1;i<=rand.Next(1, 3);i++)
            WriteCode();
        Call();
        Relax();        
        for (int i = 1; i <= rand.Next(2, 5); i++)
            WriteCode();
    }
}

public class Manager : Worker
{
    // помилка в задачі, очкільки змінна не використовується - її видаляємо
    private Random rand = new Random();

    public Manager(string name) : base(name)
    {
        Position = "Менеджер";
        FillWorkDay();
    }

    public override void FillWorkDay()
    {
        Call();
        Relax();
        for (int i = 1; i <= 3; i++)
        {
            Call();
        }
    }
}

public class Team
{
    private List<Worker> _coworkers = new List<Worker>();
    private string _name;
    public Team(string name)
    {
        _name = name;
    }

    public void AddNewCoworker(Worker worker)
    {
        _coworkers.Add(worker);
    }

    public void ShowInfo()
    {
        
        Console.WriteLine($"Group name: {_name}");
        if (_coworkers.Count > 0)
        {
            Console.WriteLine("Workers:");
            foreach (var worker in _coworkers) Console.WriteLine(worker.Name);
        }
        else
        {
            Console.WriteLine("Workers are absent");
        }
        // можна без порожнього рядка
        Console.WriteLine();
    }

    public void ShowDetailedInfo()
    {
        // TODO - майже 100% дублювання кода з методом ShowInfo
        // варто створити загальний приватний метод, а відмінне писати в конкретному методі
        Console.WriteLine($"Group name: {_name}");
        if (_coworkers.Count > 0)
        {
            Console.WriteLine("Workers:");
            // у випадку використання методів для string, варто використовувати саме його, а не String (рекомендація останніх років)
            foreach (var worker in _coworkers) Console.WriteLine($"{worker.Name} - {worker.Position} - {string.Join(", ",worker.WorkDay)}" );
        }
        else
        {
            Console.WriteLine("Workers are absent");
        }
        
        // можна без порожнього рядка
        Console.WriteLine();
    }
    
}
