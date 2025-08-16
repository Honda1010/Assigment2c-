using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPPAdv4.Part1
{
	public class Book
	{
		public string ISBN { get; set; }
		public string Title { get; set; }
		public string[] Author { get; set; }
		public DateTime PublishedDate { get; set; }
		public Decimal Price { get; set; }
        public Book(string _ISBN,string _Title, string[] _Author,DateTime _PublishedDate,Decimal _Price)
        {
			ISBN = _ISBN;
			Title = _Title;
			Author = _Author;
			PublishedDate = _PublishedDate;
			Price = _Price;
		}
		public override string ToString()
		{
			return $"{ISBN} - {Title} - {string.Join(", ", Author)} - {PublishedDate.ToShortDateString()} - {Price:C}";
		}
	}
}
