using System;
using NUnit.Framework;
using UnityEngine;
using static UnityEngine.Object;

namespace Sisus.Init.Tests
{
	public class Instantiate_Base_Tests
	{
		[Test]
		public void Instantiate_01_With_Null_Object_Throws_MissingReferenceException()
		{
			AnyInitializable original = null;
			try
			{
				original.Instantiate(1);
				Assert.Fail();
			}
			catch(ArgumentNullException) { }
		}

		[Test]
		public void Instantiate_01_With_Destroyed_Object_Throws_MissingReferenceException()
		{
			AnyInitializable original = new GameObject().AddComponent<AnyInitializable>();
			DestroyImmediate(original);

			try
			{
				original.Instantiate(1);
				Assert.Fail();
			}
			catch(ArgumentNullException) { }
		}

		[Test]
		public void Instantiate_12_With_Null_Object_Throws_MissingReferenceException()
		{
			AnyInitializable original = null;
			try
			{
				original.Instantiate(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12);
				Assert.Fail();
			}
			catch(ArgumentNullException) { }
		}

		[Test]
		public void Instantiate_12_With_Destroyed_Object_Throws_MissingReferenceException()
		{
			AnyInitializable original = new GameObject().AddComponent<AnyInitializable>();
			DestroyImmediate(original);

			try
			{
				original.Instantiate(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12);
				Assert.Fail();
			}
			catch(ArgumentNullException) { }
		}
	}
}