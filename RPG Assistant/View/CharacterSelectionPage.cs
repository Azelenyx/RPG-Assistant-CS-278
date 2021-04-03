using RPG_Assistant.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Xamarin.Forms;

namespace RPG_Assistant.View
{
    class CharacterSelectionPage : CharacterSelectionPageBase
    {
        protected override async void CharacterSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem is Character character)
            {
                try
                {
                    await Navigation.PushModalAsync(new CharacterView_ANDROID(character));
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.StackTrace);
                    Debug.WriteLine(ex.Source);
                    Debug.WriteLine(ex.Message);
                }
            }
        }
    }
}
