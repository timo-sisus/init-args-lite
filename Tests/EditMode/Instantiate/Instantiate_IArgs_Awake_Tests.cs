using NUnit.Framework;
using UnityEngine;
using static UnityEngine.Object;

namespace Sisus.Init.Tests
{
	public class Instantiate_IArgs_Awake_Tests
	{
		AnyArgsAwake original;

		[SetUp]
		public void SetUp() => original = new GameObject(GetType().Name).AddComponent<AnyArgsAwake>();

		[TearDown]
		public void TearDown() => DestroyImmediate(original.gameObject);

		[Test]
		public void Instantiate_1_Arg_Fails_In_EditMode_With_InitArgumentsNotReceivedException()
		{
			try
			{
				original.Instantiate(1);
			}
			catch(InitArgumentsNotReceivedException)
			{
				return;
			}

			Assert.Fail();
		}

		[Test]
		public void Instantiate_2_Args_Fails_In_EditMode_With_InitArgumentsNotReceivedException()
		{
			try
			{
				original.Instantiate(1, 2);
			}
			catch(InitArgumentsNotReceivedException)
			{
				return;
			}
			Assert.Fail();
		}

		[Test]
		public void Instantiate_3_Args_Fails_In_EditMode_With_InitArgumentsNotReceivedException()
		{
			try
			{
				original.Instantiate(1, 2, 3);
			}
			catch(InitArgumentsNotReceivedException)
			{
				return;
			}

			Assert.Fail();
		}

		[Test]
		public void Instantiate_4_Args_Fails_In_EditMode_With_InitArgumentsNotReceivedException()
		{
			try
			{
				original.Instantiate(1, 2, 3, 4);
			}
			catch(InitArgumentsNotReceivedException)
			{
				return;
			}
			Assert.Fail();
		}

		[Test]
		public void Instantiate_5_Args_Fails_In_EditMode_With_InitArgumentsNotReceivedException()
		{
			try
			{
				original.Instantiate(1, 2, 3, 4, 5);
			}
			catch(InitArgumentsNotReceivedException)
			{
				return;
			}

			Assert.Fail();
		}

		[Test]
		public void Instantiate_6_Args_Fails_In_EditMode_With_InitArgumentsNotReceivedException()
		{
			try
			{
				original.Instantiate(1, 2, 3, 4, 5, 6);
			}
			catch(InitArgumentsNotReceivedException)
			{
				return;
			}

			Assert.Fail();
		}

		[Test]
		public void Instantiate_7_Args_Fails_In_EditMode_With_InitArgumentsNotReceivedException()
		{
			try
			{
				original.Instantiate(1, 2, 3, 4, 5, 6, 7);
			}
			catch(InitArgumentsNotReceivedException)
			{
				return;
			}

			Assert.Fail();
		}

		[Test]
		public void Instantiate_8_Args_Fails_In_EditMode_With_InitArgumentsNotReceivedException()
		{
			try
			{
				original.Instantiate(1, 2, 3, 4, 5, 6, 7, 8);
			}
			catch(InitArgumentsNotReceivedException)
			{
				return;
			}

			Assert.Fail();
		}

		[Test]
		public void Instantiate_9_Args_Fails_In_EditMode_With_InitArgumentsNotReceivedException()
		{
			try
			{
				original.Instantiate(1, 2, 3, 4, 5, 6, 7, 8, 9);
			}
			catch(InitArgumentsNotReceivedException)
			{
				return;
			}

			Assert.Fail();
		}

		[Test]
		public void Instantiate_10_Args_Fails_In_EditMode_With_InitArgumentsNotReceivedException()
		{
			try
			{
				original.Instantiate(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
			}
			catch(InitArgumentsNotReceivedException)
			{
				return;
			}

			Assert.Fail();
		}

		[Test]
		public void Instantiate_11_Args_Fails_In_EditMode_With_InitArgumentsNotReceivedException()
		{
			try
			{
				original.Instantiate(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11);
			}
			catch(InitArgumentsNotReceivedException)
			{
				return;
			}

			Assert.Fail();
		}

		[Test]
		public void Instantiate_12_Args_Fails_In_EditMode_With_InitArgumentsNotReceivedException()
		{
			try
			{
				original.Instantiate(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12);
			}
			catch(InitArgumentsNotReceivedException)
			{
				return;
			}

			Assert.Fail();
		}
	}
}