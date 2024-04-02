using NUnit.Framework;
using UnityEngine;
using static UnityEngine.Object;

namespace Sisus.Init.Tests
{
	public class AddComponent_IArgs_ExecuteAlways_Tests
	{
		private GameObject gameObject;

		[SetUp]
		public void SetUp() => gameObject = new(GetType().Name);

		[TearDown]
		public void TearDown() => DestroyImmediate(gameObject);

		[Test]
		public void AddComponent_01_Arg_Works()
		{
			const int INJECTED_COUNT =  1;

			var client = new GameObject().AddComponent<AnyArgsExecuteAlways, int>(1);
			Assert.AreEqual(INJECTED_COUNT, client.receivedDependencies);
			for(int i = 1; i <= INJECTED_COUNT; i++)
			{
				Assert.AreEqual(i, client[i]);
			}

			new GameObject().AddComponent(out client, 1);
			Assert.AreEqual(INJECTED_COUNT, client.receivedDependencies);
			for(int i = 1; i <= INJECTED_COUNT; i++)
			{
				Assert.AreEqual(i, client[i]);
			}
		}

		[Test]
		public void AddComponent_02_Args_Works()
		{
			const int INJECTED_COUNT =  2;

			var client = new GameObject().AddComponent<AnyArgsExecuteAlways, int, int>(1, 2);
			Assert.AreEqual(INJECTED_COUNT, client.receivedDependencies);
			for(int i = 1; i <= INJECTED_COUNT; i++)
			{
				Assert.AreEqual(i, client[i]);
			}

			new GameObject().AddComponent(out client, 1, 2);
			Assert.AreEqual(INJECTED_COUNT, client.receivedDependencies);
			for(int i = 1; i <= INJECTED_COUNT; i++)
			{
				Assert.AreEqual(i, client[i]);
			}
		}

		[Test]
		public void AddComponent_03_Args_Works()
		{
			const int INJECTED_COUNT =  3;

			var client = new GameObject().AddComponent<AnyArgsExecuteAlways, int, int, int>(1, 2, 3);
			Assert.AreEqual(INJECTED_COUNT, client.receivedDependencies);
			for(int i = 1; i <= INJECTED_COUNT; i++)
			{
				Assert.AreEqual(i, client[i]);
			}

			new GameObject().AddComponent(out client, 1, 2, 3);
			Assert.AreEqual(INJECTED_COUNT, client.receivedDependencies);
			for(int i = 1; i <= INJECTED_COUNT; i++)
			{
				Assert.AreEqual(i, client[i]);
			}
		}

		[Test]
		public void AddComponent_04_Args_Works()
		{
			const int INJECTED_COUNT =  4;

			var client = new GameObject().AddComponent<AnyArgsExecuteAlways, int, int, int, int>(1, 2, 3, 4);
			Assert.AreEqual(INJECTED_COUNT, client.receivedDependencies);
			for(int i = 1; i <= INJECTED_COUNT; i++)
			{
				Assert.AreEqual(i, client[i]);
			}

			new GameObject().AddComponent(out client, 1, 2, 3, 4);
			Assert.AreEqual(INJECTED_COUNT, client.receivedDependencies);
			for(int i = 1; i <= INJECTED_COUNT; i++)
			{
				Assert.AreEqual(i, client[i]);
			}
		}

		[Test]
		public void AddComponent_05_Args_Works()
		{
			const int INJECTED_COUNT =  5;

			var client = new GameObject().AddComponent<AnyArgsExecuteAlways, int, int, int, int, int>(1, 2, 3, 4, 5);
			Assert.AreEqual(INJECTED_COUNT, client.receivedDependencies);
			for(int i = 1; i <= INJECTED_COUNT; i++)
			{
				Assert.AreEqual(i, client[i]);
			}

			new GameObject().AddComponent(out client, 1, 2, 3, 4, 5);
			Assert.AreEqual(INJECTED_COUNT, client.receivedDependencies);
			for(int i = 1; i <= INJECTED_COUNT; i++)
			{
				Assert.AreEqual(i, client[i]);
			}
		}

		[Test]
		public void AddComponent_06_Args_Works()
		{
			const int INJECTED_COUNT =  6;

			var client = new GameObject().AddComponent<AnyArgsExecuteAlways, int, int, int, int, int, int>(1, 2, 3, 4, 5, 6);
			Assert.AreEqual(INJECTED_COUNT, client.receivedDependencies);
			for(int i = 1; i <= INJECTED_COUNT; i++)
			{
				Assert.AreEqual(i, client[i]);
			}

			new GameObject().AddComponent(out client, 1, 2, 3, 4, 5, 6);
			Assert.AreEqual(INJECTED_COUNT, client.receivedDependencies);
			for(int i = 1; i <= INJECTED_COUNT; i++)
			{
				Assert.AreEqual(i, client[i]);
			}
		}

		[Test]
		public void AddComponent_07_Args_Works()
		{
			const int INJECTED_COUNT =  7;

			var client = new GameObject().AddComponent<AnyArgsExecuteAlways, int, int, int, int, int, int, int>(1, 2, 3, 4, 5, 6, 7);
			Assert.AreEqual(INJECTED_COUNT, client.receivedDependencies);
			for(int i = 1; i <= INJECTED_COUNT; i++)
			{
				Assert.AreEqual(i, client[i]);
			}

			new GameObject().AddComponent(out client, 1, 2, 3, 4, 5, 6, 7);
			Assert.AreEqual(INJECTED_COUNT, client.receivedDependencies);
			for(int i = 1; i <= INJECTED_COUNT; i++)
			{
				Assert.AreEqual(i, client[i]);
			}
		}

		[Test]
		public void AddComponent_08_Args_Works()
		{
			const int INJECTED_COUNT =  8;

			var client = new GameObject().AddComponent<AnyArgsExecuteAlways, int, int, int, int, int, int, int, int>(1, 2, 3, 4, 5, 6, 7, 8);
			Assert.AreEqual(INJECTED_COUNT, client.receivedDependencies);
			for(int i = 1; i <= INJECTED_COUNT; i++)
			{
				Assert.AreEqual(i, client[i]);
			}

			new GameObject().AddComponent(out client, 1, 2, 3, 4, 5, 6, 7, 8);
			Assert.AreEqual(INJECTED_COUNT, client.receivedDependencies);
			for(int i = 1; i <= INJECTED_COUNT; i++)
			{
				Assert.AreEqual(i, client[i]);
			}
		}

		[Test]
		public void AddComponent_09_Args_Works()
		{
			const int INJECTED_COUNT =  9;

			var client = new GameObject().AddComponent<AnyArgsExecuteAlways, int, int, int, int, int, int, int, int, int>(1, 2, 3, 4, 5, 6, 7, 8, 9);
			Assert.AreEqual(INJECTED_COUNT, client.receivedDependencies);
			for(int i = 1; i <= INJECTED_COUNT; i++)
			{
				Assert.AreEqual(i, client[i]);
			}

			new GameObject().AddComponent(out client, 1, 2, 3, 4, 5, 6, 7, 8, 9);
			Assert.AreEqual(INJECTED_COUNT, client.receivedDependencies);
			for(int i = 1; i <= INJECTED_COUNT; i++)
			{
				Assert.AreEqual(i, client[i]);
			}
		}

		[Test]
		public void AddComponent_10_Args_Works()
		{
			const int INJECTED_COUNT =  10;

			var client = new GameObject().AddComponent<AnyArgsExecuteAlways, int, int, int, int, int, int, int, int, int, int>(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
			Assert.AreEqual(INJECTED_COUNT, client.receivedDependencies);
			for(int i = 1; i <= INJECTED_COUNT; i++)
			{
				Assert.AreEqual(i, client[i]);
			}

			new GameObject().AddComponent(out client, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
			Assert.AreEqual(INJECTED_COUNT, client.receivedDependencies);
			for(int i = 1; i <= INJECTED_COUNT; i++)
			{
				Assert.AreEqual(i, client[i]);
			}
		}

		[Test]
		public void AddComponent_11_Args_Works()
		{
			const int INJECTED_COUNT =  11;

			var client = new GameObject().AddComponent<AnyArgsExecuteAlways, int, int, int, int, int, int, int, int, int, int, int>(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11);
			Assert.AreEqual(INJECTED_COUNT, client.receivedDependencies);
			for(int i = 1; i <= INJECTED_COUNT; i++)
			{
				Assert.AreEqual(i, client[i]);
			}

			new GameObject().AddComponent(out client, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11);
			Assert.AreEqual(INJECTED_COUNT, client.receivedDependencies);
			for(int i = 1; i <= INJECTED_COUNT; i++)
			{
				Assert.AreEqual(i, client[i]);
			}
		}

		[Test]
		public void AddComponent_12_Args_Works()
		{
			const int INJECTED_COUNT =  12;

			var client = new GameObject().AddComponent<AnyArgsExecuteAlways, int, int, int, int, int, int, int, int, int, int, int, int>(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12);
			Assert.AreEqual(INJECTED_COUNT, client.receivedDependencies);
			for(int i = 1; i <= INJECTED_COUNT; i++)
			{
				Assert.AreEqual(i, client[i]);
			}

			new GameObject().AddComponent(out client, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12);
			Assert.AreEqual(INJECTED_COUNT, client.receivedDependencies);
			for(int i = 1; i <= INJECTED_COUNT; i++)
			{
				Assert.AreEqual(i, client[i]);
			}
		}
	}
}