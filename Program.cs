using System;
using Exam2.Subjects;
namespace Exam2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Test Subject and Exam creation
			Subject subject = new Subject(1, "Mathematics");
			Console.WriteLine("Creating final exam for the subject...");
			subject.CreateExam();
			Console.WriteLine("Exam created successfully.");
		}
	}
}
