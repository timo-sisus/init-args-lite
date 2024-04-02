#pragma warning disable IDE0052

using System.Collections.Generic;

namespace Sisus.Init.Tests.Performance
{
	public sealed class Client_MonoBehaviourT : MonoBehaviour<Service, Service, Service, Service, Service, Service, Service, Service, Service, Service, Service, Service>
	{
		Service s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11, s12;

		protected override void Init(Service s1, Service s2, Service s3, Service s4, Service s5, Service s6, Service s7, Service s8, Service s9, Service s10, Service s11, Service s12)
		{
			this.s1 = s1;
			this.s2 = s2;
			this.s3 = s3;
			this.s4 = s4;
			this.s5 = s5;
			this.s6 = s6;
			this.s7 = s7;
			this.s8 = s8;
			this.s9 = s9;
			this.s10 = s10;
			this.s11 = s11;
			this.s12 = s12;
		}
	}
}