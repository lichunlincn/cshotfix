using System;
using System.Collections;
using System.Collections.Generic;
namespace Editor_Mono.Collections.Generic
{
	public sealed class ReadOnlyCollection<T> : Collection<T>, ICollection<T>, IEnumerable<T>, IList, ICollection, IEnumerable
	{
		private static ReadOnlyCollection<T> empty;
		public static ReadOnlyCollection<T> Empty
		{
			get
			{
				ReadOnlyCollection<T> arg_14_0;
				if ((arg_14_0 = ReadOnlyCollection<T>.empty) == null)
				{
					arg_14_0 = (ReadOnlyCollection<T>.empty = new ReadOnlyCollection<T>());
				}
				return arg_14_0;
			}
		}
		bool ICollection<T>.IsReadOnly
		{
			get
			{
				return true;
			}
		}
		bool IList.IsFixedSize
		{
			get
			{
				return true;
			}
		}
		bool IList.IsReadOnly
		{
			get
			{
				return true;
			}
		}
		private ReadOnlyCollection()
		{
		}
		public ReadOnlyCollection(T[] array)
		{
			if (array == null)
			{
				throw new ArgumentNullException();
			}
			this.Initialize(array, array.Length);
		}
		public ReadOnlyCollection(Collection<T> collection)
		{
			if (collection == null)
			{
				throw new ArgumentNullException();
			}
			this.Initialize(collection.items, collection.size);
		}
		private void Initialize(T[] items, int size)
		{
			this.items = new T[size];
			Array.Copy(items, 0, this.items, 0, size);
			this.size = size;
		}
		internal override void Grow(int desired)
		{
			throw new InvalidOperationException();
		}
		protected override void OnAdd(T item, int index)
		{
			throw new InvalidOperationException();
		}
		protected override void OnClear()
		{
			throw new InvalidOperationException();
		}
		protected override void OnInsert(T item, int index)
		{
			throw new InvalidOperationException();
		}
		protected override void OnRemove(T item, int index)
		{
			throw new InvalidOperationException();
		}
		protected override void OnSet(T item, int index)
		{
			throw new InvalidOperationException();
		}
	}
}
