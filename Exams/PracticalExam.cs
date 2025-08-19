using Exam2.Answers;
using Exam2.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Exam2.Exams
{
	internal class PracticalExam:Exam
	{
		public List<MCQ> mcqQuestions { get; set; }
		public Double TotalMarks
		{
			get
			{
				return mcqQuestions.Sum(q => q.Mark);
			}
		}
		public Double StudentMarks { get; set; } = 0.0;
		public PracticalExam(int _examTime, int _NumberOfQuestions, List<MCQ> _mcqQuestions)
			: base(_examTime, _NumberOfQuestions)
		{
			mcqQuestions = _mcqQuestions;
			foreach (var question in mcqQuestions)
			{
				base.questions.Add(question);
			}
		}
		public void ShowResults(TimeSpan duration, List<Answer> StudentAns)
		{
			Console.WriteLine($"Total exam duration: {duration.TotalMinutes} minutes");
			Console.WriteLine($"Total Marks: {TotalMarks}");
			Console.WriteLine($"Student Marks: {StudentMarks}");
			for (int i = 0; i < mcqQuestions.Count; i++)
			{
				Console.WriteLine($"Question {i + 1}: {mcqQuestions[i].Header}");
				Console.WriteLine($"Your Answer: {StudentAns[i].AnswerId}");
				Console.WriteLine($"Correct Answer: {mcqQuestions[i].correctAnswer}");
			}
		}
		public override void ShowExamDetails()
		{
			base.StartExam();
			List<Answer> SudentAns = new List<Answer>(this.mcqQuestions.Count);
			Console.WriteLine("Final Exam Details:");
			base.ShowExamDetails();
			foreach (var Q in mcqQuestions)
			{
					Q.ShowQustion();
					Console.Write("Enter your answer (Answer ID): ");
					int answerId;
					while (!int.TryParse(Console.ReadLine(), out answerId) || !	Q.options.Any(o => o.AnswerId == answerId))
					{
						Console.Write("Invalid input. Please enter a valid Answer ID: ");
					}
					Answer studentAnswer = new Answer(answerId);
					SudentAns.Add(studentAnswer);
					if (Q.AnswerIsCorrected(studentAnswer))
					{
						StudentMarks += Q.Mark;
					}
					Console.WriteLine("------------------------------------------------");
			}
			base.EndExam();
			TimeSpan duration = base.ExamEnd - base.ExamBegin;
			ShowResults(duration,SudentAns);
		}
	}
}
