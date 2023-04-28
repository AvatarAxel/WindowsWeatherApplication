using System;
using System.IO;
using System.Windows;
using System.Windows.Media.Imaging;
using ComunicationLayer;
using ComunicationLayer.Model.api;
using System.Windows.Media.Imaging;
using ComunicationLayer.Objects;

namespace WeatherWindowsApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ClearFields();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBoxCityInput.Text)) 
            {
                ClearFields();
                ShowCurrentWeather();
            }           
            else 
            {
                MessageBox.Show("Please enter valid information", "Attention", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void Button_ClickForest(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBoxCityInput.Text))
            {
                ClearFields();
                ShowForestWeather();
            }
            else
            {
                MessageBox.Show("Please enter valid information", "Attention", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private async void ShowCurrentWeather() 
        {
            try
            {                
                CurrentWeatherResponse currentWeatherResponse = await OpenWeatherMapService.GetOneDayWeather(TextBoxCityInput.Text);
                this.LabelDayThree.Content = "Temp Maxima: "+currentWeatherResponse.Main.TempMax+" °C"+ "\n";
                this.LabelDayThree.Content += "Temp Minima: " + currentWeatherResponse.Main.TempMax+ " °C";
                
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri("https://openweathermap.org/img/wn/" + currentWeatherResponse.Weathers[0].Icon + "@2x.png");
                bitmap.EndInit();
                this.ImageDayThree.Source = bitmap;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection error please try later", "Fault", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private async void ShowForestWeather() {
            try
            {
                NearbyWeatherResponse nearbyWeatherResponse = await OpenWeatherMapService.GetForestWeather(TextBoxCityInput.Text);
                this.LabelDayOne.Content = "Temp Maxima: " + nearbyWeatherResponse.ListCurrentWeather[0].Main.TempMax + " °C" + "\n";
                this.LabelDayOne.Content += "Temp Minima: " + nearbyWeatherResponse.ListCurrentWeather[0].Main.TempMax + " °C";
                BitmapImage bitmap01 = new BitmapImage();
                bitmap01.BeginInit();
                bitmap01.UriSource = new Uri("https://openweathermap.org/img/wn/" + nearbyWeatherResponse.ListCurrentWeather[0].Weathers[0].Icon + "@2x.png");
                bitmap01.EndInit();
                this.ImageDayOne.Source = bitmap01;

                this.LabelDayTwo.Content = "Temp Maxima: " + nearbyWeatherResponse.ListCurrentWeather[1].Main.TempMax + " °C" + "\n";
                this.LabelDayTwo.Content += "Temp Minima: " + nearbyWeatherResponse.ListCurrentWeather[1].Main.TempMax + " °C";                
                BitmapImage bitmap02 = new BitmapImage();
                bitmap02.BeginInit();
                bitmap02.UriSource = new Uri("https://openweathermap.org/img/wn/" + nearbyWeatherResponse.ListCurrentWeather[1].Weathers[0].Icon + "@2x.png");
                bitmap02.EndInit();
                this.ImageDayTwo.Source = bitmap02;

                this.LabelDayThree.Content = "Temp Maxima: " + nearbyWeatherResponse.ListCurrentWeather[2].Main.TempMax + " °C" + "\n";
                this.LabelDayThree.Content += "Temp Minima: " + nearbyWeatherResponse.ListCurrentWeather[2].Main.TempMax + " °C";
                BitmapImage bitmap03 = new BitmapImage();
                bitmap03.BeginInit();
                bitmap03.UriSource = new Uri("https://openweathermap.org/img/wn/" + nearbyWeatherResponse.ListCurrentWeather[2].Weathers[0].Icon + "@2x.png");
                bitmap03.EndInit();
                this.ImageDayThree.Source = bitmap03;

                this.LabelDayFour.Content = "Temp Maxima: " + nearbyWeatherResponse.ListCurrentWeather[3].Main.TempMax + " °C" + "\n";
                this.LabelDayFour.Content += "Temp Minima: " + nearbyWeatherResponse.ListCurrentWeather[3].Main.TempMax + " °C";
                BitmapImage bitmap04 = new BitmapImage();
                bitmap04.BeginInit();
                bitmap04.UriSource = new Uri("https://openweathermap.org/img/wn/" + nearbyWeatherResponse.ListCurrentWeather[3].Weathers[0].Icon + "@2x.png");
                bitmap04.EndInit();
                this.ImageDayFour.Source = bitmap04;

                this.LabelDayFive.Content = "Temp Maxima: " + nearbyWeatherResponse.ListCurrentWeather[4].Main.TempMax + " °C" + "\n";
                this.LabelDayFive.Content += "Temp Minima: " + nearbyWeatherResponse.ListCurrentWeather[4].Main.TempMax + " °C";
                BitmapImage bitmap05 = new BitmapImage();
                bitmap05.BeginInit();
                bitmap05.UriSource = new Uri("https://openweathermap.org/img/wn/" + nearbyWeatherResponse.ListCurrentWeather[4].Weathers[0].Icon + "@2x.png");
                bitmap05.EndInit();
                this.ImageDayFive.Source = bitmap05;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection error please try later", "Fault", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void ClearFields() {
            LabelDayOne.Content = "";
            LabelDayTwo.Content = "";
            LabelDayThree.Content = "";
            LabelDayFour.Content = "";
            LabelDayFive.Content = "";            
        }

    }

}
