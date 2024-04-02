using NUnit.Framework;
using UnityEngine;
using static UnityEngine.Object;

namespace Sisus.Init.Tests
{
	public class AddComponent_IArgs_Awake_Tests
	{
		GameObject gameObject;

		[SetUp]
		public void SetUp() => gameObject = new GameObject(GetType().Name);

		[TearDown]
		public void TearDown() => DestroyImmediate(gameObject);

		[Test]
		public void AddComponent_With_1_Arg_Fails_In_EditMode_With_InitArgumentsNotReceivedException()
		{
			try
			{
				gameObject.AddComponent<AnyArgsAwake, int>(1);
				Assert.Fail();
			}
			catch(InitArgumentsNotReceivedException) { }

			try
			{
				gameObject.AddComponent(out AnyArgsAwake client, 1);
				Assert.Fail();
			}
			catch(InitArgumentsNotReceivedException) { }
		}

		[Test]
		public void Instantiate_With_2_Args_Fails_In_EditMode_With_InitArgumentsNotReceivedException()
		{
			try
			{
				gameObject.AddComponent<AnyArgsAwake, int, int>(1, 2);
				Assert.Fail();
			}
			catch(InitArgumentsNotReceivedException) { }

			try
			{
				gameObject.AddComponent(out AnyArgsAwake client, 1, 2);
				Assert.Fail();
			}
			catch(InitArgumentsNotReceivedException) { }
		}

		[Test]
		public void Instantiate_With_3_Args_Fails_In_EditMode_With_InitArgumentsNotReceivedException()
		{
			try
			{
				gameObject.AddComponent<AnyArgsAwake, int, int, int>(1, 2, 3);
				Assert.Fail();
			}
			catch(InitArgumentsNotReceivedException) { }

			try
			{
				gameObject.AddComponent(out AnyArgsAwake client, 1, 2, 3);
				Assert.Fail();
			}
			catch(InitArgumentsNotReceivedException) { }
		}

		[Test]
		public void Instantiate_With_4_Args_Fails_In_EditMode_With_InitArgumentsNotReceivedException()
		{
			try
			{
				gameObject.AddComponent<AnyArgsAwake, int, int, int, int>(1, 2, 3, 4);
				Assert.Fail();
			}
			catch(InitArgumentsNotReceivedException) { }

			try
			{
				gameObject.AddComponent(out AnyArgsAwake client, 1, 2, 3, 4);
				Assert.Fail();
			}
			catch(InitArgumentsNotReceivedException) { }
		}

		[Test]
		public void Instantiate_With_5_Args_Fails_In_EditMode_With_InitArgumentsNotReceivedException()
		{
			try
			{
				gameObject.AddComponent<AnyArgsAwake, int, int, int, int, int>(1, 2, 3, 4, 5);
				Assert.Fail();
			}
			catch(InitArgumentsNotReceivedException) { }

			try
			{
				gameObject.AddComponent(out AnyArgsAwake client, 1, 2, 3, 4, 5);
				Assert.Fail();
			}
			catch(InitArgumentsNotReceivedException) { }
		}

		[Test]
		public void Instantiate_With_6_Args_Fails_In_EditMode_With_InitArgumentsNotReceivedException()
		{
			try
			{
				gameObject.AddComponent<AnyArgsAwake, int, int, int, int, int, int>(1, 2, 3, 4, 5, 6);
				Assert.Fail();
			}
			catch(InitArgumentsNotReceivedException) { }

			try
			{
				gameObject.AddComponent(out AnyArgsAwake client, 1, 2, 3, 4, 5, 6);
				Assert.Fail();
			}
			catch(InitArgumentsNotReceivedException) { }
		}

		[Test]
		public void Instantiate_With_7_Args_Fails_In_EditMode_With_InitArgumentsNotReceivedException()
		{
			try
			{
				gameObject.AddComponent<AnyArgsAwake, int, int, int, int, int, int, int>(1, 2, 3, 4, 5, 6, 7);
				Assert.Fail();
			}
			catch(InitArgumentsNotReceivedException) { }

			try
			{
				gameObject.AddComponent(out AnyArgsAwake client, 1, 2, 3, 4, 5, 6, 7);
				Assert.Fail();
			}
			catch(InitArgumentsNotReceivedException) { }
		}

		[Test]
		public void Instantiate_With_8_Args_Fails_In_EditMode_With_InitArgumentsNotReceivedException()
		{
			try
			{
				gameObject.AddComponent<AnyArgsAwake, int, int, int, int, int, int, int, int>(1, 2, 3, 4, 5, 6, 7, 8);
				Assert.Fail();
			}
			catch(InitArgumentsNotReceivedException) { }

			try
			{
				gameObject.AddComponent(out AnyArgsAwake client, 1, 2, 3, 4, 5, 6, 7, 8);
				Assert.Fail();
			}
			catch(InitArgumentsNotReceivedException) { }
		}

		[Test]
		public void Instantiate_With_9_Args_Fails_In_EditMode_With_InitArgumentsNotReceivedException()
		{
			try
			{
				gameObject.AddComponent<AnyArgsAwake, int, int, int, int, int, int, int, int, int>(1, 2, 3, 4, 5, 6, 7, 8, 9);
				Assert.Fail();
			}
			catch(InitArgumentsNotReceivedException) { }

			try
			{
				gameObject.AddComponent(out AnyArgsAwake client, 1, 2, 3, 4, 5, 6, 7, 8, 9);
				Assert.Fail();
			}
			catch(InitArgumentsNotReceivedException) { }
		}

		[Test]
		public void Instantiate_With_10_Args_Fails_In_EditMode_With_InitArgumentsNotReceivedException()
		{
			try
			{
				gameObject.AddComponent<AnyArgsAwake, int, int, int, int, int, int, int, int, int, int>(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
				Assert.Fail();
			}
			catch(InitArgumentsNotReceivedException) { }

			try
			{
				gameObject.AddComponent(out AnyArgsAwake client, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
				Assert.Fail();
			}
			catch(InitArgumentsNotReceivedException) { }
		}

		[Test]
		public void Instantiate_With_11_Args_Fails_In_EditMode_With_InitArgumentsNotReceivedException()
		{
			try
			{
				gameObject.AddComponent<AnyArgsAwake, int, int, int, int, int, int, int, int, int, int, int>(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11);
				Assert.Fail();
			}
			catch(InitArgumentsNotReceivedException) { }

			try
			{
				gameObject.AddComponent(out AnyArgsAwake client, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11);
				Assert.Fail();
			}
			catch(InitArgumentsNotReceivedException) { }
		}

		[Test]
		public void Instantiate_With_12_Args_Fails_In_EditMode_With_InitArgumentsNotReceivedException()
		{
			try
			{
				gameObject.AddComponent<AnyArgsAwake, int, int, int, int, int, int, int, int, int, int, int, int>(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12);
				Assert.Fail();
			}
			catch(InitArgumentsNotReceivedException) { }

			try
			{
				gameObject.AddComponent(out AnyArgsAwake client, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12);
				Assert.Fail();
			}
			catch(InitArgumentsNotReceivedException) { }
		}
	}
}