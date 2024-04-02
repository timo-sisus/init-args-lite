#pragma warning disable CS0649

using System;
using NUnit.Framework;
using Unity.PerformanceTesting;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Sisus.Init.Tests.Performance
{
	public class AddComponent_Performance_Tests
	{
		const int WARMUP_COUNT = 10;
		const int MEASUREMENT_COUNT = 5;
		const int ITERATIONS_PER_MEASUREMENT = 1000;

		GameObject gameObject;
		Service s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11, s12;

		[OneTimeSetUp]
		public void OneTimeSetup()
		{
			s1 = s2 = s3 = s4 = s5 = s6 = s7 = s8 = s9 = s10 = s11 = s12 = Service.Instance;
			gameObject = new GameObject(GetType().Name);
		}

		[TearDown]
		public void TearDown()
		{
			foreach(var component in gameObject.GetComponents<MonoBehaviour>())
			{
				Object.DestroyImmediate(component);
			}
		}

		[OneTimeTearDown]
		public void OneTimeTearDown() => Object.DestroyImmediate(gameObject);

		[Performance, Test]
		public void AddComponent_MonoBehaviour_12_Singleton() => Measure(AddClientSingleton);

		[Performance, Test]
		public void AddComponent_MonoBehaviourT_12_Init_Args() => Measure(AddClientInitArgs);

		void Measure(Action method) => Unity.PerformanceTesting.Measure.Method(method)
			.WarmupCount(WARMUP_COUNT)
			.MeasurementCount(MEASUREMENT_COUNT)
			.IterationsPerMeasurement(ITERATIONS_PER_MEASUREMENT)
			.GC()
			.Run();

		void AddClientSingleton() => gameObject.AddComponent<Client_Singleton>();
		void AddClientInitArgs() => gameObject.AddComponent<Client_MonoBehaviourT, Service, Service, Service, Service, Service, Service, Service, Service, Service, Service, Service, Service>(s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11, s12);
	}
}
