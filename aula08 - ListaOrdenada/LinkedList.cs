using System;
using System.Collections.Generic;
using System.Text;

public class LinkdList
{
   public Node head;
   public LinkdList()
   {
       head = null;
   }
   public void Add(int valor)
   {
       var newNode = new Node(valor);
       newNode.next = head;
       head = newNode;
   }

}