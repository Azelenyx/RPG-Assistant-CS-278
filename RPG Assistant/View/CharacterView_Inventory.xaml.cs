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
    public partial class CharacterView_Inventory : ContentPage
    {

        public List<string> inventory = new List<string>();

        public CharacterView_Inventory()
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

            inventory.Add(itemName);

        }

        public void RemoveItem(int itemIndex)
        {
            inventory.RemoveAt(itemIndex);
        }

        public void ShowInventory()
        {

            foreach (string item in inventory)
            {
                
                inventoryText.Text = inventoryText.Text + item + "\n";
                Console.Write(item);
            }


        }

        void AddItemButtonClicked(System.Object sender, System.EventArgs e)
        {

            if (itemName.Text != null)
            {
                AddItem(itemName.Text);
                itemName.Text = "";
            }
            inventoryText.Text = "";
            ShowInventory();

        }
    }
}