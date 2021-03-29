using System;
using System.Collections.ObjectModel;

namespace RickAndMortyApp.Model
{
    public class ResponseApi<T>
    {
        public Info info { get; set; }
        public ObservableCollection<T> results { get; set; }
    }
}
