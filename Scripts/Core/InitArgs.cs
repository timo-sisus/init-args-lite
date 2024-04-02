using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Object = UnityEngine.Object;

namespace Sisus.Init
{
	/// <summary>
	/// Utility class containing methods related to providing and retrieving arguments for objects that implement
	/// one of the <see cref="IArgs{}">IArgs</see> interfaces such as <see cref="MonoBehaviour{TArgument}"/>.
	/// </summary>
	public static class InitArgs
	{
		/// <summary>
		/// Provides an argument for use with initializing a client of type <typeparamref name="TClient"/>.
		/// <para>
		/// The argument can be retrieved by the initializing object during any phase of initialization using the
		/// <see cref="TryGet{TClient, TArgument}"/> function.
		/// </para>
		/// <para>
		/// Once the argument has been received it can be cleared from the temporary argument cache using <see cref="Clear{TClient, TArgument}"/>.
		/// </para>
		/// <para>
		/// The <typeparamref name="TClient"/> must implement the <see cref="IArgs{TArgument}"/> interface in order for it to be used with this function.
		/// </para>
		/// </summary>
		/// <typeparam name="TClient"> The type of the client that will receive the argument. </typeparam>
		/// <typeparam name="TArgument"> The type of the argument. </typeparam>
		/// <param name="argument"> The argument provided for the <typeparamref name="TClient"/>. </param>
		public static void Set<TClient, TArgument>(TArgument argument) where TClient : IArgs<TArgument> => Arg<TArgument>.arg[typeof(TClient)] = new(argument, received: false);

		/// <summary>
		/// Provides two arguments for use with initializing a client of type <typeparamref name="TClient"/>.
		/// <para>
		/// The arguments can be retrieved by the initializing object during any phase of initialization using the
		/// <see cref="TryGet{TClient, TFirstArgument, TSecondArgument}"/> function.
		/// </para>
		/// <para>
		/// Once the arguments have been received it can be cleared from the temporary argument cache using
		/// <see cref="Clear{TClient, TFirstArgument, TSecondArgument}"/>.
		/// </para>
		/// <para>
		/// The <typeparamref name="TClient"/> must implement the <see cref="IArgs{TFirstArgument, TSecondArgument}"/> interface in order for it to be used with this function.
		/// </para>
		/// </summary>
		/// <typeparam name="TClient"> The type of the client that will receive the arguments. </typeparam>
		/// <typeparam name="TFirstArgument"> The type of the first argument. </typeparam>
		/// <typeparam name="TSecondArgument"> The type of the second argument. </typeparam>
		/// <param name="firstArgument"> The first argument provided for the <typeparamref name="TClient"/>. </param>
		/// <param name="secondArgument"> The second argument provided for the <typeparamref name="TClient"/>. </param>
		public static void Set<TClient, TFirstArgument, TSecondArgument>(TFirstArgument firstArgument, TSecondArgument secondArgument)
			where TClient : IArgs<TFirstArgument, TSecondArgument>
				=> Args<TFirstArgument, TSecondArgument>.args[typeof(TClient)]
					= new(firstArgument, secondArgument, received: false);

		/// <summary>
		/// Provides three arguments for use with initializing a client of type <typeparamref name="TClient"/>.
		/// <para>
		/// The arguments can be retrieved by the initializing object during any phase of initialization using the
		/// <see cref="TryGet{TClient, TFirstArgument, TSecondArgument, TThirdArgument}"/> function.
		/// </para>
		/// <para>
		/// Once the arguments have been received it can be cleared from the temporary argument cache using
		/// <see cref="Clear{TClient, TFirstArgument, TSecondArgument, TThirdArgument}"/>.
		/// </para>
		/// <para>
		/// The <typeparamref name="TClient"/> must implement the <see cref="IArgs{TFirstArgument, TSecondArgument, TThirdArgument}"/> interface in order for it to be used with this function.
		/// </para>
		/// </summary>
		/// <typeparam name="TClient"> The type of the client that will receive the arguments. </typeparam>
		/// <typeparam name="TFirstArgument"> The type of the first argument. </typeparam>
		/// <typeparam name="TSecondArgument"> The type of the second argument. </typeparam>
		/// <typeparam name="TThirdArgument"> The type of the third argument. </typeparam>
		/// <param name="firstArgument"> The first argument provided for the <typeparamref name="TClient"/>. </param>
		/// <param name="secondArgument"> The second argument provided for the <typeparamref name="TClient"/>. </param>
		/// <param name="thirdArgument"> The third  argument provided for the <typeparamref name="TClient"/>. </param>
		public static void Set<TClient, TFirstArgument, TSecondArgument, TThirdArgument>
			(TFirstArgument firstArgument, TSecondArgument secondArgument, TThirdArgument thirdArgument)
				where TClient : IArgs<TFirstArgument, TSecondArgument, TThirdArgument>
					=> Args<TFirstArgument, TSecondArgument, TThirdArgument>.args[typeof(TClient)]
						= new(firstArgument, secondArgument, thirdArgument, received: false);

		/// <summary>
		/// Provides four arguments for use with initializing a client of type <typeparamref name="TClient"/>.
		/// <para>
		/// The arguments can be retrieved by the initializing object during any phase of initialization using the
		/// <see cref="TryGet{TClient, TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument}"/> function.
		/// </para>
		/// <para>
		/// Once the arguments have been received it can be cleared from the temporary argument cache using
		/// <see cref="Clear{TClient, TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument}"/>.
		/// </para>
		/// <para>
		/// The <typeparamref name="TClient"/> must implement the <see cref="IArgs{TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument}"/> interface in order for it to be used with this function.
		/// </para>
		/// </summary>
		/// <typeparam name="TClient"> The type of the client that will receive the arguments. </typeparam>
		/// <typeparam name="TFirstArgument"> The type of the first argument. </typeparam>
		/// <typeparam name="TSecondArgument"> The type of the second argument. </typeparam>
		/// <typeparam name="TThirdArgument"> The type of the third argument. </typeparam>
		/// <typeparam name="TFourthArgument"> The type of the fourth argument. </typeparam>
		/// <param name="firstArgument"> The first argument provided for the <typeparamref name="TClient"/>. </param>
		/// <param name="secondArgument"> The second argument provided for the <typeparamref name="TClient"/>. </param>
		/// <param name="thirdArgument"> The third  argument provided for the <typeparamref name="TClient"/>. </param>
		/// <param name="fourthArgument"> The fourth argument provided for the <typeparamref name="TClient"/>. </param>
		public static void Set<TClient, TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument>
			(TFirstArgument firstArgument, TSecondArgument secondArgument, TThirdArgument thirdArgument, TFourthArgument fourthArgument)
				where TClient : IArgs<TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument>
					=> Args<TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument>.args[typeof(TClient)]
						= new(firstArgument, secondArgument, thirdArgument, fourthArgument, received: false);

		/// <summary>
		/// Provides five arguments for use with initializing a client of type <typeparamref name="TClient"/>.
		/// <para>
		/// The arguments can be retrieved by the initializing object during any phase of initialization using the
		/// <see cref="TryGet{TClient, TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument}"/> function.
		/// </para>
		/// <para>
		/// Once the arguments have been received it can be cleared from the temporary argument cache using
		/// <see cref="Clear{TClient, TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument}"/>.
		/// </para>
		/// <para>
		/// The <typeparamref name="TClient"/> must implement the <see cref="IArgs{TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument}"/> interface in order for it to be used with this function.
		/// </para>
		/// </summary>
		/// <typeparam name="TClient"> The type of the client that will receive the arguments. </typeparam>
		/// <typeparam name="TFirstArgument"> The type of the first argument. </typeparam>
		/// <typeparam name="TSecondArgument"> The type of the second argument. </typeparam>
		/// <typeparam name="TThirdArgument"> The type of the third argument. </typeparam>
		/// <typeparam name="TFourthArgument"> The type of the fourth argument. </typeparam>
		/// <typeparam name="TFifthArgument"> The type of the fifth argument. </typeparam>
		/// <param name="firstArgument"> The first argument provided for the <typeparamref name="TClient"/>. </param>
		/// <param name="secondArgument"> The second argument provided for the <typeparamref name="TClient"/>. </param>
		/// <param name="thirdArgument"> The third  argument provided for the <typeparamref name="TClient"/>. </param>
		/// <param name="fourthArgument"> The fourth argument provided for the <typeparamref name="TClient"/>. </param>
		/// <param name="fifthArgument"> The fifth argument provided for the <typeparamref name="TClient"/>. </param>
		public static void Set<TClient, TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument>
			(TFirstArgument firstArgument, TSecondArgument secondArgument, TThirdArgument thirdArgument, TFourthArgument fourthArgument, TFifthArgument fifthArgument)
				where TClient : IArgs<TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument>
					=> Args<TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument>.args[typeof(TClient)]
						= new(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, received: false);

		/// <summary>
		/// Provides six arguments for use with initializing a client of type <typeparamref name="TClient"/>.
		/// <para>
		/// The arguments can be retrieved by the initializing object during any phase of initialization using the
		/// <see cref="TryGet{TClient, TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument}"/> function.
		/// </para>
		/// <para>
		/// Once the arguments have been received it can be cleared from the temporary argument cache using
		/// <see cref="Clear{TClient, TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument}"/>.
		/// </para>
		/// <para>
		/// The <typeparamref name="TClient"/> must implement the <see cref="IArgs{TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument}"/> interface in order for it to be used with this function.
		/// </para>
		/// </summary>
		/// <typeparam name="TClient"> The type of the client that will receive the arguments. </typeparam>
		/// <typeparam name="TFirstArgument"> The type of the first argument. </typeparam>
		/// <typeparam name="TSecondArgument"> The type of the second argument. </typeparam>
		/// <typeparam name="TThirdArgument"> The type of the third argument. </typeparam>
		/// <typeparam name="TFourthArgument"> The type of the fourth argument. </typeparam>
		/// <typeparam name="TFifthArgument"> The type of the fifth argument. </typeparam>
		/// <typeparam name="TSixthArgument"> The type of the sixth argument. </typeparam>
		/// <param name="firstArgument"> The first argument provided for the <typeparamref name="TClient"/>. </param>
		/// <param name="secondArgument"> The second argument provided for the <typeparamref name="TClient"/>. </param>
		/// <param name="thirdArgument"> The third  argument provided for the <typeparamref name="TClient"/>. </param>
		/// <param name="fourthArgument"> The fourth argument provided for the <typeparamref name="TClient"/>. </param>
		/// <param name="fifthArgument"> The fifth argument provided for the <typeparamref name="TClient"/>. </param>
		/// <param name="sixthArgument"> The sixth argument provided for the <typeparamref name="TClient"/>. </param>
		public static void Set<TClient, TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument>
			(TFirstArgument firstArgument, TSecondArgument secondArgument, TThirdArgument thirdArgument, TFourthArgument fourthArgument, TFifthArgument fifthArgument, TSixthArgument sixthArgument)
				where TClient : IArgs<TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument>
					=> Args<TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument>.args[typeof(TClient)]
						= new(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, sixthArgument, received: false);

		public static void Set<TClient, TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument, TSeventhArgument>
			(TFirstArgument firstArgument, TSecondArgument secondArgument, TThirdArgument thirdArgument, TFourthArgument fourthArgument, TFifthArgument fifthArgument, TSixthArgument sixthArgument, TSeventhArgument seventhArgument)
				where TClient : IArgs<TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument, TSeventhArgument>
					=> Args<TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument, TSeventhArgument>.args[typeof(TClient)]
						= new(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, sixthArgument, seventhArgument, received: false);

		public static void Set<TClient, TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument, TSeventhArgument, TEighthArgument>
			(TFirstArgument firstArgument, TSecondArgument secondArgument, TThirdArgument thirdArgument, TFourthArgument fourthArgument, TFifthArgument fifthArgument, TSixthArgument sixthArgument, TSeventhArgument seventhArgument, TEighthArgument eighthArgument)
				where TClient : IArgs<TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument, TSeventhArgument, TEighthArgument>
					=> Args<TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument, TSeventhArgument, TEighthArgument>.args[typeof(TClient)]
						= new(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, sixthArgument, seventhArgument, eighthArgument, received: false);

		public static void Set<TClient, TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument, TSeventhArgument, TEighthArgument, TNinthArgument>
			(TFirstArgument firstArgument, TSecondArgument secondArgument, TThirdArgument thirdArgument, TFourthArgument fourthArgument, TFifthArgument fifthArgument, TSixthArgument sixthArgument, TSeventhArgument seventhArgument, TEighthArgument eighthArgument, TNinthArgument ninthArgument)
				where TClient : IArgs<TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument, TSeventhArgument, TEighthArgument, TNinthArgument>
					=> Args<TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument, TSeventhArgument, TEighthArgument, TNinthArgument>.args[typeof(TClient)]
						= new(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, sixthArgument, seventhArgument, eighthArgument, ninthArgument, received: false);

		public static void Set<TClient, TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument, TSeventhArgument, TEighthArgument, TNinthArgument, TTenthArgument>
			(TFirstArgument firstArgument, TSecondArgument secondArgument, TThirdArgument thirdArgument, TFourthArgument fourthArgument, TFifthArgument fifthArgument, TSixthArgument sixthArgument, TSeventhArgument seventhArgument, TEighthArgument eighthArgument, TNinthArgument ninthArgument, TTenthArgument tenthArgument)
				where TClient : IArgs<TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument, TSeventhArgument, TEighthArgument, TNinthArgument, TTenthArgument>
					=> Args<TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument, TSeventhArgument, TEighthArgument, TNinthArgument, TTenthArgument>.args[typeof(TClient)]
						= new(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, sixthArgument, seventhArgument, eighthArgument, ninthArgument, tenthArgument, received: false);

		public static void Set<TClient, TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument, TSeventhArgument, TEighthArgument, TNinthArgument, TTenthArgument, TEleventhArgument>
			(TFirstArgument firstArgument, TSecondArgument secondArgument, TThirdArgument thirdArgument, TFourthArgument fourthArgument, TFifthArgument fifthArgument, TSixthArgument sixthArgument, TSeventhArgument seventhArgument, TEighthArgument eighthArgument, TNinthArgument ninthArgument, TTenthArgument tenthArgument, TEleventhArgument eleventhArgument)
				where TClient : IArgs<TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument, TSeventhArgument, TEighthArgument, TNinthArgument, TTenthArgument, TEleventhArgument>
					=> Args<TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument, TSeventhArgument, TEighthArgument, TNinthArgument, TTenthArgument, TEleventhArgument>.args[typeof(TClient)]
						= new(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, sixthArgument, seventhArgument, eighthArgument, ninthArgument, tenthArgument, eleventhArgument, received: false);

		public static void Set<TClient, TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument, TSeventhArgument, TEighthArgument, TNinthArgument, TTenthArgument, TEleventhArgument, TTwelfthArgument>
			(TFirstArgument firstArgument, TSecondArgument secondArgument, TThirdArgument thirdArgument, TFourthArgument fourthArgument, TFifthArgument fifthArgument, TSixthArgument sixthArgument, TSeventhArgument seventhArgument, TEighthArgument eighthArgument, TNinthArgument ninthArgument, TTenthArgument tenthArgument, TEleventhArgument eleventhArgument, TTwelfthArgument twelfthArgument)
				where TClient : IArgs<TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument, TSeventhArgument, TEighthArgument, TNinthArgument, TTenthArgument, TEleventhArgument, TTwelfthArgument>
					=> Args<TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument, TSeventhArgument, TEighthArgument, TNinthArgument, TTenthArgument, TEleventhArgument, TTwelfthArgument>.args[typeof(TClient)]
						= new(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, sixthArgument, seventhArgument, eighthArgument, ninthArgument, tenthArgument, eleventhArgument, twelfthArgument, received: false);

		/// <summary>
		/// Retrieves an argument provided for the client object using the <see cref="Set{TClient, TArgument}"/> function.
		/// <para>
		/// The <paramref name="client"/> must implement the <see cref="IArgs{TArgument}"/> interface in order for it to be used with this function.
		/// </para>
		/// </summary>
		/// <typeparam name="TClient"> The type of the <paramref name="client"/> object. </typeparam>
		/// <param name="client"> The object whose dependencies to retrieve. </typeparam>
		/// <param name="argument"> The argument received, or default value if no stored argument was found. </typeparam>
		/// <returns> <see langword="true"/> if an argument had been provided for the object; otherwise, <see langword="false"/>. </returns>
		/// <exception cref="ArgumentNullException"> Thrown if <paramref name="client"/> argument is <see langword="null"/>. </exception>
		public static bool TryGet<TClient, TArgument>([DisallowNull] TClient client, out TArgument argument) where TClient : IArgs<TArgument>
		{
			#if DEBUG
			if(client is Object obj ? !obj : client is null)
			{
				throw new ArgumentNullException($"The {typeof(TClient).Name} whose dependencies you are trying to get is null.", null as Exception);
			}
			#endif

			var args = Arg<TArgument>.arg;
			var clientType = client.GetType();
			if(args.TryGetValue(clientType, out var dependency))
			{
				argument = dependency.argument;
				args[clientType] = new(argument, received:true);
				return true;
			}

			argument = default;
			return false;
		}

		/// <summary>
		/// Retrieves arguments provided for the client object using the <see cref="Set{TClient, TFirstArgument, TSecondArgument}"/> function.
		/// <para>
		/// The <paramref name="client"/> must implement the <see cref="IArgs{TFirstArgument, TSecondArgument}"/> interface in order for it to be used with this function.
		/// </para>
		/// </summary>
		/// <typeparam name="TClient"> The type of the <paramref name="client"/> object. </typeparam>
		/// <param name="client"> The object whose dependencies to retrieve. </typeparam>
		/// <param name="firstArgument"> The first argument received, or default value if no stored argument was found. </typeparam>
		/// <param name="secondArgument"> The second argument received, or default value if no stored argument was found. </typeparam>
		/// <returns> <see langword="true"/> if arguments had been provided for the object; otherwise, <see langword="false"/>. </returns>
		/// <exception cref="ArgumentNullException" > Thrown if client argument is null. </exception>
		public static bool TryGet<TClient, TFirstArgument, TSecondArgument>
			([DisallowNull] TClient client, out TFirstArgument firstArgument, out TSecondArgument secondArgument)
				where TClient : IArgs<TFirstArgument, TSecondArgument>
		{
			#if DEBUG
			if(client is Object obj ? !obj : client is null)
			{
				throw new ArgumentNullException($"The {typeof(TClient).Name} whose dependencies you are trying to get is null.", null as Exception);
			}
			#endif

			var args = Args<TFirstArgument, TSecondArgument>.args;
			var clientType = client.GetType();
			if(args.TryGetValue(clientType, out var dependencies))
			{
				firstArgument = dependencies.firstArgument;
				secondArgument = dependencies.secondArgument;
				args[clientType] = new(firstArgument, secondArgument, received:true);
				return true;
			}

			firstArgument = default;
			secondArgument = default;
			return false;
		}

		/// <summary>
		/// Retrieves arguments provided for the client object using the <see cref="Set{TClient, TFirstArgument, TSecondArgument, TThirdArgument}"/> function.
		/// <para>
		/// The <paramref name="client"/> must implement the <see cref="IArgs{TFirstArgument, TSecondArgument, TThirdArgument}"/> interface in order for it to be used with this function.
		/// </para>
		/// </summary>
		/// <typeparam name="TClient"> The type of the <paramref name="client"/> object. </typeparam>
		/// <param name="client"> The object whose dependencies to retrieve. </typeparam>
		/// <param name="firstArgument"> The first argument received, or default value if no stored argument was found. </typeparam>
		/// <param name="secondArgument"> The second argument received, or default value if no stored argument was found. </typeparam>
		/// <param name="thirdArgument"> The third argument received, or default value if no stored argument was found. </typeparam>
		/// <returns> <see langword="true"/> if arguments had been provided for the object; otherwise, <see langword="false"/>. </returns>
		/// <exception cref="ArgumentNullException" > Thrown if client argument is null. </exception>
		public static bool TryGet<TClient, TFirstArgument, TSecondArgument, TThirdArgument>
			([DisallowNull] TClient client, out TFirstArgument firstArgument, out TSecondArgument secondArgument, out TThirdArgument thirdArgument)
				where TClient : IArgs<TFirstArgument, TSecondArgument, TThirdArgument>
		{
			#if DEBUG
			if(client is Object obj ? !obj : client is null)
			{
				throw new ArgumentNullException($"The {typeof(TClient).Name} whose dependencies you are trying to get is null.", null as Exception);
			}
			#endif

			var args = Args<TFirstArgument, TSecondArgument, TThirdArgument>.args;
			var clientType = client.GetType();
			if(args.TryGetValue(clientType, out var dependencies))
			{
				firstArgument = dependencies.firstArgument;
				secondArgument = dependencies.secondArgument;
				thirdArgument = dependencies.thirdArgument;
				args[clientType] = new(firstArgument, secondArgument, thirdArgument, received:true);
				return true;
			}

			firstArgument = default;
			secondArgument = default;
			thirdArgument = default;
			return false;
		}

		/// <summary>
		/// Retrieves arguments provided for the client object using the <see cref="Set{TClient, TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument}"/> function.
		/// <para>
		/// The <paramref name="client"/> must implement the <see cref="IArgs{TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument}"/> interface in order for it to be used with this function.
		/// </para>
		/// </summary>
		/// <typeparam name="TClient"> The type of the <paramref name="client"/> object. </typeparam>
		/// <param name="client"> The object whose dependencies to retrieve. </typeparam>
		/// <param name="firstArgument"> The first argument received, or default value if no stored argument was found. </typeparam>
		/// <param name="secondArgument"> The second argument received, or default value if no stored argument was found. </typeparam>
		/// <param name="thirdArgument"> The third argument received, or default value if no stored argument was found. </typeparam>
		/// <param name="fourthArgument"> The fourth argument received, or default value if no stored argument was found. </typeparam>
		/// <returns> <see langword="true"/> if arguments had been provided for the object; otherwise, <see langword="false"/>. </returns>
		/// <exception cref="ArgumentNullException" > Thrown if client argument is null. </exception>
		public static bool TryGet<TClient, TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument>
			([DisallowNull] TClient client, out TFirstArgument firstArgument, out TSecondArgument secondArgument, out TThirdArgument thirdArgument, out TFourthArgument fourthArgument)
				where TClient : IArgs<TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument>
		{
			#if DEBUG
			if(client is Object obj ? !obj : client is null)
			{
				throw new ArgumentNullException($"The {typeof(TClient).Name} whose dependencies you are trying to get is null.", null as Exception);
			}
			#endif

			var args = Args<TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument>.args;
			var clientType = client.GetType();
			if(args.TryGetValue(clientType, out var dependencies))
			{
				firstArgument = dependencies.firstArgument;
				secondArgument = dependencies.secondArgument;
				thirdArgument = dependencies.thirdArgument;
				fourthArgument = dependencies.fourthArgument;
				args[clientType] = new(firstArgument, secondArgument, thirdArgument, fourthArgument, received:true);
				return true;
			}

			firstArgument = default;
			secondArgument = default;
			thirdArgument = default;
			fourthArgument = default;
			return false;
		}

		/// <summary>
		/// Retrieves arguments provided for the client object using the <see cref="Set{TClient, TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument}"/> function.
		/// <para>
		/// The <paramref name="client"/> must implement the <see cref="IArgs{TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument}"/> interface in order for it to be used with this function.
		/// </para>
		/// </summary>
		/// <typeparam name="TClient"> The type of the <paramref name="client"/> object. </typeparam>
		/// <param name="client"> The object whose dependencies to retrieve. </typeparam>
		/// <param name="firstArgument"> The first argument received, or default value if no stored argument was found. </typeparam>
		/// <param name="secondArgument"> The second argument received, or default value if no stored argument was found. </typeparam>
		/// <param name="thirdArgument"> The third argument received, or default value if no stored argument was found. </typeparam>
		/// <param name="fourthArgument"> The fourth argument received, or default value if no stored argument was found. </typeparam>
		/// <param name="fifthArgument"> The five argument received, or default value if no stored argument was found. </typeparam>
		/// <returns> <see langword="true"/> if arguments had been provided for the object; otherwise, <see langword="false"/>. </returns>
		/// <exception cref="ArgumentNullException" > Thrown if client argument is null. </exception>
		public static bool TryGet<TClient, TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument>
			([DisallowNull] TClient client, out TFirstArgument firstArgument, out TSecondArgument secondArgument, out TThirdArgument thirdArgument, out TFourthArgument fourthArgument, out TFifthArgument fifthArgument)
				where TClient : IArgs<TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument>
		{
			#if DEBUG
			if(client is Object obj ? !obj : client is null)
			{
				throw new ArgumentNullException($"The {typeof(TClient).Name} whose dependencies you are trying to get is null.", null as Exception);
			}
			#endif

			var args = Args<TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument>.args;
			var clientType = client.GetType();
			if(args.TryGetValue(clientType, out var dependencies))
			{
				firstArgument = dependencies.firstArgument;
				secondArgument = dependencies.secondArgument;
				thirdArgument = dependencies.thirdArgument;
				fourthArgument = dependencies.fourthArgument;
				fifthArgument = dependencies.fifthArgument;
				args[clientType] = new(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, received:true);
				return true;
			}

			firstArgument = default;
			secondArgument = default;
			thirdArgument = default;
			fourthArgument = default;
			fifthArgument = default;
			return false;
		}

		/// <summary>
		/// Retrieves arguments provided for the client object using the <see cref="Set{TClient, TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument}"/> function.
		/// <para>
		/// The <paramref name="client"/> must implement the <see cref="IArgs{TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument}"/> interface in order for it to be used with this function.
		/// </para>
		/// </summary>
		/// <typeparam name="TClient"> The type of the <paramref name="client"/> object. </typeparam>
		/// <param name="client"> The object whose dependencies to retrieve. </typeparam>
		/// <param name="firstArgument"> The first argument received, or default value if no stored argument was found. </typeparam>
		/// <param name="secondArgument"> The second argument received, or default value if no stored argument was found. </typeparam>
		/// <param name="thirdArgument"> The third argument received, or default value if no stored argument was found. </typeparam>
		/// <param name="fourthArgument"> The fourth argument received, or default value if no stored argument was found. </typeparam>
		/// <param name="fifthArgument"> The five argument received, or default value if no stored argument was found. </typeparam>
		/// <param name="sixthArgument"> The sixth argument received, or default value if no stored argument was found. </typeparam>
		/// <returns> <see langword="true"/> if arguments had been provided for the object; otherwise, <see langword="false"/>. </returns>
		/// <exception cref="ArgumentNullException" > Thrown if client argument is null. </exception>
		public static bool TryGet<TClient, TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument>
			([DisallowNull] TClient client, out TFirstArgument firstArgument, out TSecondArgument secondArgument, out TThirdArgument thirdArgument, out TFourthArgument fourthArgument, out TFifthArgument fifthArgument, out TSixthArgument sixthArgument)
				where TClient : IArgs<TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument>
		{
			#if DEBUG
			if(client is Object obj ? !obj : client is null)
			{
				throw new ArgumentNullException($"The {typeof(TClient).Name} whose dependencies you are trying to get is null.", null as Exception);
			}
			#endif

			var args = Args<TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument>.args;
			var clientType = client.GetType();
			if(args.TryGetValue(clientType, out var dependencies))
			{
				firstArgument = dependencies.firstArgument;
				secondArgument = dependencies.secondArgument;
				thirdArgument = dependencies.thirdArgument;
				fourthArgument = dependencies.fourthArgument;
				fifthArgument = dependencies.fifthArgument;
				sixthArgument = dependencies.sixthArgument;
				args[clientType] = new(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, sixthArgument, received:true);
				return true;
			}

			firstArgument = default;
			secondArgument = default;
			thirdArgument = default;
			fourthArgument = default;
			fifthArgument = default;
			sixthArgument = default;
			return false;
		}

		/// <summary>
		/// Retrieves arguments provided for the client object using the <see cref="Set{TClient, TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument, TSeventhArgument}"/> function.
		/// <para>
		/// The <paramref name="client"/> must implement the <see cref="IArgs{TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument, TSeventhArgument}"/> interface in order for it to be used with this function.
		/// </para>
		/// </summary>
		/// <typeparam name="TClient"> The type of the <paramref name="client"/> object. </typeparam>
		/// <param name="client"> The object whose dependencies to retrieve. </typeparam>
		/// <param name="firstArgument"> The first argument received, or default value if no stored argument was found. </typeparam>
		/// <param name="secondArgument"> The second argument received, or default value if no stored argument was found. </typeparam>
		/// <param name="thirdArgument"> The third argument received, or default value if no stored argument was found. </typeparam>
		/// <param name="fourthArgument"> The fourth argument received, or default value if no stored argument was found. </typeparam>
		/// <param name="fifthArgument"> The five argument received, or default value if no stored argument was found. </typeparam>
		/// <param name="sixthArgument"> The sixth argument received, or default value if no stored argument was found. </typeparam>
		/// <param name="seventhArgument"> The seventh argument received, or default value if no stored argument was found. </typeparam>
		/// <returns> <see langword="true"/> if arguments had been provided for the object; otherwise, <see langword="false"/>. </returns>
		/// <exception cref="ArgumentNullException" > Thrown if client argument is null. </exception>
		public static bool TryGet<TClient, TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument, TSeventhArgument>
			([DisallowNull] TClient client, out TFirstArgument firstArgument, out TSecondArgument secondArgument, out TThirdArgument thirdArgument, out TFourthArgument fourthArgument, out TFifthArgument fifthArgument, out TSixthArgument sixthArgument, out TSeventhArgument seventhArgument)
				where TClient : IArgs<TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument, TSeventhArgument>
		{
			#if DEBUG
			if(client is Object obj ? !obj : client is null)
			{
				throw new ArgumentNullException($"The {typeof(TClient).Name} whose dependencies you are trying to get is null.", null as Exception);
			}
			#endif

			var args = Args<TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument, TSeventhArgument>.args;
			var clientType = client.GetType();
			if(args.TryGetValue(clientType, out var dependencies))
			{
				firstArgument = dependencies.firstArgument;
				secondArgument = dependencies.secondArgument;
				thirdArgument = dependencies.thirdArgument;
				fourthArgument = dependencies.fourthArgument;
				fifthArgument = dependencies.fifthArgument;
				sixthArgument = dependencies.sixthArgument;
				seventhArgument = dependencies.seventhArgument;
				args[clientType] = new(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, sixthArgument, seventhArgument, received:true);
				return true;
			}

			firstArgument = default;
			secondArgument = default;
			thirdArgument = default;
			fourthArgument = default;
			fifthArgument = default;
			sixthArgument = default;
			seventhArgument = default;
			return false;
		}

		/// <summary>
		/// Retrieves arguments provided for the client object using the <see cref="Set{TClient, TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument, TSeventhArgument, TEighthArgument}"/> function.
		/// <para>
		/// The <paramref name="client"/> must implement the <see cref="IArgs{TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument, TSeventhArgument, TEighthArgument}"/> interface in order for it to be used with this function.
		/// </para>
		/// </summary>
		/// <typeparam name="TClient"> The type of the <paramref name="client"/> object. </typeparam>
		/// <param name="client"> The object whose dependencies to retrieve. </typeparam>
		/// <param name="firstArgument"> The first argument received, or default value if no stored argument was found. </typeparam>
		/// <param name="secondArgument"> The second argument received, or default value if no stored argument was found. </typeparam>
		/// <param name="thirdArgument"> The third argument received, or default value if no stored argument was found. </typeparam>
		/// <param name="fourthArgument"> The fourth argument received, or default value if no stored argument was found. </typeparam>
		/// <param name="fifthArgument"> The five argument received, or default value if no stored argument was found. </typeparam>
		/// <param name="sixthArgument"> The sixth argument received, or default value if no stored argument was found. </typeparam>
		/// <param name="seventhArgument"> The seventh argument received, or default value if no stored argument was found. </typeparam>
		/// <param name="eighthArgument"> The eighth argument received, or default value if no stored argument was found. </typeparam>
		/// <returns> <see langword="true"/> if arguments had been provided for the object; otherwise, <see langword="false"/>. </returns>
		/// <exception cref="ArgumentNullException" > Thrown if client argument is null. </exception>
		public static bool TryGet<TClient, TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument, TSeventhArgument, TEighthArgument>
			([DisallowNull] TClient client, out TFirstArgument firstArgument, out TSecondArgument secondArgument, out TThirdArgument thirdArgument, out TFourthArgument fourthArgument, out TFifthArgument fifthArgument, out TSixthArgument sixthArgument, out TSeventhArgument seventhArgument, out TEighthArgument eighthArgument)
				where TClient : IArgs<TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument, TSeventhArgument, TEighthArgument>
		{
			#if DEBUG
			if(client is Object obj ? !obj : client is null)
			{
				throw new ArgumentNullException($"The {typeof(TClient).Name} whose dependencies you are trying to get is null.", null as Exception);
			}
			#endif

			var args = Args<TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument, TSeventhArgument, TEighthArgument>.args;
			var clientType = client.GetType();
			if(args.TryGetValue(clientType, out var dependencies))
			{
				firstArgument = dependencies.firstArgument;
				secondArgument = dependencies.secondArgument;
				thirdArgument = dependencies.thirdArgument;
				fourthArgument = dependencies.fourthArgument;
				fifthArgument = dependencies.fifthArgument;
				sixthArgument = dependencies.sixthArgument;
				seventhArgument = dependencies.seventhArgument;
				eighthArgument = dependencies.eighthArgument;
				args[clientType] = new(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, sixthArgument, seventhArgument, eighthArgument, received:true);
				return true;
			}

			firstArgument = default;
			secondArgument = default;
			thirdArgument = default;
			fourthArgument = default;
			fifthArgument = default;
			sixthArgument = default;
			seventhArgument = default;
			eighthArgument = default;
			return false;
		}

		/// <summary>
		/// Retrieves arguments provided for the client object using the <see cref="Set{TClient, TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument, TSeventhArgument, TEighthArgument, TNinthArgument}"/> function.
		/// <para>
		/// <para>
		/// The <paramref name="client"/> must implement the <see cref="IArgs{TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument, TSeventhArgument, TEighthArgument, TNinthArgument}"/> interface in order for it to be used with this function.
		/// </para>
		/// </summary>
		/// <typeparam name="TClient"> The type of the <paramref name="client"/> object. </typeparam>
		/// <param name="client"> The object whose dependencies to retrieve. </typeparam>
		/// <param name="firstArgument"> The first argument received, or default value if no stored argument was found. </typeparam>
		/// <param name="secondArgument"> The second argument received, or default value if no stored argument was found. </typeparam>
		/// <param name="thirdArgument"> The third argument received, or default value if no stored argument was found. </typeparam>
		/// <param name="fourthArgument"> The fourth argument received, or default value if no stored argument was found. </typeparam>
		/// <param name="fifthArgument"> The five argument received, or default value if no stored argument was found. </typeparam>
		/// <param name="sixthArgument"> The sixth argument received, or default value if no stored argument was found. </typeparam>
		/// <param name="seventhArgument"> The seventh argument received, or default value if no stored argument was found. </typeparam>
		/// <param name="eighthArgument"> The eighth argument received, or default value if no stored argument was found. </typeparam>
		/// <param name="ninthArgument"> The ninth argument received, or default value if no stored argument was found. </typeparam>
		/// <returns> <see langword="true"/> if arguments had been provided for the object; otherwise, <see langword="false"/>. </returns>
		/// <exception cref="ArgumentNullException" > Thrown if client argument is null. </exception>
		public static bool TryGet<TClient, TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument, TSeventhArgument, TEighthArgument, TNinthArgument>
			([DisallowNull] TClient client, out TFirstArgument firstArgument, out TSecondArgument secondArgument, out TThirdArgument thirdArgument, out TFourthArgument fourthArgument, out TFifthArgument fifthArgument, out TSixthArgument sixthArgument, out TSeventhArgument seventhArgument, out TEighthArgument eighthArgument, out TNinthArgument ninthArgument)
				where TClient : IArgs<TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument, TSeventhArgument, TEighthArgument, TNinthArgument>
		{
			#if DEBUG
			if(client is Object obj ? !obj : client is null)
			{
				throw new ArgumentNullException($"The {typeof(TClient).Name} whose dependencies you are trying to get is null.", null as Exception);
			}
			#endif

			var args = Args<TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument, TSeventhArgument, TEighthArgument, TNinthArgument>.args;
			var clientType = client.GetType();
			if(args.TryGetValue(clientType, out var dependencies))
			{
				firstArgument = dependencies.firstArgument;
				secondArgument = dependencies.secondArgument;
				thirdArgument = dependencies.thirdArgument;
				fourthArgument = dependencies.fourthArgument;
				fifthArgument = dependencies.fifthArgument;
				sixthArgument = dependencies.sixthArgument;
				seventhArgument = dependencies.seventhArgument;
				eighthArgument = dependencies.eighthArgument;
				ninthArgument = dependencies.ninthArgument;
				args[clientType] = new(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, sixthArgument, seventhArgument, eighthArgument, ninthArgument, received:true);
				return true;
			}

			firstArgument = default;
			secondArgument = default;
			thirdArgument = default;
			fourthArgument = default;
			fifthArgument = default;
			sixthArgument = default;
			seventhArgument = default;
			eighthArgument = default;
			ninthArgument = default;
			return false;
		}

		/// <summary>
		/// Retrieves arguments provided for the client object using the <see cref="Set{TClient, TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument, TSeventhArgument, TEighthArgument, TNinthArgument, TTenthArgument}"/> function.
		/// <para>
		/// The <paramref name="client"/> must implement the <see cref="IArgs{TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument, TSeventhArgument, TEighthArgument, TNinthArgument, TTenthArgument}"/> interface in order for it to be used with this function.
		/// </para>
		/// </summary>
		/// <typeparam name="TClient"> The type of the <paramref name="client"/> object. </typeparam>
		/// <param name="client"> The object whose dependencies to retrieve. </typeparam>
		/// <param name="firstArgument"> The first argument received, or default value if no stored argument was found. </typeparam>
		/// <param name="secondArgument"> The second argument received, or default value if no stored argument was found. </typeparam>
		/// <param name="thirdArgument"> The third argument received, or default value if no stored argument was found. </typeparam>
		/// <param name="fourthArgument"> The fourth argument received, or default value if no stored argument was found. </typeparam>
		/// <param name="fifthArgument"> The five argument received, or default value if no stored argument was found. </typeparam>
		/// <param name="sixthArgument"> The sixth argument received, or default value if no stored argument was found. </typeparam>
		/// <param name="seventhArgument"> The seventh argument received, or default value if no stored argument was found. </typeparam>
		/// <param name="eighthArgument"> The eighth argument received, or default value if no stored argument was found. </typeparam>
		/// <param name="ninthArgument"> The ninth argument received, or default value if no stored argument was found. </typeparam>
		/// <param name="tenthArgument"> The tenth argument received, or default value if no stored argument was found. </typeparam>
		/// <returns> <see langword="true"/> if arguments had been provided for the object; otherwise, <see langword="false"/>. </returns>
		/// <exception cref="ArgumentNullException" > Thrown if client argument is null. </exception>
		public static bool TryGet<TClient, TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument, TSeventhArgument, TEighthArgument, TNinthArgument, TTenthArgument>
			([DisallowNull] TClient client, out TFirstArgument firstArgument, out TSecondArgument secondArgument, out TThirdArgument thirdArgument, out TFourthArgument fourthArgument, out TFifthArgument fifthArgument, out TSixthArgument sixthArgument, out TSeventhArgument seventhArgument, out TEighthArgument eighthArgument, out TNinthArgument ninthArgument, out TTenthArgument tenthArgument)
				where TClient : IArgs<TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument, TSeventhArgument, TEighthArgument, TNinthArgument, TTenthArgument>
		{
			#if DEBUG
			if(client is Object obj ? !obj : client is null)
			{
				throw new ArgumentNullException($"The {typeof(TClient).Name} whose dependencies you are trying to get is null.", null as Exception);
			}
			#endif

			var args = Args<TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument, TSeventhArgument, TEighthArgument, TNinthArgument, TTenthArgument>.args;
			var clientType = client.GetType();
			if(args.TryGetValue(clientType, out var dependencies))
			{
				firstArgument = dependencies.firstArgument;
				secondArgument = dependencies.secondArgument;
				thirdArgument = dependencies.thirdArgument;
				fourthArgument = dependencies.fourthArgument;
				fifthArgument = dependencies.fifthArgument;
				sixthArgument = dependencies.sixthArgument;
				seventhArgument = dependencies.seventhArgument;
				eighthArgument = dependencies.eighthArgument;
				ninthArgument = dependencies.ninthArgument;
				tenthArgument = dependencies.tenthArgument;
				args[clientType] = new(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, sixthArgument, seventhArgument, eighthArgument, ninthArgument, tenthArgument, received:true);
				return true;
			}

			firstArgument = default;
			secondArgument = default;
			thirdArgument = default;
			fourthArgument = default;
			fifthArgument = default;
			sixthArgument = default;
			seventhArgument = default;
			eighthArgument = default;
			ninthArgument = default;
			tenthArgument = default;
			return false;
		}

		/// <summary>
		/// Retrieves arguments provided for the client object using the <see cref="Set{TClient, TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument, TSeventhArgument, TEighthArgument, TNinthArgument, TTenthArgument, TEleventhArgument}"/> function.
		/// <para>
		/// The <paramref name="client"/> must implement the <see cref="IArgs{TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument, TSeventhArgument, TEighthArgument, TNinthArgument, TTenthArgument, TEleventhArgument}"/> interface in order for it to be used with this function.
		/// </para>
		/// </summary>
		/// <typeparam name="TClient"> The type of the <paramref name="client"/> object. </typeparam>
		/// <param name="client"> The object whose dependencies to retrieve. </typeparam>
		/// <param name="firstArgument"> The first argument received, or default value if no stored argument was found. </typeparam>
		/// <param name="secondArgument"> The second argument received, or default value if no stored argument was found. </typeparam>
		/// <param name="thirdArgument"> The third argument received, or default value if no stored argument was found. </typeparam>
		/// <param name="fourthArgument"> The fourth argument received, or default value if no stored argument was found. </typeparam>
		/// <param name="fifthArgument"> The five argument received, or default value if no stored argument was found. </typeparam>
		/// <param name="sixthArgument"> The sixth argument received, or default value if no stored argument was found. </typeparam>
		/// <param name="seventhArgument"> The seventh argument received, or default value if no stored argument was found. </typeparam>
		/// <param name="eighthArgument"> The eighth argument received, or default value if no stored argument was found. </typeparam>
		/// <param name="ninthArgument"> The ninth argument received, or default value if no stored argument was found. </typeparam>
		/// <param name="tenthArgument"> The tenth argument received, or default value if no stored argument was found. </typeparam>
		/// <param name="eleventhArgument"> The eleventh received, or default value if no stored argument was found. </typeparam>
		/// <returns> <see langword="true"/> if arguments had been provided for the object; otherwise, <see langword="false"/>. </returns>
		/// <exception cref="ArgumentNullException" > Thrown if client argument is null. </exception>
		public static bool TryGet<TClient, TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument, TSeventhArgument, TEighthArgument, TNinthArgument, TTenthArgument, TEleventhArgument>
			([DisallowNull] TClient client, out TFirstArgument firstArgument, out TSecondArgument secondArgument, out TThirdArgument thirdArgument, out TFourthArgument fourthArgument, out TFifthArgument fifthArgument, out TSixthArgument sixthArgument, out TSeventhArgument seventhArgument, out TEighthArgument eighthArgument, out TNinthArgument ninthArgument, out TTenthArgument tenthArgument, out TEleventhArgument eleventhArgument)
				where TClient : IArgs<TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument, TSeventhArgument, TEighthArgument, TNinthArgument, TTenthArgument, TEleventhArgument>
		{
			#if DEBUG
			if(client is Object obj ? !obj : client is null)
			{
				throw new ArgumentNullException($"The {typeof(TClient).Name} whose dependencies you are trying to get is null.", null as Exception);
			}
			#endif

			var args = Args<TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument, TSeventhArgument, TEighthArgument, TNinthArgument, TTenthArgument, TEleventhArgument>.args;
			var clientType = client.GetType();
			if(args.TryGetValue(clientType, out var dependencies))
			{
				firstArgument = dependencies.firstArgument;
				secondArgument = dependencies.secondArgument;
				thirdArgument = dependencies.thirdArgument;
				fourthArgument = dependencies.fourthArgument;
				fifthArgument = dependencies.fifthArgument;
				sixthArgument = dependencies.sixthArgument;
				seventhArgument = dependencies.seventhArgument;
				eighthArgument = dependencies.eighthArgument;
				ninthArgument = dependencies.ninthArgument;
				tenthArgument = dependencies.tenthArgument;
				eleventhArgument = dependencies.eleventhArgument;
				args[clientType] = new(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, sixthArgument, seventhArgument, eighthArgument, ninthArgument, tenthArgument, eleventhArgument, received:true);
				return true;
			}

			firstArgument = default;
			secondArgument = default;
			thirdArgument = default;
			fourthArgument = default;
			fifthArgument = default;
			sixthArgument = default;
			seventhArgument = default;
			eighthArgument = default;
			ninthArgument = default;
			tenthArgument = default;
			eleventhArgument = default;
			return false;
		}

		/// <summary>
		/// Retrieves arguments provided for the client object using the <see cref="Set{TClient, TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument, TSeventhArgument, TEighthArgument, TNinthArgument, TTenthArgument, TEleventhArgument, TTwelfthArgument}"/> function.
		/// <para>
		/// The <paramref name="client"/> must implement the <see cref="IArgs{TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument, TSeventhArgument, TEighthArgument, TNinthArgument, TTenthArgument, TEleventhArgument, TTwelfthArgument}"/> interface in order for it to be used with this function.
		/// </para>
		/// </summary>
		/// <typeparam name="TClient"> The type of the <paramref name="client"/> object. </typeparam>
		/// <param name="client"> The object whose dependencies to retrieve. </typeparam>
		/// <param name="firstArgument"> The first argument received, or default value if no stored argument was found. </typeparam>
		/// <param name="secondArgument"> The second argument received, or default value if no stored argument was found. </typeparam>
		/// <param name="thirdArgument"> The third argument received, or default value if no stored argument was found. </typeparam>
		/// <param name="fourthArgument"> The fourth argument received, or default value if no stored argument was found. </typeparam>
		/// <param name="fifthArgument"> The five argument received, or default value if no stored argument was found. </typeparam>
		/// <param name="sixthArgument"> The sixth argument received, or default value if no stored argument was found. </typeparam>
		/// <param name="seventhArgument"> The seventh argument received, or default value if no stored argument was found. </typeparam>
		/// <param name="eighthArgument"> The eighth argument received, or default value if no stored argument was found. </typeparam>
		/// <param name="ninthArgument"> The ninth argument received, or default value if no stored argument was found. </typeparam>
		/// <param name="tenthArgument"> The tenth argument received, or default value if no stored argument was found. </typeparam>
		/// <param name="eleventhArgument"> The eleventh received, or default value if no stored argument was found. </typeparam>
		/// <param name="twelfthArgument"> The twelfth received, or default value if no stored argument was found. </typeparam>
		/// <returns> <see langword="true"/> if arguments had been provided for the object; otherwise, <see langword="false"/>. </returns>
		/// <exception cref="ArgumentNullException" > Thrown if client argument is null. </exception>
		public static bool TryGet<TClient, TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument, TSeventhArgument, TEighthArgument, TNinthArgument, TTenthArgument, TEleventhArgument, TTwelfthArgument>
			([DisallowNull] TClient client, out TFirstArgument firstArgument, out TSecondArgument secondArgument, out TThirdArgument thirdArgument, out TFourthArgument fourthArgument, out TFifthArgument fifthArgument, out TSixthArgument sixthArgument, out TSeventhArgument seventhArgument, out TEighthArgument eighthArgument, out TNinthArgument ninthArgument, out TTenthArgument tenthArgument, out TEleventhArgument eleventhArgument, out TTwelfthArgument twelfthArgument)
				where TClient : IArgs<TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument, TSeventhArgument, TEighthArgument, TNinthArgument, TTenthArgument, TEleventhArgument, TTwelfthArgument>
		{
			#if DEBUG
			if(client is Object obj ? !obj : client is null)
			{
				throw new ArgumentNullException($"The {typeof(TClient).Name} whose dependencies you are trying to get is null.", null as Exception);
			}
			#endif

			var args = Args<TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument, TSeventhArgument, TEighthArgument, TNinthArgument, TTenthArgument, TEleventhArgument, TTwelfthArgument>.args;
			var clientType = client.GetType();
			if(args.TryGetValue(clientType, out var dependencies))
			{
				firstArgument = dependencies.firstArgument;
				secondArgument = dependencies.secondArgument;
				thirdArgument = dependencies.thirdArgument;
				fourthArgument = dependencies.fourthArgument;
				fifthArgument = dependencies.fifthArgument;
				sixthArgument = dependencies.sixthArgument;
				seventhArgument = dependencies.seventhArgument;
				eighthArgument = dependencies.eighthArgument;
				ninthArgument = dependencies.ninthArgument;
				tenthArgument = dependencies.tenthArgument;
				eleventhArgument = dependencies.eleventhArgument;
				twelfthArgument = dependencies.twelfthArgument;
				args[clientType] = new(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, sixthArgument, seventhArgument, eighthArgument, ninthArgument, tenthArgument, eleventhArgument, twelfthArgument, received:true);
				return true;
			}

			firstArgument = default;
			secondArgument = default;
			thirdArgument = default;
			fourthArgument = default;
			fifthArgument = default;
			sixthArgument = default;
			seventhArgument = default;
			eighthArgument = default;
			ninthArgument = default;
			tenthArgument = default;
			eleventhArgument = default;
			twelfthArgument = default;
			return false;
		}

		/// <summary>
		/// Clears argument provided for client of type <typeparamref name="TClient"/> using the <see cref="Set{TClient, TArgument}"/> function
		/// and returns a value indicating if the argument was not received by the client.
		/// </summary>
		/// <typeparam name="TClient"> The type of the object whose argument is cleared. </typeparam>
		/// <typeparam name="TArgument"> The type of the dependency. </typeparam>
		/// <returns>
		/// <see langword="true"/> if argument for <typeparamref name="TClient"/> class was provided
		/// using <see cref="Set{TClient, TArgument}"/> but never retrieved using
		/// <see cref="TryGet{TClient, TArgument}"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static bool Clear<TClient, TArgument>()
			where TClient : IArgs<TArgument>
		{

			if(Arg<TArgument>.arg.TryGetValue(typeof(TClient), out var dependency))
			{
				Arg<TArgument>.arg.Remove(typeof(TClient), out _);
				return !dependency.received;
			}

			return false;
		}

		/// <summary>
		/// Clears arguments provided for client of type <typeparamref name="TClient"/> using the
		/// <see cref="Set{TClient, TFirstArgument, TSecondArgument}"/> function
		/// and returns a value indicating if the arguments were not received by the client.
		/// </summary>
		/// <typeparam name="TClient"> The type of the object whose arguments are cleared. </typeparam>
		/// <typeparam name="TFirstArgument"> The type of the first dependency. </typeparam>
		/// <typeparam name="TSecondArgument"> The type of the second dependency. </typeparam>
		/// <returns>
		/// <see langword="true"/> if arguments for <typeparamref name="TClient"/> class were provided
		/// using <see cref="Set{TClient, TFirstArgument, TSecondArgument}"/> but never retrieved using
		/// <see cref="TryGet{TClient, TFirstArgument, TSecondArgument}"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static bool Clear<TClient, TFirstArgument, TSecondArgument>()
			where TClient : IArgs<TFirstArgument, TSecondArgument>
		{
			if(Args<TFirstArgument, TSecondArgument>.args.TryGetValue(typeof(TClient), out var dependency))
			{
				Args<TFirstArgument, TSecondArgument>.args.Remove(typeof(TClient), out _);
				return !dependency.received;
			}

			return false;
		}

		/// <summary>
		/// Clears arguments provided for client of type <typeparamref name="TClient"/> using the
		/// <see cref="Set{TClient, TFirstArgument, TSecondArgument, TThirdArgument}"/> function
		/// and returns a value indicating if the arguments were not received by the client.
		/// </summary>
		/// <typeparam name="TClient"> The type of the object whose arguments are cleared. </typeparam>
		/// <typeparam name="TFirstArgument"> The type of the first dependency. </typeparam>
		/// <typeparam name="TSecondArgument"> The type of the second dependency. </typeparam>
		/// <typeparam name="TThirdArgument"> The type of the third dependency. </typeparam>
		/// <returns>
		/// <see langword="true"/> if arguments for <typeparamref name="TClient"/> class were provided
		/// using <see cref="Set{TClient, TFirstArgument, TSecondArgument, TThirdArgument}"/> but never retrieved using
		/// <see cref="TryGet{TClient, TFirstArgument, TSecondArgument, TThirdArgument}"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static bool Clear<TClient, TFirstArgument, TSecondArgument, TThirdArgument>()
			where TClient : IArgs<TFirstArgument, TSecondArgument, TThirdArgument>
		{
			if(Args<TFirstArgument, TSecondArgument, TThirdArgument>.args.TryGetValue(typeof(TClient), out var dependency))
			{
				Args<TFirstArgument, TSecondArgument, TThirdArgument>.args.Remove(typeof(TClient), out _);
				return !dependency.received;
			}

			return false;
		}

		/// <summary>
		/// Clears arguments previously provided for client of type <typeparamref name="TClient"/> using the
		/// <see cref="Set{TClient, TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument}"/> function
		/// and returns a value indicating if the arguments were not received by the client.
		/// </summary>
		/// <typeparam name="TClient"> The type of the object whose arguments are cleared. </typeparam>
		/// <typeparam name="TFirstArgument"> The type of the first argument. </typeparam>
		/// <typeparam name="TSecondArgument"> The type of the second argument. </typeparam>
		/// <typeparam name="TThirdArgument"> The type of the third argument. </typeparam>
		/// <typeparam name="TFourthArgument"> The type of the fourth argument. </typeparam>
		/// <returns>
		/// <see langword="true"/> if arguments for <typeparamref name="TClient"/> class were provided
		/// using <see cref="Set{TClient, TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument}"/> but never retrieved using
		/// <see cref="TryGet{TClient, TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument}"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static bool Clear<TClient, TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument>()
			where TClient : IArgs<TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument>
		{
			if(Args<TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument>.args.TryGetValue(typeof(TClient), out var dependency))
			{
				Args<TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument>.args.Remove(typeof(TClient), out _);
				return !dependency.received;
			}

			return false;
		}

		/// <summary>
		/// Clears arguments provided for client of type <typeparamref name="TClient"/> using the
		/// <see cref="Set{TClient, TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument}"/> function
		/// and returns a value indicating if the arguments were not received by the client.
		/// </summary>
		/// <typeparam name="TClient"> The type of the object whose arguments are cleared. </typeparam>
		/// <typeparam name="TFirstArgument"> The type of the first argument. </typeparam>
		/// <typeparam name="TSecondArgument"> The type of the second argument. </typeparam>
		/// <typeparam name="TThirdArgument"> The type of the third argument. </typeparam>
		/// <typeparam name="TFourthArgument"> The type of the fourth argument. </typeparam>
		/// <typeparam name="TFifthArgument"> The type of the fifth argument. </typeparam>
		/// <returns>
		/// <see langword="true"/> if arguments for <typeparamref name="TClient"/> class were provided
		/// using <see cref="Set{TClient, TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument}"/> but never retrieved using
		/// <see cref="TryGet{TClient, TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument}"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static bool Clear<TClient, TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument>()
			where TClient : IArgs<TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument>
		{
			if(Args<TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument>.args.TryGetValue(typeof(TClient), out var dependency))
			{
				Args<TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument>.args.Remove(typeof(TClient), out _);
				return !dependency.received;
			}

			return false;
		}

		/// <summary>
		/// Clears arguments provided for client of type <typeparamref name="TClient"/> using the
		/// <see cref="Set{TClient, TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument}"/>
		/// function and returns a value indicating if the arguments were not received by the client.
		/// </summary>
		/// <typeparam name="TClient"> The type of the object whose arguments are cleared. </typeparam>
		/// <typeparam name="TFirstArgument"> The type of the first argument. </typeparam>
		/// <typeparam name="TSecondArgument"> The type of the second argument. </typeparam>
		/// <typeparam name="TThirdArgument"> The type of the third argument. </typeparam>
		/// <typeparam name="TFourthArgument"> The type of the fourth argument. </typeparam>
		/// <typeparam name="TFifthArgument"> The type of the fifth argument. </typeparam>
		/// <typeparam name="TSixthArgument"> The type of the sixth argument. </typeparam>
		/// <returns>
		/// <see langword="true"/> if arguments for <typeparamref name="TClient"/> class were provided
		/// using <see cref="Set{TClient, TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument}"/> but never retrieved using
		/// <see cref="TryGet{TClient, TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument}"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static bool Clear<TClient, TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument>()
			where TClient : IArgs<TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument>
		{
			if(Args<TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument>.args.TryGetValue(typeof(TClient), out var dependency))
			{
				Args<TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument>.args.Remove(typeof(TClient), out _);
				return !dependency.received;
			}

			return false;
		}

		public static bool Clear<TClient, TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument, TSeventhArgument>()
			where TClient : IArgs<TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument, TSeventhArgument>
		{
			if(Args<TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument, TSeventhArgument>.args.TryGetValue(typeof(TClient), out var dependency))
			{
				Args<TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument, TSeventhArgument>.args.Remove(typeof(TClient), out _);
				return !dependency.received;
			}

			return false;
		}

		public static bool Clear<TClient, TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument, TSeventhArgument, TEighthArgument>()
			where TClient : IArgs<TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument, TSeventhArgument, TEighthArgument>
		{
			if(Args<TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument, TSeventhArgument, TEighthArgument>.args.TryGetValue(typeof(TClient), out var dependency))
			{
				Args<TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument, TSeventhArgument, TEighthArgument>.args.Remove(typeof(TClient), out _);
				return !dependency.received;
			}

			return false;
		}

		public static bool Clear<TClient, TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument, TSeventhArgument, TEighthArgument, TNinthArgument>()
			where TClient : IArgs<TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument, TSeventhArgument, TEighthArgument, TNinthArgument>
		{
			if(Args<TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument, TSeventhArgument, TEighthArgument, TNinthArgument>.args.TryGetValue(typeof(TClient), out var dependency))
			{
				Args<TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument, TSeventhArgument, TEighthArgument, TNinthArgument>.args.Remove(typeof(TClient), out _);
				return !dependency.received;
			}

			return false;
		}

		public static bool Clear<TClient, TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument, TSeventhArgument, TEighthArgument, TNinthArgument, TTenthArgument>()
			where TClient : IArgs<TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument, TSeventhArgument, TEighthArgument, TNinthArgument, TTenthArgument>
		{
			if(Args<TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument, TSeventhArgument, TEighthArgument, TNinthArgument, TTenthArgument>.args.TryGetValue(typeof(TClient), out var dependency))
			{
				Args<TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument, TSeventhArgument, TEighthArgument, TNinthArgument, TTenthArgument>.args.Remove(typeof(TClient), out _);
				return !dependency.received;
			}

			return false;
		}

		public static bool Clear<TClient, TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument, TSeventhArgument, TEighthArgument, TNinthArgument, TTenthArgument, TEleventhArgument>()
			where TClient : IArgs<TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument, TSeventhArgument, TEighthArgument, TNinthArgument, TTenthArgument, TEleventhArgument>
		{
			if(Args<TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument, TSeventhArgument, TEighthArgument, TNinthArgument, TTenthArgument, TEleventhArgument>.args.TryGetValue(typeof(TClient), out var dependency))
			{
				Args<TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument, TSeventhArgument, TEighthArgument, TNinthArgument, TTenthArgument, TEleventhArgument>.args.Remove(typeof(TClient), out _);
				return !dependency.received;
			}

			return false;
		}

		public static bool Clear<TClient, TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument, TSeventhArgument, TEighthArgument, TNinthArgument, TTenthArgument, TEleventhArgument, TTwelfthArgument>()
			where TClient : IArgs<TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument, TSeventhArgument, TEighthArgument, TNinthArgument, TTenthArgument, TEleventhArgument, TTwelfthArgument>
		{
			if(Args<TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument, TSeventhArgument, TEighthArgument, TNinthArgument, TTenthArgument, TEleventhArgument, TTwelfthArgument>.args.TryGetValue(typeof(TClient), out var dependency))
			{
				Args<TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument, TSeventhArgument, TEighthArgument, TNinthArgument, TTenthArgument, TEleventhArgument, TTwelfthArgument>.args.Remove(typeof(TClient), out _);
				return !dependency.received;
			}

			return false;
		}

		private readonly struct Arg<TArgument>
		{
			public static readonly Dictionary<Type, Arg<TArgument>> arg = new();

			public readonly TArgument argument;
			public readonly bool received;

			public Arg(TArgument argument, bool received)
			{
				this.argument = argument;
				this.received = received;
			}
		}

		private readonly struct Args<TFirstArgument, TSecondArgument>
		{
			public static readonly Dictionary<Type, Args<TFirstArgument, TSecondArgument>> args = new();

			public readonly TFirstArgument firstArgument;
			public readonly TSecondArgument secondArgument;
			public readonly bool received;

			public Args(TFirstArgument firstArgument, TSecondArgument secondArgument, bool received)
			{
				this.firstArgument = firstArgument;
				this.secondArgument = secondArgument;
				this.received = received;
			}
		}

		private readonly struct Args<TFirstArgument, TSecondArgument, TThirdArgument>
		{
			public static readonly Dictionary<Type, Args<TFirstArgument, TSecondArgument, TThirdArgument>> args = new();

			public readonly TFirstArgument firstArgument;
			public readonly TSecondArgument secondArgument;
			public readonly TThirdArgument thirdArgument;
			public readonly bool received;

			public Args(TFirstArgument firstArgument, TSecondArgument secondArgument, TThirdArgument thirdArgument, bool received)
			{
				this.firstArgument = firstArgument;
				this.secondArgument = secondArgument;
				this.thirdArgument = thirdArgument;
				this.received = received;
			}
		}

		private readonly struct Args<TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument>
		{
			public static readonly Dictionary<Type, Args<TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument>> args = new();

			public readonly TFirstArgument firstArgument;
			public readonly TSecondArgument secondArgument;
			public readonly TThirdArgument thirdArgument;
			public readonly TFourthArgument fourthArgument;
			public readonly bool received;

			public Args(TFirstArgument firstArgument, TSecondArgument secondArgument, TThirdArgument thirdArgument, TFourthArgument fourthArgument, bool received)
			{
				this.firstArgument = firstArgument;
				this.secondArgument = secondArgument;
				this.thirdArgument = thirdArgument;
				this.fourthArgument = fourthArgument;
				this.received = received;
			}
		}

		private readonly struct Args<TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument>
		{
			public static readonly Dictionary<Type, Args<TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument>> args = new();

			public readonly TFirstArgument firstArgument;
			public readonly TSecondArgument secondArgument;
			public readonly TThirdArgument thirdArgument;
			public readonly TFourthArgument fourthArgument;
			public readonly TFifthArgument fifthArgument;
			public readonly bool received;

			public Args(TFirstArgument firstArgument, TSecondArgument secondArgument, TThirdArgument thirdArgument, TFourthArgument fourthArgument, TFifthArgument fifthArgument, bool received)
			{
				this.firstArgument = firstArgument;
				this.secondArgument = secondArgument;
				this.thirdArgument = thirdArgument;
				this.fourthArgument = fourthArgument;
				this.fifthArgument = fifthArgument;
				this.received = received;
			}
		}

		private readonly struct Args<TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument>
		{
			public static readonly Dictionary<Type, Args<TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument>> args = new();

			public readonly TFirstArgument firstArgument;
			public readonly TSecondArgument secondArgument;
			public readonly TThirdArgument thirdArgument;
			public readonly TFourthArgument fourthArgument;
			public readonly TFifthArgument fifthArgument;
			public readonly TSixthArgument sixthArgument;
			public readonly bool received;

			public Args(TFirstArgument firstArgument, TSecondArgument secondArgument, TThirdArgument thirdArgument, TFourthArgument fourthArgument, TFifthArgument fifthArgument, TSixthArgument sixthArgument, bool received)
			{
				this.firstArgument = firstArgument;
				this.secondArgument = secondArgument;
				this.thirdArgument = thirdArgument;
				this.fourthArgument = fourthArgument;
				this.fifthArgument = fifthArgument;
				this.sixthArgument = sixthArgument;
				this.received = received;
			}
		}

		private readonly struct Args<TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument, TSeventhArgument>
		{
			public static readonly Dictionary<Type, Args<TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument, TSeventhArgument>> args = new();

			public readonly TFirstArgument firstArgument;
			public readonly TSecondArgument secondArgument;
			public readonly TThirdArgument thirdArgument;
			public readonly TFourthArgument fourthArgument;
			public readonly TFifthArgument fifthArgument;
			public readonly TSixthArgument sixthArgument;
			public readonly TSeventhArgument seventhArgument;
			public readonly bool received;

			public Args(TFirstArgument firstArgument, TSecondArgument secondArgument, TThirdArgument thirdArgument, TFourthArgument fourthArgument, TFifthArgument fifthArgument, TSixthArgument sixthArgument, TSeventhArgument seventhArgument, bool received)
			{
				this.firstArgument = firstArgument;
				this.secondArgument = secondArgument;
				this.thirdArgument = thirdArgument;
				this.fourthArgument = fourthArgument;
				this.fifthArgument = fifthArgument;
				this.sixthArgument = sixthArgument;
				this.seventhArgument = seventhArgument;
				this.received = received;
			}
		}

		private readonly struct Args<TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument, TSeventhArgument, TEighthArgument>
		{
			public static readonly Dictionary<Type, Args<TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument, TSeventhArgument, TEighthArgument>> args = new();

			public readonly TFirstArgument firstArgument;
			public readonly TSecondArgument secondArgument;
			public readonly TThirdArgument thirdArgument;
			public readonly TFourthArgument fourthArgument;
			public readonly TFifthArgument fifthArgument;
			public readonly TSixthArgument sixthArgument;
			public readonly TSeventhArgument seventhArgument;
			public readonly TEighthArgument eighthArgument;
			public readonly bool received;

			public Args(TFirstArgument firstArgument, TSecondArgument secondArgument, TThirdArgument thirdArgument, TFourthArgument fourthArgument, TFifthArgument fifthArgument, TSixthArgument sixthArgument, TSeventhArgument seventhArgument, TEighthArgument eighthArgument, bool received)
			{
				this.firstArgument = firstArgument;
				this.secondArgument = secondArgument;
				this.thirdArgument = thirdArgument;
				this.fourthArgument = fourthArgument;
				this.fifthArgument = fifthArgument;
				this.sixthArgument = sixthArgument;
				this.seventhArgument = seventhArgument;
				this.eighthArgument = eighthArgument;
				this.received = received;
			}
		}

		private readonly struct Args<TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument, TSeventhArgument, TEighthArgument, TNinthArgument>
		{
			public static readonly Dictionary<Type, Args<TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument, TSeventhArgument, TEighthArgument, TNinthArgument>> args = new();

			public readonly TFirstArgument firstArgument;
			public readonly TSecondArgument secondArgument;
			public readonly TThirdArgument thirdArgument;
			public readonly TFourthArgument fourthArgument;
			public readonly TFifthArgument fifthArgument;
			public readonly TSixthArgument sixthArgument;
			public readonly TSeventhArgument seventhArgument;
			public readonly TEighthArgument eighthArgument;
			public readonly TNinthArgument ninthArgument;
			public readonly bool received;

			public Args(TFirstArgument firstArgument, TSecondArgument secondArgument, TThirdArgument thirdArgument, TFourthArgument fourthArgument, TFifthArgument fifthArgument, TSixthArgument sixthArgument, TSeventhArgument seventhArgument, TEighthArgument eighthArgument, TNinthArgument ninthArgument, bool received)
			{
				this.firstArgument = firstArgument;
				this.secondArgument = secondArgument;
				this.thirdArgument = thirdArgument;
				this.fourthArgument = fourthArgument;
				this.fifthArgument = fifthArgument;
				this.sixthArgument = sixthArgument;
				this.seventhArgument = seventhArgument;
				this.eighthArgument = eighthArgument;
				this.ninthArgument = ninthArgument;
				this.received = received;
			}
		}

		private readonly struct Args<TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument, TSeventhArgument, TEighthArgument, TNinthArgument, TTenthArgument>
		{
			public static readonly Dictionary<Type, Args<TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument, TSeventhArgument, TEighthArgument, TNinthArgument, TTenthArgument>> args = new();

			public readonly TFirstArgument firstArgument;
			public readonly TSecondArgument secondArgument;
			public readonly TThirdArgument thirdArgument;
			public readonly TFourthArgument fourthArgument;
			public readonly TFifthArgument fifthArgument;
			public readonly TSixthArgument sixthArgument;
			public readonly TSeventhArgument seventhArgument;
			public readonly TEighthArgument eighthArgument;
			public readonly TNinthArgument ninthArgument;
			public readonly TTenthArgument tenthArgument;
			public readonly bool received;

			public Args(TFirstArgument firstArgument, TSecondArgument secondArgument, TThirdArgument thirdArgument, TFourthArgument fourthArgument, TFifthArgument fifthArgument, TSixthArgument sixthArgument, TSeventhArgument seventhArgument, TEighthArgument eighthArgument, TNinthArgument ninthArgument, TTenthArgument tenthArgument, bool received)
			{
				this.firstArgument = firstArgument;
				this.secondArgument = secondArgument;
				this.thirdArgument = thirdArgument;
				this.fourthArgument = fourthArgument;
				this.fifthArgument = fifthArgument;
				this.sixthArgument = sixthArgument;
				this.seventhArgument = seventhArgument;
				this.eighthArgument = eighthArgument;
				this.ninthArgument = ninthArgument;
				this.tenthArgument = tenthArgument;
				this.received = received;
			}
		}

		private readonly struct Args<TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument, TSeventhArgument, TEighthArgument, TNinthArgument, TTenthArgument, TEleventhArgument>
		{
			public static readonly Dictionary<Type, Args<TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument, TSeventhArgument, TEighthArgument, TNinthArgument, TTenthArgument, TEleventhArgument>> args = new();

			public readonly TFirstArgument firstArgument;
			public readonly TSecondArgument secondArgument;
			public readonly TThirdArgument thirdArgument;
			public readonly TFourthArgument fourthArgument;
			public readonly TFifthArgument fifthArgument;
			public readonly TSixthArgument sixthArgument;
			public readonly TSeventhArgument seventhArgument;
			public readonly TEighthArgument eighthArgument;
			public readonly TNinthArgument ninthArgument;
			public readonly TTenthArgument tenthArgument;
			public readonly TEleventhArgument eleventhArgument;
			public readonly bool received;

			public Args(TFirstArgument firstArgument, TSecondArgument secondArgument, TThirdArgument thirdArgument, TFourthArgument fourthArgument, TFifthArgument fifthArgument, TSixthArgument sixthArgument, TSeventhArgument seventhArgument, TEighthArgument eighthArgument, TNinthArgument ninthArgument, TTenthArgument tenthArgument, TEleventhArgument eleventhArgument, bool received)
			{
				this.firstArgument = firstArgument;
				this.secondArgument = secondArgument;
				this.thirdArgument = thirdArgument;
				this.fourthArgument = fourthArgument;
				this.fifthArgument = fifthArgument;
				this.sixthArgument = sixthArgument;
				this.seventhArgument = seventhArgument;
				this.eighthArgument = eighthArgument;
				this.ninthArgument = ninthArgument;
				this.tenthArgument = tenthArgument;
				this.eleventhArgument = eleventhArgument;
				this.received = received;
			}
		}

		private readonly struct Args<TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument, TSeventhArgument, TEighthArgument, TNinthArgument, TTenthArgument, TEleventhArgument, TTwelfthArgument>
		{
			public static readonly Dictionary<Type, Args<TFirstArgument, TSecondArgument, TThirdArgument, TFourthArgument, TFifthArgument, TSixthArgument, TSeventhArgument, TEighthArgument, TNinthArgument, TTenthArgument, TEleventhArgument, TTwelfthArgument>> args = new();

			public readonly TFirstArgument firstArgument;
			public readonly TSecondArgument secondArgument;
			public readonly TThirdArgument thirdArgument;
			public readonly TFourthArgument fourthArgument;
			public readonly TFifthArgument fifthArgument;
			public readonly TSixthArgument sixthArgument;
			public readonly TSeventhArgument seventhArgument;
			public readonly TEighthArgument eighthArgument;
			public readonly TNinthArgument ninthArgument;
			public readonly TTenthArgument tenthArgument;
			public readonly TEleventhArgument eleventhArgument;
			public readonly TTwelfthArgument twelfthArgument;
			public readonly bool received;

			public Args(TFirstArgument firstArgument, TSecondArgument secondArgument, TThirdArgument thirdArgument, TFourthArgument fourthArgument, TFifthArgument fifthArgument, TSixthArgument sixthArgument, TSeventhArgument seventhArgument, TEighthArgument eighthArgument, TNinthArgument ninthArgument, TTenthArgument tenthArgument, TEleventhArgument eleventhArgument, TTwelfthArgument twelfthArgument, bool received)
			{
				this.firstArgument = firstArgument;
				this.secondArgument = secondArgument;
				this.thirdArgument = thirdArgument;
				this.fourthArgument = fourthArgument;
				this.fifthArgument = fifthArgument;
				this.sixthArgument = sixthArgument;
				this.seventhArgument = seventhArgument;
				this.eighthArgument = eighthArgument;
				this.ninthArgument = ninthArgument;
				this.tenthArgument = tenthArgument;
				this.eleventhArgument = eleventhArgument;
				this.twelfthArgument = twelfthArgument;
				this.received = received;
			}
		}
	}
}