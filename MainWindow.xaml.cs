using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAppPreference
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void ShowPreferencesButton_Click(object sender, RoutedEventArgs e)
        {
            string selectedPreferences = "Ваши предпочтения: ";

            if (redRadioButton.IsChecked == true)
            {
                selectedPreferences += "Красный, ";
            }

            if (blueRadioButton.IsChecked == true)
            {
                selectedPreferences += "Синий, ";
            }

            if (greenRadioButton.IsChecked == true)
            {
                selectedPreferences += "Зеленый, ";
            }

            if (rockRadioButton.IsChecked == true)
            {
                selectedPreferences += "Рок, ";
            }

            if (popRadioButton.IsChecked == true)
            {
                selectedPreferences += "Поп, ";
            }

            if (jazzRadioButton.IsChecked == true)
            {
                selectedPreferences += "Джаз, ";
            }

            if (pizzaRadioButton.IsChecked == true)
            {
                selectedPreferences += "Пицца, ";
            }

            if (sushiRadioButton.IsChecked == true)
            {
                selectedPreferences += "Суши, ";
            }

            if (burgerRadioButton.IsChecked == true)
            {
                selectedPreferences += "Бургер, ";
            }

            // Удалите последнюю запятую и пробел
            selectedPreferences = selectedPreferences.TrimEnd(' ', ',');

            selectedPreferencesTextBlock.Text = selectedPreferences;
        }
        private void ClearSelectionButton_Click(object sender, RoutedEventArgs e)
        {
            redRadioButton.IsChecked = false;
            blueRadioButton.IsChecked = false;
            greenRadioButton.IsChecked = false;
            rockRadioButton.IsChecked = false;
            popRadioButton.IsChecked = false;
            jazzRadioButton.IsChecked = false;
            pizzaRadioButton.IsChecked = false;
            sushiRadioButton.IsChecked = false;
            burgerRadioButton.IsChecked = false;
            selectedPreferencesTextBlock.Text = "Выберите ваши предпочтения";
        }
    }
}
