using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Drift8
{
    public sealed partial class DriftPadPage : Page
    {
        public DriftPadPage()
        {
            this.InitializeComponent();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            // This should go back to HubPage.xaml if it's in the stack
            if (Frame.CanGoBack)
            {
                Frame.GoBack();
            }
            else
            {
                // Handle the case where there's no page in the stack
                // You might want to navigate to HubPage explicitly
                Frame.Navigate(typeof(HubPage));
            }
        }
    }
}
