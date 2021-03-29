using System;
using RickAndMortyApp.Bootstrap;
using RickAndMortyApp.View.Character;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RickAndMortyApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            AppContainer.Container = AppSetUp.CreateContainer();
            MainPage = new CharacterListView();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
