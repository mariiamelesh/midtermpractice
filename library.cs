namespace Midterm {
	public class Library {
		private List<Book> allBooks {get; set;}
		
		public void AddBook(Book book) {
			allBooks.Add(book);
		}
		
		public void ShowBooks() {
			foreach (Book book in allBooks) {
				book.GetInfo();
			}
		}
	}
}