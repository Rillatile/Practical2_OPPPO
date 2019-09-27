using System;
using System.Collections;
using Practical2_OPPPO.Films;
using Practical2_OPPPO.Collections.Entrails;

namespace Practical2_OPPPO.Collections
{
    public class MyList : IEnumerable
    {
        private Node _first;
        private Node _last;

        public int Count { get; private set; }

        public MyList()
        {
            _first = null;
            _last = null;
            Count = 0;
        }

        public void Add(Film value)
        {
            if (_first == null)
            {
                _first = new Node(value);
                _last = _first;
                _first.Next = _last;
            }
            else
            {
                Node newNode = new Node(value);

                _last.Next = newNode;
                _last = newNode;
                _last.Next = _first;
            }

            Count++;
        }

        public void Sort(SortType sortType = SortType.Descending)
        {
            if (Count < 2) return;

            for (int i = 0; i < Count; i++)
            {
                bool flag = false;
                Node n1 = _first;
                Node n2 = n1.Next;

                for (int j = 0; j < Count - 1; j++)
                {
                    if (sortType == SortType.Ascending ? (n1 > n2) : (n1 < n2))
                    {
                        Film temp = n1.Value;

                        n1.Value = n2.Value;
                        n2.Value = temp;
                        flag = true;
                    }

                    n1 = n2;
                    n2 = n2.Next;
                }

                if (!flag) break;
            }
        }

        public void Remove(Predicate<Film> predicate)
        {
            if (Count == 0) return;

            Node current = _first;
            Node previous = _last;
            int counter = 0;
            int startSize = Count;

            do
            {
                if (predicate(current.Value))
                {
                    previous.Next = current.Next;
                    current = previous.Next;

                    if (previous == _last)
                        _first = previous.Next;

                    if (current == _first)
                        _last = previous;

                    Count--;
                }
                else
                {
                    previous = current;
                    current = current.Next;
                }

                counter++;
            } while (counter != startSize);
        }

        public IEnumerator GetEnumerator()
        {
            if (_first == null) yield break;

            Node current = _first;

            do
            {
                yield return current.Value;
                current = current.Next;
            } while (current != _first);
        }
    }
}
