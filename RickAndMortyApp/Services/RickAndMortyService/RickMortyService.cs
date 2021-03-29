using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using RickAndMortyApp.Model;
using RickAndMortyApp.Services.HttpFactory;

namespace RickAndMortyApp.Services.RickAndMortyService
{
    public class RickMortyService : IRickMortyService
    {
        readonly HttpService http;

        public RickMortyService(string baseAdress)
        {
            http = new HttpService(baseAdress);
        }

        /// <summary>
        /// Allows to get all Rick and Morty characters from api
        /// </summary>
        /// <returns></returns>
        public async Task<(string errorMessage, ObservableCollection<Character>)> GetCharacters()
        {
            (bool isError,_, ResponseApi<Character> result) = await http.Get<ResponseApi<Character>>("character");

            if (isError)
                return ("it was not possible to get the characters, try again please", default);

            return (string.Empty, result.results);
        }
    }
}
