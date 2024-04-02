using NUnit.Framework;
using UnityEngine;
using static UnityEngine.Object;

namespace Sisus.Init.Tests
{
	public class AddComponent_MonoBehaviourT_Tests
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

			var client = gameObject.AddComponent<MonoBehaviourT1Impl, int>(1);
			Assert.IsTrue(client.receivedDependencies);
			for(int i = 1; i <= INJECTED_COUNT; i++)
			{
				Assert.AreEqual(i, client[i]);
			}

			DestroyImmediate(client);

			gameObject.AddComponent(out client, 1);
			Assert.IsTrue(client.receivedDependencies);
			for(int i = 1; i <= INJECTED_COUNT; i++)
			{
				Assert.AreEqual(i, client[i]);
			}
		}

		[Test]
		public void AddComponent_02_Args_Works()
		{
			const int INJECTED_COUNT = 2;
			
			var client = gameObject.AddComponent<MonoBehaviourT2Impl, int, int>(1, 2);
			Assert.IsTrue(client.receivedDependencies);
			for(int i = 1; i <= INJECTED_COUNT; i++)
			{
				Assert.AreEqual(i, client[i]);
			}

			DestroyImmediate(client);

			gameObject.AddComponent(out client, 1, 2);
			Assert.IsTrue(client.receivedDependencies);
			for(int i = 1; i <= INJECTED_COUNT; i++)
			{
				Assert.AreEqual(i, client[i]);
			}
		}

		[Test]
		public void AddComponent_03_Args_Works()
		{
			const int INJECTED_COUNT = 3;
			
			var client = gameObject.AddComponent<MonoBehaviourT3Impl, int, int, int>(1, 2, 3);
			Assert.IsTrue(client.receivedDependencies);
			for(int i = 1; i <= INJECTED_COUNT; i++)
			{
				Assert.AreEqual(i, client[i]);
			}

			DestroyImmediate(client);

			gameObject.AddComponent(out client, 1, 2, 3);
			Assert.IsTrue(client.receivedDependencies);
			for(int i = 1; i <= INJECTED_COUNT; i++)
			{
				Assert.AreEqual(i, client[i]);
			}
		}

		[Test]
		public void AddComponent_04_Args_Works()
		{
			const int INJECTED_COUNT = 4;
			
			var client = gameObject.AddComponent<MonoBehaviourT4Impl, int, int, int, int>(1, 2, 3, 4);
			Assert.IsTrue(client.receivedDependencies);
			for(int i = 1; i <= INJECTED_COUNT; i++)
			{
				Assert.AreEqual(i, client[i]);
			}

			DestroyImmediate(client);

			gameObject.AddComponent(out client, 1, 2, 3, 4);
			Assert.IsTrue(client.receivedDependencies);
			for(int i = 1; i <= INJECTED_COUNT; i++)
			{
				Assert.AreEqual(i, client[i]);
			}
		}

		[Test]
		public void AddComponent_05_Args_Works()
		{
			const int INJECTED_COUNT = 5;
			
			var client = gameObject.AddComponent<MonoBehaviourT5Impl, int, int, int, int, int>(1, 2, 3, 4, 5);
			Assert.IsTrue(client.receivedDependencies);
			for(int i = 1; i <= INJECTED_COUNT; i++)
			{
				Assert.AreEqual(i, client[i]);
			}

			DestroyImmediate(client);

			gameObject.AddComponent(out client, 1, 2, 3, 4, 5);
			Assert.IsTrue(client.receivedDependencies);
			for(int i = 1; i <= INJECTED_COUNT; i++)
			{
				Assert.AreEqual(i, client[i]);
			}
		}

		[Test]
		public void AddComponent_06_Args_Works()
		{
			const int INJECTED_COUNT = 6;
			
			var client = gameObject.AddComponent<MonoBehaviourT6Impl, int, int, int, int, int, int>(1, 2, 3, 4, 5, 6);
			Assert.IsTrue(client.receivedDependencies);
			for(int i = 1; i <= INJECTED_COUNT; i++)
			{
				Assert.AreEqual(i, client[i]);
			}

			DestroyImmediate(client);

			gameObject.AddComponent(out client, 1, 2, 3, 4, 5, 6);
			Assert.IsTrue(client.receivedDependencies);
			for(int i = 1; i <= INJECTED_COUNT; i++)
			{
				Assert.AreEqual(i, client[i]);
			}
		}

		[Test]
		public void AddComponent_07_Args_Works()
		{
			const int INJECTED_COUNT = 7;
			
			var client = gameObject.AddComponent<MonoBehaviourT7Impl, int, int, int, int, int, int, int>(1, 2, 3, 4, 5, 6, 7);
			Assert.IsTrue(client.receivedDependencies);
			for(int i = 1; i <= INJECTED_COUNT; i++)
			{
				Assert.AreEqual(i, client[i]);
			}

			DestroyImmediate(client);

			gameObject.AddComponent(out client, 1, 2, 3, 4, 5, 6, 7);
			Assert.IsTrue(client.receivedDependencies);
			for(int i = 1; i <= INJECTED_COUNT; i++)
			{
				Assert.AreEqual(i, client[i]);
			}
		}

		[Test]
		public void AddComponent_08_Args_Works()
		{
			const int INJECTED_COUNT = 8;
			
			var client = gameObject.AddComponent<MonoBehaviourT8Impl, int, int, int, int, int, int, int, int>(1, 2, 3, 4, 5, 6, 7, 8);
			Assert.IsTrue(client.receivedDependencies);
			for(int i = 1; i <= INJECTED_COUNT; i++)
			{
				Assert.AreEqual(i, client[i]);
			}

			DestroyImmediate(client);

			gameObject.AddComponent(out client, 1, 2, 3, 4, 5, 6, 7, 8);
			Assert.IsTrue(client.receivedDependencies);
			for(int i = 1; i <= INJECTED_COUNT; i++)
			{
				Assert.AreEqual(i, client[i]);
			}
		}

		[Test]
		public void AddComponent_09_Args_Works()
		{
			const int INJECTED_COUNT = 9;
			
			var client = gameObject.AddComponent<MonoBehaviourT9Impl, int, int, int, int, int, int, int, int, int>(1, 2, 3, 4, 5, 6, 7, 8, 9);
			Assert.IsTrue(client.receivedDependencies);
			for(int i = 1; i <= INJECTED_COUNT; i++)
			{
				Assert.AreEqual(i, client[i]);
			}

			DestroyImmediate(client);

			gameObject.AddComponent(out client, 1, 2, 3, 4, 5, 6, 7, 8, 9);
			Assert.IsTrue(client.receivedDependencies);
			for(int i = 1; i <= INJECTED_COUNT; i++)
			{
				Assert.AreEqual(i, client[i]);
			}
		}

		[Test]
		public void AddComponent_10_Args_Works()
		{
			const int INJECTED_COUNT = 10;

			var client = gameObject.AddComponent<MonoBehaviourT10Impl, int, int, int, int, int, int, int, int, int, int>(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
			Assert.IsTrue(client.receivedDependencies);
			for(int i = 1; i <= INJECTED_COUNT; i++)
			{
				Assert.AreEqual(i, client[i]);
			}

			DestroyImmediate(client);

			gameObject.AddComponent(out client, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
			Assert.IsTrue(client.receivedDependencies);
			for(int i = 1; i <= INJECTED_COUNT; i++)
			{
				Assert.AreEqual(i, client[i]);
			}
		}

		[Test]
		public void AddComponent_11_Args_Works()
		{
			const int INJECTED_COUNT = 11;

			var client = gameObject.AddComponent<MonoBehaviourT11Impl, int, int, int, int, int, int, int, int, int, int, int>(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11);
			Assert.IsTrue(client.receivedDependencies);
			for(int i = 1; i <= INJECTED_COUNT; i++)
			{
				Assert.AreEqual(i, client[i]);
			}

			DestroyImmediate(client);

			gameObject.AddComponent(out client, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11);
			Assert.IsTrue(client.receivedDependencies);
			for(int i = 1; i <= INJECTED_COUNT; i++)
			{
				Assert.AreEqual(i, client[i]);
			}
		}

		[Test]
		public void AddComponent_12_Args_Works()
		{
			const int INJECTED_COUNT = 12;

			var client = gameObject.AddComponent<MonoBehaviourT12Impl, int, int, int, int, int, int, int, int, int, int, int, int>(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12);
			Assert.IsTrue(client.receivedDependencies);
			for(int i = 1; i <= INJECTED_COUNT; i++)
			{
				Assert.AreEqual(i, client[i]);
			}

			DestroyImmediate(client);

			gameObject.AddComponent(out client, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12);
			Assert.IsTrue(client.receivedDependencies);
			for(int i = 1; i <= INJECTED_COUNT; i++)
			{
				Assert.AreEqual(i, client[i]);
			}
		}
	}
}