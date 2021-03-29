using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using RickAndMortyApp.Bootstrap;
using RickAndMortyApp.Services.RickAndMortyService;
using RickAndMortyApp.Utilities;
using CharacterModel = RickAndMortyApp.Model.Character;
namespace RickAndMortyApp.ViewModel.Character
{
    public class CharacterListViewModel : BaseViewModel
    {
        ObservableCollection<CharacterModel> _characters;
        public ObservableCollection<CharacterModel> characters
        {
            get => _characters;
            set => SetProperty(ref _characters, value);
        }

        public CharacterListViewModel()
        {
            Task.Factory.StartNew(LoadCharacters);
        }

        /// <summary>
        /// Loads Rick and Morthy characters
        /// </summary>
        /// <returns></returns>
        async Task LoadCharacters()
        {
            (string errorMessage, ObservableCollection<CharacterModel> characters) = await AppContainer.ResolveService<IRickMortyService>().GetCharacters();

            if (!string.IsNullOrWhiteSpace(errorMessage))
            {
                await App.Current.MainPage.DisplayAlert("Rick and Morthy", errorMessage, "Cancel");
                return;
            }

            this.characters = characters;
        }
    }
}
