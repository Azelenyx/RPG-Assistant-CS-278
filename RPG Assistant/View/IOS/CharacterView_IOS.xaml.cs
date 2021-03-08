using RPG_Assistant.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.Xaml;

namespace RPG_Assistant.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CharacterView_IOS : ContentPage
    {
        public CharacterView_IOS()
        {
            InitializeComponent();
            // This is optional, but provides better layout for the iPhone X 
            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);
        }

        public Character newCharacter;
        public CharacterView_IOS(Character character)
        {
            newCharacter = character;
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            characterName.Text = newCharacter.name;
        }
    }
}