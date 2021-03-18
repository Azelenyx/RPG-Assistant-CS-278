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
        public void Button_Clicked(object sender, System.EventArgs e)
        {
            character = new Character
            {
                name = characterName.Text,
                race = characterRace,
                cClass = characterClass
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