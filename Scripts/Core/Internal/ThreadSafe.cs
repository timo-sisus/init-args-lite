#if UNITY_EDITOR
using UnityEngine;
using UnityEditor;

namespace Sisus.Init.EditorOnly
{
	/// <summary>
	/// Provides thread safe alternatives to some of Unity's static properties.
	/// </summary>
	public static class ThreadSafe
	{
		private static readonly object threadLock = new();
		private static bool inPlayMode = false;

		/// <summary>
		/// Provides thread safe alternatives to some static properties of <see cref="UnityEngine.Application"/>.
		/// </summary>
		public static class Application
		{
			/// <summary>
			/// Gets a value indicating whether or not the Editor is in Play Mode or not.
			/// <para>
			/// The value of this property is updated during every <see cref="EditorApplication.playModeStateChanged"/>
			/// event to reflect the current state of the Editor.
			/// </para>
			/// <para>
			/// Reading the value of this property is a a thread safe operation and can be used instead of
			/// <see cref="UnityEngine.Application.isPlaying"/> in threaded contexts such as in the constructor
			/// of a <see cref="Component"/> or during <see cref="ISerializationCallbackReceiver"/> events.
			/// </para>
			/// </summary>
			public static bool IsPlaying
			{
				get
				{
					lock(threadLock)
					{
						return inPlayMode;
					}
				}
			}
		}

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void OnEnterPlayMode()
		{
			lock(threadLock)
			{
				inPlayMode = true;
			}

			EditorApplication.playModeStateChanged -= OnPlayModeStateChanged;
			EditorApplication.playModeStateChanged += OnPlayModeStateChanged;
		}

		private static void OnPlayModeStateChanged(PlayModeStateChange state)
		{
			switch(state)
			{
				case PlayModeStateChange.EnteredEditMode:
					lock(threadLock)
					{
						inPlayMode = false;
					}
					break;
				case PlayModeStateChange.ExitingEditMode:
					lock(threadLock)
					{
						inPlayMode = false;
					}
					break;
				case PlayModeStateChange.EnteredPlayMode:
					lock(threadLock)
					{
						inPlayMode = true;
					}
					break;
				case PlayModeStateChange.ExitingPlayMode:
					lock(threadLock)
					{
						inPlayMode = true;
					}
					break;
			}
		}
	}
}
#endif