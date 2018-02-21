using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace smogger_beta
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            BackButoon.Visibility = Visibility.Collapsed;
            MyFrame.Navigate(typeof(Stacje));
            StatusStrony.Text = "Stacje";
            Stacje.IsSelected = true;
        }

        private void HomeButoon_Click(object sender, RoutedEventArgs e)
        {
            MySpliView.IsPaneOpen = !MySpliView.IsPaneOpen;
        }

        private void IconListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Stacje.IsSelected)
            {
                BackButoon.Visibility = Visibility.Collapsed;
                MyFrame.Navigate(typeof(Stacje));
                MySpliView.IsPaneOpen = !MySpliView.IsPaneOpen;
            }
            else if (Ustawienia.IsSelected)
            {
                BackButoon.Visibility = Visibility.Visible;
                MyFrame.Navigate(typeof(Ustawienia));
                MySpliView.IsPaneOpen = !MySpliView.IsPaneOpen;
            }
            else if (Informacje.IsSelected)
            {
                BackButoon.Visibility = Visibility.Visible;
                MyFrame.Navigate(typeof(Informacje));
                MySpliView.IsPaneOpen = !MySpliView.IsPaneOpen;
            }
            if (StatusStrony == null) return;

            var combo = (ListBox)sender;
            var item = (ListBoxItem)combo.SelectedItem;
            StatusStrony.Text = item.Name.ToString();
        }
        private void MySpliView_SizeChanged(object sender, SizeChangedEventArgs e)
        {

        }

        private void BackButoon_Click(object sender, RoutedEventArgs e)
        {
            if (MyFrame.CanGoBack)
            {
                MyFrame.GoBack();
                Stacje.IsSelected = true;
            }

        }
    }
}
