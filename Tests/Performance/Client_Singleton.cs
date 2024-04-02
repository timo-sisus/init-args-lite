#pragma warning disable IDE0052

using UnityEngine;

namespace Sisus.Init.Tests.Performance
{
	public sealed class Client_Singleton : MonoBehaviour
	{
		Service s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11, s12;

		void Awake()
		{
			s1 = Service.Instance;
			s2 = Service.Instance;
			s3 = Service.Instance;
			s4 = Service.Instance;
			s5 = Service.Instance;
			s6 = Service.Instance;
			s7 = Service.Instance;
			s8 = Service.Instance;
			s9 = Service.Instance;
			s10 = Service.Instance;
			s11 = Service.Instance;
			s12 = Service.Instance;
		}
	}
}
