using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2.Answers
{
	internal class Answer
	{
		public int AnswerId { get; set; }
		public string AnswerText { get; set; }
        public Answer(int _AnsId,string _AnswerText)
        {
			AnswerId = _AnsId;
			AnswerText = _AnswerText;
		}
		public Answer(int _AnsId)
		{
			AnswerId = _AnsId;
		}
		public Answer(string _AnswerText)
		{
			AnswerText = _AnswerText;
		}


		public override string ToString()
		{
			return $"{this.AnswerId} : {this.AnswerText}";
		}
	}
}
