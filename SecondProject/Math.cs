using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppAss2.SecondProject
{
	internal class Math
	{
		//Define Class Maths that has four methods: Add, Subtract, Multiply, and Divide, each of them takes two parameters
		public static int Add(int a, int b)
		{
			return a + b;
		}
		public static int Subtract(int a, int b)
		{
			return a - b;
		}
		public static int Multiply(int a, int b)
		{
			return a * b;
		}
		public static double Divide(int a, int b)
		{
			if (b == 0)
			{
				throw new DivideByZeroException("Cannot divide by zero.");
			}
			return (double)a / b;
		}
	}
}
