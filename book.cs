namespace Midterm {
	public class Book {
		public string Name {get; private set;}
		public string Year {get; private set;}
		
		public Book(string name, string year) {
			Name = name;
			Year = year;
		}
		
		public void GetInfo() {
			Console.WriteLine("Book '{Name}' published in {Year}");
		}
	}
}