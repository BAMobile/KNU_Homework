namespace ConsoleApp1;

	public abstract class Geographical_object
	{
		public string X { get; }
		public string Y { get; }
		public string Name { get; }
		public string Description { get; }
		public abstract string ObjectType { get; }

		public Geographical_object(string x, string y, string name, string desc)
		{
			X = x;
			Y = y;
			Name = name;
			Description = desc;
		}

		public virtual void GetInfo()
		{
			Console.WriteLine($"Географічний об'єкт: {ObjectType}");
			Console.WriteLine($"Координата Х: {X}");
			Console.WriteLine($"Координата У: {Y}");
			Console.WriteLine($"Назва: {Name}");
			Console.WriteLine($"Опис: {Description}");
		}
	}

	public class River : Geographical_object
	{
		private decimal _flow_rate;
		private decimal _total_length;
		public override string ObjectType => @"Річка";

		public River(string x, string y, string name, string desc, decimal flowRate, decimal totalLength) : base(x, y, name, desc)
		{
			_flow_rate = flowRate;
			_total_length = totalLength;
		}

		public override void GetInfo()
		{
			base.GetInfo();

			Console.WriteLine($"Швидкість течії (см/с): {_flow_rate} ");
			Console.WriteLine($"Загальна довжина: {_total_length} км");
			Console.WriteLine();
		}

	}

	public class Mountain : Geographical_object
	{
		public decimal Peak { get; }
		public override string ObjectType => @"Гора";
		public Mountain(string x, string y, string name, string desc, decimal peak) : base(x, y, name, desc)
		{
			Peak = peak;
		}
		public override void GetInfo()
		{
			base.GetInfo();

			Console.WriteLine($"Найвища точка: {Peak} метрів");
			Console.WriteLine();
		}
	}
