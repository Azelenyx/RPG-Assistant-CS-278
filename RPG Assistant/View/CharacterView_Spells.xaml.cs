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
    public partial class CharacterView_Spells : ContentPage
    {

        public List<string> spells = new List<string>();

        public CharacterView_Spells()
        {
            InitializeComponent();
            // This is for Android
            On<Xamarin.Forms.PlatformConfiguration.Android>();
        }
        public int testNum = 0;
        void Button_Clicked(System.Object sender, System.EventArgs e)
        {

            Navigation.PopModalAsync();

        }

        public void AddItem(string itemName)
        {

            spells.Add(itemName);

        }

        public void RemoveItem(int itemIndex)
        {
            spells.RemoveAt(itemIndex);
        }

        public void ShowInventory()
        {

            foreach (string spell in spells)
            {

                spellText.Text = spellText.Text + spell + "\n";
                Console.Write(spell);
            }


        }

        void AddSpellButtonClicked(System.Object sender, System.EventArgs e)
        {

            if (spellName.Text != null)
            {
                AddItem(spellName.Text);
                spellName.Text = "";
            }
            spellText.Text = "";
            ShowInventory();

        }



    }
}