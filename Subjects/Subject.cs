using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exam2.Exams;
using Exam2.Questions;
using Exam2.Answers;

namespace Exam2.Subjects
{
	internal class Subject
	{
		public int SubjectId { get; set; }
		public string SubjectName { get; set; }
		public Exam Exam { get; set; }
		public Subject(int subjectId, string subjectName, Exam exam)
		{
			SubjectId = subjectId;
			SubjectName = subjectName;
			Exam = exam;
		}
		public Subject(int subjectId, string subjectName)
		{
			SubjectId = subjectId;
			SubjectName = subjectName;
			Exam = null;
		}
		public Subject() { }
		private MCQ CreateMCQQuestion() {
			Console.WriteLine("Enter question body:");
			string body = Console.ReadLine();
			Console.WriteLine("Enter question grade:");
			double grade = double.Parse(Console.ReadLine());
			Console.WriteLine("Enter number of options:");
			int numOptions = int.Parse(Console.ReadLine());
			Answer[] options = new Answer[numOptions];
			for (int j = 0; j < numOptions; j++)
			{
				Console.WriteLine($"Enter option {j + 1}:");
				string optionText = Console.ReadLine();
				options[j] = new Answer(j + 1, optionText);
			}
			Console.WriteLine("Enter the correct answer option number:");
			int correctAnswer = int.Parse(Console.ReadLine());
			return new MCQ(body, grade, options, correctAnswer);
		}
		private TrueOrFalse CreateTRFQuesion() {
			Console.WriteLine("Enter question body:");
			string body = Console.ReadLine();
			Console.WriteLine("Enter question grade:");
			double grade = double.Parse(Console.ReadLine());
			Console.WriteLine("Is the statement true or false? (T/F)");
			string isTrue = Console.ReadLine();
			return new TrueOrFalse(body, grade, isTrue.ToUpper());
		}
		private void CreateFinalExam()
		{
			List<MCQ> mcqQuestions = new List<MCQ>();
			List<TrueOrFalse> trueOrFalseQuestions = new List<TrueOrFalse>();
			Console.WriteLine("Enter exam time in minutes:");
			int examTime = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter number of questions:");
			int numberOfQuestions = int.Parse(Console.ReadLine());
			for (int i = 0; i < numberOfQuestions; i++)
			{
				Console.WriteLine("Choose Question Type 1 For MCQ or 2 For TrueOrFalse");
				int questionType = int.Parse(Console.ReadLine());
				if (questionType == 1) {
					MCQ mcqQuestion = CreateMCQQuestion();
					mcqQuestions.Add(mcqQuestion);
				} else if (questionType == 2) {
					TrueOrFalse trueOrFalseQuestion = CreateTRFQuesion();
					trueOrFalseQuestions.Add(trueOrFalseQuestion);
				} else {
					Console.WriteLine("Invalid question type selected.");
				}
			}
			Exam = new FinalExam(examTime, numberOfQuestions, mcqQuestions, trueOrFalseQuestions);
		}
		private void CreatePracticalExam()
		{
			List<MCQ> mcqQuestions = new List<MCQ>();
			Console.WriteLine("Enter exam time in minutes:");
			int examTime = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter number of questions:");
			int numberOfQuestions = int.Parse(Console.ReadLine());
			for (int i = 0; i < numberOfQuestions; i++)
			{
				MCQ mcqQuestion = CreateMCQQuestion();
				mcqQuestions.Add(mcqQuestion);
			}
			Exam = new PracticalExam(examTime, numberOfQuestions, mcqQuestions);
		}
		public void CreateExam()
		{
			Console.WriteLine("Choose Exam Type 1 For Final Exam or 2 For Practical Exam");
			int examType = int.Parse(Console.ReadLine());
			if (examType == 1)
			{
				CreateFinalExam();
			}
			else if (examType == 2)
			{
				CreatePracticalExam();
			}
			Console.WriteLine("Did you want to Test Your Exam Y/N");
			string testExam = Console.ReadLine().ToUpper();
			if (testExam == "Y")
			{
				if (Exam is FinalExam finalExam)
				{
					finalExam.ShowExamDetails();
				}
				else if (Exam is PracticalExam practicalExam)
				{
					practicalExam.ShowExamDetails();
				}
			}
			else
			{
				Console.WriteLine("You can take the exam later.");
			}
		}
	}
}
