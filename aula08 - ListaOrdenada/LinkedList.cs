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
   public void Add(int valor)// Método para adicionar valores na LinkedList
   {
       var newNode = new Node(valor);
       newNode.next = head;
       head = newNode;
   }
   public Node Find(int valor)// Método para pesquisa
   {
       Node aux = head;
       while(aux != null && aux.data != valor)
       {
           aux = aux.next;
       }
       return aux;
   }
   public bool IsEmpty() //Método retorna null caso o dado procurado não se ja encontrado
   {
      return (head == null);
   }

   public void Print()// Método Imprimindo a LikedList
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
   public void Remove(int valor)
   {
       
   }

}