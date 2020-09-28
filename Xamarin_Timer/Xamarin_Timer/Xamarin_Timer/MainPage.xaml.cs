using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Xamarin_Timer
{
    public partial class MainPage : ContentPage
    {
        private int count = 0;

        public string readme = "Howdy.  Hope you like my code here.  Love - Carlos Castillo Sept28, 2020";

        public MainPage()
        {
            InitializeComponent();
        }

        private void IncrementCounterClicked(object sender, EventArgs ignoreMe)
        {
            count++;
            CounterLabel.Text = count.ToString();
        }
    }
}
