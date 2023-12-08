using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaLibrary.ShapeAreaLibraryTests
{
	internal class TriangeTests
	{
		[Test]
		public void CalculateCircleAreaIntegers()
		{
			Assert.Multiple(() =>
			{
				Assert.That(ShapeService.CalculateArea(new Triangle(3, 4, 5)), Is.EqualTo(6));
				Assert.That(ShapeService.CalculateArea(new Triangle(5, 11, 15)), Is.EqualTo(19.136));
				Assert.That(ShapeService.CalculateArea(new Triangle(13, 23, 33)), Is.EqualTo(113.116));
				Assert.That(ShapeService.CalculateArea(new Triangle(232, 213, 442)), Is.EqualTo(5694.861));
				Assert.That(ShapeService.CalculateArea(new Triangle(331, 211, 497)), Is.EqualTo(26071.577));
			});
		}

		[Test]
		public void CalculateCircleAreaDoubles()
		{
			Assert.Multiple(() =>
			{
				Assert.That(ShapeService.CalculateArea(new Triangle(3.3, 4.1, 5.4)), Is.EqualTo(6.755));
				Assert.That(ShapeService.CalculateArea(new Triangle(5.12, 11.33, 15.55)), Is.EqualTo(19.127));
				Assert.That(ShapeService.CalculateArea(new Triangle(13.98, 23.9, 33.97)), Is.EqualTo(136.139));
				Assert.That(ShapeService.CalculateArea(new Triangle(232.13, 213.55, 442.76)), Is.EqualTo(5632.888));
				Assert.That(ShapeService.CalculateArea(new Triangle(331.03, 211.8, 497.45)), Is.EqualTo(26233.096));
			});
		}

		[Test]
		public void CheckIsRightTriangle()
		{
			Assert.Multiple(() =>
			{
				Assert.That(ShapeService.IsRightTriangle(new Triangle(3, 4, 5)), Is.True);
				Assert.That(ShapeService.IsRightTriangle(new Triangle(4, 5, 8)), Is.False);
			});
		}

		[Test]
		public void CalculateCircleAreaExceptions()
		{
			Assert.Throws<ArgumentOutOfRangeException>(() => ShapeService.CalculateArea(new Triangle(-1, 3.1, 2)));
			Assert.Throws<ArgumentOutOfRangeException>(() => ShapeService.CalculateArea(new Triangle(1, -3.1, 2)));
			Assert.Throws<ArgumentOutOfRangeException>(() => ShapeService.CalculateArea(new Triangle(1, 3.1, -2)));
			Assert.Throws<ArgumentOutOfRangeException>(() => ShapeService.CalculateArea(new Triangle(0, 3.1, 2)));
			Assert.Throws<ArgumentOutOfRangeException>(() => ShapeService.CalculateArea(new Triangle(1, 3.1, 0)));
		}

	}
}
