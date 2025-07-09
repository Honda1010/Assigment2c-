namespace Ass5Course
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region Question 19
			/*
			 * Write a program that prints an identity matrix using for loop,
			 * in other words takes a value n from the user and shows the identity table of size n * n
			 */
			//Console.Write("Enter the size of the identity matrix: ");
			//int n = int.Parse(Console.ReadLine());
			//for (int i = 0; i < n; i++)
			//{
			//	for (int j = 0; j < n; j++)
			//	{
			//		if (i == j)
			//		{
			//			Console.Write("1 ");
			//		}
			//		else
			//		{
			//			Console.Write("0 ");
			//		}
			//	}
			//	Console.WriteLine();
			//}
			#endregion
			#region Question 20
			/*
			 * Write a program in C# Sharp to find the sum of all elements of the array
			 */
			//int n;
			//Console.Write("Enter the number of elements in the array: ");
			//n = int.Parse(Console.ReadLine());
			//int[] numbers = new	int[n];
			//Console.WriteLine($"Enter {n} numbers to store in the array:");
			//for (int i = 0; i < numbers.Length; i++)
			//{
			//	Console.Write($"Enter number {i + 1}: ");
			//	numbers[i] = int.Parse(Console.ReadLine());
			//}
			//int sum = 0;
			//for (int i = 0; i < numbers.Length; i++)
			//{
			//	sum += numbers[i];
			//}
			//Console.WriteLine($"The sum of all elements in the array is: {sum}");
			#endregion
			#region Question 21
			/*
			 * Write a program in C# Sharp to merge two arrays of the same size sorted in ascending orde
			 */
			//int n;
			//Console.Write("Enter the number of elements in the arrays: ");
			//n = int.Parse(Console.ReadLine());
			//int[] array1 = new int[n];
			//int[] array2 = new int[n];
			//int[] NewArray = new int[n * 2];
			//Console.WriteLine($"Enter {n} numbers for the first array:");
			//for (int i = 0; i < array1.Length; i++)
			//{
			//	Console.Write($"Enter number {i + 1}: ");
			//	array1[i] = int.Parse(Console.ReadLine());
			//}
			//Console.WriteLine($"Enter {n} numbers for the second array:");
			//for (int i = 0; i < array2.Length; i++)
			//{
			//	Console.Write($"Enter number {i + 1}: ");
			//	array2[i] = int.Parse(Console.ReadLine());
			//}
			//for (int i = 0; i < n; i++)
			//{
			//	NewArray[i] = array1[i];
			//	NewArray[i + n] = array2[i];
			//}
			//for (int i = 0; i < NewArray.Length - 1; i++)
			//{
			//	for (int j = 0; j < NewArray.Length - i - 1; j++)
			//	{
			//		if (NewArray[j] > NewArray[j + 1])
			//		{
			//			int temp = NewArray[j];
			//			NewArray[j] = NewArray[j + 1];
			//			NewArray[j + 1] = temp;
			//		}
			//	}
			//}
			//Console.WriteLine("Merged and sorted array:");
			//for (int i = 0; i < NewArray.Length; i++)
			//{
			//	Console.Write(NewArray[i] + " ");
			//}

			#endregion
			#region Question 22
			/*
			 * Write a program in C# Sharp to count the frequency of each element of an array
			 */
			//int n;
			//Console.Write("Enter the number of elements in the array: ");
			//n = int.Parse(Console.ReadLine());
			//int[] numbers = new int[n];
			//Console.WriteLine($"Enter {n} numbers to store in the array:");
			//for (int i = 0; i < numbers.Length; i++)
			//{
			//	Console.Write($"Enter number {i + 1}: ");
			//	numbers[i] = int.Parse(Console.ReadLine());
			//}
			//int[] frequency = new int[n];
			//for (int i = 0; i < n; i++)
			//{
			//	frequency[i] = 1; 
			//	for (int j = i + 1; j < n; j++)
			//	{
			//		if (numbers[i] == numbers[j])
			//		{
			//			frequency[i]++;
			//			numbers[j] = 0; 
			//		}
			//	}
			//}
			//Console.WriteLine("Element\tFrequency");
			//for (int i = 0; i < n; i++)
			//{
			//	if (numbers[i] != 0)
			//	{
			//		Console.WriteLine($"{numbers[i]}\t{frequency[i]}");
			//	}
			//}
			#endregion
			#region Question 23
			/*
			 * Write a program in C# Sharp to find maximum and minimum element in an array
			 */
			//int n;
			//Console.Write("Enter the number of elements in the array: ");
			//n = int.Parse(Console.ReadLine());
			//int[] numbers = new int[n];
			//Console.WriteLine($"Enter {n} numbers to store in the array:");
			//for (int i = 0; i < numbers.Length; i++)
			//{
			//	Console.Write($"Enter number {i + 1}: ");
			//	numbers[i] = int.Parse(Console.ReadLine());
			//}
			//int max = numbers[0];
			//int min = numbers[0];
			//for (int i = 1; i < numbers.Length; i++)
			//{
			//	if (numbers[i] > max)
			//	{
			//		max = numbers[i];
			//	}
			//	if (numbers[i] < min)
			//	{
			//		min = numbers[i];
			//	}
			//}
			//Console.WriteLine($"Maximum : {max} Minimum: {min}");
			#endregion
			#region Question 24
			/*
			 * Write a program in C# Sharp to find the second largest element in an array
			 */
			//int n;
			//Console.Write("Enter the number of elements in the array: ");
			//n = int.Parse(Console.ReadLine());
			//int[] numbers = new int[n];
			//Console.WriteLine($"Enter {n} numbers to store in the array:");
			//for (int i = 0; i < numbers.Length; i++)
			//{
			//	Console.Write($"Enter number {i + 1}: ");
			//	numbers[i] = int.Parse(Console.ReadLine());
			//}
			//int max = -1;
			//int secondMax = -1;
			//for (int i = 0; i < numbers.Length; i++)
			//{
			//	if (numbers[i] > max)
			//	{
			//		secondMax = max;
			//		max = numbers[i];
			//	}
			//	else if (numbers[i] > secondMax && numbers[i] < max)
			//	{
			//		secondMax = numbers[i];
			//	}
			//}
			//Console.WriteLine($"The second largest element in the array is: {secondMax}");
			#endregion
			#region Question 25
			//int n;
			//Console.Write("Enter the number of elements in the array: ");
			//n = int.Parse(Console.ReadLine());
			//int[] numbers = new int[n];
			//Console.WriteLine($"Enter {n} numbers to store in the array:");
			//for (int i = 0; i < numbers.Length; i++)
			//{
			//	Console.Write($"Enter number {i + 1}: ");
			//	numbers[i] = int.Parse(Console.ReadLine());
			//}
			//int maxDistance = -1;
			//for (int i = 0; i < numbers.Length; i++)
			//{
			//	for (int j = i + 1; j < numbers.Length; j++)
			//	{
			//		if (numbers[i] == numbers[j])
			//		{
			//			int distance = j - i - 1;
			//			if (distance > maxDistance)
			//			{
			//				maxDistance = distance;
			//			}
			//		}
			//	}
			//}
			//         Console.WriteLine($"Max Distance: {maxDistance}");
			#endregion
			#region Question 26	
			//Console.Write("Enter a list of space separated words: ");
			//string input = Console.ReadLine();
			//string[] words = input.Split(' ');
			//for (int i = words.Length-1; i >=0; i--)
			//{
			//	Console.Write(words[i]+" ");
			//}
			#endregion
			#region Question 27
			/*
			 * Write a program to create two multidimensional arrays of same size.
			 * Accept value from user and store them in first array. Now copy all the elements of first array on second array and print second array
			 */
			//int r, c;
			//Console.Write("Enter the number of rows: ");
			//r = int.Parse(Console.ReadLine());
			//Console.Write("Enter the number of columns: ");
			//c = int.Parse(Console.ReadLine());
			//int[,] firstArray = new int[r, c];
			//int[,] secondArray = new int[r, c];
			//Console.WriteLine($"Enter {r * c} numbers to store in the first array:");
			//for (int i = 0; i < r; i++)
			//{
			//	for (int j = 0; j < c; j++)
			//	{
			//		Console.Write($"Enter number for position [{i},{j}]: ");
			//		firstArray[i, j] = int.Parse(Console.ReadLine());
			//		secondArray[i, j] = firstArray[i, j]; 
			//	}
			//}
			//Console.WriteLine("Second array after copying elements from the first array:");
			//for (int i = 0; i < r; i++)
			//{
			//	for (int j = 0; j < c; j++)
			//	{
			//		Console.Write(secondArray[i, j] + " ");
			//	}
			//	Console.WriteLine();
			//}
			#endregion
			#region Question 28
			/*
			 * Write a Program to Print One Dimensional Array in Reverse Order
			 */
			//Console.Write("Enter the number of elements in the array: ");
			//int n = int.Parse(Console.ReadLine());
			//int[] numbers = new int[n];
			//Console.WriteLine($"Enter {n} numbers to store in the array:");
			//for (int i = 0; i < numbers.Length; i++)
			//{
			//	Console.Write($"Enter number {i + 1}: ");
			//	numbers[i] = int.Parse(Console.ReadLine());
			//}
			//Console.WriteLine("Array in reverse order:");
			//for (int i = numbers.Length - 1; i >= 0; i--)
			//{
			//	Console.Write(numbers[i] + " ");
			//}
			#endregion
		}
	}
}
