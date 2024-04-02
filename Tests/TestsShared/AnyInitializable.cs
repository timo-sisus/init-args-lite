using System;
using UnityEngine;

namespace Sisus.Init.Tests
{
	public class AnyInitializable : MonoBehaviour
		, IInitializable
		, IInitializable<int>
		, IInitializable<int, int>
		, IInitializable<int, int, int>
		, IInitializable<int, int, int, int>
		, IInitializable<int, int, int, int, int>
		, IInitializable<int, int, int, int, int, int>
		, IInitializable<int, int, int, int, int, int, int>
		, IInitializable<int, int, int, int, int, int, int, int>
		, IInitializable<int, int, int, int, int, int, int, int, int>
		, IInitializable<int, int, int, int, int, int, int, int, int, int>
		, IInitializable<int, int, int, int, int, int, int, int, int, int, int>
		, IInitializable<int, int, int, int, int, int, int, int, int, int, int, int>
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

		public int receivedDependencies = 0;

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

		public bool Init()
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
			receivedDependencies = 0;

			int d1, d2, d3, d4, d5, d6, d7, d8, d9, d10, d11, d12;
			if(InitArgs.TryGet(this, out d1))
			{
				dependency1 = d1;
				receivedDependencies = 1;
				return true;
			}

			if(InitArgs.TryGet(this, out d1, out d2))
			{
				dependency1 = d1;
				dependency2 = d2;
				receivedDependencies = 2;
				return true;
			}

			if(InitArgs.TryGet(this, out d1, out d2, out d3))
			{
				dependency1 = d1;
				dependency2 = d2;
				dependency3 = d3;
				receivedDependencies = 3;
				return true;
			}

			if(InitArgs.TryGet(this, out d1, out d2, out d3, out d4))
			{
				dependency1 = d1;
				dependency2 = d2;
				dependency3 = d3;
				dependency4 = d4;
				receivedDependencies = 4;
				return true;
			}

			if(InitArgs.TryGet(this, out d1, out d2, out d3, out d4, out d5))
			{
				dependency1 = d1;
				dependency2 = d2;
				dependency3 = d3;
				dependency4 = d4;
				dependency5 = d5;
				receivedDependencies = 5;
				return true;
			}

			if(InitArgs.TryGet(this, out d1, out d2, out d3, out d4, out d5, out d6))
			{
				dependency1 = d1;
				dependency2 = d2;
				dependency3 = d3;
				dependency4 = d4;
				dependency5 = d5;
				dependency6 = d6;
				receivedDependencies = 6;
				return true;
			}

			if(InitArgs.TryGet(this, out d1, out d2, out d3, out d4, out d5, out d6, out d7))
			{
				dependency1 = d1;
				dependency2 = d2;
				dependency3 = d3;
				dependency4 = d4;
				dependency5 = d5;
				dependency6 = d6;
				dependency7 = d7;
				receivedDependencies = 7;
				return true;
			}

			if(InitArgs.TryGet(this, out d1, out d2, out d3, out d4, out d5, out d6, out d7, out d8))
			{
				dependency1 = d1;
				dependency2 = d2;
				dependency3 = d3;
				dependency4 = d4;
				dependency5 = d5;
				dependency6 = d6;
				dependency7 = d7;
				dependency8 = d8;
				receivedDependencies = 8;
				return true;
			}

			if(InitArgs.TryGet(this, out d1, out d2, out d3, out d4, out d5, out d6, out d7, out d8, out d9))
			{
				dependency1 = d1;
				dependency2 = d2;
				dependency3 = d3;
				dependency4 = d4;
				dependency5 = d5;
				dependency6 = d6;
				dependency7 = d7;
				dependency8 = d8;
				dependency9 = d9;
				receivedDependencies = 9;
				return true;
			}

			if(InitArgs.TryGet(this, out d1, out d2, out d3, out d4, out d5, out d6, out d7, out d8, out d9, out d10))
			{
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
				receivedDependencies = 10;
				return true;
			}
			
			if(InitArgs.TryGet(this, out d1, out d2, out d3, out d4, out d5, out d6, out d7, out d8, out d9, out d10, out d11))
			{
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
				receivedDependencies = 11;
				return true;
			}

			if(InitArgs.TryGet(this, out d1, out d2, out d3, out d4, out d5, out d6, out d7, out d8, out d9, out d10, out d11, out d12))
			{
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
				receivedDependencies = 12;
				return true;
			}

			return false;
		}

		public void Init(int d1)
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
			receivedDependencies = 1;
		}

		public void Init(int d1, int d2)
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
			receivedDependencies = 2;
		}

		public void Init(int d1, int d2, int d3)
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
			receivedDependencies = 3;
		}

		public void Init(int d1, int d2, int d3, int d4)
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
			receivedDependencies = 4;
		}

		public void Init(int d1, int d2, int d3, int d4, int d5)
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
			receivedDependencies = 5;
		}

		public void Init(int d1, int d2, int d3, int d4, int d5, int d6)
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
			receivedDependencies = 6;
		}

		public void Init(int d1, int d2, int d3, int d4, int d5, int d6, int d7)
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
			receivedDependencies = 7;
		}

		public void Init(int d1, int d2, int d3, int d4, int d5, int d6, int d7, int d8)
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
			receivedDependencies = 8;
		}

		public void Init(int d1, int d2, int d3, int d4, int d5, int d6, int d7, int d8, int d9)
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
			receivedDependencies = 9;
		}

		public void Init(int d1, int d2, int d3, int d4, int d5, int d6, int d7, int d8, int d9, int d10)
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
			receivedDependencies = 10;
		}

		public void Init(int d1, int d2, int d3, int d4, int d5, int d6, int d7, int d8, int d9, int d10, int d11)
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
			receivedDependencies = 11;
		}

		public void Init(int d1, int d2, int d3, int d4, int d5, int d6, int d7, int d8, int d9, int d10, int d11, int d12)
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
			receivedDependencies = 12;
		}
	}
}