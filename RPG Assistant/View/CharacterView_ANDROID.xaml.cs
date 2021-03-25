using RPG_Assistant.Database;
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

        public int testNum = 0;
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
            characterClass.Text = "Class: " + newCharacter.cClass;

            SScore.Text = newCharacter.strength.ToString();
            DScore.Text = newCharacter.dexterity.ToString();
            CScore.Text = newCharacter.charisma.ToString();
            IScore.Text = newCharacter.inteligence.ToString();
            WScore.Text = newCharacter.wisdom.ToString();
            ChScore.Text = newCharacter.charisma.ToString();

            SModifier.Text = newCharacter.Modifier(newCharacter.strength).ToString();
            DModifier.Text = newCharacter.Modifier(newCharacter.dexterity).ToString();
            CModifier.Text = newCharacter.Modifier(newCharacter.constitution).ToString();
            IModifier.Text = newCharacter.Modifier(newCharacter.inteligence).ToString();
            WModifier.Text = newCharacter.Modifier(newCharacter.wisdom).ToString();
            ChModifier.Text = newCharacter.Modifier(newCharacter.charisma).ToString();

            /*
            var task = Task.Run(async () =>
            {
                var character = await CharacterDatabase.SelectCharacter();
            });*/
        }

        void InventoryButton_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushModalAsync(new CharacterView_Inventory());
        }

        void SpellsButton_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushModalAsync(new CharacterView_Spells());
        }


    }
}