using System;
using System.Collections.Generic;

namespace Exercicio2
{
    public class Livro: Produto, Imposto
    {
        public Livro():base()
        {
            this.Autor = "";
            this.Tema = "";
            this.Qpag = 0;
        }

        public Livro(String nome, double preco, int qtd, String autor, String tema, int qpag):base(nome, preco, qtd)
        {
            this.Autor = autor;
            this.Tema = tema;
            this.Qpag = qpag;
        }

        
        private String autor;
        public String Autor
        {
            get { return autor; }
            set { autor = value; }
        }
        
        private String tema;
        public String Tema
        {
            get { return tema; }
            set { tema = value; }
        }
        
        private int qpag;
        public int Qpag
        {
            get { return qpag; }
            set { qpag = value; }
        }
        

        
        public double CalculoImposto()
        {
            double imposto = 0;

            
                if(this.Tema == "educativo")
                {
                    
                }
                else
                {
                    imposto = this.Preco + (0.1 * this.Preco);
                }
            
            return imposto;
        }
        
    }
}