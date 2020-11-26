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
   public void Add(int valor)// Adicionando valores na LinkedList
   {
       var newNode = new Node(valor);
       newNode.next = head;
       head = newNode;
   }
   public void Print()// Imprimindo a LikedList
   {
      Console.Write("[HEAD]");
      var aux = head;

      while (aux != null)
      {
         Console.Write($"-> [{aux.data}]");
         aux = aux.next;
      }
      Console.Write("-> [NULL]");
      
   }

}