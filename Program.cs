using OppAss2.FirstProject;
using OppAss2.ThirdProject;
using Math = OppAss2.SecondProject.Math;
namespace OppAss2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region ContinueFisrtProjectRequirment
			#region 3rdRequirment
			//Read from the User the Coordinates for 2 points P1, P2 (Check the input using tryPares, Parse, Convert).
			Console.WriteLine("Enter the coordinates for Point 1 (X Y Z): ");
			string input = Console.ReadLine();
			string[] coordinates1 = input.Split(' ');
			_3DPoint p1 = new _3DPoint() {
				X = int.TryParse(coordinates1[0], out int x1) ? x1 : 0,
				Y = int.TryParse(coordinates1[1], out int y1) ? y1 : 0,
				Z = coordinates1.Length > 2 && int.TryParse(coordinates1[2], out int z1) ? z1 : 0
			};
			Console.WriteLine("Enter the coordinates for Point 2 (X Y Z): ");
			input = Console.ReadLine();
			string[] coordinates2 = input.Split(' ');
			_3DPoint p2 = new _3DPoint()
			{
				X = int.TryParse(coordinates2[0], out int x2) ? x2 : 0,
				Y = int.TryParse(coordinates2[1], out int y2) ? y2 : 0,
				Z = coordinates2.Length > 2 && int.TryParse(coordinates2[2], out int z2) ? z2 : 0
			};
            #endregion
            #region 4thRequirment
            Console.WriteLine(p1);
			Console.WriteLine(p2);
			if (p1==p2) {
				Console.WriteLine("The two points are equal.");
			}
			else
			{
				Console.WriteLine("The two points are not equal.");
			}
			// not work properly
			#endregion
			#region 5thRequirment
			//Define an array of points and sort this array based on X & Y coordinates
			_3DPoint[] points = new _3DPoint[] { p1, p2, new _3DPoint(5, 5, 5), new _3DPoint(1, 2, 3) };
			Console.WriteLine("Points before sorting:");
			foreach (var point in points)
			{
				Console.WriteLine(point);
			}
			Array.Sort(points);
			Console.WriteLine("Points after sorting:");
			foreach (var point in points)
			{
				Console.WriteLine(point);
			}
			#endregion
			#endregion
			#region ContinueSecondpProjectRequirment
			//Define Class Maths that has four methods: Add, Subtract, Multiply, and Divide, each of them takes two parameters. Call each method in Main ()
			Console.WriteLine("Enter two numbers for arithmetic operations (A B): ");
			input = Console.ReadLine();
			string[] numbers = input.Split(' ');
			int a = int.TryParse(numbers[0], out int num1) ? num1 : 0;
			int b = int.TryParse(numbers[1], out int num2) ? num2 : 0;
			Console.WriteLine($"Addition: {Math.Add(a, b)}");
			Console.WriteLine($"Subtraction: {Math.Subtract(a, b)}");
			Console.WriteLine($"Multiplication: {Math.Multiply(a, b)}");
			Console.WriteLine($"Division: {Math.Divide(a, b)}");
			#endregion
			#region TestThirdProject
			Duration D1 = new Duration(1, 10, 15);
            Console.WriteLine(D1);
			D1 = new Duration(3600);
            Console.WriteLine(D1);
			Duration D2 = new Duration(7800);
            Console.WriteLine(D2);
			Duration D3 = new Duration(666);
            Console.WriteLine(D3);
			D3 = D1 + D2;
			Console.WriteLine($"D1 + D2 = {D3}");
			D3 = D1 + 7800;
			Console.WriteLine($"D1 + 7800 = {D3}");
			D3 = D3+666;
			Console.WriteLine($"D1 + 666 = {D3}");
			D3 = ++D1;
            Console.WriteLine(D3);
			D3 = --D2;
			Console.WriteLine(D3);
			D3 = D1 - D2;
			Console.WriteLine($"D1 - D2 = {D3}");
			if (D1>D2)
			{
                Console.WriteLine("> Work Properly");
			}
			if (D1 <= D2)
			{
				Console.WriteLine("< Work Properly");
			}
			if (D1)
			{
				Console.WriteLine("implicit casting Work Properly");
			}
			DateTime Obj = (DateTime)D1;
			Console.WriteLine($"D1 as DateTime: {Obj}");
			#endregion

		}
	}
}
