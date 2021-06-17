using Editor_Mono.Cecil;
using System;
using System.Collections;
using System.Collections.Generic;
namespace Editor_Mono.Collections.Generic
{
	public class Collection<T> : IList<T>, ICollection<T>, IEnumerable<T>, IList, ICollection, IEnumerable
	{
		public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
		{
			private Collection<T> collection;
			private T current;
			private int next;
			private readonly int version;
			public T Current
			{
				get
				{
					return this.current;
				}
			}
			object IEnumerator.Current
			{
				get
				{
					this.CheckState();
					if (this.next <= 0)
					{
						throw new InvalidOperationException();
					}
					return this.current;
				}
			}
			internal Enumerator(Collection<T> collection)
			{
				this = default(Collection<T>.Enumerator);
				this.collection = collection;
				this.version = collection.version;
			}
			public bool MoveNext()
			{
				this.CheckState();
				if (this.next < 0)
				{
					return false;
				}
				if (this.next < this.collection.size)
				{
					this.current = this.collection.items[this.next++];
					return true;
				}
				this.next = -1;
				return false;
			}
			public void Reset()
			{
				this.CheckState();
				this.next = 0;
			}
			private void CheckState()
			{
				if (this.collection == null)
				{
					throw new ObjectDisposedException(base.GetType().FullName);
				}
				if (this.version != this.collection.version)
				{
					throw new InvalidOperationException();
				}
			}
			public void Dispose()
			{
				this.collection = null;
			}
		}
		internal T[] items;
		internal int size;
		private int version;
		public int Count
		{
			get
			{
				return this.size;
			}
		}
		public T this[int index]
		{
			get
			{
				if (index >= this.size)
				{
					throw new ArgumentOutOfRangeException();
				}
				return this.items[index];
			}
			set
			{
				this.CheckIndex(index);
				if (index == this.size)
				{
					throw new ArgumentOutOfRangeException();
				}
				this.OnSet(value, index);
				this.items[index] = value;
			}
		}
		public int Capacity
		{
			get
			{
				return this.items.Length;
			}
			set
			{
				if (value < 0 || value < this.size)
				{
					throw new ArgumentOutOfRangeException();
				}
				this.Resize(value);
			}
		}
		bool ICollection<T>.IsReadOnly
		{
			get
			{
				return false;
			}
		}
		bool IList.IsFixedSize
		{
			get
			{
				return false;
			}
		}
		bool IList.IsReadOnly
		{
			get
			{
				return false;
			}
		}
		object IList.this[int index]
		{
			get
			{
				return this[index];
			}
			set
			{
				this.CheckIndex(index);
				try
				{
					this[index] = (T)((object)value);
					return;
				}
				catch (InvalidCastException)
				{
				}
				catch (NullReferenceException)
				{
				}
				throw new ArgumentException();
			}
		}
		int ICollection.Count
		{
			get
			{
				return this.Count;
			}
		}
		bool ICollection.IsSynchronized
		{
			get
			{
				return false;
			}
		}
		object ICollection.SyncRoot
		{
			get
			{
				return this;
			}
		}
		public Collection()
		{
			this.items = Empty<T>.Array;
		}
		public Collection(int capacity)
		{
			if (capacity < 0)
			{
				throw new ArgumentOutOfRangeException();
			}
			this.items = new T[capacity];
		}
		public Collection(ICollection<T> items)
		{
			if (items == null)
			{
				throw new ArgumentNullException("items");
			}
			this.items = new T[items.Count];
			items.CopyTo(this.items, 0);
			this.size = this.items.Length;
		}
		public void Add(T item)
		{
			if (this.size == this.items.Length)
			{
				this.Grow(1);
			}
			this.OnAdd(item, this.size);
			this.items[this.size++] = item;
			this.version++;
		}
		public bool Contains(T item)
		{
			return this.IndexOf(item) != -1;
		}
		public int IndexOf(T item)
		{
			return Array.IndexOf<T>(this.items, item, 0, this.size);
		}
		public void Insert(int index, T item)
		{
			this.CheckIndex(index);
			if (this.size == this.items.Length)
			{
				this.Grow(1);
			}
			this.OnInsert(item, index);
			this.Shift(index, 1);
			this.items[index] = item;
			this.version++;
		}
		public void RemoveAt(int index)
		{
			if (index < 0 || index >= this.size)
			{
				throw new ArgumentOutOfRangeException();
			}
			T item = this.items[index];
			this.OnRemove(item, index);
			this.Shift(index, -1);
			this.version++;
		}
		public bool Remove(T item)
		{
			int num = this.IndexOf(item);
			if (num == -1)
			{
				return false;
			}
			this.OnRemove(item, num);
			this.Shift(num, -1);
			this.version++;
			return true;
		}
		public void Clear()
		{
			this.OnClear();
			Array.Clear(this.items, 0, this.size);
			this.size = 0;
			this.version++;
		}
		public void CopyTo(T[] array, int arrayIndex)
		{
			Array.Copy(this.items, 0, array, arrayIndex, this.size);
		}
		public T[] ToArray()
		{
			T[] array = new T[this.size];
			Array.Copy(this.items, 0, array, 0, this.size);
			return array;
		}
		private void CheckIndex(int index)
		{
			if (index < 0 || index > this.size)
			{
				throw new ArgumentOutOfRangeException();
			}
		}
		private void Shift(int start, int delta)
		{
			if (delta < 0)
			{
				start -= delta;
			}
			if (start < this.size)
			{
				Array.Copy(this.items, start, this.items, start + delta, this.size - start);
			}
			this.size += delta;
			if (delta < 0)
			{
				Array.Clear(this.items, this.size, -delta);
			}
		}
		protected virtual void OnAdd(T item, int index)
		{
		}
		protected virtual void OnInsert(T item, int index)
		{
		}
		protected virtual void OnSet(T item, int index)
		{
		}
		protected virtual void OnRemove(T item, int index)
		{
		}
		protected virtual void OnClear()
		{
		}
        internal virtual void Grow(int desired)
        {
            int new_size = size + desired;
            if (new_size <= items.Length)
                return;

            const int default_capacity = 4;

            new_size = System.Math.Max(
                System.Math.Max(items.Length * 2, default_capacity),
                new_size);

            Resize(new_size);
        }
        protected void Resize(int new_size)
		{
			if (new_size == this.size)
			{
				return;
			}
			if (new_size < this.size)
			{
				throw new ArgumentOutOfRangeException();
			}
			this.items = this.items.Resize(new_size);
		}
		int IList.Add(object value)
		{
			try
			{
				this.Add((T)((object)value));
				return this.size - 1;
			}
			catch (InvalidCastException)
			{
			}
			catch (NullReferenceException)
			{
			}
			throw new ArgumentException();
		}
		void IList.Clear()
		{
			this.Clear();
		}
		bool IList.Contains(object value)
		{
			return ((IList)this).IndexOf(value) > -1;
		}
		int IList.IndexOf(object value)
		{
			try
			{
				return this.IndexOf((T)((object)value));
			}
			catch (InvalidCastException)
			{
			}
			catch (NullReferenceException)
			{
			}
			return -1;
		}
		void IList.Insert(int index, object value)
		{
			this.CheckIndex(index);
			try
			{
				this.Insert(index, (T)((object)value));
				return;
			}
			catch (InvalidCastException)
			{
			}
			catch (NullReferenceException)
			{
			}
			throw new ArgumentException();
		}
		void IList.Remove(object value)
		{
			try
			{
				this.Remove((T)((object)value));
			}
			catch (InvalidCastException)
			{
			}
			catch (NullReferenceException)
			{
			}
		}
		void IList.RemoveAt(int index)
		{
			this.RemoveAt(index);
		}
		void ICollection.CopyTo(Array array, int index)
		{
			Array.Copy(this.items, 0, array, index, this.size);
		}
		public Collection<T>.Enumerator GetEnumerator()
		{
			return new Collection<T>.Enumerator(this);
		}
		IEnumerator IEnumerable.GetEnumerator()
		{
			return new Collection<T>.Enumerator(this);
		}
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return new Collection<T>.Enumerator(this);
		}
	}
}
