using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADVAss1.Question2
{
	internal class Range<T> where T : IComparable<T>
	{
        public T min { get; set; }
		public T max { get; set; }
        public Range(T _min,T _max)
        {
			min = _min;
			max = _max;
		}
		public bool IsInRange(T value)
		{
			return value.CompareTo(min) >= 0 &&
				   value.CompareTo(max) <= 0;
		}
		public Double Length()
		{
			return Convert.ToDouble(max)- Convert.ToDouble(min);
		}
		public override string ToString()
		{
			return $"Range: [{min}, {max}]";
		}

	}
}
