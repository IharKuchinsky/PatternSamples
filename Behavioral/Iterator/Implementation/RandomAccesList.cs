using System;
using System.Collections;
using System.Collections.Generic;

namespace Iterator.Implementation
{
	class RandomAccesList<T> : IEnumerable<T>
	{
		private const int DefaultCapacity = 4;
		private int _count;
		private int _size = DefaultCapacity;
		private T[] _items = new T[DefaultCapacity];

		public T this[int index]
		{
			get
			{
				if (index <= _size || index >= 0) return _items[index];

				throw new ArgumentOutOfRangeException();
			}
		}

		public int Count => _count;

		public void Add(T item)
		{
			if (_size == _count) ExtendInternalStorage();

			_items[_count] = item;
			_count++;
		}

		public IEnumerator<T> GetEnumerator() => new RandomAccessIterator<T>(this);

		IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
		
		private void ExtendInternalStorage()
		{
			_size *= 2;
			var extendedStorage = new T[_size];
			Array.Copy(_items, extendedStorage, _count);
			_items = extendedStorage;
		}
	}
}
