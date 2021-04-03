using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace RPG_Assistant.View
{
    public abstract class CharacterSelectionPageBase : ContentPage
    {
        protected SelectCharacterView selectCharacterView;
        public CharacterSelectionPageBase()
        {
            selectCharacterView = new SelectCharacterView();
            selectCharacterView.CharacterListView.ItemSelected += CharacterSelected;
            Content = selectCharacterView;
        }

        protected abstract void CharacterSelected(object sender, SelectedItemChangedEventArgs e);

        protected override async void OnAppearing()
        {
            await selectCharacterView.RefreshCharactersAsync();
        }
    }
}
