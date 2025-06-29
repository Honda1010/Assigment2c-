using System.ComponentModel;
using System.Runtime.InteropServices;

namespace assigment1course
{
	class point {
		int x;
		int y;
		public point(int x, int y)
		{
			this.x = x;
			this.y = y;
		}
		public int X { set; get; }
		public int Y { set; get; }
	}
	internal class Program
	{

		static void Main(string[] args)
		{
			#region Question1
			//Write a program that allows the user to enter a number then print it
			int number;
			Console.Write("Enter a number: ");
			number = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine(number);
			#endregion
			#region Question2
			//Write C# program that converts a string to an integer,
			//but the string contains non-numeric characters. And mention what will happen
			string str = "123abc";
			Console.WriteLine(Convert.ToInt32(str));
			// this code will throw formate exception
			#endregion
			#region Question3
			//Write C# program that Perform a simple 
			//arithmetic operation with floating-point numbers And mention what will happen
			float num1 = 5.5f;
			float num2 = 2.2f;
			float result = num1 / num2;
			Console.WriteLine($"The result of {num1} / {num2} is: {result}");
			// this code will work fine and print the result of the division
			#endregion
			#region Question4
			//Write C# program that Extract a substring from a given string
			string str1 = "mohaned mohamed";
			string substr = str1.Substring(0, 7);
			string substr2 = str1.Substring(8, 7);
			Console.WriteLine(substr);
			Console.WriteLine(substr2);
			#endregion
			#region Question5
			//Write C# program that Assigning one value type variable to another 
			//and modifying the value of one variable and mention what will happen
			int a = 10;
			int b = 5;
			b = a; // b now holds the value of a
			a = 20; // changing a does not affect b
			Console.WriteLine($"a: {a}, b: {b}"); // Output will be a: 20, b: 10
			#endregion
			#region Question6
			//Write C# program that Assigning one reference type variable to another and 
			//modifying the object through one variable and mention what will happen
			point p1 = new point(10, 20);
			point p2 = p1; // p2 now references the same object as p1
			p1.X = 30; // changing p1 will affect p2 since they reference the same object
			Console.WriteLine($"p1: ({p1.X}, {p1.Y}), p2: ({p2.X}, {p2.Y})"); // Output will be p1: (30, 20), p2: (30, 20) same values
			#endregion
			#region Question7
			//Write C# program that take two string variables and print them as one variable
			string str4 = "mohaned";
			string str2 = "mohamed";
			string str3 = str4 + " " + str2;
			//Console.WriteLine(str3);
			#endregion
			#region Question8
			//int d;
			//d = Convert.ToInt32(!(30 < 20)); // A value 1 will be assigned to d, because !(30 < 20) is true, and true is converted to 1
			//conclusion : choice b is the correct answer
			#endregion
			#region Question9
			//Console.WriteLine(13 / 2 + " " + 13 % 2);
			// This will print "6 1" because 13 divided by 2 is 6 and 13 % 2 is 1.
			// conclusion : choice d is the correct answer
			#endregion
			#region Question10
			//int num = 1, z = 5;
			//if (!(num <= 0))
			//	Console.WriteLine(++num + z++ + " " + ++z);
			//else
			//	Console.WriteLine(--num + z-- + " " + --z);
			// This will print "7 7" because num is incremented before being added to z, and z is incremented after being added to the result (so after this z will be 6) after that z is incremented before print so it will be also 7 .
			// conclusion : choice d is the correct answer
			#endregion

		}
	}
}
