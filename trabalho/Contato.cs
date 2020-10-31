using System;
using System.Collections.Generic;
using System.Text;


    public class Contato
    {
        public string nome { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }

        public Contato(string nome, string telefone, string email)
        {
            this.nome = nome;
            this.telefone = telefone;
            this.email = email;
        }

        public override string ToString()
        {
            string result = "";
            result += "Nome: " + nome + "\n";
            result += "Telefone: " + telefone + "\n";
            result += "Email: " + email + "\n";

            return result;
        }
    }

