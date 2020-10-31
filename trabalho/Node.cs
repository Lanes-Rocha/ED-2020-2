using System;
using System.Collections.Generic;
using System.Text;

    class Node
    {
        public Contato data;
        public Node prev;
        public Node next;

        public Node()
        {
            data = null;
            prev = null;
            next = null;
        }

        public Node(Contato contato)
        {
            data = contato;
            prev = null;
            next = null;
        }
    }
