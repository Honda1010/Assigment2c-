using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppAss2.ThirdProject
{
	internal class Duration
	{
		#region 1stRequirment
		//Define Class Duration To include Three Attributes Hours, Minutes and Seconds.
		public int Hours { get; set; }
		public int Minutes { get; set; }
		public int Seconds { get; set; }
		#endregion
		#region 2ndRequirment
		//Override All System.Object Members (ToString, Equals,GetHasCode) 
		public override string ToString()
		{
			return $"Hours:{Hours}, Minutes:{Minutes}, Seconds:{Seconds}";
		}
		public override bool Equals(object? obj)
		{
			if (obj is Duration other)
			{
				return Hours == other.Hours && Minutes == other.Minutes && Seconds == other.Seconds;
			}
			return false;
		}
		public override int GetHashCode()
		{
			return HashCode.Combine(Hours, Minutes, Seconds);
		}
		#endregion
		#region 3rdRequirment
		// Define Constructors for the Duration class
		public Duration()
		{

		}
        public Duration(int _s)
        {
			if (_s >= 60)
			{
				Minutes = _s/60;
				Seconds = _s % 60;
				if (Minutes >= 60)
				{
					Hours = Minutes / 60;
					Minutes = Minutes % 60;
				}
			}
        }
        public Duration(int _h, int _m, int _s)
		{
			Hours = _h;
			Minutes = _m;
			Seconds = _s;
		}
		#endregion
		#region 4thRequirment
		// Define all operator +,-,++,--,>,<,>=,<= ,casting
		public static Duration operator +(Duration d1, Duration d2)
		{
			int totalSeconds = d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds +
							   d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds;
			return new Duration(totalSeconds);
		}
		public static Duration operator +(Duration d, int seconds)
		{
			int totalSeconds = d.Hours * 3600 + d.Minutes * 60 + d.Seconds + seconds;
			return new Duration(totalSeconds);
		}
		public static Duration operator -(Duration d1, Duration d2)
		{
			int totalSeconds1 = d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds;
			int totalSeconds2 = d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds;
			int resultSeconds = Math.Max(totalSeconds1 - totalSeconds2, 0);
			return new Duration(resultSeconds);
		}
		public static Duration operator ++(Duration d)
		{
				d.Minutes++;
				if (d.Minutes >= 60)
				{
					d.Minutes = d.Minutes%60;
					d.Hours++;
				}
			return d;
		}
		public static Duration operator --(Duration d)
		{
			//Decrease One Minute
			d.Minutes--;
			if (d.Minutes < 0)
			{
				d.Minutes = 59;
				d.Hours--;
				if (d.Hours < 0)
				{
					d.Hours = 0;
					d.Minutes = 0;
					d.Seconds = 0;
				}
			}
			return d;
		}
		public static bool operator >(Duration d1, Duration d2)
		{
			return (d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds) >
				   (d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds);
		}
		public static bool operator <(Duration d1, Duration d2)
		{
			return (d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds) <
				   (d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds);
		}
		public static bool operator >=(Duration d1, Duration d2)
		{
			return (d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds) >=
				   (d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds);
		}
		public static bool operator <=(Duration d1, Duration d2)
		{
			return (d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds) <=
				   (d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds);
		}
		public static bool operator ==(Duration d1, Duration d2)
		{
			return d1.Equals(d2);
		}
		public static bool operator !=(Duration d1, Duration d2)
		{
			return !d1.Equals(d2);
		}
		public static explicit operator DateTime(Duration duration)
		{
			return new DateTime(1, 1, 1, duration.Hours, duration.Minutes, duration.Seconds);
		}
		public static explicit operator Duration(DateTime dateTime)
		{
			return new Duration(dateTime.Hour, dateTime.Minute, dateTime.Second);
		}
		public static implicit operator bool(Duration duration)
		{
			return duration.Hours > 0 || duration.Minutes > 0 || duration.Seconds > 0;
		}
		#endregion


	}
}
