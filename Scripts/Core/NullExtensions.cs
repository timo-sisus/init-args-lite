using System;
using System.Diagnostics;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Sisus
{
	/// <summary>
	/// Helper class for checking whether the value of a variable that is of <see cref="object"/>, interface or generic
	/// type is <see langword="null"/>, <see cref="Object.Destroy">destroyed</see> or <see cref="GameObject.activeInHierarchy">inactive</see>.
	/// <para>
	/// By adding a using static directive it is possible to access the static members of the
	/// <see cref="NullExtensions"/> class without having to qualify the access with the type name, making it possible
	/// to perform safe and reliable null-checking conveniently by comparing objects against <see cref="Null"/>.
	/// </para>
	/// <example>
	/// <code>
	/// using Sisus.Init;
	/// using static Sisus.NullExtensions;
	/// 
	/// public class EventListener : MonoBehaviour{IEvent}, IEventListener
	/// {
	///		private IEvent trigger;
	/// 
	///		protected override void Init(IEventBroadcaster trigger)
	///		{
	///			this.trigger = trigger;
	///		}
	/// 
	///		private void OnEnable()
	///		{
	///			trigger.AddListener(this);
	///		}
	/// 
	///		private void OnEvent()
	///		{
	///			Debug.Log($"{name} heard event {trigger}.");
	///		}
	/// 
	///		private void OnDisable()
	///		{
	///			if(trigger != Null)
	///			{
	///				trigger.RemoveListener(this);
	///			}
	///		}
	/// }
	/// </code>
	/// </example>
	/// </summary>
	public static class NullExtensions
	{
		/// <summary>
		/// A value against which any <see cref="object"/> can be compared to determine whether or not it is
		/// <see langword="null"/> or an <see cref="Object"/> which has been <see cref="Object.Destroy">destroyed</see>.
		/// <example>
		/// <code>
		/// using static Sisus.NullExtensions;
		/// 
		/// public class EventListener : MonoBehaviour{IEvent}, IEventListener
		/// {
		///		private IEvent trigger;
		/// 
		///		protected override void Init(IEventBroadcaster trigger)
		///		{
		///			this.trigger = trigger;
		///		}
		/// 
		///		private void OnEnable()
		///		{
		///			trigger.AddListener(this);
		///		}
		/// 
		///		private void OnEvent()
		///		{
		///			Debug.Log($"{name} heard event {trigger}.");
		///		}
		/// 
		///		private void OnDisable()
		///		{
		///			if(trigger != Null)
		///			{
		///				trigger.RemoveListener(this);
		///			}
		///		}
		/// }
		/// </code>
		/// </example>
		/// </summary>
		public static readonly NullComparer Null = new NullComparer();

		/// <summary>
		/// Throws an <see cref="ArgumentNullException"/> if <paramref name="reference"/>
		/// is <see langword="null"/> or a destroyed <see cref="Object"/>.
		/// <para>
		/// This method will only execute in the editor and in development builds;
		/// all calls made to this method will be completely stripped out of release builds.
		/// </para>
		/// </summary>
		/// <typeparam name="TObject"> Type of the object to check. </typeparam>
		/// <param name="reference"> Object to guard against being <see langword="null"/>. </param>
		/// <param name="exceptionMessage">
		/// Exception message to show in the Console if reference is <see langword="null"/>.
		/// <para>
		/// If the message contains "{0}" then that will be replaced with the
		/// name of the <typeparamref name="TObject"/> type.
		/// </para>
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Thrown if <paramref name="reference"/> is <see langword="null"/> or a destroyed <see cref="Object"/>.
		/// </exception>
		[Conditional("DEBUG")]
		public static void ThrowIfNull<TObject>(TObject reference, string exceptionMessage)
		{
			#if DEBUG
			if(reference == Null)
			{
				throw new ArgumentNullException(string.Format(exceptionMessage, typeof(TObject).Name), default(Exception));
			}
			#endif
		}

		/// <summary>
		/// Throws an <see cref="ArgumentNullException"/> if <paramref name="reference"/>
		/// is <see langword="null"/> or a destroyed <see cref="Object"/>.
		/// <para>
		/// This method will only execute in the editor and in development builds;
		/// all calls made to this method will be completely stripped out of release builds.
		/// </para>
		/// </summary>
		/// <param name="reference"> Object to guard against being <see langword="null"/>. </param>
		/// <param name="exceptionMessage">
		/// Exception message to show in the Console if reference is <see langword="null"/>.
		/// <para>
		/// If the message contains "{0}" then that will be replaced with the
		/// name of the provided <paramref name="type"/>.
		/// </para>
		/// </param>
		/// <param name="type"> Type information to include in the message. </param>
		/// <exception cref="ArgumentNullException">
		[Conditional("DEBUG")]
		public static void ThrowIfNull(Object reference, string exceptionMessage, Type type)
		{
			#if DEBUG
			if(reference == null)
			{
				throw new ArgumentNullException(string.Format(exceptionMessage, type.Name, default(Exception)));
			}
			#endif
		}

		/// <summary>
		/// Throws an <see cref="ArgumentNullException"/> if <paramref name="reference"/>
		/// is <see langword="null"/> or a destroyed <see cref="Object"/>.
		/// <para>
		/// This method will only execute in the editor and in development builds;
		/// all calls made to this method will be completely stripped out of release builds.
		/// </para>
		/// </summary>
		/// <param name="reference"> Object to guard against being <see langword="null"/>. </param>
		/// <param name="exceptionMessage">
		/// Exception message to show in the Console if reference is <see langword="null"/>.
		/// <para>
		/// If the message contains "{0}" then that will be replaced with the
		/// name of the provided <paramref name="type"/>.
		/// </para>
		/// </param>
		/// <param name="type"> Type information to include in the message. </param>
		/// <exception cref="ArgumentNullException">
		[Conditional("DEBUG")]
		public static void ThrowIfNull(object reference, string exceptionMessage, Type type)
		{
			#if DEBUG
			if(reference == Null)
			{
				throw new ArgumentNullException(string.Format(exceptionMessage, type.Name), default(Exception));
			}
			#endif
		}

		/// <summary>
		/// Represents a <see langword="null"/> reference or an <see cref="Object"/> that has been <see cref="Object.Destroy">destroyed</see>.
		/// </summary>
		public sealed class NullComparer
		{
			internal NullComparer() { }

			public override bool Equals(object obj) => obj is Object unityObject ? unityObject == null : obj is null;
			public override int GetHashCode() => 0;
			public override string ToString() => "Null";

			/// <summary>
			/// Determines whether the specified <paramref name="unityObject"/> is a <see langword="null"/> reference or has been <see cref="Object.Destroy">destroyed</see>.
			/// </summary>
			/// <param name="@object"> The <see cref="Object"/> to check. </param>
			/// <returns> <see langword="true"/> if the specified <see cref="Object"/> is a <see langword="null"/> reference or has been <see cref="Object.Destroy">destroyed; otherwise, <see langword="false"/>. </returns>
			public static bool operator ==(Object unityObject, NullComparer @null) =>
				unityObject == null;

			/// <summary>
			/// Determines whether the specified <paramref name="unityObject"/> is not a <see langword="null"/> reference and has not been <see cref="Object.Destroy">destroyed</see>.
			/// </summary>
			/// <param name="@object"> The <see cref="Object"/> to check. </param>
			/// <returns> <see langword="true"/> if the specified <see cref="Object"/> is not a <see langword="null"/> reference and has not been <see cref="Object.Destroy">destroyed; otherwise, <see langword="false"/>. </returns>
			public static bool operator !=(Object unityObject, NullComparer @null) =>
				unityObject != null;

			/// <summary>
			/// Determines whether the specified <paramref name="object"/> is a <see langword="null"/> reference or an <see cref="Object"/> that has been <see cref="Object.Destroy">destroyed</see>.
			/// </summary>
			/// <param name="@object"> The <see cref="object"/> to check. </param>
			/// <returns> <see langword="true"/> if the specified <see cref="object"/> is a <see langword="null"/> reference or an <see cref="Object"/> that has been <see cref="Object.Destroy">destroyed; otherwise, <see langword="false"/>. </returns>
			public static bool operator ==(object @object, NullComparer @null) =>
				@object is Object unityObject ? unityObject == null : @object is null;

			/// <summary>
			/// Determines whether the specified <paramref name="object"/> is not a <see langword="null"/> reference or an <see cref="Object"/> that has been <see cref="Object.Destroy">destroyed</see>.
			/// </summary>
			/// <param name="@object"> The <see cref="object"/> to check. </param>
			/// <returns> <see langword="true"/> if the specified <see cref="object"/> is not a <see langword="null"/> reference or an <see cref="Object"/> that has been <see cref="Object.Destroy">destroyed; otherwise, <see langword="false"/>. </returns>
			public static bool operator !=(object @object, NullComparer @null) =>
				@object is Object unityObject ? unityObject != null : !(@object is null);
		}
	}
}