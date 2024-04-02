#pragma warning disable CS0649

using System;
using NUnit.Framework;
using Unity.PerformanceTesting;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Sisus.Init.Tests.Performance
{
	public class Instantiate_Performance_Tests
	{
		const int WARMUP_COUNT = 10;
		const int MEASUREMENT_COUNT = 10;
		const int ITERATIONS_PER_MEASUREMENT = 10000;

		Transform instancesParent;
		Client_MonoBehaviourT clientMonoBehaviourT;
		Client_SerializeField clientSerializedFields;
		Client_Singleton clientSingleton;
		Service s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11, s12;

		[OneTimeSetUp]
		public void OneTimeSetUp()
		{
			instancesParent = new GameObject(GetType().Name).transform;

			clientSerializedFields = new GameObject(GetType().Name).AddComponent<Client_SerializeField>();
			clientMonoBehaviourT = new GameObject(GetType().Name).AddComponent<Client_MonoBehaviourT>();
			clientSingleton = new GameObject(GetType().Name).AddComponent<Client_Singleton>();

			s1 = s2 = s3 = s4 = s5 = s6 = s7 = s8 = s9 = s10 = s11 = s12 = Service.Instance;
		}

		[TearDown]
		public void TearDown()
		{
			foreach(var component in instancesParent.GetComponentsInChildren<MonoBehaviour>())
			{
				Object.DestroyImmediate(component.gameObject);
			}
		}

		[OneTimeTearDown]
		public void OneTimeTearDown()
		{
			Object.DestroyImmediate(clientSerializedFields.gameObject);
			Object.DestroyImmediate(clientMonoBehaviourT.gameObject);
			Object.DestroyImmediate(clientSingleton.gameObject);
		}

		[Performance, Test]
		public void Instantiate_MonoBehaviour_12_Serialized_Fields() => Measure(InstantiateClientSerializedFields);

		[Performance, Test]
		public void Instantiate_MonoBehaviour_12_Singleton() => Measure(InstantiateClientSingleton);

		[Performance, Test]
		public void Instantiate_MonoBehaviourT_12_Init_Args() => Measure(InstantiateClientInitArgs);

		void Measure(Action method) => Unity.PerformanceTesting.Measure.Method(method)
			.WarmupCount(WARMUP_COUNT)
			.MeasurementCount(MEASUREMENT_COUNT)
			.IterationsPerMeasurement(ITERATIONS_PER_MEASUREMENT)
			.GC()
			.Run();

		void InstantiateClientSingleton() => Object.Instantiate(clientSingleton, instancesParent);
		void InstantiateClientSerializedFields() => Object.Instantiate(clientSerializedFields, instancesParent);
		void InstantiateClientInitArgs() => clientMonoBehaviourT.Instantiate(s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11, s12);
	}
}
