using RPG_Assistant.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
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

        //int count = 0;
        void Button_Clicked(object sender, System.EventArgs e)
        {
            var cName = characterName.Text;
            //var race = characterRace.Text;
            var cRace = characterRace;
            var cClass = characterClass;
            character = new Character(cName, cRace, cClass);
            Navigation.PushModalAsync(new CharacterView_ANDROID(character));
        }
    }
}