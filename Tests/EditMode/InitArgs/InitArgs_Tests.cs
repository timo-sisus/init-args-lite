using NUnit.Framework;
using UnityEngine;
using static UnityEngine.Object;

namespace Sisus.Init.Tests
{
	public class InitArgs_Tests
	{
		private AnyInitializable client;

		[OneTimeSetUp]
		public void SetUp() => client = new GameObject(GetType().Name).AddComponent<AnyInitializable>();

		[OneTimeTearDown]
		public void TearDown() => DestroyImmediate(client.gameObject);

		[Test]
		public void InitArgs_01_Arg_Clear_Returns_False_If_No_Arguments_Injected()
		{
			InitArgs.Clear<AnyInitializable, int>();
			
			bool unreceivedArgumentsWereCleared1 = InitArgs.Clear<AnyInitializable, int>();
			InitArgs.TryGet<AnyInitializable, int>(client, out _);
			bool unreceivedArgumentsWereCleared2 = InitArgs.Clear<AnyInitializable, int>();
			
			Assert.IsFalse(unreceivedArgumentsWereCleared1);
			Assert.IsFalse(unreceivedArgumentsWereCleared2);
		}

		[Test]
		public void InitArgs_01_Arg_Clear_Returns_True_If_Arguments_Were_Not_Received()
		{
			InitArgs.Set<AnyInitializable, int>(1);

			bool unreceivedArgumentsWereCleared = InitArgs.Clear<AnyInitializable, int>();

			Assert.IsTrue(unreceivedArgumentsWereCleared);
		}

		[Test]
		public void InitArgs_01_Arg_Clear_Returns_False_If_Arguments_Were_Received()
		{
			const int INJECTED_COUNT = 1;
			var foundArgs = new int[INJECTED_COUNT];
			InitArgs.Set<AnyInitializable, int>(1);
			InitArgs.TryGet(client, out foundArgs[0]);

			bool unreceivedArgumentsWereCleared = InitArgs.Clear<AnyInitializable, int>();

			Assert.IsFalse(unreceivedArgumentsWereCleared);
		}

		[Test]
		public void InitArgs_01_Arg_TryGet_Receives_Arguments_Injected_Using_Set()
		{
			const int INJECTED_COUNT = 1;
			var foundArgs = new int[INJECTED_COUNT];

			InitArgs.Set<AnyInitializable, int>(1);
			bool wereArgumentsFound = InitArgs.TryGet(client, out foundArgs[0]);

			Assert.IsTrue(wereArgumentsFound);
			for(int i = 1; i <= INJECTED_COUNT; i++)
			{
				Assert.AreEqual(i, foundArgs[i - 1]);
			}

			InitArgs.Clear<AnyInitializable, int>();
		}

		[Test]
		public void InitArgs_01_Arg_TryGet_Returns_False_After_Clear()
		{
			InitArgs.Set<AnyInitializable, int>(1);
			InitArgs.Clear<AnyInitializable, int>();
			bool wereArgumentsFound = InitArgs.TryGet<AnyInitializable, int>(client, out _);
			
			Assert.IsFalse(wereArgumentsFound);
		}





		[Test]
		public void InitArgs_12_Arg_Clear_Returns_False_If_No_Arguments_Injected()
		{
			InitArgs.Clear<AnyInitializable, int, int, int, int, int, int, int, int, int, int, int, int>();
			
			bool unreceivedArgumentsWereCleared1 = InitArgs.Clear<AnyInitializable, int, int, int, int, int, int, int, int, int, int, int, int>();
			InitArgs.TryGet<AnyInitializable, int, int, int, int, int, int, int, int, int, int, int, int>(client, out _, out _, out _, out _, out _, out _, out _, out _, out _, out _, out _, out _);
			bool unreceivedArgumentsWereCleared2 = InitArgs.Clear<AnyInitializable, int, int, int, int, int, int, int, int, int, int, int, int>();
			
			Assert.IsFalse(unreceivedArgumentsWereCleared1);
			Assert.IsFalse(unreceivedArgumentsWereCleared2);
		}

		[Test]
		public void InitArgs_12_Arg_Clear_Returns_True_If_Arguments_Were_Not_Received()
		{
			InitArgs.Set<AnyInitializable, int, int, int, int, int, int, int, int, int, int, int, int>(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12);

			bool unreceivedArgumentsWereCleared = InitArgs.Clear<AnyInitializable, int, int, int, int, int, int, int, int, int, int, int, int>();

			Assert.True(unreceivedArgumentsWereCleared);
		}

		[Test]
		public void InitArgs_12_Arg_Clear_Returns_False_If_Arguments_Were_Received()
		{
			InitArgs.Set<AnyInitializable, int, int, int, int, int, int, int, int, int, int, int, int>(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12);
			InitArgs.TryGet<AnyInitializable, int, int, int, int, int, int, int, int, int, int, int, int>(client, out _, out _, out _, out _, out _, out _, out _, out _, out _, out _, out _, out _);

			bool unreceivedArgumentsWereCleared = InitArgs.Clear<AnyInitializable, int, int, int, int, int, int, int, int, int, int, int, int>();

			Assert.IsFalse(unreceivedArgumentsWereCleared);
		}

		[Test]
		public void InitArgs_12_Arg_TryGet_Receives_Arguments_Injected_Using_Set()
		{
			const int INJECTED_COUNT = 12;
			var foundArgs = new int[INJECTED_COUNT];

			InitArgs.Set<AnyInitializable, int, int, int, int, int, int, int, int, int, int, int, int>(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12);
			bool wereArgumentsFound = InitArgs.TryGet(client, out foundArgs[0], out foundArgs[1], out foundArgs[2], out foundArgs[3], out foundArgs[4], out foundArgs[5], out foundArgs[6], out foundArgs[7], out foundArgs[8], out foundArgs[9], out foundArgs[10], out foundArgs[11]);

			Assert.IsTrue(wereArgumentsFound);
			for(int i = 1; i <= INJECTED_COUNT; i++)
			{
				Assert.AreEqual(i, foundArgs[i - 1]);
			}

			InitArgs.Clear<AnyInitializable, int, int, int, int, int, int, int, int, int, int, int, int>();
		}

		[Test]
		public void InitArgs_12_Arg_TryGet_Returns_False_After_Clear()
		{
			InitArgs.Set<AnyInitializable, int, int, int, int, int, int, int, int, int, int, int, int>(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12);
			InitArgs.Clear<AnyInitializable, int, int, int, int, int, int, int, int, int, int, int, int>();
			bool wereArgumentsFound = InitArgs.TryGet<AnyInitializable, int, int, int, int, int, int, int, int, int, int, int, int>(client, out _, out _, out _, out _, out _, out _, out _, out _, out _, out _, out _, out _);
			
			Assert.IsFalse(wereArgumentsFound);

			InitArgs.Clear<AnyInitializable, int, int, int, int, int, int, int, int, int, int, int, int>();
		}
	}
}
