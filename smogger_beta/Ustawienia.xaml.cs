using smogger_beta.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace smogger_beta
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Ustawienia : Page
    {
        ApplicationDataContainer roamingSettings = null;

        private List<Location> cities;

        const string chosenLoaction = "chosenCity";

        public Ustawienia()
        {
            this.InitializeComponent();
            cities = CityChooser.GetCities();
            roamingSettings = ApplicationData.Current.RoamingSettings;
            DisplayChosenCity();
        }
        private void DisplayChosenCity()
        {
            Object value = roamingSettings.Values[chosenLoaction];
            //TODO Display chosen city name
            //WybraneMiasto.Text = String.Format("Wybrane miasto: {0}", (value == null ? "<empty>" : ("\"" + value + "\"")));
        }
        private void ListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var miasta = (Location)e.ClickedItem;
            roamingSettings.Values[chosenLoaction] = miasta.CityId;
            WybraneMiasto.Text = String.Format("Wybrane miasto: {0}", ("\"" + miasta.CityName + "\""));
            //TODO Navigate to rootFrame 
            //this.Frame.Navigate(typeof(Stacje), null);
        }
    }
}
