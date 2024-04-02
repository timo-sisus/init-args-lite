#pragma warning disable IDE0052


namespace Sisus.Init.Tests.Performance
{
	public abstract class Singleton<T> where T : Singleton<T>, new()
	{
		private static T instance;
		public static T Instance => instance ??= new();
	}
}
