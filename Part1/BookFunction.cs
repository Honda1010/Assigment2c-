using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPPAdv4.Part1
{
	public class BookFunction
	{
		public static string GetTitle(Book book)
		{
			return book.Title;
		}
		public static string GetAuthor(Book book)
		{
			return string.Join(", ", book?.Author);
		}
		public static string GetPrice(Book book)
		{
			return book.Price.ToString("C");
		}
	}
}
