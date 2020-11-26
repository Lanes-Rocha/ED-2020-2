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
   public void AddOrdered(int valor)//Método insere de forma ordenado
   {
       var newNode = new Node(valor);
       Node aux = head;
       if(head ==null || valor < head.data)//Trata lista vazia e menor valor da lista
       {
           newNode.next = head;
           head = newNode;
           return;
       }
       while ((aux.next != null) && (valor > aux.next.data))
       {
           aux = aux.next;
       }      
       newNode.next = aux.next;
       aux.next = newNode;
   }
   public Node Find(int valor)// Método para pesquisa
   {
       Node aux = head;
       while((aux != null) && (aux.data != valor))
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
       if(this.IsEmpty())
       {
           return;
       }
       Node aux = head;
       Node ant = null;
       while ((aux != null) && (aux.data != valor))
       {
           ant = aux;
           aux = aux.next;
       }
       if (ant == null)// removendo primeiro nó
       {
           head = aux.next;
       }else //Qualquer outro caso
       {
            ant.next = aux.next;
       }
       //Nó é removido da MEM. by GC
   }

}