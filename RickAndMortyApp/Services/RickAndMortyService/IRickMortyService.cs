using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using RickAndMortyApp.Model;

namespace RickAndMortyApp.Services.RickAndMortyService
{
    public interface IRickMortyService
    {
        Task<(string errorMessage, ObservableCollection<Character>)> GetCharacters();
    }
}
