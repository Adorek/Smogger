using smogger_beta.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public sealed partial class Stacje : Page
    {
        ApplicationDataContainer roamingSettings = null;

        const string chosenLoaction = "chosenCity";

        public ObservableCollection<Actual> OverallStationData { get; set; }
        public ObservableCollection<Detail> DetailedStationData { get; set; }

        public Stacje()
        {
            this.InitializeComponent();
 
            OverallStationData = new ObservableCollection<Actual>();
            DetailedStationData = new ObservableCollection<Detail>();

            roamingSettings = ApplicationData.Current.RoamingSettings;

            DisplayOutput();
        }
        void DisplayOutput()
        {

            Object value = roamingSettings.Values[chosenLoaction];

        }

        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            MyProgressRing.IsActive = true;
            MyProgressRing.Visibility = Visibility.Visible;
            /*
            try
            {
                Object WybraneMiasto = roamingSettings.Values[chosenLoaction];
                //WybranaWies.Text = String.Format("Wybrane miasto: {0}", (value == null ? "<empty>" : ("\"" + value + "\"")));
            }
            catch
            {
                return;
            }*/
            await PollutionFacade.PopulateDaneActualAsync(OverallStationData);
            await PollutionFacade.PopulateDemoActualAsync(DetailedStationData);

            MyProgressRing.IsActive = false;
            MyProgressRing.Visibility = Visibility.Collapsed;

        }
    }
}