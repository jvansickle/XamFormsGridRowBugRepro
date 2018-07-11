using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GridBugTester
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void Handle_Show_Clicked(object sender, System.EventArgs e)
        {
            testGrid.RowDefinitions[1].Height = 15;
            testGrid.HeightRequest += 15;
        }

        void Handle_Hide_Clicked(object sender, System.EventArgs e)
        {
            testGrid.RowDefinitions[1].Height = 0;
            testGrid.HeightRequest -= 15;
        }
    }
}
