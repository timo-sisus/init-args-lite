using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Sisus.Init.Internal;
using UnityEngine;
using Debug = UnityEngine.Debug;

namespace Sisus.Init
{
	/// <summary>
	/// A base class for <see cref="MonoBehaviour">MonoBehaviours</see> that can be
	/// <see cref="InstantiateExtensions.Instantiate{TComponent, TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument, TSeventhArgument, TEighthArgument, TNinthArgument, TTenthArgument, TEleventhArgument}">instantiated</see>
	/// or <see cref="AddComponentExtensions.AddComponent{TComponent, TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument, TSeventhArgument, TEighthArgument, TNinthArgument, TTenthArgument, TEleventhArgument}">added</see>
	/// to a <see cref="GameObject"/> with eleven arguments passed to the <see cref="Init"/> function of the created instance.
	/// <para>
	/// Instances of classes inheriting from <see cref="MonoBehaviour{TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument, TSeventhArgument, TEighthArgument, TNinthArgument, TTenthArgument, TEleventhArgument}"/>
	/// receive the arguments via the <see cref="Init"/> method where they can be assigned to member fields or properties.
	/// </para>
	/// </summary>
	/// <typeparam name="TFirstArgument"> Type of the first argument received in the <see cref="Init"/> function. </typeparam>
	/// <typeparam name="TSecondArgument"> Type of the second argument received in the <see cref="Init"/> function. </typeparam>
	/// <typeparam name="TThirdArgument"> Type of the third argument received in the <see cref="Init"/> function. </typeparam>
	/// <typeparam name="TFourthArgument"> Type of the fourth argument received in the <see cref="Init"/> function. </typeparam>
	/// <typeparam name="TFifthArgument"> Type of the fifth argument received in the <see cref="Init"/> function. </typeparam>
	/// <typeparam name="TSixthArgument"> Type of the sixth argument received in the <see cref="Init"/> function. </typeparam>
	/// <typeparam name="TSeventhArgument"> Type of the seventh argument received in the <see cref="Init"/> function. </typeparam>
	/// <typeparam name="TEighthArgument"> Type of the eighth argument received in the <see cref="Init"/> function. </typeparam>
	/// <typeparam name="TNinthArgument"> Type of the ninth argument received in the <see cref="Init"/> function. </typeparam>
	/// <typeparam name="TTenthArgument"> Type of the tenth argument received in the <see cref="Init"/> function. </typeparam>
	/// <typeparam name="TEleventhArgument"> Type of the eleventh argument received in the <see cref="Init"/> function. </typeparam>
	public abstract class MonoBehaviour<TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument, TSeventhArgument, TEighthArgument, TNinthArgument, TTenthArgument, TEleventhArgument> : MonoBehaviour, IInitializable<TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument, TSeventhArgument, TEighthArgument, TNinthArgument, TTenthArgument, TEleventhArgument>, IInitializable
	{
		private InitState initState;

		/// <summary>
		/// Provides the <see cref="Component"/> with the objects that it depends on.
		/// <para>
		/// You can think of the <see cref="Init"/> function as a parameterized constructor alternative for the component.
		/// </para>
		/// <para>
		/// <see cref="Init"/> gets called when the script is being loaded, before the <see cref="OnAwake"/>, OnEnable and Start events when
		/// the component is created using <see cref="InstantiateExtensions.Instantiate{TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument, TSeventhArgument, TEighthArgument, TNinthArgument, TTenthArgument, TEleventhArgument}"/> or
		/// <see cref="AddComponentExtensions.AddComponent{TComponent, TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument, TSeventhArgument, TEighthArgument, TNinthArgument, TTenthArgument, TEleventhArgument}}"/>.
		/// </para>
		/// <para>
		/// Note that <see cref="Init"/> gets called immediately following object creation even if the <see cref="GameObject"/> to which the component
		/// was added is <see cref="GameObject.activeInHierarchy">inactive</see> unlike some other initialization event functions such as Awake and OnEnable.
		/// </para>
		/// </summary>
		/// <param name="firstArgument"> The first object that this component depends on. </param>
		/// <param name="secondArgument"> The second object that this component depends on. </param>
		/// <param name="thirdArgument"> The third object that this component depends on. </param>
		/// <param name="fourthArgument"> The fourth object that this component depends on. </param>
		/// <param name="fifthArgument"> The fifth object that this component depends on. </param>
		/// <param name="sixthArgument"> The sixth object that this component depends on. </param>
		/// <param name="seventhArgument"> The seventh object that this component depends on. </param>
		/// <param name="eighthArgument"> The eighth object that this component depends on. </param>
		/// <param name="ninthArgument"> The ninth object that this component depends on. </param>
		/// <param name="tenthArgument"> The tenth object that this component depends on. </param>
		/// <param name="eleventhArgument"> The eleventh object that this component depends on. </param>
		protected abstract void Init(TFirstArgument firstArgument, TSecondArgument secondArgument, TThirdArgument thirdArgument, TFourthArgument fourthArgument, TFifthArgument fifthArgument, TSixthArgument sixthArgument, TSeventhArgument seventhArgument, TEighthArgument eighthArgument, TNinthArgument ninthArgument, TTenthArgument tenthArgument, TEleventhArgument eleventhArgument);

		/// <summary>
		/// A value against which any <see cref="object"/> can be compared to determine whether or not it is
		/// <see langword="null"/> or an <see cref="Object"/> which has been <see cref="Object.Destroy">destroyed</see>.
		/// <example>
		/// <code>
		/// private IEvent trigger;
		/// 
		///	private void OnDisable()
		///	{
		///		if(trigger != Null)
		///		{
		///			trigger.RemoveListener(this);
		///		}
		///	}
		/// </code>
		/// </example>
		/// </summary>
		[NotNull]
		protected static NullExtensions.NullComparer Null => NullExtensions.Null;

		/// <summary>
		/// <see cref="OnAwake"/> is called when the script instance is being loaded during the <see cref="Awake"/> event after the <see cref="Init"/> function has finished.
		/// <para>
		/// <see cref="OnAwake"/> is called either when an active <see cref="GameObject"/> that contains the script is initialized when a <see cref="UnityEngine.SceneManagement.Scene">Scene</see> loads,
		/// or when a previously <see cref="GameObject.activeInHierarchy">inactive</see> <see cref="GameObject"/> is set active, or after a <see cref="GameObject"/> created with <see cref="Object.Instantiate"/>
		/// is initialized.
		/// </para>
		/// <para>
		/// Unity calls <see cref="OnAwake"/> only once during the lifetime of the script instance. A script's lifetime lasts until the Scene that contains it is unloaded.
		/// If the Scene is loaded again, Unity loads the script instance again, so <see cref="OnAwake"/> will be called again.
		/// If the Scene is loaded multiple times additively, Unity loads several script instances, so <see cref="OnAwake"/> will be called several times (once on each instance).
		/// </para>
		/// <para>
		/// For active <see cref="GameObject">GameObjects</see> placed in a Scene, Unity calls <see cref="OnAwake"/> after all active <see cref="GameObject">GameObjects</see>
		/// in the Scene are initialized, so you can safely use methods such as <see cref="GameObject.FindWithTag"/> to query other <see cref="GameObject">GameObjects</see>.
		/// </para>
		/// <para>
		/// The order that Unity calls each <see cref="GameObject"/>'s Awake (and by extension <see cref="OnAwake"/>) is not deterministic.
		/// Because of this, you should not rely on one <see cref="GameObject"/>'s Awake being called before or after another
		/// (for example, you should not assume that a reference assigned by one GameObject's <see cref="OnAwake"/> will be usable in another GameObject's <see cref="Awake"/>).
		/// Instead, you should use <see cref="Awake"/>/<see cref="OnAwake"/> to set up references between scripts, and use Start, which is called after all <see cref="Awake"/>
		/// and <see cref="OnAwake"/> calls are finished, to pass any information back and forth.
		/// </para>
		/// <para>
		/// <see cref="OnAwake"/> is always called before any Start functions. This allows you to order initialization of scripts.
		/// <see cref="OnAwake"/> is called even if the script is a disabled component of an active GameObject.
		/// <see cref="OnAwake"/> can not act as a coroutine.
		/// </para>
		/// <para>
		/// Note: Use <see cref="OnAwake"/> instead of the constructor for initialization, as the serialized state of the <see cref="Component"/> is undefined at construction time.
		/// </para>
		/// </summary>
		protected virtual void OnAwake() { }

		private protected void Awake()
		{
			if(initState == InitState.Uninitialized)
			{
				Init();
			}

			OnAwake();
		}

		bool IInitializable.Init() => Init();

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private bool Init()
		{
			if(!InitArgs.TryGet(this, out TFirstArgument firstArgument, out TSecondArgument secondArgument, out TThirdArgument thirdArgument, out TFourthArgument fourthArgument, out TFifthArgument fifthArgument, out TSixthArgument sixthArgument, out TSeventhArgument seventhArgument, out TEighthArgument eighthArgument, out TNinthArgument ninthArgument, out TTenthArgument tenthArgument, out TEleventhArgument eleventhArgument))
			{
				return false;
			}

			initState = InitState.Initializing;

			ValidateArgumentsIfPlayMode(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, sixthArgument, seventhArgument, eighthArgument, ninthArgument, tenthArgument, eleventhArgument);

			Init(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, sixthArgument, seventhArgument, eighthArgument, ninthArgument, tenthArgument, eleventhArgument);

			initState = InitState.Initialized;

			return true;
		}

		/// <inheritdoc/>
		void IInitializable<TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument, TSeventhArgument, TEighthArgument, TNinthArgument, TTenthArgument, TEleventhArgument>
			.Init(TFirstArgument firstArgument, TSecondArgument secondArgument, TThirdArgument thirdArgument, TFourthArgument fourthArgument, TFifthArgument fifthArgument, TSixthArgument sixthArgument, TSeventhArgument seventhArgument, TEighthArgument eighthArgument, TNinthArgument ninthArgument, TTenthArgument tenthArgument, TEleventhArgument eleventhArgument)
		{
			initState = InitState.Initializing;

			ValidateArgumentsIfPlayMode(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, sixthArgument, seventhArgument, eighthArgument, ninthArgument, tenthArgument, eleventhArgument);

			Init(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, sixthArgument, seventhArgument, eighthArgument, ninthArgument, tenthArgument, eleventhArgument);

			initState = InitState.Initialized;
		}

		/// <summary>
		/// Identical to <see cref="Init(TArgument)"/>, but non-virtual, so slightly faster.
		/// </summary>
		internal void InitInternal(TFirstArgument firstArgument, TSecondArgument secondArgument, TThirdArgument thirdArgument, TFourthArgument fourthArgument, TFifthArgument fifthArgument, TSixthArgument sixthArgument, TSeventhArgument seventhArgument, TEighthArgument eighthArgument, TNinthArgument ninthArgument, TTenthArgument tenthArgument, TEleventhArgument eleventhArgument)
		{
			initState = InitState.Initializing;

			ValidateArgumentsIfPlayMode(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, sixthArgument, seventhArgument, eighthArgument, ninthArgument, tenthArgument, eleventhArgument);

			Init(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, sixthArgument, seventhArgument, eighthArgument, ninthArgument, tenthArgument, eleventhArgument);

			initState = InitState.Initialized;
		}

		/// <summary>
		/// Method that can be overridden and used to validate the initialization arguments that were received by this object.
		/// <para>
		/// You can use the <see cref="ThrowIfNull"/> method to throw an <see cref="ArgumentNullException"/>
		/// if an argument is <see cref="Null">null</see>.
		/// <example>
		/// <code>
		/// protected override void ValidateArguments(IInputManager inputManager, Camera camera)
		/// {
		///		ThrowIfNull(inputManager);
		///		ThrowIfNull(camera);
		/// }
		/// </code>
		/// </example>
		/// </para>
		/// <para>
		/// You can use the <see cref="AssertNotNull"/> method to log an assertion to the Console
		/// if an argument is <see cref="Null">null</see>.
		/// <example>
		/// <code>
		/// protected override void ValidateArguments(IInputManager inputManager, Camera camera)
		/// {
		///		AssertNotNull(inputManager);
		///		AssertNotNull(camera);
		/// }
		/// </code>
		/// </example>
		/// </para>
		/// <para>
		/// Calls to this method are ignored in non-development builds.
		/// </para>
		/// </summary>
		/// <param name="firstArgument"> The first received argument to validate. </param>
		/// <param name="secondArgument"> The second received argument to validate. </param>
		/// <param name="thirdArgument"> The third received argument to validate. </param>
		/// <param name="fourthArgument"> The fourth received argument to validate. </param>
		/// <param name="fifthArgument"> The fifth received argument to validate. </param>
		/// <param name="sixthArgument"> The sixth received argument to validate. </param>
		/// <param name="seventhArgument"> The seventh received argument to validate. </param>
		/// <param name="eighthArgument"> The eighth received argument to validate. </param>
		/// <param name="ninthArgument"> The ninth received argument to validate. </param>
		/// <param name="tenthArgument"> The tenth received argument to validate. </param>
		/// <param name="eleventhArgument"> The eleventh received argument to validate. </param>
		[Conditional("DEBUG")]
		protected virtual void ValidateArguments(TFirstArgument firstArgument, TSecondArgument secondArgument, TThirdArgument thirdArgument, TFourthArgument fourthArgument, TFifthArgument fifthArgument, TSixthArgument sixthArgument, TSeventhArgument seventhArgument, TEighthArgument eighthArgument, TNinthArgument ninthArgument, TTenthArgument tenthArgument, TEleventhArgument eleventhArgument) { }

		/// <summary>
		/// Checks if the <paramref name="argument"/> is <see langword="null"/> and throws an <see cref="ArgumentNullException"/> if it is.
		/// <para>
		/// This method call is ignored in non-development builds.
		/// </para>
		/// </summary>
		/// <param name="argument"> The argument to test. </param>
		[Conditional("DEBUG")]
		protected void ThrowIfNull<TArgument>(TArgument argument, [CallerMemberName] string memberName = "") where TArgument : class
		{
			#if DEBUG
			if(argument == Null) throw new ArgumentNullException(memberName, $"Init argument '{memberName}' of type {typeof(TArgument).Name} passed to {GetType().Name} was null.");
			#endif
		}

		/// <summary>
		/// Checks if the <paramref name="argument"/> is <see langword="null"/> and logs an assertion message to the console if it is.
		/// <para>
		/// This method call is ignored in non-development builds.
		/// </para>
		/// </summary>
		/// <param name="argument"> The argument to test. </param>
		[Conditional("DEBUG")]
		protected void AssertNotNull<TArgument>(TArgument argument, [CallerMemberName] string memberName = "") where TArgument : class
		{
			#if DEBUG
			if(argument == Null) Debug.LogAssertion($"Init argument '{memberName}' of type {typeof(TArgument).Name} passed to {GetType().Name} was null.", this);
			#endif
		}

		[Conditional("DEBUG")]
		private void ValidateArgumentsIfPlayMode(TFirstArgument firstArgument, TSecondArgument secondArgument, TThirdArgument thirdArgument, TFourthArgument fourthArgument, TFifthArgument fifthArgument, TSixthArgument sixthArgument, TSeventhArgument seventhArgument, TEighthArgument eighthArgument, TNinthArgument ninthArgument, TTenthArgument tenthArgument, TEleventhArgument eleventhArgument)
		{
			#if UNITY_EDITOR
			if(!EditorOnly.ThreadSafe.Application.IsPlaying)
			{
				return;
			}
			#endif

			ValidateArguments(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, sixthArgument, seventhArgument, eighthArgument, ninthArgument, tenthArgument, eleventhArgument);
		}
	}
}