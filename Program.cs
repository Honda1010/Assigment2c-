using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading;
using static LINQ1.ListGenerator;
namespace LINQ1
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
			//Uses Count to get the number of odd numbers in the array
			int[] Arr2 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
			var results4 = Arr2.Where(n => n % 2 == 1);
			Console.WriteLine(results4.Count());
			//Return a list of customers and how many orders each has
			var results5 = CustomerList.Select(c => new { c.CustomerName, NumberOfOrders = c.Orders.Count() });
			foreach (var item in results5)
			{
				Console.WriteLine(item);
			}
			//Return a list of categories and how many products each has
			var results6 = ProductList.GroupBy(p => p.Category).Select(g => new { Category = g.Key, NumberOfProducts = g.Count() });
			foreach (var item in results6)
			{
				Console.WriteLine(item);
			}
			//Get the total of the numbers in an array.
			int[] Arr3 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
			var results7 = Arr3.Sum();
			Console.WriteLine(results7);
			//9. Get the total units in stock for each product category.
			var results8 = ProductList.GroupBy(p => p.Category).Select(g => new { Category = g.Key, TotalUnitsInStock = g.Sum(p => p.UnitsInStock) });
			foreach (var item in results8)
			{
				Console.WriteLine(item);
			}
			//Get the cheapest price among each category's products
			var result9 = ProductList.GroupBy(p => p.Category).Select(g => new { Category = g.Key, CheapestPrice = g.Min(p => p.UnitPrice) });
			foreach (var item in result9)
			{
				Console.WriteLine(item);
			}
			//Get the products with the cheapest price in each category (Use Let)
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


			//Get the most expensive price among each category's products.
			var result11 = ProductList.GroupBy(p => p.Category).Select(g => new { Category = g.Key, CheapestPrice = g.Max(p => p.UnitPrice) });
			foreach (var item in result11)
			{
				Console.WriteLine(item);
			}
			//Get the products with the most expensive price in each category
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
			//Get the average price of each category's products.
			var result13 = ProductList.GroupBy(p => p.Category).Select(g => new { Category = g.Key, AveragePrice = g.Average(p => p.UnitPrice) });
			foreach (var item in result13)
			{
				Console.WriteLine(item);
			}
			#endregion
			#region LINQ - Ordering Operators

			//Sort a list of products by name
			var result14 = ProductList.OrderBy(p => p.ProductName);
			foreach (var item in result14)
			{
				Console.WriteLine(item);
			}
			//Uses a custom comparer to do a case-insensitive sort of the words in an array.
			String[] Arr4 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
			var result15 = Arr4.OrderBy(s => s, StringComparer.OrdinalIgnoreCase);
			foreach (var item in result15)
			{
				Console.WriteLine(item);
			}
			//Sort a list of products by units in stock from highest to lowest
			var result16 = ProductList.OrderByDescending(p => p.UnitsInStock);
			foreach (var item in result16)
			{
				Console.WriteLine(item);
			}
			//Sort a list of digits, first by length of their name, and then alphabetically by the name itself
			string[] Arr5 = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
			var result17 = Arr5.OrderBy(s => s.Length).ThenBy(s => s);
			foreach (var item in result17)
			{
				Console.WriteLine(item);
			}
			//Sort first by - word length and then by a case -insensitive sort of the words in an array
			var result18 = Arr4.OrderBy(s => s.Length).ThenBy(s => s, StringComparer.OrdinalIgnoreCase);
			foreach (var item in result18)
			{
				Console.WriteLine(item);
			}
			//Sort a list of products, first by category, and then by unit price, from highest to lowest
			var result19 = ProductList.OrderBy(p => p.Category).ThenByDescending(p => p.UnitPrice);
			foreach (var item in result19)
			{
				Console.WriteLine(item);
			}
			//Sort first by - word length and then by a case -insensitive descending sort of the words in an array
			var result20 = Arr4.OrderBy(s => s.Length).ThenByDescending(s => s, StringComparer.OrdinalIgnoreCase);
			foreach (var item in result20)
			{
				Console.WriteLine(item);
			}
			//Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array
			var result21 = Arr5.Where(s => s[1] == 'i').Reverse();
			foreach (var item in result21)
			{
				Console.WriteLine(item);
			}
			#endregion
			#region Transformation Operators
			//Return a sequence of just the names of a list of products
			var result22 = ProductList.Select(p =>p.ProductName);
			foreach (var item in result22)
			{
				Console.WriteLine(item);
			}
			// Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).
			String[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
			var result23 = words.Select(s=> new {Lower=s.ToLower(),Upper=s.ToUpper() });
			foreach (var item in result23)
			{
				Console.WriteLine(item);
			}
			//Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type
			var result24 = ProductList.Select(p => new { p.ProductName, p.Category, Price = p.UnitPrice });
			foreach (var item in result24)
			{
				Console.WriteLine(item);
			}
			//Determine if the value of int in an array matches their position in the array.
			int[] Arr6 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
			var result25 = Arr6.Select((n,i) => n==i);
			Console.WriteLine("Number : in-place?");
			for (int i = 0; i <Arr6.Length ; i++)
			{
				Console.WriteLine($"{Arr6[i]} : {result25.ElementAt(i)}");
			}
			//Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB
			int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
			int[] numbersB = { 1, 3, 5, 7, 8 };
			var result26 = from a in numbersA
						   from b in numbersB
						   where a < b
						   select new { a, b };
			Console.WriteLine("pair where a < b");
			foreach (var item in result26)
			{
				Console.WriteLine($"{item.a} is less than {item.b}");
			}
			#endregion

		}
	}
}
