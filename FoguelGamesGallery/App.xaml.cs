using FoguelGamesGallery.Views;

namespace FoguelGamesGallery
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new PaginaInicial());
        }
    }
}
