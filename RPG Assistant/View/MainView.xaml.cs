using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RPG_Assistant.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainView : ContentPage
    {
        CharacterSelectionPage selectionPage;
        CharacterDeletionPage deletionPage;
        public MainView()
        {
            InitializeComponent();
            selectionPage = new CharacterSelectionPage();
            deletionPage = new CharacterDeletionPage();
        }

        public void Clicked_CreateCharacter(object sender, System.EventArgs e)
        {
            Navigation.PushModalAsync(new CreateCharacterView_ANDROID());
        }

        public async void Clicked_SelectCharacter(object sender, System.EventArgs e)
        {
            //Navigation.PushModalAsync(new SelectCharacterView());
            await Navigation.PushModalAsync(selectionPage);
        }

        public async void Clicked_DeleteCharacter(object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(deletionPage);
        }
    }
}