using Practical2_OPPPO.Films;

namespace Practical2_OPPPO.Collections.Entrails
{
    class Node
    {
        public Film Value { get; set; }
        public Node Next { get; set; }

        public Node(Film value)
        {
            Value = value;
            Next = null;
        }

        public static bool operator >(Node n1, Node n2) => n1.Value.Rating > n2.Value.Rating;

        public static bool operator <(Node n1, Node n2) => !(n1 > n2);
    }
}
