using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Livro l = new Livro();
            VideoGame v = new VideoGame();
            Loja loja = new Loja();
           

            Livro l1 = new Livro("Fundação", 10, 20, "Asimov", "Ficção Cientifica", 400); 
            Livro l2 = new Livro("Os Últimos Dias de Krypton", 30, 40, "Erin e Moulton", "educativo", 500); 
            Livro l3 = new Livro("Constantine Hellblazer", 50, 60, "Alan Moore", "Quadrinho", 600); 

            VideoGame DS = new VideoGame("3DS", 1500, 100, "Nintendo", "Portátil", false); 
            VideoGame Switch = new VideoGame("PS4", 1600, 100, "Nintendo", "Portátil", false); 
            VideoGame WiiU = new VideoGame("PS4", 1700, 100, "Nintendo", "Portátil", false); 

            List<Livro> Livro = new List<Livro>();
            Livro.Add(l1);
            Livro.Add(l2);
            Livro.Add(l3);

            List<VideoGame> videoGame = new List<VideoGame>();
            videoGame.Add(DS);
            videoGame.Add(Switch);
            videoGame.Add(WiiU);
            
            Loja Amazon = new Loja("Amazon", "1234", Livro, videoGame);

            l2.CalculoImposto();
            l3.CalculoImposto();

            DS.CalculoImposto();
            WiiU.CalculoImposto();

            Amazon.Listalivros();
            Amazon.Listavideogame();
            Amazon.CalculaPatrimonio();

        }
    }
}
