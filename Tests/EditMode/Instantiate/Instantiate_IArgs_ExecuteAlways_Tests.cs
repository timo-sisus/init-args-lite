using NUnit.Framework;
using UnityEngine;
using static UnityEngine.Object;

namespace Sisus.Init.Tests
{
	public class Instantiate_IArgs_ExecuteAlways_Tests
	{
		private AnyArgsExecuteAlways original;

		[SetUp]
		public void SetUp() => original = new GameObject(GetType().Name).AddComponent<AnyArgsExecuteAlways>();

		[TearDown]
		public void TearDown() => DestroyImmediate(original.gameObject);

		[Test]
		public void Instantiate_1_Arg()
		{
			var clone = original.Instantiate(1);
			Assert.AreEqual(1, clone.receivedDependencies);
			for(int i = 1; i <= 1; i++)
			{
				Assert.AreEqual(i, clone[i]);
			}

			DestroyImmediate(clone.gameObject);
		}

		[Test]
		public void Instantiate_2_Args_Works()
		{
			var clone = original.Instantiate(1, 2);
			Assert.AreEqual(2, clone.receivedDependencies);
			for(int i = 1; i <= 2; i++)
			{
				Assert.AreEqual(i, clone[i]);
			}

			DestroyImmediate(clone.gameObject);
		}

		[Test]
		public void Instantiate_3_Args_Works()
		{
			var clone = original.Instantiate(1, 2, 3);
			Assert.AreEqual(3, clone.receivedDependencies);
			for(int i = 1; i <= 3; i++)
			{
				Assert.AreEqual(i, clone[i]);
			}

			DestroyImmediate(clone.gameObject);
		}

		[Test]
		public void Instantiate_4_Args_Works()
		{
			var clone = original.Instantiate(1, 2, 3, 4);
			Assert.AreEqual(4, clone.receivedDependencies);
			for(int i = 1; i <= 4; i++)
			{
				Assert.AreEqual(i, clone[i]);
			}

			DestroyImmediate(clone.gameObject);
		}

		[Test]
		public void Instantiate_5_Args_Works()
		{
			var clone = original.Instantiate(1, 2, 3, 4, 5);
			Assert.AreEqual(5, clone.receivedDependencies);
			for(int i = 1; i <= 5; i++)
			{
				Assert.AreEqual(i, clone[i]);
			}

			DestroyImmediate(clone.gameObject);
		}

		[Test]
		public void Instantiate_6_Args_Works()
		{
			var clone = original.Instantiate(1, 2, 3, 4, 5, 6);
			Assert.AreEqual(6, clone.receivedDependencies);
			for(int i = 1; i <= 6; i++)
			{
				Assert.AreEqual(i, clone[i]);
			}

			DestroyImmediate(clone.gameObject);
		}

		[Test]
		public void Instantiate_7_Args_Works()
		{
			var clone = original.Instantiate(1, 2, 3, 4, 5, 6, 7);
			Assert.AreEqual(7, clone.receivedDependencies);
			for(int i = 1; i <= 7; i++)
			{
				Assert.AreEqual(i, clone[i]);
			}

			DestroyImmediate(clone.gameObject);
		}

		[Test]
		public void Instantiate_8_Args_Works()
		{
			var clone = original.Instantiate(1, 2, 3, 4, 5, 6, 7, 8);
			Assert.AreEqual(8, clone.receivedDependencies);
			for(int i = 1; i <= 8; i++)
			{
				Assert.AreEqual(i, clone[i]);
			}

			DestroyImmediate(clone.gameObject);
		}

		[Test]
		public void Instantiate_9_Args_Works()
		{
			var clone = original.Instantiate(1, 2, 3, 4, 5, 6, 7, 8, 9);
			Assert.AreEqual(9, clone.receivedDependencies);
			for(int i = 1; i <= 9; i++)
			{
				Assert.AreEqual(i, clone[i]);
			}

			DestroyImmediate(clone.gameObject);
		}

		[Test]
		public void Instantiate_10_Args_Works()
		{
			var clone = original.Instantiate(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
			Assert.AreEqual(10, clone.receivedDependencies);
			for(int i = 1; i <= 10; i++)
			{
				Assert.AreEqual(i, clone[i]);
			}

			DestroyImmediate(clone.gameObject);
		}

		[Test]
		public void Instantiate_11_Args_Works()
		{
			var clone = original.Instantiate(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11);
			Assert.AreEqual(11, clone.receivedDependencies);
			for(int i = 1; i <= 11; i++)
			{
				Assert.AreEqual(i, clone[i]);
			}

			DestroyImmediate(clone.gameObject);
		}

		[Test]
		public void Instantiate_12_Args_Works()
		{
			var clone = original.Instantiate(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12);
			Assert.AreEqual(12, clone.receivedDependencies);
			for(int i = 1; i <= 12; i++)
			{
				Assert.AreEqual(i, clone[i]);
			}

			DestroyImmediate(clone.gameObject);
		}
	}
}