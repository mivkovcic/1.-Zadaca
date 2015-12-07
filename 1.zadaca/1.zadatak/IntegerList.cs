using System;

namespace _1.zadatak
{
    public class IntegerList : IIntegerList
    {
        private int[] _internalStorage;
        private int _currentIndex;
        private int _currentSize;

        public IntegerList()
        {
            _internalStorage = new int[4];
            _currentSize = 4;
            _currentIndex = 0;
        }

        public IntegerList(int initialSize)
        {
            _internalStorage = new int[initialSize];
            _currentSize = initialSize;
            _currentIndex = 0;
        }

        public void Add(int item)
        {
            if (_currentIndex == _currentSize)
            {
                int[] tempStorage = new int[_currentSize];
                _internalStorage.CopyTo(tempStorage, 0);
                _currentSize *= 2;
                _internalStorage = new int[_currentSize];
                tempStorage.CopyTo(_internalStorage, 0);
            }
            _internalStorage[_currentIndex++] = item;
        }

        public bool Remove(int item)
        {
            int index = _currentSize;
            for (int i = 0; i < _currentSize; i++)
            {
                if (_internalStorage[i] == item)
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
                _internalStorage[index] = 0;
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

        public int GetElement(int index)
        {
            if (index < _currentSize)
            {
                return _internalStorage[index];
            }
            throw new IndexOutOfRangeException();
        }

        public int IndexOf(int item)
        {
            for (int i = 0; i < _currentSize; i++)
            {
                if (_internalStorage[i] == item)
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
            _internalStorage = new int[_currentSize];
            _currentIndex = 0;
        }

        public bool Contains(int item)
        {
            for (int i = 0; i < _currentSize; i++)
            {
                if (_internalStorage[i] == item)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
