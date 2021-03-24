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
        public MainView()
        {
            InitializeComponent();
        }

        public void Clicked_CreateCharacter(object sender, System.EventArgs e)
        {
            Navigation.PushModalAsync(new CreateCharacterView_ANDROID());
        }

        public void Clicked_SelectCharacter(object sender, System.EventArgs e)
        {
            Navigation.PushModalAsync(new SelectCharacterView());
        }

        public void Clicked_DeleteCharacter(object sender, System.EventArgs e)
        {

        }
    }
}