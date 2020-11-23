using System;

namespace trabalho
{
    class Programa
    {
        static void Main(string[] args)
        {
            ListaDuplamC list = new ListaDuplamC();
            int menu;
            while (true)
            {
                
                Console.WriteLine("1        - Adicionar");
                Console.WriteLine("2        - Remover");
                Console.WriteLine("3        - Atualizar");
                Console.WriteLine("4        - Recuperar");
                Console.WriteLine("5        - Ordenar");
                Console.WriteLine("6        - Listar");
                Console.WriteLine("7        - Salvar");
                Console.WriteLine("8        - Navegar");
                Console.WriteLine("0        - Sair");
                Console.WriteLine("Opcao: ");
                menu = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                if (menu == 1)
                {
                    string nome, telefone, email;

                    Console.WriteLine("Novo Contato:");

                    Console.WriteLine("Nome: ");
                    nome = Console.ReadLine();

                    Console.WriteLine("Telefone: ");
                    telefone = Console.ReadLine();

                    Console.WriteLine("Email: ");
                    email = Console.ReadLine();

                    list.Add(new Contato(nome, telefone, email));
                }
                else if (menu == 2)
                {
                    string email;
                    Console.WriteLine("Digite um email: ");
                    email = Console.ReadLine();
                    Console.WriteLine("Procurando contato.");

                    if (list.DeleteNode(email))
                    {
                        Console.WriteLine("Contato encontrado e deletado.");
                    }
                    else
                    {
                        Console.WriteLine("O contato não foi deletado.");
                    }
                }
                else if (menu == 3)
                {
                    string email;
                    Console.WriteLine("Digite o email: ");
                    email = Console.ReadLine();
                    Console.WriteLine("Procurando contato para atualizar.");

                    Contato contato = list.Find(email);

                    if (contato != null)
                    {
                        Console.WriteLine("Editando usuário.");
                        Console.WriteLine(contato);

                        Console.WriteLine("Nome: ");
                        contato.nome = Console.ReadLine();

                        Console.WriteLine("Telefone: ");
                        contato.telefone = Console.ReadLine();

                        Console.WriteLine("Email: ");
                        contato.email = Console.ReadLine();

                        Console.WriteLine("Contato Atualizado.");
                    }
                    else
                    {
                        Console.WriteLine("O arquivo não foi carregado");
                    }
                }
                else if (menu == 4)
                {
                    Console.WriteLine("Recuperando do arquivo...");

                    if (list.LoadFile("arquivo.txt"))
                    {
                        Console.WriteLine("O arquivo foi carregado.");
                    }
                    else
                    {
                        Console.WriteLine("O arquivo não foi carregado.");
                    }
                }
                else if (menu == 5)
                {
                    int sortOption;

                    Console.WriteLine("Escolha a opção de ordenação.");
                    Console.WriteLine("1 - Nome");
                    Console.WriteLine("2 - Email");
                    Console.WriteLine("Opção: ");

                    sortOption = Convert.ToInt32(Console.ReadLine());
                    if (sortOption == 1)
                    {
                        list.BubbleSort("nome");
                    }
                    else if (sortOption == 2)
                    {
                        list.BubbleSort("email");
                    }
                    Console.Clear();
                }
                else if (menu == 6)
                {
                    Console.WriteLine("Listando Contatos:");
                    list.Print();
                }
                else if (menu == 7)
                {
                    Console.WriteLine("Salvando o arquivo...");

                    if (list.PrintFile("arquivo.txt"))
                    {
                        Console.WriteLine("Arquivo salvo.");
                    }
                    else
                    {
                        Console.WriteLine("O arquivo não foi salvo.");
                    }

                }
                else if (menu == 8)
                {
                    if (list.head == null)
                    {
                        Console.WriteLine("Lista vazia.");
                        return;
                    }

                    Node temp = list.head;

                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine("Navegação:");
                        Console.WriteLine("Seta esquerda: contato anterior");
                        Console.WriteLine("Seta direita: próximo contato");
                        Console.WriteLine("Precione qualquer tecla para sair.");
                        Console.WriteLine("Contato Atual:");
                        Console.WriteLine(temp.data);

                        string key = Console.ReadKey().Key.ToString();

                        if (key == "LeftArrow")
                        {
                            temp = temp.prev;
                        }
                        else if (key == "RightArrow")
                        {
                            temp = temp.next;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                else
                {
                    break;
                }
            }
        }
    }
}
