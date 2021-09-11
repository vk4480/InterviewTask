using System;
using System.Collections.Generic;
using System.Text;

namespace DoublyLinked
{
    public class Node
    {
        public int Data;
        public Node Next;
        public Node Prev;

        public Node(int d)
        {
            Data = d;
            /* Prev and Next are left Null */
        }
    }
}
