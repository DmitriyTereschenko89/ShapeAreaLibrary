using ShapeAreaLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaLibrary.ShapeAreaLibraryTests
{
	internal class ShapeService
	{
		public static double CalculateArea(IShape shape)
		{
			return Math.Round(shape.GetArea(), 3);
		}

		public static bool IsRightTriangle(ITriangle triangle)
		{
			return triangle.IsRightTriangle();
		}

	}
}
