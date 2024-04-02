#pragma warning disable S1186

using System.Collections.Concurrent;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools.Constraints;
using Is = NUnit.Framework.Is;

namespace Sisus.Init.Tests
{
	public class InitArgs_Allocation_Tests
	{
		const int Capacity = 8;
		ConcurrentDictionary<object, int> concurrentIntDictionary;
		ConcurrentDictionary<object, object> concurrentObjectDictionary;
		Dictionary<object, int> intDictionary;
		Dictionary<object, object> objectDictionary;
		object setKey;
		object setValue;
		object getKey;
		object getValue;
		TestDelegate initArgs_TryGet_1Arg_Delegate;
		TestDelegate concurrentDictionary_Int_Set_Delegate;
		TestDelegate concurrentDictionary_Int_Get_Delegate;
		TestDelegate concurrentDictionary_Object_Set_Delegate;
		TestDelegate concurrentDictionary_Object_Get_Delegate;
		TestDelegate dictionary_Int_Set_Delegate;
		TestDelegate dictionary_Object_Set_Delegate;
		TestDelegate empty_Delegate;
		readonly object threadLock = new();
		static AnyArgsAwake client;

		[SetUp]
		public void SetUp()
		{
			concurrentIntDictionary = new(1, Capacity);
			concurrentObjectDictionary = new(1, Capacity);
			intDictionary = new(Capacity);
			objectDictionary = new(Capacity);
			setKey = new();
			setValue = new();
			getKey = new();
			getValue = new();

			concurrentIntDictionary[getKey] = 1;
			concurrentObjectDictionary[getKey] = getValue;

			InitArgs.Set<AnyArgsAwake, int>(1);
			initArgs_TryGet_1Arg_Delegate = InitArgs_TryGet_1Arg_Method;
			concurrentDictionary_Int_Set_Delegate = ConcurrentDictionary_Int_Set_Method;
			concurrentDictionary_Int_Get_Delegate = ConcurrentDictionary_Int_Get_Method;
			concurrentDictionary_Object_Set_Delegate = ConcurrentDictionary_Object_Set_Method;
			concurrentDictionary_Object_Get_Delegate = ConcurrentDictionary_Object_Get_Method;
			dictionary_Int_Set_Delegate = Dictionary_Int_Set_Method;
			dictionary_Object_Set_Delegate = Dictionary_Object_Set_Method;
			empty_Delegate = EmptyMethod;

			if(client == null)
			{
				client = new GameObject(GetType().Name).AddComponent<AnyArgsAwake>();
			}
		}

		[Test] public void InitArgs_TryGet_1Arg_Does_Not_Allocate() => Assert.That(initArgs_TryGet_1Arg_Delegate, Is.Not.AllocatingGCMemory());
		[Test] public void InitArgs_Set_1Arg_Does_Not_Allocate() => Assert.That(() => InitArgs.Set<AnyArgsAwake, int>(1), Is.Not.AllocatingGCMemory());
		[Test] public void ConcurrentDictionary_Int_Set_Allocates() => Assert.That(concurrentDictionary_Int_Set_Delegate, Is.Not.Not.AllocatingGCMemory());
		[Test] public void ConcurrentDictionary_Object_Set_Allocates() => Assert.That(concurrentDictionary_Object_Set_Delegate, Is.Not.Not.AllocatingGCMemory());

		[Test] public void ConcurrentDictionary_Object_Get_Does_Not_Allocate() => Assert.That(concurrentDictionary_Object_Get_Delegate, Is.Not.AllocatingGCMemory());
		[Test] public void ConcurrentDictionary_Int_Get_Does_Not_Allocate() => Assert.That(concurrentDictionary_Int_Get_Delegate, Is.Not.AllocatingGCMemory());
		[Test] public void Dictionary_Int_Set_Does_Not_Allocate() => Assert.That(dictionary_Int_Set_Delegate, Is.Not.AllocatingGCMemory());
		[Test] public void Dictionary_Object_Set_Does_Not_Allocate() => Assert.That(dictionary_Object_Set_Delegate, Is.Not.AllocatingGCMemory());
		[Test] public void Empty_Delegate_Does_Not_Allocate() => Assert.That(empty_Delegate, Is.Not.AllocatingGCMemory());
		
		void InitArgs_TryGet_1Arg_Method() => InitArgs.TryGet<AnyArgsAwake, int>(client, out _);
		void ConcurrentDictionary_Int_Set_Method() => concurrentIntDictionary[setKey] = 1;
		void ConcurrentDictionary_Object_Set_Method() => concurrentObjectDictionary[setKey] = setValue;
		void ConcurrentDictionary_Int_Get_Method() => concurrentIntDictionary.GetValueOrDefault(getKey);
		void ConcurrentDictionary_Object_Get_Method() => concurrentObjectDictionary.GetValueOrDefault(getKey);

		void Dictionary_Int_Set_Method()
		{
			lock(threadLock)
			{
				intDictionary[setKey] = 1;
			}
		}

		void Dictionary_Object_Set_Method()
		{
			lock(threadLock)
			{
				objectDictionary[setKey] = setValue;
			}
		}

		void EmptyMethod() { }

		[TearDown]
		public void TearDown() => InitArgs.Clear<AnyArgsAwake, int>();
	}
}