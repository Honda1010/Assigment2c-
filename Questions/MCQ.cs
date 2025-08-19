using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exam2.Answers;
namespace Exam2.Questions
{
	internal class MCQ:Question
	{
		public Answer[] options { get; set; }
		public int correctAnswer { get; set; }

		public MCQ(string _Body, double _grade, Answer[] _options, int _correctAnswer)
			: base("Choose The Correct Answer", _Body, _grade)
		{
			options = _options;
			correctAnswer = _correctAnswer;
		}

		public MCQ(Question question, Answer[] _options, int _correctAnswer)
			: base(question.Header, question.Body, question.Mark)
		{
			this.options = _options;
			this.correctAnswer = _correctAnswer;
		}


		public void ShowOptions()
		{
			Console.WriteLine("Options:");
			foreach (var option in options)
			{
				Console.WriteLine(option.ToString());
			}
		}
		public override void ShowQustion()
		{
			base.ShowQustion();
			ShowOptions();
		}

		public bool AnswerIsCorrected(Answer answer)
		{
			return correctAnswer==answer.AnswerId;
		}
		public override string ToString()
		{
			string optionsString = string.Join(", ", options.ToString);
			return $"{base.ToString()}\nOptions: {optionsString}\nCorrect Answer: {correctAnswer}";
		}
	}
}
