using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RPG_Assistant
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }


        // This will open the notes tab
        public void NotesButtonClicked(System.Object sender, System.EventArgs e)
        {
            if (NotesFrame.Opacity == 0)
            {
                NotesFrame.Opacity = 1;
            }
        }

        // This will open the stats tab
        public void StatsButtonClicked(System.Object sender, System.EventArgs e)
        {

            if (StatsFrame.Opacity == 0)
            {
                StatsFrame.Opacity = 1;
            }

        }

        // this will close the stats tab
        void CloseStatsButtonClicked(System.Object sender, System.EventArgs e)
        {
            if (StatsFrame.Opacity == 1)
            {
                StatsFrame.Opacity = 0;
            }
        }

        // this will close the notes tab
        void CloseNotesButtonClicked(System.Object sender, System.EventArgs e)
        {
            if (NotesFrame.Opacity == 1)
            {
                NotesFrame.Opacity = 0;
            }
        }

    }
}
