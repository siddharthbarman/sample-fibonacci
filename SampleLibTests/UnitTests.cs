using NUnit.Framework;

namespace SampleLib
{
	public class Tests
	{
		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public void TestGenerationOfFirstNumber()
		{
			Fibonacci fib = new Fibonacci();
			int[] seq = fib.Generate(1);
			Assert.AreEqual(1, seq.Length);
			Assert.AreEqual(0, seq[0]);
		}

		[Test]
		public void TestGenerationOfFirstTwoNumbers()
		{
			Fibonacci fib = new Fibonacci();
			int[] seq = fib.Generate(2);
			Assert.AreEqual(2, seq.Length);
			Assert.AreEqual(0, seq[0]);
			Assert.AreEqual(1, seq[1]);
		}

		[Test]
		public void TestGenerationOfFirstFiveNumbers()
		{
			Fibonacci fib = new Fibonacci();
			int[] seq = fib.Generate(5);
			Assert.AreEqual(5, seq.Length);
			Assert.AreEqual(0, seq[0]);
			Assert.AreEqual(1, seq[1]);
			Assert.AreEqual(1, seq[2]);
			Assert.AreEqual(2, seq[3]);
			Assert.AreEqual(3, seq[4]);
		}
	}
}