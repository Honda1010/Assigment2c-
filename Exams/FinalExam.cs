using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exam2.Questions;
using Exam2.Answers;

namespace Exam2.Exams
{
	internal class FinalExam:Exam
	{
		// final exam can contain MCQ and TrueOrFalse questions
		public List<MCQ> mcqQuestions { get; set; }
		public List<TrueOrFalse> trueOrFalseQuestions { get; set; }

		public Double TotalMarks
		{
			get
			{
				return base.questions.Sum(q => q.Mark);
			}
		}
		public Double StudentMarks { get; set; } = 0.0;
		public FinalExam(int _examTime, int _NumberOfQuestions, List<MCQ> _mcqQuestions, List<TrueOrFalse> _trueOrFalseQuestion)
			: base(_examTime, _NumberOfQuestions)
		{
			mcqQuestions = _mcqQuestions;
			trueOrFalseQuestions = _trueOrFalseQuestion;
			// Add questions to the base class
			foreach (var question in mcqQuestions)
			{
				base.questions.Add(question);
			}
			foreach (var question in trueOrFalseQuestions)
			{
				base.questions.Add(question);
			}
		}
		public FinalExam(int _examTime, int _NumberOfQuestions)
			: base(_examTime, _NumberOfQuestions)
		{
			base.questions = new List<Question>(_NumberOfQuestions);
		}
		public void ShowResults(TimeSpan duration, List<Answer> StudentAns)
		{
			Console.WriteLine($"Total exam duration: {duration.TotalMinutes} minutes");
			Console.WriteLine($"Total Marks: {TotalMarks}");
			Console.WriteLine($"Student Marks: {StudentMarks}");

			for (int i = 0; i < base.questions.Count; i++)
			{
				var question = base.questions[i];
				Console.WriteLine($"Question {i + 1}: {question.Header}");
				if (question is MCQ mcq)
				{
					Console.WriteLine($"Your Answer: {StudentAns[i].AnswerId}");
					Console.WriteLine($"Correct Answer: {mcq.correctAnswer}");
				}
				else if (question is TrueOrFalse trueOrFalse)
				{
					Console.WriteLine($"Your Answer: {StudentAns[i].AnswerText}");
					Console.WriteLine($"Correct Answer: {trueOrFalse.correctAnswer}");
				}
			}

			if (StudentMarks >= TotalMarks / 2)
			{
				Console.WriteLine("Result: Passed");
			}
			else
			{
				Console.WriteLine("Result: Failed");
			}
		}
	


		public override void ShowExamDetails()
		{
			base.StartExam();
			List<Answer> StudentAns = new List<Answer>(base.NumberOfQuestions);
			Console.WriteLine("Final Exam Details:");
			base.ShowExamDetails();
			foreach (var Q in base.questions)
			{
				if (Q is MCQ mcq)
				{
					mcq.ShowQustion();
					Console.Write("Enter your answer (Answer ID): ");
					int answerId;
					while (!int.TryParse(Console.ReadLine(), out answerId) || !mcq.options.Any(o => o.AnswerId == answerId))
					{
						Console.Write("Invalid input. Please enter a valid Answer ID: ");
					}
					Answer studentAnswer = new Answer(answerId);
					StudentAns.Add(studentAnswer);
					if (mcq.AnswerIsCorrected(studentAnswer))
					{
						StudentMarks += mcq.Mark;
					}
				}
				else if (Q is TrueOrFalse trueOrFalse)
				{
					trueOrFalse.ShowQustion();
					Console.Write("Enter your answer (T/F): ");
					string answer;
					while (true)
					{
						answer = Console.ReadLine()?.Trim().ToUpper();
						if (answer == "T" || answer == "F")
						{
							break;
						}
						Console.Write("Invalid input. Please enter 'T' for True or 'F' for False: ");
					}
					Answer studentAnswer = new Answer(answer);
					StudentAns.Add(studentAnswer);
					if (trueOrFalse.IsCorrectAnswer(answer))
					{
						StudentMarks += trueOrFalse.Mark;
					}
				}
				Console.WriteLine("------------------------------------------------");
			}
			base.EndExam();
			TimeSpan duration = base.ExamEnd - base.ExamBegin;
			ShowResults(duration, StudentAns);
		}
	}
}
