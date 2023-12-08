using ShapeAreaLibrary.Interfaces;

namespace ShapeAreaLibrary.Shapes
{
	public class Circle(double radius) : IShape
	{
		private readonly double radius = radius;

		public double GetArea()
		{
			if (radius <= 0)
			{
				throw new ArgumentOutOfRangeException("Radius is less or equal zero.");
			}

			return Math.PI * radius * radius;
		}
	}
}
