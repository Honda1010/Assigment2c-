
using System.Buffers.Text;
using System.ComponentModel;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ass6Course
{
	internal class Program
	{
		#region Question1
		// Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.
		// Answer:
		// Passing by value means that a copy of the variable is passed to the method.
		// Changes made to the parameter inside the method do not affect the original variable.
		// Passing by reference means that a reference to the original variable is passed to the method.
		// Changes made to the parameter inside the method will affect the original variable.
		// Example:
		static void swapbyvalue(int a, int b)
		{
			int temp = a;
			a = b;
			b = temp;
		}
		static void swapbyreference(ref int a, ref int b)
		{
			int temp = a;
			a = b;
			b = temp;
		}
		#endregion
		#region Question2
		//Explain the difference between passing (Reference typeparameters) by value and by reference then write a suitable c# example.
		// Answer:
		// Passing reference type parameters by value means that a copy of the reference is passed to the method.
		// Changes made to the object inside the method will affect the original object, but reassigning the reference will not affect the original reference.
		// Passing reference type parameters by reference means that a reference to the original object is passed to the method.
		// Changes made to the object inside the method will affect the original object, and reassigning the reference will also affect the original reference.
		// Example:
		static int SumOfArrayByValue(int[] arr)
		{
			int total = 0;
			arr[0]= 100;
			foreach (int num in arr)
			{
				total += num;
			}
			return total;
		}
		static int SumOfArrayByReference(ref int[] arr)
		{
			int total = 0;
			arr[0] = 100; // This will change the original array
			foreach (int num in arr)
			{
				total += num;
			}
			return total;
		}
		#endregion
		#region Question3
		//Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers
		static void Calculate(int a, int b, out int sum, out int subtract)
		{
			sum = a + b;
			subtract = a - b;
		}
		#endregion
		#region Question4
		//Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
		static int SumOfDigits(int number)
		{
			int sum = 0;
			while (number > 0)
			{
				sum += number % 10;
				number /= 10;
			}
			return sum;
		}
		#endregion
		#region Question5
		//Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:
		static bool IsPrime(int number)
		{
			if (number <= 1) return false;
			for (int i = 2; i*i <= number; i++)
			{
				if (number % i == 0) return false;
			}
			return true;
		}
		#endregion
		#region Question6
		//Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters
		static void MinMaxArray(int[] arr, out int min, out int max)
		{
			if (arr == null || arr.Length == 0)
			{
				min = 0;
				max = 0;
				return;
			}
			min = arr[0];
			max = arr[0];
			foreach (int num in arr)
			{
				if (num < min) min = num;
				if (num > max) max = num;
			}
		}
		#endregion
		#region Question 7
		//Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter
		static long Factorial(int number)
		{
			long result = 1;
			for (int i = 2; i <= number; i++)
			{
				result *= i;
			}
			return result;
		}
		#endregion
		#region Question 8
		//Create a function named "ChangeChar" to modify a letter in a certain position(0 based) of a string, replacing it with a different letter
		static string ChangeChar(string input, int position, char newChar)
		{
			char[] result = input.ToCharArray();
			result[position] = newChar;
			return new string(result);
		}
		#endregion

		static void Main(string[] args)
		{
			#region TestQ3
			int sum, subtract;
			Calculate(10, 5, out sum, out subtract);
			Console.WriteLine($"Sum: {sum}, Subtract: {subtract}");
			#endregion
			#region TestQ4
			int number = 12345;
			int digitSum = SumOfDigits(number);
			Console.WriteLine($"Sum of digits in {number} is {digitSum}");
			#endregion
			#region TestQ5
			Console.WriteLine("Is 29 prime? " + IsPrime(29));
			Console.WriteLine("Is 30 prime? " + IsPrime(30));
			#endregion
			#region TestQ6
			int min, max;
			int[] arr = { 3, 5, 1, 8, 2 };
			MinMaxArray(arr,out min, out max);
			Console.WriteLine($"Minimum: {min}, Maximum: {max}");
			#endregion
			#region TestQ7
			int Number = 5;
			long Result = Factorial(Number);
			Console.WriteLine($"Factorial of {Number} is {Result}");
			#endregion
			#region TestQ8
			string original = "mohannad mohammed";
			int position = 0;
			char newChar = 'M';
			string modified = ChangeChar(original, position, newChar);
			Console.WriteLine($"Original: {original}, Modified: {modified}");
			#endregion


		}
	}
}
