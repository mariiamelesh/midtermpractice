namespace Midterm {
	public class Program {
		static void Main(string[] args) {
			Library library = new ();
			Book book1 = new ("361 Degree Farengheit", "1980");
			Book book2 = new ("Кобзар", "1840");
			Journal journal1 = new ("Fashion", 8);
			Journal journal2 = new ("Dota", 1);
			Video video1 = new ("Gay porn", "12:04");
			Video video2 = new ("Porn", "9:34");

			
			book1.GetInfo();
			journal1.GetInfo();
			video1.GetInfo();
			
			library.AddMaterial(book1);
			library.AddMaterial(book1);
			library.AddMaterial(book2);
			library.AddMaterial(journal1);
			library.AddMaterial(journal2);
			library.AddMaterial(video1);
			library.AddMaterial(video2);
			
			library.ShowMaterials();
		}
	}
}