using RPG_Assistant.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms.Xaml;

namespace RPG_Assistant.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CharacterView_ANDROID : ContentPage
    {
        public CharacterView_ANDROID()
        {
            InitializeComponent();
            // This is for Android
            On<Xamarin.Forms.PlatformConfiguration.Android>();
        }

        public Character newCharacter;
        public CharacterView_ANDROID(Character character)
        {
            newCharacter = character;
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            characterName.Text = newCharacter.name;
            characterRace.Text = "Race: " + newCharacter.race;
            characterClass.Text = "Class: " + newCharacter.characterClass;
        }
    }
}