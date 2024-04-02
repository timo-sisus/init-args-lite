using System;

namespace Sisus.Init.Tests
{
	public class MonoBehaviourT1Impl : MonoBehaviour<int>
	{
		public int? dependency1;
		public bool receivedDependencies;

		public int this[int index] => index switch
		{
			1 => dependency1.Value,
			_ => throw new IndexOutOfRangeException("index: " + index),
		};

		protected override void Init(int d1)
		{
			dependency1 = null;
			
			dependency1 = d1;
			receivedDependencies = true;
		}
	}

	public class MonoBehaviourT2Impl : MonoBehaviour<int, int>
	{
		public int? dependency1;
		public int? dependency2;
		public bool receivedDependencies;

		public int this[int index] => index switch
		{
			1 => dependency1.Value,
			2 => dependency2.Value,
			_ => throw new IndexOutOfRangeException("index: " + index),
		};

		protected override void Init(int d1, int d2)
		{
			dependency1 = null;
			dependency2 = null;

			dependency1 = d1;
			dependency2 = d2;

			receivedDependencies = true;
		}
	}

	public class MonoBehaviourT3Impl : MonoBehaviour<int, int, int>
	{
		public int? dependency1;
		public int? dependency2;
		public int? dependency3;
		public bool receivedDependencies;

		public int this[int index] => index switch
		{
			1 => dependency1.Value,
			2 => dependency2.Value,
			3 => dependency3.Value,
			_ => throw new IndexOutOfRangeException("index: " + index),
		};

		protected override void Init(int d1, int d2, int d3)
		{
			dependency1 = null;
			dependency2 = null;
			dependency3 = null;

			dependency1 = d1;
			dependency2 = d2;
			dependency3 = d3;

			receivedDependencies = true;
		}
	}

	public class MonoBehaviourT4Impl : MonoBehaviour<int, int, int, int>
	{
		public int? dependency1;
		public int? dependency2;
		public int? dependency3;
		public int? dependency4;
		public bool receivedDependencies;

		public int this[int index] => index switch
		{
			1 => dependency1.Value,
			2 => dependency2.Value,
			3 => dependency3.Value,
			4 => dependency4.Value,
			_ => throw new IndexOutOfRangeException("index: " + index),
		};

		protected override void Init(int d1, int d2, int d3, int d4)
		{
			dependency1 = null;
			dependency2 = null;
			dependency3 = null;
			dependency4 = null;

			dependency1 = d1;
			dependency2 = d2;
			dependency3 = d3;
			dependency4 = d4;

			receivedDependencies = true;
		}
	}

	public class MonoBehaviourT5Impl : MonoBehaviour<int, int, int, int, int>
	{
		public int? dependency1;
		public int? dependency2;
		public int? dependency3;
		public int? dependency4;
		public int? dependency5;
		public bool receivedDependencies;

		public int this[int index] => index switch
		{
			1 => dependency1.Value,
			2 => dependency2.Value,
			3 => dependency3.Value,
			4 => dependency4.Value,
			5 => dependency5.Value,
			_ => throw new IndexOutOfRangeException("index: " + index),
		};

		protected override void Init(int d1, int d2, int d3, int d4, int d5)
		{
			dependency1 = null;
			dependency2 = null;
			dependency3 = null;
			dependency4 = null;
			dependency5 = null;

			dependency1 = d1;
			dependency2 = d2;
			dependency3 = d3;
			dependency4 = d4;
			dependency5 = d5;

			receivedDependencies = true;
		}
	}

	public class MonoBehaviourT6Impl : MonoBehaviour<int, int, int, int, int, int>
	{
		public int? dependency1;
		public int? dependency2;
		public int? dependency3;
		public int? dependency4;
		public int? dependency5;
		public int? dependency6;
		public bool receivedDependencies;

		public int this[int index] => index switch
		{
			1 => dependency1.Value,
			2 => dependency2.Value,
			3 => dependency3.Value,
			4 => dependency4.Value,
			5 => dependency5.Value,
			6 => dependency6.Value,
			_ => throw new IndexOutOfRangeException("index: " + index),
		};

		protected override void Init(int d1, int d2, int d3, int d4, int d5, int d6)
		{
			dependency1 = null;
			dependency2 = null;
			dependency3 = null;
			dependency4 = null;
			dependency5 = null;
			dependency6 = null;

			dependency1 = d1;
			dependency2 = d2;
			dependency3 = d3;
			dependency4 = d4;
			dependency5 = d5;
			dependency6 = d6;

			receivedDependencies = true;
		}
	}

	public class MonoBehaviourT7Impl : MonoBehaviour<int, int, int, int, int, int, int>
	{
		public int? dependency1;
		public int? dependency2;
		public int? dependency3;
		public int? dependency4;
		public int? dependency5;
		public int? dependency6;
		public int? dependency7;
		public bool receivedDependencies;

		public int this[int index] => index switch
		{
			1 => dependency1.Value,
			2 => dependency2.Value,
			3 => dependency3.Value,
			4 => dependency4.Value,
			5 => dependency5.Value,
			6 => dependency6.Value,
			7 => dependency7.Value,
			_ => throw new IndexOutOfRangeException("index: " + index),
		};

		protected override void Init(int d1, int d2, int d3, int d4, int d5, int d6, int d7)
		{
			dependency1 = null;
			dependency2 = null;
			dependency3 = null;
			dependency4 = null;
			dependency5 = null;
			dependency6 = null;
			dependency7 = null;

			dependency1 = d1;
			dependency2 = d2;
			dependency3 = d3;
			dependency4 = d4;
			dependency5 = d5;
			dependency6 = d6;
			dependency7 = d7;

			receivedDependencies = true;
		}
	}

	public class MonoBehaviourT8Impl : MonoBehaviour<int, int, int, int, int, int, int, int>
	{
		public int? dependency1;
		public int? dependency2;
		public int? dependency3;
		public int? dependency4;
		public int? dependency5;
		public int? dependency6;
		public int? dependency7;
		public int? dependency8;
		public bool receivedDependencies;

		public int this[int index] => index switch
		{
			1 => dependency1.Value,
			2 => dependency2.Value,
			3 => dependency3.Value,
			4 => dependency4.Value,
			5 => dependency5.Value,
			6 => dependency6.Value,
			7 => dependency7.Value,
			8 => dependency8.Value,
			_ => throw new IndexOutOfRangeException("index: " + index),
		};

		protected override void Init(int d1, int d2, int d3, int d4, int d5, int d6, int d7, int d8)
		{
			dependency1 = null;
			dependency2 = null;
			dependency3 = null;
			dependency4 = null;
			dependency5 = null;
			dependency6 = null;
			dependency7 = null;
			dependency8 = null;

			dependency1 = d1;
			dependency2 = d2;
			dependency3 = d3;
			dependency4 = d4;
			dependency5 = d5;
			dependency6 = d6;
			dependency7 = d7;
			dependency8 = d8;

			receivedDependencies = true;
		}
	}

	public class MonoBehaviourT9Impl : MonoBehaviour<int, int, int, int, int, int, int, int, int>
	{
		public int? dependency1;
		public int? dependency2;
		public int? dependency3;
		public int? dependency4;
		public int? dependency5;
		public int? dependency6;
		public int? dependency7;
		public int? dependency8;
		public int? dependency9;
		public bool receivedDependencies;

		public int this[int index] => index switch
		{
			1 => dependency1.Value,
			2 => dependency2.Value,
			3 => dependency3.Value,
			4 => dependency4.Value,
			5 => dependency5.Value,
			6 => dependency6.Value,
			7 => dependency7.Value,
			8 => dependency8.Value,
			9 => dependency9.Value,
			_ => throw new IndexOutOfRangeException("index: " + index),
		};

		protected override void Init(int d1, int d2, int d3, int d4, int d5, int d6, int d7, int d8, int d9)
		{
			dependency1 = null;
			dependency2 = null;
			dependency3 = null;
			dependency4 = null;
			dependency5 = null;
			dependency6 = null;
			dependency7 = null;
			dependency8 = null;
			dependency9 = null;

			dependency1 = d1;
			dependency2 = d2;
			dependency3 = d3;
			dependency4 = d4;
			dependency5 = d5;
			dependency6 = d6;
			dependency7 = d7;
			dependency8 = d8;
			dependency9 = d9;

			receivedDependencies = true;
		}
	}

	public class MonoBehaviourT10Impl : MonoBehaviour<int, int, int, int, int, int, int, int, int, int>
	{
		public int? dependency1;
		public int? dependency2;
		public int? dependency3;
		public int? dependency4;
		public int? dependency5;
		public int? dependency6;
		public int? dependency7;
		public int? dependency8;
		public int? dependency9;
		public int? dependency10;
		public bool receivedDependencies;

		public int this[int index] => index switch
		{
			1 => dependency1.Value,
			2 => dependency2.Value,
			3 => dependency3.Value,
			4 => dependency4.Value,
			5 => dependency5.Value,
			6 => dependency6.Value,
			7 => dependency7.Value,
			8 => dependency8.Value,
			9 => dependency9.Value,
			10 => dependency10.Value,
			_ => throw new IndexOutOfRangeException("index: " + index),
		};

		protected override void Init(int d1, int d2, int d3, int d4, int d5, int d6, int d7, int d8, int d9, int d10)
		{
			dependency1 = null;
			dependency2 = null;
			dependency3 = null;
			dependency4 = null;
			dependency5 = null;
			dependency6 = null;
			dependency7 = null;
			dependency8 = null;
			dependency9 = null;
			dependency10 = null;

			dependency1 = d1;
			dependency2 = d2;
			dependency3 = d3;
			dependency4 = d4;
			dependency5 = d5;
			dependency6 = d6;
			dependency7 = d7;
			dependency8 = d8;
			dependency9 = d9;
			dependency10 = d10;

			receivedDependencies = true;
		}
	}

	public class MonoBehaviourT11Impl : MonoBehaviour<int, int, int, int, int, int, int, int, int, int, int>
	{
		public int? dependency1;
		public int? dependency2;
		public int? dependency3;
		public int? dependency4;
		public int? dependency5;
		public int? dependency6;
		public int? dependency7;
		public int? dependency8;
		public int? dependency9;
		public int? dependency10;
		public int? dependency11;
		public bool receivedDependencies;

		public int this[int index] => index switch
		{
			1 => dependency1.Value,
			2 => dependency2.Value,
			3 => dependency3.Value,
			4 => dependency4.Value,
			5 => dependency5.Value,
			6 => dependency6.Value,
			7 => dependency7.Value,
			8 => dependency8.Value,
			9 => dependency9.Value,
			10 => dependency10.Value,
			11 => dependency11.Value,
			_ => throw new IndexOutOfRangeException("index: " + index),
		};

		protected override void Init(int d1, int d2, int d3, int d4, int d5, int d6, int d7, int d8, int d9, int d10, int d11)
		{
			dependency1 = null;
			dependency2 = null;
			dependency3 = null;
			dependency4 = null;
			dependency5 = null;
			dependency6 = null;
			dependency7 = null;
			dependency8 = null;
			dependency9 = null;
			dependency10 = null;
			dependency11 = null;

			dependency1 = d1;
			dependency2 = d2;
			dependency3 = d3;
			dependency4 = d4;
			dependency5 = d5;
			dependency6 = d6;
			dependency7 = d7;
			dependency8 = d8;
			dependency9 = d9;
			dependency10 = d10;
			dependency11 = d11;

			receivedDependencies = true;
		}
	}

	public class MonoBehaviourT12Impl : MonoBehaviour<int, int, int, int, int, int, int, int, int, int, int, int>
	{
		public int? dependency1;
		public int? dependency2;
		public int? dependency3;
		public int? dependency4;
		public int? dependency5;
		public int? dependency6;
		public int? dependency7;
		public int? dependency8;
		public int? dependency9;
		public int? dependency10;
		public int? dependency11;
		public int? dependency12;
		public bool receivedDependencies;

		public int this[int index] => index switch
		{
			1 => dependency1.Value,
			2 => dependency2.Value,
			3 => dependency3.Value,
			4 => dependency4.Value,
			5 => dependency5.Value,
			6 => dependency6.Value,
			7 => dependency7.Value,
			8 => dependency8.Value,
			9 => dependency9.Value,
			10 => dependency10.Value,
			11 => dependency11.Value,
			12 => dependency12.Value,
			_ => throw new IndexOutOfRangeException("index: " + index),
		};

		protected override void Init(int d1, int d2, int d3, int d4, int d5, int d6, int d7, int d8, int d9, int d10, int d11, int d12)
		{
			dependency1 = null;
			dependency2 = null;
			dependency3 = null;
			dependency4 = null;
			dependency5 = null;
			dependency6 = null;
			dependency7 = null;
			dependency8 = null;
			dependency9 = null;
			dependency10 = null;
			dependency11 = null;
			dependency12 = null;

			dependency1 = d1;
			dependency2 = d2;
			dependency3 = d3;
			dependency4 = d4;
			dependency5 = d5;
			dependency6 = d6;
			dependency7 = d7;
			dependency8 = d8;
			dependency9 = d9;
			dependency10 = d10;
			dependency11 = d11;
			dependency12 = d12;

			receivedDependencies = true;
		}
	}
}