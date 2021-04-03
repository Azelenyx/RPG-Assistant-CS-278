using RPG_Assistant.Database;
using RPG_Assistant.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace RPG_Assistant.View
{
    class CharacterDeletionPage : CharacterSelectionPageBase
    {
        protected override async void CharacterSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem is Character character)
            {
                var answer = await DisplayAlert("Delete Character", $"Are you sure you want to delete {character.name}?", "Yes", "No");
                if (answer)
                {
                    await CharacterDatabase.DeleteCharacter(character.Id);
                    await selectCharacterView.RefreshCharactersAsync();
                    selectCharacterView.CharacterListView.SelectedItem = null;
                }
            }
        }
    }
}
