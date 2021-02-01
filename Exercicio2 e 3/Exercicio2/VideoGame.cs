using System;
using System.Collections.Generic;

namespace Exercicio2
{
    public class VideoGame: Produto, Imposto 
    {
        public VideoGame(): base()
        {
            this.Marca = "";
            this.Modelo = "";
            this.isUsado = true;
        }

        public VideoGame(String nome, double preco, int qtd, String marca, String modelo, bool isusado) :base(nome, preco,qtd)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.isUsado = isusado;
        }

        private String marca;
         public String Marca
         {
             get { return marca; }
             set { marca = value; }
         }

         private String modelo;
         public String Modelo
         {
             get { return modelo; }
             set { modelo = value; }
         }

         private bool isusado;
         public bool isUsado
         {
             get { return isusado; }
             set { isusado = value; }
         }

        public double CalculoImposto()
        {
            double imposto = 0;
            
        
                if(this.isUsado == true)
                {
                
                    imposto = this.Preco + (0.25 * this.Preco);
                }
                else
                {
          
                    imposto = this.Preco + (0.45 * this.Preco);
                }
            return imposto;
        }
        
         
    }
}