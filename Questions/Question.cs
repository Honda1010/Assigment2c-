using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2.Questions
{
    internal class Question
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public double Mark { get; set; }
        public Question(string _Header, string _Body, double _mark)
        {
            Header = _Header;
            Body = _Body;
            Mark = _mark;
        }
		public Question(string _Header, double _mark)
		{
			Header = _Header;
			Mark = _mark;
		}
        public Question() { }

		public virtual void ShowQustion()
		{
            if (Header is not null) {
				Console.WriteLine(Header);
			}
			Console.WriteLine(Body + " ? " + $"Mark: {Mark}");
		}
		public override string ToString()
        {
            return $"Header: {Header}\nBody: {Body}\nGrade: {Mark}";
        }
    }
}
