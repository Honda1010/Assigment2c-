using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exam2.Questions;

namespace Exam2.Exams
{
	internal class Exam
	{
		public int examTime { get; set; }
		public int NumberOfQuestions { get; set; }
		public List<Question> questions { get; set; }
		public DateTime ExamBegin { get; set; }
		public DateTime ExamEnd { get; set; }
		public Exam(int _examTime, int _NumberOfQuestions)
		{
			examTime = _examTime;
			NumberOfQuestions = _NumberOfQuestions;
			questions = new List<Question>();
		}
		public Exam() { }
		public virtual void ShowExamDetails() {
			Console.WriteLine($"Exam Time: {examTime} minutes");
			Console.WriteLine($"Number of Questions: {NumberOfQuestions}");
			Console.WriteLine("Questions:");
		}
		public void StartExam()
		{
			ExamBegin = DateTime.Now;
			Console.WriteLine($"Exam started at: {ExamBegin}");
		}
		public void EndExam()
		{
			ExamEnd = DateTime.Now;
			Console.WriteLine($"Exam ended at: {ExamEnd}");
		}
		public string GetTimeSpent()
		{
			TimeSpan duration = ExamEnd - ExamBegin;
			return $"Total exam duration: {duration.TotalMinutes} minutes";
		}
		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine($"Exam Time: {examTime}");
			sb.AppendLine($"Number of Questions: {NumberOfQuestions}");
			sb.AppendLine("Questions:");
			foreach (var question in questions)
			{
				sb.AppendLine(question.ToString());
			}
			return sb.ToString();
		}
	}
}
