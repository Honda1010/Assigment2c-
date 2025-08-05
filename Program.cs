using ADVAss1.Question2;
namespace ADVAss1
{
	internal class Program
	{
		#region Question1
		/*
		 * The Bubble Sort algorithm has a time complexity of O(n^2) in its worst and average cases, which makes it inefficient for large datasets.
		 * How we can optimize the Bubble Sort algorithm And implement the code of this optimized bubble sort algorithm
		 */
		public static void OptimizedBubbleSort(int[] arr)
		{
			int n = arr.Length;
			bool swapped;
			for (int i = 0; i < n - 1; i++)
			{
				swapped = false;
				for (int j = 0; j < n - i - 1; j++)
				{
					if (arr[j] > arr[j + 1])
					{
						int temp = arr[j];
						arr[j] = arr[j + 1];
						arr[j + 1] = temp;
						swapped = true;
					}
				}
				if (!swapped)
					break;
			}
		}
		#endregion
		static void Main(string[] args)
		{
			#region TestQuestion1
			int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
			Console.WriteLine("Original array:");
			Console.WriteLine(string.Join(", ", arr));
			OptimizedBubbleSort(arr);
			Console.WriteLine("Sorted array:");
			Console.WriteLine(string.Join(", ", arr));
			#endregion
			#region TestQuestion2
			Range<int> intRange = new Range<int>(10, 20);
			Console.WriteLine(intRange);
			int valueToCheck=15;
			Console.WriteLine($"Is {valueToCheck} in range? {intRange.IsInRange(valueToCheck)}");
			Console.WriteLine($"Length of range: {intRange.Length()}");
			Range<double> doubleRange = new Range<double>(5.5, 10.5);
			Console.WriteLine(doubleRange);
			double doubleValueToCheck = 7.5;
			Console.WriteLine($"Is {doubleValueToCheck} in range? {doubleRange.IsInRange(doubleValueToCheck)}");
			Console.WriteLine($"Length of range: {doubleRange.Length()}");
			#endregion


		}
	}
}
