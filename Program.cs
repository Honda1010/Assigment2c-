using System;
using System.Runtime.Intrinsics.X86;
using static LINQ2.ListGenerator;
using static System.Net.Mime.MediaTypeNames;
namespace LINQ2
{
    internal class Program
    {
        static void Main(string[] args)
        {
			#region LINQ - Element Operators
			//Get first Product out of Stock
			var results = ProductList.Where(p => p.UnitsInStock == 0).First();
			Console.WriteLine(results);
			//Return the first product whose Price > 1000, unless there is no match, in which case null is returned
			var results2 = ProductList.Where(p => p.UnitPrice > 1000).FirstOrDefault();
			Console.WriteLine(results2);
			// Retrieve the second number greater than 5
			int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
			var results3 = Arr.Where(n => n > 5).ElementAtOrDefault(1);
			Console.WriteLine(results3);
			#endregion
			#region LINQ - Aggregate Operators
			//1)Uses Count to get the number of odd numbers in the array
			int[] Arr2 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
			var results4 = Arr2.Where(n => n % 2 == 1);
			Console.WriteLine(results4.Count());
			//2)Return a list of customers and how many orders each has
			var results5 = CustomerList.Select(c => new { c.CustomerName, NumberOfOrders = c.Orders.Count() });
			foreach (var item in results5)
			{
				Console.WriteLine(item);
			}
			//3)Return a list of categories and how many products each has
			var results6 = ProductList.GroupBy(p => p.Category).Select(g => new { Category = g.Key, NumberOfProducts = g.Count() });
			foreach (var item in results6)
			{
				Console.WriteLine(item);
			}
			//4)Get the total of the numbers in an array.
			int[] Arr3 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
			var results7 = Arr3.Sum();
			Console.WriteLine(results7);
			//5) Get the total number of characters of all words in dictionary_english.txt (Read dictionary_english.txt into Array of String First)
			string[] words = System.IO.File.ReadAllLines("dictionary_english.txt");
			var totalCharacters = words.Sum(w => w.Length);
			Console.WriteLine(totalCharacters);
			// 6) Get the length of the shortest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
			var shortestWordLength = words.Min(w => w.Length);
			Console.WriteLine(shortestWordLength);
			// 7) Get the length of the longest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
			var longestWordLength = words.Max(w => w.Length);
			Console.WriteLine(longestWordLength);
			// 8) Get the average word length of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
			var averageWordLength = words.Average(w => w.Length);
			Console.WriteLine(averageWordLength);
			//9. Get the total units in stock for each product category.
			var results8 = ProductList.GroupBy(p => p.Category).Select(g => new { Category = g.Key, TotalUnitsInStock = g.Sum(p => p.UnitsInStock) });
			foreach (var item in results8)
			{
				Console.WriteLine(item);
			}
			//10) Get the cheapest price among each category's products
			var result9 = ProductList.GroupBy(p => p.Category).Select(g => new { Category = g.Key, CheapestPrice = g.Min(p => p.UnitPrice) });
			foreach (var item in result9)
			{
				Console.WriteLine(item);
			}
			//11) Get the products with the cheapest price in each category (Use Let)
			var result10 = ProductList.GroupBy(p => p.Category)
			.SelectMany(group =>
			{
				var cheapestPrice = group.Min(p => p.UnitPrice);
				return group.Where(p => p.UnitPrice == cheapestPrice)
							.Select(p => new { Category = group.Key, Product = p });
			});
			foreach (var item in result10)
			{
				Console.WriteLine(item);
			}


			//12) Get the most expensive price among each category's products.
			var result11 = ProductList.GroupBy(p => p.Category).Select(g => new { Category = g.Key, CheapestPrice = g.Max(p => p.UnitPrice) });
			foreach (var item in result11)
			{
				Console.WriteLine(item);
			}
			//13) Get the products with the most expensive price in each category
			var result12 = ProductList.GroupBy(p => p.Category).SelectMany(group =>
			{
				var cheapestPrice = group.Min(p => p.UnitPrice);
				return group.Where(p => p.UnitPrice == cheapestPrice)
							.Select(p => new { Category = group.Key, Product = p });
			});
			foreach (var item in result12)
			{
				Console.WriteLine(item);
			}
			//14) Get the average price of each category's products.
			var result13 = ProductList.GroupBy(p => p.Category).Select(g => new { Category = g.Key, AveragePrice = g.Average(p => p.UnitPrice) });
			foreach (var item in result13)
			{
				Console.WriteLine(item);
			}
			#endregion
			#region Set Operators
			//1) Find the unique Category names from Product List
			var result14 = ProductList.Select(p => p.Category).Distinct();
			foreach (var item in result14)
			{
				Console.WriteLine(item);
			}
			//2) Produce a Sequence containing the unique first letter from both product and customer names
			var productFirstLetters = ProductList.Select(p => p.ProductName[0]);
			var customerFirstLetters = CustomerList.Select(c => c.CustomerName[0]);
			var result15 = productFirstLetters.Union(customerFirstLetters);
			foreach (var item in result15)
			{
				Console.WriteLine(item);
			}
			//3)Create one sequence that contains the common first letter from both product and customer names
			var result16 = productFirstLetters.Intersect(customerFirstLetters);
			foreach (var item in result16)
			{
				Console.WriteLine(item);
			}
			//4)Create one sequence that contains the first letters of product names that are not also first letters of customer names
			var result17 = productFirstLetters.Except(customerFirstLetters);
			foreach (var item in result17)
			{
				Console.WriteLine(item);
			}
			//5)Create one sequence that contains the last Three Characters in each name of all customers and products, including any duplicates
			var productLastThreeChars = ProductList.Select(p => p.ProductName[^3..]);
			var customerLastThreeChars = CustomerList.Select(c => c.CustomerName[^3..]);
			var result18 = productLastThreeChars.Concat(customerLastThreeChars);
			foreach (var item in result18)
			{
				Console.WriteLine(item);
			}

			#endregion
			#region LINQ - Quantifiers
			// 1) Determine if any of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First) contain the substring 'ei'
			var result19 = words.Any(w => w.Contains("ei"));
			Console.WriteLine(result19);
			// 2)Return a grouped a list of products only for categories that have at least one product that is out of stock.
			var result20 = ProductList.GroupBy(p => p.Category).Where(g => g.Any(p => p.UnitsInStock >= 1));
			foreach (var group in result20)
			{
				Console.WriteLine($"Category: {group.Key}");
				foreach (var product in group)
				{
					Console.WriteLine($"{product}");
				}
			}
			Console.WriteLine("----------------------------------------------");
			//3)  Return a grouped a list of products only for categories that have all of their products in stock
			var result21 = ProductList.GroupBy(p => p.Category).Where(g => g.All(p => p.UnitsInStock >= 1));
			foreach (var group in result21)
			{
				Console.WriteLine($"Category: {group.Key}");
				foreach (var product in group)
				{
					Console.WriteLine($"{product}");
				}
			}
			#endregion
			#region Grouping Operators
			//1) Use group by to partition a list of numbers by their remainder when divided by 5
			int[] arr4 = { 0,1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
			var result22 = arr4.GroupBy(n => n % 5);
			foreach (var group in result22)
			{
				Console.WriteLine($"Numbers with a remainder of {group.Key} when divided by 5:");
				foreach (var number in group)
				{
					Console.WriteLine(number);
				}
			}
			//2)Uses group by to partition a list of words by their first letter.Use dictionary_english.txt for Input
			var result23 = words.GroupBy(w => w[0]);
			foreach (var group in result23)
			{
				Console.WriteLine($"Words that start with the letter '{group.Key}':");
				foreach (var word in group)
				{
					Console.WriteLine(word);
				}
			}
			//3)Use Group By with a custom comparer that matches words that are consists of the same Characters Together
			string[] Arr6 = { "from", "salt", "earn", "last", "near", "form" };

			var result24 = Arr6.GroupBy(word => word,new CustomComparer());

			foreach (var group in result24)
			{
				foreach (var word in group)
				{
					Console.WriteLine(word);
				}
				Console.WriteLine("....");
			}




			#endregion
		}
	}
	class CustomComparer : IEqualityComparer<string>
	{
		public bool Equals(string x, string y)
		{
			return SortString(x) == SortString(y);
		}

		public int GetHashCode(string obj)
		{
			return SortString(obj).GetHashCode();
		}

		private string SortString(string s)
		{
			return new string(s.OrderBy(c => c).ToArray());
		}
	}
}
