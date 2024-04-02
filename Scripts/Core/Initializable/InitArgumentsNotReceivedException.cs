using System;
using System.Collections.Generic;
using System.Text;

namespace Sisus.Init
{
	/// <summary>
	/// The exception that is thrown when arguments have been provided for an object being initialized but it fails to receive them.
	/// </summary>
	public sealed class InitArgumentsNotReceivedException : InitArgsException
	{
		static readonly Dictionary<Type, int> argumentCountsByIInitializableTypeDefinition = new(12)
		{
			{ typeof(IInitializable<>), 1 },
			{ typeof(IInitializable<,>), 2 },
			{ typeof(IInitializable<,,>), 3 },
			{ typeof(IInitializable<,,,>), 4 },
			{ typeof(IInitializable<,,,,>), 5 },
			{ typeof(IInitializable<,,,,,>), 6 },
			{ typeof(IInitializable<,,,,,,>), 7 },
			{ typeof(IInitializable<,,,,,,,>), 8 },
			{ typeof(IInitializable<,,,,,,,,>), 9 },
			{ typeof(IInitializable<,,,,,,,,,>), 10 },
			{ typeof(IInitializable<,,,,,,,,,,>), 11 },
			{ typeof(IInitializable<,,,,,,,,,,,>), 12 }
		};

		/// <summary>
		/// Initializes a new instance of the <see cref="InitArgumentsNotReceivedException"/> class.
		/// </summary>
		public InitArgumentsNotReceivedException() : base(GenerateMessage(null, null)) { }

		/// <summary>
		/// Initializes a new instance of the <see cref="InitArgumentsNotReceivedException"/> class.
		/// </summary>
		/// <param name="methodName"> Name of the method from which the exception originates. </param>
		public InitArgumentsNotReceivedException(string methodName) : base(GenerateMessage(methodName, null)) { }

		/// <summary>
		/// Initializes a new instance of the <see cref="InitArgumentsNotReceivedException"/> class.
		/// </summary>
		/// <param name="methodName"> Name of the method from which the exception originates. </param>
		/// <param name="clientType"> Type of the client that failed to receive the arguments. </param>
		public InitArgumentsNotReceivedException(string methodName, Type clientType) : base(GenerateMessage(methodName, clientType)) { }

		/// <summary>
		/// Initializes a new instance of the <see cref="InitArgumentsNotReceivedException"/> class.
		/// </summary>
		/// <param name="clientType"> Type of the client that failed to receive the arguments. </param>
		public InitArgumentsNotReceivedException(Type clientType) : base(GenerateMessage(null, clientType)) { }

		/// <summary>
		/// Initializes a new instance of the <see cref="InitArgumentsNotReceivedException"/> class.
		/// </summary>
		/// <param name="client"> The client object that failed to receive the arguments. </param>
		public InitArgumentsNotReceivedException(object client) : base(GenerateMessage(null, client?.GetType())) { }

		/// <summary>
		/// Initializes a new instance of the <see cref="InitArgumentsNotReceivedException"/> class.
		/// </summary>
		/// <param name="methodName"> Name of the method from which the exception originates. </param>
		/// <param name="inner">
		/// The exception that is the cause of the current exception. If the innerException parameter is not a null reference, the current exception is raised in a catch block that handles the inner exception.
		/// </param>
		public InitArgumentsNotReceivedException(string methodName, Exception inner) : base(GenerateMessage(methodName, null), inner) { }

		private static string GenerateMessage(string methodName, Type clientType)
		{
			if(clientType != null)
			{
				foreach(var interfaceType in clientType.GetInterfaces())
				{
					if(!interfaceType.IsGenericType)
					{
						continue;
					}

					var genericTypeDefinition = interfaceType.IsGenericTypeDefinition ? interfaceType : interfaceType.GetGenericTypeDefinition();
					Type initializableType = null;
					if(argumentCountsByIInitializableTypeDefinition.TryGetValue(genericTypeDefinition, out _))
					{
						initializableType = interfaceType;
					}

					if(initializableType != null)
					{
						var sb = new StringBuilder();
						if(!string.IsNullOrEmpty(methodName))
						{
							sb.Append(methodName);
							sb.Append(" called for ");
							sb.Append(clientType.Name);
							sb.Append(" that implements ");
							sb.Append(initializableType.Name);
							sb.Append(" but it still somehow did not receive the provided arguments during initialization.");
						}
						else
						{
							sb.Append(clientType.Name);
							sb.Append(" implements ");
							sb.Append(initializableType.Name);
							sb.Append(" but still somehow did not receive the provided arguments during initialization.");
						}

						return sb.ToString();
					}
				}

				if(typeof(IInitializable).IsAssignableFrom(clientType))
				{
					if(!string.IsNullOrEmpty(methodName))
					{
						return $"{methodName}() called but {clientType.Name} that implements IInitializable did it failed to retrieve all the services it depends on.";
					}

					return $"{clientType.Name} does not implement IInitializable<T...> and did not receive the provided arguments during initialization.";
				}

				if(!string.IsNullOrEmpty(methodName))
				{
					return $"{methodName}() called but {clientType.Name} does not implement any IInitializable<T...> interface and did not receive the provided arguments during initialization.";
				}

				return $"{clientType.Name} does not implement any IInitializable<T...> interface and did not receive the provided arguments during initialization.";
			}
			
			if(!string.IsNullOrEmpty(methodName))
			{
				return $"{methodName}() called but client does not implement IInitializable<T...> and did not receive the provided arguments during initialization.";
			}

			return "Client does not implement IInitializable<T...> and did not receive the provided arguments during initialization.";
		}
	}
}