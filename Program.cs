using System.Collections;
using OOPAdv2.Question3;
namespace OOPAdv2
{
	internal class Program
	{
		#region Question1
		/*
		 * You are given an ArrayList containing a sequence of elements.
		 * try to reverse the order of elements in the ArrayList in-place(in the same arrayList) without using the built-in Reverse.
		 * Implement a function that takes the ArrayList as input and modifies it to have the reversed order of elements.
		 */
		public static ArrayList ReverseArray(ArrayList list)
		{
			ArrayList reversedList = new ArrayList();
			for (int i = list.Count - 1; i >= 0; i--)
			{
				reversedList.Add(list[i]);
			}
			return reversedList;
		}
		#endregion
		#region Question2
		/*
		 * You are given a list of integers.
		 * Your task is to find and return a new list containing only the even numbers from the given list.
		 */
		public static List<int> EvenList(List<int>list) {
			List<int> evenList = new List<int>();
			foreach (int number in list)
			{
				if (number % 2 == 0)
				{
					evenList.Add(number);
				}
			}
			return evenList;
		}
		#endregion
		#region Question4
		/*
		 * Given an array  consists of  numbers with size N and number of queries,
		 * in each query you will be given an integer X,
		 * \and you should print how many numbers in array that is greater than  X.
		 */
		public static int NumberofItemsGreaterThan(List<int> list, int value)
		{
			int count = 0;
			foreach (int number in list)
			{
				if (number > value)
				{
					count++;
				}
			}
			return count;
		}
		#endregion
		#region Question5
		/*
		 * Given a number N and an array of N numbers. Determine if it's palindrome or not
		 */
		public static bool IsPalindrome(int[] arr)
		{
			int left = 0;
			int right = arr.Length - 1;

			while (left < right)
			{
				if (arr[left] != arr[right])
				{
					return false;
				}
				left++;
				right--;
			}
			return true;
		}
		#endregion
		#region Question6
		/*
		 * Given an array, implement a function to remove duplicate elements from an array
		 */
		public static int[] RemoveDuplicates(int[] arr)
		{
			List<int> uniqueList = new List<int>();
			foreach (int number in arr)
			{
				if (!uniqueList.Contains(number))
				{
					uniqueList.Add(number);
				}
			}
			return uniqueList.ToArray();
		}
		#endregion
		#region Question7
		/*
		 * Given an array list , implement a function to remove all odd numbers from it.
		 */
		public static ArrayList RemoveOddNumbers(ArrayList list)
		{
			ArrayList evenList = new ArrayList();
			foreach (int number in list)
			{
				if (number % 2 == 0)
				{
					evenList.Add(number);
				}
			}
			return evenList;
		}
		#endregion

		static void Main(string[] args)
		{
			#region TestQuestion1
			ArrayList myList = new ArrayList() { 1, 2, 3, 4, 5 };
			Console.WriteLine("Original ArrayList: ");
			for (int i = 0; i < myList.Count; i++)
			{
				Console.Write(myList[i] + " ");
			}
			Console.WriteLine();
			ArrayList reversedList = ReverseArray(myList);
			Console.WriteLine("Reversed ArrayList: ");
			for (int i = 0; i < myList.Count; i++)
			{
				Console.Write(reversedList[i] + " ");
			}
			#endregion
			#region TestQuestion2
			List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
			Console.WriteLine("\nOriginal List: ");
			foreach (int number in numbers)
			{
				Console.Write(number + " ");
			}
			List<int> evenNumbers = EvenList(numbers);
			Console.WriteLine("\nEven Numbers List: ");
			foreach (int evenNumber in evenNumbers)
			{
				Console.Write(evenNumber + " ");
			}
			#endregion
			#region TestQuestion3
			FixedSizeList<int> fixedSizeList = new FixedSizeList<int>(5);
			fixedSizeList.Add(1);
			fixedSizeList.Add(2);
			fixedSizeList.Add(3);
			fixedSizeList.Add(4);
			fixedSizeList.Add(5);
			try
			{
				fixedSizeList.Add(6);
			}
			catch (InvalidOperationException ex)
			{
				Console.WriteLine("\nException: " + ex.Message);
			}
			Console.WriteLine("\nFixed Size List Items: ");
			for (int i = 0; i < 5; i++)
			{
				Console.Write(fixedSizeList.Get(i) + " ");
			}
            Console.WriteLine();
			try
			{
				Console.WriteLine("\nItem at index 5: " + fixedSizeList.Get(5));
			}
			catch (ArgumentOutOfRangeException ex)
			{
				Console.WriteLine("Exception: " + ex.Message);
			}
			try
			{
				Console.WriteLine("Item at index -1: " + fixedSizeList.Get(-1));
			}
			catch (ArgumentOutOfRangeException ex)
			{
				Console.WriteLine("Exception: " + ex.Message);
			}

			#endregion
			#region TestQuestion4
			int n, q;
			n = Convert.ToInt32(Console.ReadLine());
			q = Convert.ToInt32(Console.ReadLine());
			List<int> list = new List<int>(n);
			for (int i = 0; i < n; i++)
			{
				list.Add(Convert.ToInt32(Console.ReadLine()));
			}
			while (q != 0)
			{
				int value = Convert.ToInt32(Console.ReadLine());
				int count = NumberofItemsGreaterThan(list, value);
				Console.WriteLine($"Number of items greater than {value}: {count}");
				q--;
			}
			#endregion
			#region TestQuestion5
			//Given a number N and an array of N numbers. Determine if it's palindrome or not
			int size;
			size = Convert.ToInt32(Console.ReadLine());
			int[] arr = new int[size];
			for (int i = 0; i < size; i++)
			{
				arr[i] = Convert.ToInt32(Console.ReadLine());
			}
			bool isPalindrome = IsPalindrome(arr);
			if (isPalindrome)
			{
				Console.WriteLine("The array is a palindrome.");
			}
			else
			{
				Console.WriteLine("The array is not a palindrome.");
			}
			#endregion
			#region TestQuestion6
			int[] inputArray = { 1, 2, 3, 2, 4, 5, 1, 6 };
			Console.WriteLine("\nOriginal Array: ");
			foreach (int number in inputArray)
			{
				Console.Write(number + " ");
			}
			int[] uniqueArray = RemoveDuplicates(inputArray);
			Console.WriteLine("\nArray after removing duplicates: ");
			foreach (int number in uniqueArray)
			{
				Console.Write(number + " ");
			}
			#endregion
			#region TestQuestion7
			ArrayList oddList = new ArrayList() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
			Console.WriteLine("\nOriginal ArrayList: ");
			for (int i = 0; i < oddList.Count; i++)
			{
				Console.Write(oddList[i] + " ");
			}
			ArrayList evenList = RemoveOddNumbers(oddList);
			Console.WriteLine("\nArrayList after removing odd numbers: ");
			for (int i = 0; i < evenList.Count; i++)
			{
				Console.Write(evenList[i] + " ");
			}
			#endregion

		}
	}
}
