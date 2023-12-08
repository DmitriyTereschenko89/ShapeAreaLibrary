using ShapeAreaLibrary.ShapeAreaLibraryTests;
using ShapeAreaLibrary.Shapes;

namespace ShapeAreaLibraryTests
{
	public class CircleAreaTests
	{
		[Test]
		public void CalculateCircleAreaIntegers()
		{
			Assert.Multiple(() =>
			{
				Assert.That(ShapeService.CalculateArea(new Circle(4)), Is.EqualTo(50.265));
				Assert.That(ShapeService.CalculateArea(new Circle(10)), Is.EqualTo(314.159));
				Assert.That(ShapeService.CalculateArea(new Circle(200)), Is.EqualTo(125663.706));
				Assert.That(ShapeService.CalculateArea(new Circle(1672810)), Is.EqualTo(8791097661617.327));
				Assert.That(ShapeService.CalculateArea(new Circle(828281922)), Is.EqualTo(2.1552926003557783E+18));
			});
		}

		[Test]
		public void CalculateCircleAreaDoubles()
		{
			Assert.Multiple(() =>
			{
				Assert.That(ShapeService.CalculateArea(new Circle(4.3)), Is.EqualTo(58.088));
				Assert.That(ShapeService.CalculateArea(new Circle(10.11)), Is.EqualTo(321.109));
				Assert.That(ShapeService.CalculateArea(new Circle(200.31)), Is.EqualTo(126053.566));
				Assert.That(ShapeService.CalculateArea(new Circle(167.89)), Is.EqualTo(88552.236));
				Assert.That(ShapeService.CalculateArea(new Circle(8282.31)), Is.EqualTo(215502759.774));
			});
		}

		[Test]
		public void CalculateCircleAreaExceptions()
		{
			Assert.Throws<ArgumentOutOfRangeException>(() => ShapeService.CalculateArea(new Circle(-3)));
			Assert.Throws<ArgumentOutOfRangeException>(() => ShapeService.CalculateArea(new Circle(0)));
			Assert.Throws<ArgumentOutOfRangeException>(() => ShapeService.CalculateArea(new Circle(-1.3)));
			Assert.Throws<ArgumentOutOfRangeException>(() => ShapeService.CalculateArea(new Circle(-0.001)));
			Assert.Throws<ArgumentOutOfRangeException>(() => ShapeService.CalculateArea(new Circle(-0.312)));
		}
	}
}