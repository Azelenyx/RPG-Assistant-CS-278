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
    public partial class CreateCharacterView : ContentPage
    {
        public CreateCharacterView()
        {
            InitializeComponent();
            // This is optional, but provides better layout for the iPhone X 
            object p = On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);
        }

        //int count = 0;
        void Button_Clicked(object sender, System.EventArgs e)
        {
            var name = characterName.Text;
            var race = characterRace.Text;
            var character1 = new Character(name, race);
            Navigation.PushModalAsync(new CharacterView(character1));
        }
    }
}