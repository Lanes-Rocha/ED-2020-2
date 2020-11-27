using System;
using System.Collections.Generic;
using System.Text;

public class Node
{
    public int data;
    public Node next; //criando um objeto next

    public Node()// construtor 
    {
        data = -1;
        next = null;
    }
    public Node(int valor)
    {
        data = valor;
        next = null;
    }

}