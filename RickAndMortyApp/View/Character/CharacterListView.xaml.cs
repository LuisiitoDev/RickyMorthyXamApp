using System;
using System.Collections.Generic;
using RickAndMortyApp.ViewModel.Character;
using Xamarin.Forms;

namespace RickAndMortyApp.View.Character
{
    public partial class CharacterListView : ContentPage
    {
        public CharacterListView()
        {
            InitializeComponent();
            BindingContext = new CharacterListViewModel();
        }
    }
}
