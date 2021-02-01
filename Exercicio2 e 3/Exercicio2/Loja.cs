using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    
    public class Loja
    {
        
        public Loja()
        {
            this.Nome = "";
            this.Cnpj = "";
        }

        public Loja(String nome, String cnpj, List<Livro> livro, List<VideoGame> videogame)
        {
            this.Nome = nome;
            this.Cnpj = cnpj;
        }

    
        private List<Livro> livro;
        public List<Livro> Livro
        {
            get { return livro; }
            set { livro = value; }
        }

        private List<VideoGame> videogame;
        public List<VideoGame> videoGame
        {
            get { return videoGame; }
            set { videoGame = value; }
        }
        
       
        private String nome;
        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private String cnpj;
        public String Cnpj
        {
            get { return cnpj; }
            set { cnpj = value; }
        }
        
    
        public void Listalivros()
        {
            if(Livro != null) 
            {
                for(int l = 0; l < Livro.Count; l++)
                {
                    Livro livros = this.Livro[l];
                    Console.WriteLine("Livro: " + livros.Nome + ", " + livros.Preco + ", " + livros.Qtd);
                }
            }
            else
            {
                Console.WriteLine("A loja não tem livros no seu estoque.");
            }
        }

        public void Listavideogame()  
        {
            if(videoGame != null) 
            {
                for(int v = 0; v < videoGame.Count; v++)
                {
                    VideoGame game = this.videoGame[v];
                    Console.WriteLine("Video-game: "+ game.Modelo + "," + game.Preco + ", " + game.Qtd);
                }
            }
            else
            {
                Console.WriteLine("A loja não tem video-games no seu estoque.");
            }
        }

        public double CalculaPatrimonio()
        {
            double patrimonio = 0; 
            for (int p = 0; p < Livro.Count; p++)
            {
                patrimonio = Livro[p].Preco + patrimonio; 
            }
           return patrimonio;
        }
    }
}