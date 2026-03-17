namespace Midterm {
	public class Journal : IMaterial {
		public string Name {get; }
		public int Number {get; private set;}
		
		public Journal(string name, int number) {
			Name = name;
			Number = number;
		}
		
		public void GetInfo() {
			Console.WriteLine($"Journal '{Name}' #{Number}");
		}
	}
}