using OPPAdv4.Part1;

namespace OPPAdv4
{
	#region Part2
	public delegate string BookDelegate(Book book);
	public class LibraryEngine
	{
		public static void ProcessBook(List<Book> bList, BookDelegate fptr)
		{
			foreach (Book b in bList)
			{
				Console.WriteLine(fptr(b));
			}
		}
	}
	#endregion

	internal class Program
	{
		static void Main(string[] args)
		{
			#region TesTPart2
				List<Book> books = new List<Book>
				{
					new Book("1", "C# Programming", new[] { "mohannad" }, new DateTime(2020, 1, 1), 29.99m),
					new Book("2", "Learning OOP", new[] { "mohammed" }, new DateTime(2021, 5, 15), 39.99m),
					new Book("3", "Advanced C#", new[] { "mostafa" }, new DateTime(2022, 3, 10), 49.99m)
				};
			LibraryEngine.ProcessBook(books, BookFunction.GetTitle);
			LibraryEngine.ProcessBook(books, BookFunction.GetAuthor);
			LibraryEngine.ProcessBook(books, BookFunction.GetPrice);
			LibraryEngine.ProcessBook(books, delegate (Book b) { return b.ISBN; });
			LibraryEngine.ProcessBook(books,  b=> b.PublishedDate.ToString());
			#endregion
		}
	}
}
