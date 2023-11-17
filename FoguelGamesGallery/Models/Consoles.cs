using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoguelGamesGallery.Models
{
    public class Consoles
    {
        public string Nome { get; set; }

        public string Legenda {  get; set; }

        public string HeroImage { get; set; }

        public string Descricao {  get; set; }

        public Color InicioCorDestaque { get; set; }

        public Color FimCorDestaque { get; set; }

        public List<string> Images { get; set; }

        //Fundo

        public Brush BackGround
        {
            get
            {
                var gradientStops = new GradientStopCollection();
                gradientStops.Add(new GradientStop(InicioCorDestaque,
                    0.0f));
                gradientStops.Add(new GradientStop(FimCorDestaque,
                    1.0F));

                var bgBrush = new LinearGradientBrush(
                    gradientStops,
                    new Point(0.0, 0.0),
                    new Point(1.0, 1.0));

                return bgBrush;
            }
        }
    }
}
