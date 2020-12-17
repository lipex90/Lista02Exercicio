using System;
using System.Collections.Generic;
using System.Text;

namespace Lista_2_exercícios
{
    class CalculoDia
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public int Ano { get; set; }

        public CalculoDia() 
        {
        }

        public CalculoDia(string nome, int idade, int ano)
        {
            Nome = nome;
            Idade = idade;
            Ano = ano;
        }
        public void Anodevida(int ano,int idade)
        {
            ano = idade * 365;
            return ;
        }
    }
}
