using ShapeAreaLibrary.Interfaces;

namespace ShapeAreaLibrary.Shapes
{
	public class Triangle(double a, double b, double c) : IShape, ITriangle
	{
		private readonly double a = a;
		private readonly double b = b;
		private readonly double c = c;

		private bool IsInvalidArguments()
		{
			return a <= 0 || b <= 0 || c <= 0;
		}

		public double GetArea()
		{
			if (IsInvalidArguments())
			{
				throw new ArgumentOutOfRangeException("One or more of the sides are less or equal zero.");
			}
			double halfP = (a + b + c) / 2.0;
			return Math.Sqrt(halfP * (halfP - a) * (halfP - b) * (halfP - c));
		}

		public bool IsRightTriangle()
		{
			if (IsInvalidArguments())
			{
				throw new ArgumentOutOfRangeException("One or more of the sides are less or equal zero.");
			}
			
			return a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a;
		}
	}
}
