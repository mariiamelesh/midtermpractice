namespace Midterm {
	public class Video : IMaterial {
		public string Name {get; }
		public string Duration {get; private set;}
		
		public Video(string name, string duration) {
			Name = name;
			Duration = duration;
		}
		
		public void GetInfo() {
			Console.WriteLine($"Video '{Name}', duration is {Duration}");
		}
	}
}