using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Practical2_OPPPO.Collections.Entrails;

namespace Practical2_OPPPO.Collections
{
    class MyList<T> : IEnumerable<T>
    {
        private Node<T> _first;
        private Node<T> _last;

        public int Count { get; private set; }

        public MyList()
        {
            _first = null;
            _last = null;
            Count = 0;
        }

        public void Add(T value)
        {
            if (_first == null)
            {
                _first = new Node<T>(value);
                _last = _first;
                _first.Next = _last;
            }
            else
            {
                Node<T> newNode = new Node<T>(value);

                _last.Next = newNode;
                _last = newNode;
                _last.Next = _first;
            }

            Count++;
        }

        public IEnumerator<T> GetEnumerator()
        {
            if (_first == null) yield break;

            Node<T> current = _first;

            do
            {
                yield return current.Value;
                current = current.Next;
            } while (current != _first);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
