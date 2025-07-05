namespace Ass4Course
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region Question 6
			/*
			 * Write a program that allows the user to insert an integer 
			 * then print all numbers between 1 to that number
			 */
			//Console.Write("Enter an Number (Must be more than 1): ");
			//int number = int.Parse(Console.ReadLine());
			//for (int i = 1; i <= number; i++)
			//{
			//	Console.WriteLine(i);
			//}
			#endregion
			#region Question 7
			/*
			 * Write a program that allows the user to insert an integer 
			 * then print a multiplication table up to 12
			 */
			//Console.Write("Enter an Number (Must be more than 0): ");
			//int number = int.Parse(Console.ReadLine());
			//         for (int i = number; i <= number*12; i+=number)
			//         {
			//             Console.WriteLine(i);
			//         }
			#endregion
			#region Question 8
			/*
			 * Write a program that allows to user to insert number 
			 * then print all even numbers between 1 to this number
			 */
			//Console.Write("Enter an Number (Must be more than 1): ");
			//int number = int.Parse(Console.ReadLine());
			//for (int i = 1; i <= number; i++)
			//{
			//	if (i % 2 == 0)
			//	{
			//		Console.WriteLine(i);
			//	}
			//}
			#endregion
			#region Question 9
			/*
			 * Write a program that takes two integers then prints the power 
			 */
			//         Console.Write("Enter a First Number: ");
			//         int FirstNumber = int.Parse(Console.ReadLine());
			//Console.Write("Enter a Second Number: ");
			//int SecondNumber = int.Parse(Console.ReadLine());
			//         int result = 1;
			//         for (int i = 0; i < SecondNumber; i++)
			//         {
			//             result*=FirstNumber;
			//         }
			//         Console.WriteLine($"result: {result}");
			#endregion
			#region Question 10
			/*
			 * Write a program to enter marks of five subjects and calculate total, average and percentage
			 */
			//int x;
			//int total=0;
			//for (int i = 1; i <= 5; i++)
			//{
			//             Console.Write($"Enter Mark of the Subject Number {i}: ");
			//	x=int.Parse(Console.ReadLine());
			//	total += x;
			//}
			//int avg = total / 5;
			//         Console.WriteLine($"Total: {total} avg: {avg}");
			#endregion
			#region Question 11
			/*
			 * Write a program to input the month number and 
			 * print the number of days in that month
			 */
			//Console.Write("Enter Month Number: ");
			//int Month = int.Parse(Console.ReadLine());
			//switch (Month)
			//{
			//	case 1: Console.WriteLine(31); break;
			//	case 2: Console.WriteLine(28); break;
			//	case 3: Console.WriteLine(31); break;
			//	case 4: Console.WriteLine(30); break;
			//	case 5: Console.WriteLine(31); break;
			//	case 6: Console.WriteLine(30); break;
			//	case 7: Console.WriteLine(31); break;
			//	case 8: Console.WriteLine(31); break;
			//	case 9: Console.WriteLine(30); break;
			//	case 10: Console.WriteLine(31); break;
			//	case 11: Console.WriteLine(30); break;
			//	case 12: Console.WriteLine(31); break;
			//	default:
			//		break;
			//}
			#endregion
			#region Question 12
			/*
			 * Write a program to create a Simple Calculator
			 */
			//Console.Write("Enter First Operand: ");
			//int operand1=int.Parse(Console.ReadLine());
			//Console.Write("Enter second Operand: ");
			//int operand2 = int.Parse(Console.ReadLine());
			//Console.Write("Enter second Operator: ");
			//char op = char.Parse(Console.ReadLine());
			//int result = 0;
			//switch (op)
			//{
			//	case '+': result = operand1+operand2; break;
			//	case '-': result = operand1 - operand2; break;
			//	case '/': result = operand1 / operand2; break;
			//	case '*': result = operand1 * operand2; break;
			//	default:
			//		break;
			//}
			//         Console.WriteLine($"{operand1} {op} {operand2} = {result}");
			#endregion
			#region Question 13
			/*
			 * Write a program to allow the user to enter a string and print the REVERSE of it
			 */
			//Console.Write("Enter a Word: ");
			//string word = Console.ReadLine();
			//string reverse = "";
			//for (int i = word.Length - 1; i >= 0; i--)
			//{
			//	reverse += word[i];
			//}
			//Console.WriteLine($"Reverse: {reverse}");
			#endregion
			#region Question 14
			/*
			 * Write a program to allow the user to enter int and print the REVERSED of it
			 */
			//Console.Write("Enter a Number: ");
			//int number = int.Parse(Console.ReadLine());
			//string reverse = "";
			//while (number > 0)
			//{
			//	int digit = number % 10; 
			//	reverse += digit.ToString();
			//	number /= 10;
			//}
			//Console.WriteLine($"Reverse: {reverse}");
			#endregion
			#region Question 15
			/*
			 * Write a program in C# Sharp to find prime numbers within a range of numbers
			 */
			//Console.Write("Enter a Number: ");
			//int number = int.Parse(Console.ReadLine());
			//for (int i = 1; i <=number; i++)
			//{
			//	for (int j = 1; j < number; j++)
			//	{
			//		if (i % j == 0)
			//		{
			//			if (j != 1 && j != i)
			//			{
			//				break;
			//			}
			//			else if (j == i)
			//			{
			//				Console.WriteLine(i);
			//			}
			//		}

			//	}
			//}
			#endregion
			#region Question 17
			/*
			 * Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3), 
			 * and determines whether these points lie on a single straight line
			 */
			//Console.Write("Enter x1: ");
			//int x1 = int.Parse(Console.ReadLine());
			//Console.Write("Enter y1: ");
			//int y1 = int.Parse(Console.ReadLine());
			//Console.Write("Enter x2: ");
			//int x2 = int.Parse(Console.ReadLine());
			//Console.Write("Enter y2: ");
			//int y2 = int.Parse(Console.ReadLine());
			//Console.Write("Enter x3: ");
			//int x3 = int.Parse(Console.ReadLine());
			//Console.Write("Enter y3: ");
			//int y3 = int.Parse(Console.ReadLine());
			//double a = 0.5 * Math.Abs(x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2));
			//if (a == 0)
			//{
			//	Console.WriteLine("The points lie on a single straight line.");
			//}
			//else
			//{
			//	Console.WriteLine("The points do not lie on a single straight line.");
			//}
			#endregion
			#region Question 18
			/*
			 * Within a company, the efficiency of workers is evaluated based on the duration required to complete a specific task.
			 * A worker's efficiency level is determined as follows: 
			 * - If the worker completes the job within 2 to 3 hours, they are considered highly efficient.
			 * - If the worker takes 3 to 4 hours, they are instructed to increase their speed.
			 * - If the worker takes 4 to 5 hours, they are provided with training to enhance their speed.
			 * - If the worker takes more than 5 hours, they are required to leave the company.
			 * To calculate the efficiency of a worker, the time taken for the task is obtained via user input from the keyboard.
			 */
			//Console.Write("Enter the time taken to complete the task (in hours): ");
			//double timeTaken = double.Parse(Console.ReadLine());
			//if (timeTaken >= 2 && timeTaken <= 3)
			//{
			//	Console.WriteLine("Highly efficient worker.");
			//}
			//else if (timeTaken > 3 && timeTaken <= 4)
			//{
			//	Console.WriteLine("Please increase your speed.");
			//}
			//else if (timeTaken > 4 && timeTaken <= 5)
			//{
			//	Console.WriteLine("You need training to enhance your speed.");
			//}
			//else if (timeTaken > 5)
			//{
			//	Console.WriteLine("You are required to leave the company.");
			//}
			//else
			//{
			//	Console.WriteLine("Invalid input. Please enter a valid time.");
			//}
			#endregion
		}
	}
}
