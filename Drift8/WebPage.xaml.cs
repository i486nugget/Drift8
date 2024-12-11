using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Drift8
{
    public sealed partial class WebPage : Page
    {
        private WebView newWebView;

        // No constructor needed, let UWP handle it

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            if (myWebView.CanGoBack)
                myWebView.GoBack();
        }

        private void ForwardButton_Click(object sender, RoutedEventArgs e)
        {
            if (myWebView.CanGoForward)
                myWebView.GoForward();
        }

        private void RefreshButton_Click(object sender, RoutedEventArgs e)
        {
            myWebView.Refresh();
        }

        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            myWebView.Navigate(new Uri("http://www.google.com"));
        }

        private void NewTabButton_Click(object sender, RoutedEventArgs e)
        {
            var newTab = new StackPanel { Orientation = Orientation.Horizontal, Background = new Windows.UI.Xaml.Media.SolidColorBrush(Windows.UI.Colors.Black), Height = 40 };
            newTab.Children.Add(new Button { Content = "+", Width = 50 });
            newTab.Children.Add(new TextBlock { Text = "New Tab", VerticalAlignment = VerticalAlignment.Center, Foreground = new Windows.UI.Xaml.Media.SolidColorBrush(Windows.UI.Colors.White) });

            newWebView = new WebView();
            newWebView.Navigate(new Uri("http://www.google.com"));
            newWebView.HorizontalAlignment = HorizontalAlignment.Stretch;
            newWebView.VerticalAlignment = VerticalAlignment.Stretch;
            newWebView.Margin = new Windows.UI.Xaml.Thickness(0, 40, 0, 50);
            newTab.Children.Add(newWebView);

            var grid = (Grid)this.Content;
            grid.Children.Add(newTab);
            grid.Children.Add(newWebView);
        }
    }
}
