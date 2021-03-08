using RPG_Assistant.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.Xaml;
using Picker = Xamarin.Forms.Picker;

namespace RPG_Assistant.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CreateCharacterView_IOS : ContentPage
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
        public CreateCharacterView_IOS()
        {
            InitializeComponent();
            // This is optional, but provides better layout for the iPhone X 
            object p = On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);
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
            Navigation.PushModalAsync(new CharacterView_IOS(character));
        }
    }
}