using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2.Questions
{
	internal class TrueOrFalse: Question
	{
		public string correctAnswer { get; set; }

		public TrueOrFalse(string _Body, double _grade, string _correctAnswer)
			: base("True or False", _Body, _grade)
		{
			correctAnswer = _correctAnswer;
		}
		public override void ShowQustion()
		{
			base.ShowQustion();
			Console.WriteLine("Choose T/F");
		}
		public bool IsCorrectAnswer(string answer)
		{
			return correctAnswer==answer;
		}

		public override string ToString()
		{
			return $"{base.ToString()}\nCorrect Answer: {correctAnswer}";
		}

		public override bool Equals(object? obj)
		{
			return obj is TrueOrFalse other && base.Equals(other) && correctAnswer == other.correctAnswer;
		}
	
	}
}
