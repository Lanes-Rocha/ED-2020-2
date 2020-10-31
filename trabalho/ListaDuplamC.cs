using System;
using System.Collections.Generic;
using System.Text;
//using System;
using System.IO;
//using System.Text;

    class ListaDuplamC
    {
        public Node head { get; set; }

        public ListaDuplamC()
        {
            head = null;
        }

        public void Add(Contato contato)
        {
            Node newNode = new Node(contato);

            if (head == null)
            {
                newNode.prev = newNode.next = newNode;
                head = newNode;

                return;
            }

            Node last = head.prev;

            newNode.next = head;
            newNode.prev = last;

            last.next = head.prev = newNode;
        }

        public Contato Find(string email)
        {
            if (head == null)
            {
                Console.WriteLine("Lista Vazia");

                return null;
            }

            Node temp = head;
            do
            {
                if (temp.data.email == email)
                {
                    return temp.data;
                }
                temp = temp.next;
            } while (temp != head);

            return null;
        }

        public bool DeleteNode(string email)
        {
            if (head == null)
            {
                Console.WriteLine("Lista Vazia.");
                return false;
            }

            Node curr = head;
            Node prev = null;

            while (curr.data.email != email)
            {
                if (curr.next == head)
                {
                    return false;
                }
                prev = curr;
                curr = curr.next;
            }

            if (curr.next == head && prev == null)
            {
                head = null;
                return true;
            }

            if (curr == head)
            {
                prev = head.prev;
                head = head.next;

                prev.next = head;
                head.prev = prev;
            }
            else if (curr.next == head)
            {
                prev.next = head;
                head.prev = prev;
            }
            else
            {
                Node temp = curr.next;

                prev.next = temp;
                temp.prev = prev;
            }

            return true;
        }

        public int Length()
        {
            if (head == null)
            {
                return 0;
            }

            int size = 0;
            Node temp = head;
            do
            {
                size++;
                temp = temp.next;
            }
            while (temp != head);

            return size;
        }

        public void BubbleSort(string field)
        {
            bool swapped;
            Node temp;
            int length = Length();

            if (length <= 0)
            {
                Console.WriteLine("Lista Vazia.");
                return;
            }

            do
            {
                swapped = false;

                temp = head;
                for (int i = 0; i < length - 1; i++)
                {
                    string compareFieldA;
                    string compareFieldB;

                    if (field == "nome")
                    {
                        compareFieldA = temp.data.nome;
                        compareFieldB = temp.next.data.nome;
                    }
                    else
                    {
                        compareFieldA = temp.data.email;
                        compareFieldB = temp.next.data.email;
                    }

                    if (String.Compare(compareFieldA, compareFieldB) > 0)
                    {
                        Contato t = temp.data;
                        temp.data = temp.next.data;
                        temp.next.data = t;
                        swapped = true;
                    }
                    temp = temp.next;
                }
            } while (swapped);
        }

        public void Print()
        {
            if (head == null)
            {
                Console.WriteLine("Lista Vazia");

                return;
            }

            Node temp = head;
            do
            {
                Console.WriteLine("Contato:");
                Console.WriteLine(temp.data);
                temp = temp.next;
            } while (temp != head);
        }

        public bool PrintFile(string path)
        {
            try
            {
                if (File.Exists(path))
                {
                    File.Delete(path);
                }

                using (FileStream fs = File.Create(path))
                {
                    if (head == null)
                    {
                        Console.WriteLine("Lista Vazia");

                        return true;
                    }

                    Node temp = head;
                    while (temp.next != head)
                    {
                        AddText(fs, temp.data.nome + "\n");
                        AddText(fs, temp.data.telefone + "\n");
                        AddText(fs, temp.data.email + "\n");
                        temp = temp.next;
                    }
                    AddText(fs, temp.data.nome + "\n");
                    AddText(fs, temp.data.telefone + "\n");
                    AddText(fs, temp.data.email);
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public bool LoadFile(string path)
        {
            while (head != null)
            {
                DeleteNode(head.data.email);
            }
            try
            {
                if (!File.Exists(path))
                {
                    return false;
                }

                using (StreamReader file = new StreamReader(path))
                {
                    string nome;
                    string telefone;
                    string email;
                    while (true)
                    {
                        nome = file.ReadLine();

                        telefone = file.ReadLine();
                        if (telefone == null) break;

                        email = file.ReadLine();
                        if (email == null) break;

                        Add(new Contato(nome, telefone, email));
                    }
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        private static void AddText(FileStream fs, string value)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(value);
            fs.Write(info, 0, info.Length);
        }
    }

