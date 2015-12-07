using System.Collections.Generic;

namespace _4.zadatak
{
    public class GenericListEnumerator<T> : IEnumerator<T>
    {
        IGenericList<T> _collection;
        int position;

        public GenericListEnumerator(IGenericList<T> collection)
        {
            _collection = collection;
            position = -1;
        }

        public bool MoveNext()
        {
            position++;
            return (position < _collection.Count);
        }

        public T Current
        {
            get
            {
                return _collection.GetElement(position);
            }
        }

        object System.Collections.IEnumerator.Current
        {
            get { return Current; }
        }

        public void Dispose()
        {
            // Ignorirajte
        }

        public void Reset()
        {
            // Ignorirajte
        }
    }
}
