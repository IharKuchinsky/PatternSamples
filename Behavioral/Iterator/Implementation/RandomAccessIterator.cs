using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace Iterator.Implementation
{
	class RandomAccessIterator<T> : IEnumerator<T>
	{
		private readonly Random _random = new Random(DateTime.Now.Millisecond);
		private int[] _visitedIndexes;
		private int _visitedElementsCount = 0;
		private int _currentIndex = 0;
		private readonly int _count;
		private readonly RandomAccesList<T> _randomAccesList;

		public RandomAccessIterator(RandomAccesList<T> list)
		{
			_randomAccesList = list;
			_count = list.Count;
			_currentIndex = NextRandom();
			_visitedIndexes = ResetRandomIterator();
		}

		public bool MoveNext()
		{
			if (_visitedElementsCount < _count) GetNextRandomIndex();
			else return false;
			
			return _visitedElementsCount <= _count;
		}

		public void Reset()
		{
			_visitedIndexes = ResetRandomIterator();
			_currentIndex = NextRandom();
		}

		public T Current
		{
			get
			{
				if (_currentIndex < 0 || _currentIndex > _count) throw new InvalidEnumArgumentException();
				return _randomAccesList[_currentIndex];
			}
		}

		object IEnumerator.Current => Current;

		public void Dispose()
		{
			//throw new NotImplementedException();
		}

		private int NextRandom()
		{
			return _random.Next(0, _count);
		}

		private int[] ResetRandomIterator()
		{
			_visitedElementsCount = 0;
			return Enumerable.Repeat(-1, _count).ToArray();
		}

		private void GetNextRandomIndex()
		{
			while (Array.Exists(_visitedIndexes, element => element == _currentIndex)) _currentIndex = NextRandom();

			_visitedIndexes[_visitedElementsCount] = _currentIndex;
			_visitedElementsCount++;
		}
	}
}
