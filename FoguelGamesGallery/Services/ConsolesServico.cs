
using FoguelGamesGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoguelGamesGallery.Services
{
    internal static class ConsolesServico
    {
        private static List<Consoles> consoles = new()
        {
            new()
            {
                Nome = "Playstation 5",
                Legenda = "Desenvolvido pela Sony",
                HeroImage = "Playstation5.png",
                Descricao = "O PlayStation 5 (oficialmente abreviado como PS5) é um console de jogos eletrônicos de nona geração, desenvolvido pela Sony Interactive Entertainment. Foi anunciado em outubro de 2018[6] e confirmado em outubro de 2019[7] como o quinto da série PlayStation e sucessor do PlayStation 4. O console foi lançado em 12 de novembro de 2020 na América do Norte, Austrália, Coreia do Sul, Japão, Nova Zelândia e Singapura. E em 11 de dezembro de 2020 foi lançado nas Filipinas.[1] 19 de novembro para o resto do mundo.[8][9] A plataforma foi lançada em duas versões, um sistema com entrada para disco óptico compatível com Blu-ray Ultra HD para suporte a jogos lançados em mídia física ou baixados através da PlayStation Store e uma versão digital de menor custo sem a unidade de disco, utilizando apenas o download digital.",
                InicioCorDestaque = Color.FromArgb("#353535"),
                FimCorDestaque = Color.FromArgb("#8d9098"),
                Images = new()
                {
                    "https://meups.com.br/wp-content/uploads/2022/04/God-of-War-Ragnarok-PlayStation-Studios-900x503.jpg",
                    "https://m.media-amazon.com/images/S/aplus-media-library-service-media/9d439e09-a5cf-4582-8b1e-4272586515ff.__CR0,0,970,300_PT0_SX970_V1___.png",
                    "https://image.api.playstation.com/vulcan/ap/rnd/202206/0720/eEczyEMDd2BLa3dtkGJVE9Id.png"
                }
            },
            new()
            {
                Nome = "Xbox Serie X",
                Legenda = "Desenvolvido pela Microsoft",
                HeroImage = "XboxSeriesX.png",
                Descricao = "O Xbox Series X e Series S (coletivamente chamados de Xbox Series X/S[a]) são consoles domésticos de jogos eletrônicos desenvolvidos pela Microsoft. É a quarta geração da família de consoles Xbox; foi anunciada pela primeira vez durante a E3 2019 como Project Scarlett. Ambos os consoles foram lançados em 10 de novembro de 2020.",
                InicioCorDestaque = Color.FromArgb("#0C293d"),
                FimCorDestaque = Color.FromArgb("#26abe0"),
                Images = new ()
                {
                    "https://m.media-amazon.com/images/I/61D8uzSMHEL._AC_UF1000,1000_QL80_.jpg",
                    "https://store-images.s-microsoft.com/image/apps.34314.14094852858730120.8475f7cf-0333-4f77-934d-36aa19e18c42.71453430-eaf2-491a-bdc7-5a92f2e983b0?mode=scale&q=90&h=720&w=1280&background=%23FFFFFF",
                    "https://i0.wp.com/news.xbox.com/pt-br/wp-content/uploads/sites/8/2021/06/Starfield_Inline_Recap.jpg?resize=1200%2C675&ssl=1"
                }
            }, 
            new() 
            {
                Nome = "Nintendo Switch",
                Legenda = "Desenvolvido pela Nintendo",
                HeroImage = "NintendoSwitch.png",
                Descricao = "O Nintendo Switch (ニンテンドースイッチ Nintendō Suitchi?), chamado durante seu desenvolvimento de NX, é um console de videogame híbrido produzido pela empresa Nintendo, tendo sido revelado em 20 de outubro de 2016. Foi lançado oficialmente no dia 3 de março de 2017, e o preço de lançamento é de US$299,99.[3] Na ocasião do lançamento, a Sony e a Microsoft, principais concorrentes da Nintendo, usaram o Twitter para comemorar o novo console.[4] No Brasil, o console foi lançado em 18 de setembro de 2020.[5]",
            InicioCorDestaque = Color.FromArgb("#9d4a40"),
            FimCorDestaque = Color.FromArgb("#cd8026"),
            Images = new()
            {
                "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQTxdc7w0f06juD_TGvPIx5BZsBLznokgaB21YuBrcay6DA7zWBUyJwRmwAGlRUVmtKQvY&usqp=CAU",
                "https://assets.nintendo.com/image/upload/c_fill,w_1200/q_auto:best/f_auto/dpr_2.0/ncom/software/switch/70010000000025/7137262b5a64d921e193653f8aa0b722925abc5680380ca0e18a5cfd91697f58",
                "https://assets.nintendo.com/image/upload/c_fill,w_1200/q_auto:best/f_auto/dpr_2.0/ncom/software/switch/70010000039945/dcb496d7cf954c7eb51ab2e5d0c27918fb7f055e50f4e902135bd4a70a44b491"
            }
          
          }
        
        };

        public static List<Consoles> GetAllConsoles()
            => consoles;

        public static Consoles GetConsoles(string nomeConsole)
            => consoles.Where(_consoles => _consoles.Nome ==
            nomeConsole).FirstOrDefault();

        public static List<Consoles> GetFeaturedConsoles()
        {
            var rnd = new Random();
            var randomizedConsoles = consoles.OrderBy(item => rnd.Next());

            return randomizedConsoles.Take(2).ToList();
        }
    }
}
