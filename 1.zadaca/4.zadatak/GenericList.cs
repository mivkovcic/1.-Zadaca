using System;
using System.Collections.Generic;

namespace _4.zadatak
{
    public class GenericList<X> : IGenericList<X>
    {
        private X[] _internalStorage;
        private int _currentIndex;
        private int _currentSize;

        public GenericList()
        {
            _internalStorage = new X[4];
            _currentSize = 4;
            _currentIndex = 0;
        }

        public GenericList(int initialSize)
        {
            _internalStorage = new X[initialSize];
            _currentSize = initialSize;
            _currentIndex = 0;
        }

        public void Add(X item)
        {
            if (_currentIndex == _currentSize)
            {
                X[] tempStorage = new X[_currentSize];
                _internalStorage.CopyTo(tempStorage, 0);
                _currentSize *= 2;
                _internalStorage = new X[_currentSize];
                tempStorage.CopyTo(_internalStorage, 0);
            }
            _internalStorage[_currentIndex++] = item;
        }

        public bool Remove(X item)
        {
            int index = _currentSize;
            for (int i = 0; i < _currentSize; i++)
            {
                if (_internalStorage[i].Equals(item))
                {
                    index = i;
                    break;
                }
            }
            return RemoveAt(index);
        }

        public bool RemoveAt(int index)
        {
            if (index >= _currentIndex)
            {
                return false;
            }
            if (index == _currentSize - 1)
            {
                _internalStorage[index] = default(X);
            }
            else
            {
                for (int i = index; i < _currentIndex;)
                {
                    _internalStorage[i++] = _internalStorage[i];
                }
            }
            _currentIndex--;
            return true;
        }

        public X GetElement(int index)
        {
            if (index < _currentSize)
            {
                return _internalStorage[index];
            }
            throw new IndexOutOfRangeException();
        }

        public int IndexOf(X item)
        {
            for (int i = 0; i < _currentSize; i++)
            {
                if (_internalStorage[i].Equals(item))
                {
                    return i;
                }
            }
            return -1;
        }

        public int Count
        {
            get
            {
                return _currentIndex;
            }
        }

        public void Clear()
        {
            _internalStorage = new X[_currentSize];
            _currentIndex = 0;
        }

        public bool Contains(X item)
        {
            for (int i = 0; i < _currentSize; i++)
            {
                if (_internalStorage[i].Equals(item))
                {
                    return true;
                }
            }
            return false;
        }

        public IEnumerator<X> GetEnumerator()
        {
            return new GenericListEnumerator<X>(this);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
