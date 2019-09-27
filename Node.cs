using System;
using System.Collections.Generic;
using System.Text;

namespace Practical2_OPPPO.Collections.Entrails
{
    class Node<T>
    {
        public T Value { get; private set; }
        public Node<T> Next { get; set; }

        public Node(T value)
        {
            Value = value;
            Next = null;
        }
    }
}
