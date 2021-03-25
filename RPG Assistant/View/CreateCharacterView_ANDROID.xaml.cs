using RPG_Assistant.Database;
using RPG_Assistant.Model;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Picker = Xamarin.Forms.Picker;

namespace RPG_Assistant.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CreateCharacterView_ANDROID : ContentPage
    {
        /*
        Picker racePicker;
        int selectedRaceIndex;
        Picker classPicker;
        int selectedClassIndex;
        */
        Character character;
        String characterRace;
        String characterClass;
        int characterStrength;
        int characterDexterity;
        int characterConstitution;
        int characterIntelligence;
        int characterWisdom;
        int characterCharisma;
        public CreateCharacterView_ANDROID()
        {
            InitializeComponent();
            // This is for Android
            object p = On<Xamarin.Forms.PlatformConfiguration.Android>();
        }

        void OnPickerSelectedRaceChanged(object sender, EventArgs e)
        {
            var racePicker = (Picker)sender;
            int selectedRaceIndex = racePicker.SelectedIndex;

            if (selectedRaceIndex != -1)
            {
                //raceLabel.Text = racePicker.Items[selectedRaceIndex];
                characterRace = racePicker.Items[selectedRaceIndex];
            }
        }

        void OnPickerSelectedClassChanged(object sender, EventArgs e)
        {
            var classPicker = (Picker)sender;
            int selectedClassIndex = classPicker.SelectedIndex;

            if (selectedClassIndex != -1)
            {
                //raceLabel.Text = classPicker.Items[selectedClassIndex];
                characterClass = classPicker.Items[selectedClassIndex];
            }
        }
        void OnPickerSelectedStrengthChanged(object sender, EventArgs e)
        {
            var strengthPicker = (Picker)sender;
            int selectedStrengthIndex = strengthPicker.SelectedIndex;

            if (selectedStrengthIndex != -1)
            {
                characterStrength = selectedStrengthIndex;
            }
        }

        void OnPickerSelectedDexterityChanged(object sender, EventArgs e)
        {
            var dexterityPicker = (Picker)sender;
            int selectedDexterityIndex = dexterityPicker.SelectedIndex;

            if (selectedDexterityIndex != -1)
            {
                characterDexterity = selectedDexterityIndex;
            }
        }

        void OnPickerSelectedConstitutionChanged(object sender, EventArgs e)
        {
            var constitutionPicker = (Picker)sender;
            int selectedConstitutionIndex = constitutionPicker.SelectedIndex;

            if (selectedConstitutionIndex != -1)
            {
                characterConstitution = selectedConstitutionIndex;
            }
        }

        void OnPickerSelectedIntelligenceChanged(object sender, EventArgs e)
        {
            var intelligencePicker = (Picker)sender;
            int selectedIntelligenceIndex = intelligencePicker.SelectedIndex;

            if (selectedIntelligenceIndex != -1)
            {
                characterIntelligence = selectedIntelligenceIndex;
            }
        }

        void OnPickerSelectedWisdomChanged(object sender, EventArgs e)
        {
            var wisdomPicker = (Picker)sender;
            int selectedWisdomIndex = wisdomPicker.SelectedIndex;

            if (selectedWisdomIndex != -1)
            {
                characterWisdom = selectedWisdomIndex;
            }
        }

        void OnPickerSelectedCharismaChanged(object sender, EventArgs e)
        {
            var charismaPicker = (Picker)sender;
            int selectedCharismaIndex = charismaPicker.SelectedIndex;

            if (selectedCharismaIndex != -1)
            {
                characterCharisma = selectedCharismaIndex;
            }
        }

        public void Button_Clicked(object sender, System.EventArgs e)
        {
            character = new Character
            {
                name = characterName.Text,
                race = characterRace,
                cClass = characterClass,
                strength = characterStrength,
                dexterity = characterDexterity,
                constitution = characterConstitution,
                inteligence = characterIntelligence,
                wisdom = characterWisdom,
                charisma = characterCharisma
            };
            /* Save the new character in the DB */
            var task = Task.Run(async () =>
            {
                await CharacterDatabase.CreateCharacter(character);
            });
            /* Going to the Character View */
            Navigation.PushModalAsync(new CharacterView_ANDROID(character));
        }
    }
}