using System;
using Acr.UserDialogs;

namespace RickAndMortyApp.Utilities
{
    public class UIAppUtils
    {
        public static void showLoader(string message)
        {
            UserDialogs.Instance.Loading(message);
        }

        public static void hideLoader()
        {
            UserDialogs.Instance.HideLoading();
        }
    }
}
