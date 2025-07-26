using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppAss2.FirstProject
{
	internal class _3DPoint : IComparable<_3DPoint>, ICloneable
	{
		#region 1stRequirment
		//Define 3D Point Class and the basic Constructors (use chaining in constructors)
		public int X { get; set; }
		public int Y { get; set; }
		public int Z { get; set; }
		public _3DPoint()
		{

		}
		public _3DPoint(int _x, int _y)
		{
			X = _x;
			Y = _y;
		}

		public _3DPoint(int _x, int _y, int _z) : this(_x, _y)
		{
			Z = _z;
		}
		#endregion
		#region 2ndRequirment
		/*
		 * Override the ToString Function to produce this output:
		 * Point3D P = new Point3D (10,10,10);
		 * Console. WriteLine (P. ToString( ));
		 * Output: “Point Coordinates: (10, 10, 10)
		 */
		public override string ToString()
		{
			return $"Point Coordinates: ({X}, {Y}, {Z})";
		}
		#endregion
		#region 6thRequirment
		public object Clone()
		{
			return new _3DPoint(X, Y, Z);
		}

		public int CompareTo(_3DPoint? other)
		{
			if (other == null) return 1;
			int xComparison = X.CompareTo(other.X);
			if (xComparison != 0) return xComparison;
			int yComparison = Y.CompareTo(other.Y);
			if (yComparison != 0) return yComparison;
			return Z.CompareTo(other.Z);
		}
		#endregion



	}
}
