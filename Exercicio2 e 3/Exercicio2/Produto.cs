using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    public class Produto
    {
        public Produto()
        {
            this.Nome = "";
            this.Preco = 0;
            this.Qtd = 0;
        }

        public Produto(String nome, double preco, int qtd)
        {
            this.Nome = nome;
            this.Preco = preco;
            this.Qtd = qtd;
        }

        private String nome;
        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private double preco;
        public double Preco
        {
            get { return preco; }
            set { preco = value; }
        }
        
        private int qtd;
        public int Qtd
        {
            get { return qtd; }
            set { qtd = value; }
        }
    }
}