using RPG_Assistant.Database;
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
    public partial class SelectCharacterView : ContentPage
    {
        public ListView CharacterListView;
        CharacterDatabase characterDatabase;

        public SelectCharacterView()
        {
            InitializeComponent();

            characterDatabase = new CharacterDatabase();
            BindingContext = characterDatabase;

            CharacterListView = charactersListView;
           
            var task = Task.Run(async () =>
            {
                await RefreshCharactersAsync();
            });
            
        }

        public async Task RefreshCharactersAsync()
        {
            characterDatabase.Characters = await CharacterDatabase.SelectCharacter();
            charactersListView.IsVisible = characterDatabase.Characters.Count != 0;
            noCharactersLabel.IsVisible = characterDatabase.Characters.Count == 0;
        }
    }
}