using NUnit.Framework;
using UnityEngine;
using static UnityEngine.Object;

namespace Sisus.Init.Tests
{
	public class Instantiate_MonoBehaviourT_Tests
	{
		private GameObject original;

		[SetUp]
		public void SetUp() => original = new(GetType().Name);

		[TearDown]
		public void TearDown() => DestroyImmediate(original);

		[Test]
		public void Instantiate_1_Arg_Works()
		{
			var clone = original.AddComponent<MonoBehaviourT1Impl>().Instantiate(1);
			Assert.IsTrue(clone.receivedDependencies);
			for(int i = 1; i <= 1; i++)
			{
				Assert.AreEqual(i, clone[i]);
			}

			DestroyImmediate(clone.gameObject);
		}

		[Test]
		public void Instantiate_2_Args_Works()
		{
			var clone = original.AddComponent<MonoBehaviourT2Impl>().Instantiate(1, 2);
			Assert.IsTrue(clone.receivedDependencies);
			for(int i = 1; i <= 2; i++)
			{
				Assert.AreEqual(i, clone[i]);
			}

			DestroyImmediate(clone.gameObject);
		}

		[Test]
		public void Instantiate_3_Args_Works()
		{
			var clone = original.AddComponent<MonoBehaviourT3Impl>().Instantiate(1, 2, 3);
			Assert.IsTrue(clone.receivedDependencies);
			for(int i = 1; i <= 3; i++)
			{
				Assert.AreEqual(i, clone[i]);
			}

			DestroyImmediate(clone.gameObject);
		}

		[Test]
		public void Instantiate_4_Args_Works()
		{
			var clone = original.AddComponent<MonoBehaviourT4Impl>().Instantiate(1, 2, 3, 4);
			Assert.IsTrue(clone.receivedDependencies);
			for(int i = 1; i <= 4; i++)
			{
				Assert.AreEqual(i, clone[i]);
			}

			DestroyImmediate(clone.gameObject);
		}

		[Test]
		public void Instantiate_5_Args_Works()
		{
			var clone = original.AddComponent<MonoBehaviourT5Impl>().Instantiate(1, 2, 3, 4, 5);
			Assert.IsTrue(clone.receivedDependencies);
			for(int i = 1; i <= 5; i++)
			{
				Assert.AreEqual(i, clone[i]);
			}

			DestroyImmediate(clone.gameObject);
		}

		[Test]
		public void Instantiate_6_Args_Works()
		{
			var clone = original.AddComponent<MonoBehaviourT6Impl>().Instantiate(1, 2, 3, 4, 5, 6);
			Assert.IsTrue(clone.receivedDependencies);
			for(int i = 1; i <= 6; i++)
			{
				Assert.AreEqual(i, clone[i]);
			}

			DestroyImmediate(clone.gameObject);
		}

		[Test]
		public void Instantiate_7_Args_Works()
		{
			var clone = original.AddComponent<MonoBehaviourT7Impl>().Instantiate(1, 2, 3, 4, 5, 6, 7);
			Assert.IsTrue(clone.receivedDependencies);
			for(int i = 1; i <= 7; i++)
			{
				Assert.AreEqual(i, clone[i]);
			}

			DestroyImmediate(clone.gameObject);
		}

		[Test]
		public void Instantiate_8_Args_Works()
		{
			var clone = original.AddComponent<MonoBehaviourT8Impl>().Instantiate(1, 2, 3, 4, 5, 6, 7, 8);
			Assert.IsTrue(clone.receivedDependencies);
			for(int i = 1; i <= 8; i++)
			{
				Assert.AreEqual(i, clone[i]);
			}

			DestroyImmediate(clone.gameObject);
		}

		[Test]
		public void Instantiate_9_Args_Works()
		{
			var clone = original.AddComponent<MonoBehaviourT9Impl>().Instantiate(1, 2, 3, 4, 5, 6, 7, 8, 9);
			Assert.IsTrue(clone.receivedDependencies);
			for(int i = 1; i <= 9; i++)
			{
				Assert.AreEqual(i, clone[i]);
			}

			DestroyImmediate(clone.gameObject);
		}

		[Test]
		public void Instantiate_10_Args_Works()
		{
			var clone = original.AddComponent<MonoBehaviourT10Impl>().Instantiate(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
			Assert.IsTrue(clone.receivedDependencies);
			for(int i = 1; i <= 10; i++)
			{
				Assert.AreEqual(i, clone[i]);
			}

			DestroyImmediate(clone.gameObject);
		}

		[Test]
		public void Instantiate_11_Args_Works()
		{
			var clone = original.AddComponent<MonoBehaviourT11Impl>().Instantiate(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11);
			Assert.IsTrue(clone.receivedDependencies);
			for(int i = 1; i <= 11; i++)
			{
				Assert.AreEqual(i, clone[i]);
			}

			DestroyImmediate(clone.gameObject);
		}

		[Test]
		public void Instantiate_12_Args_Works()
		{
			var clone = original.AddComponent<MonoBehaviourT12Impl>().Instantiate(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12);
			Assert.IsTrue(clone.receivedDependencies);
			for(int i = 1; i <= 12; i++)
			{
				Assert.AreEqual(i, clone[i]);
			}

			DestroyImmediate(clone.gameObject);
		}
	}
}