using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Shapes;

using Monefy.Model.Holders;
using Monefy.Services.FileServices;
using Monefy.ViewModel;

namespace Monefy.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        UserViewModel userViewModel;

        public MainWindow()
        {
            InitializeComponent();

            userViewModel = new UserViewModel(new XmlFileService());
            DataContext = userViewModel;


            ExpencesHolder eh = new ExpencesHolder();

            AssignImageSources();
        }

    




        // Used to assign all default image sources from 'Images' folder 
        private void AssignImageSources()
        {
            sportsIconImage.Source = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + System.IO.Path.DirectorySeparatorChar + "Images/sportsIcon.png"));
            toiletryImage.Source = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + System.IO.Path.DirectorySeparatorChar + "Images/toiletryIcon.png"));
            transportImage.Source = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + System.IO.Path.DirectorySeparatorChar + "Images/transportIcon.png"));
            eatingOutImage.Source = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + System.IO.Path.DirectorySeparatorChar + "Images/eatingOutIcon.png"));
            taxiImage.Source = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + System.IO.Path.DirectorySeparatorChar + "Images/taxiIcon.png"));
            houseImage.Source = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + System.IO.Path.DirectorySeparatorChar + "Images/houseIcon.png"));
            clothesImage.Source = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + System.IO.Path.DirectorySeparatorChar + "Images/clothesIcon.png"));
            foodImage.Source = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + System.IO.Path.DirectorySeparatorChar + "Images/foodIcon.png"));
            giftsImage.Source = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + System.IO.Path.DirectorySeparatorChar + "Images/giftsIcon.png"));
            entertainmentImage.Source = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + System.IO.Path.DirectorySeparatorChar + "Images/entertainmentIcon.png"));
            petImage.Source = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + System.IO.Path.DirectorySeparatorChar + "Images/petIcon.png"));
            communicationsImage.Source = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + System.IO.Path.DirectorySeparatorChar + "Images/communicationsIcon.png"));
            carImage.Source = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + System.IO.Path.DirectorySeparatorChar + "Images/carIcon.png"));
            healthImage.Source = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + System.IO.Path.DirectorySeparatorChar + "Images/healthIcon.png"));
        }



        private void intervalDateLabel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (intervalDateLabel.Content.ToString() == "≡")
            {
                intervalDateLabel.Content = "←";
            }
            else if (intervalDateLabel.Content.ToString() == "←")
            {
                intervalDateLabel.Content = "≡";
            }


        }

        private void expenceButton_Click(object sender, RoutedEventArgs e)
        {
            NewExpenceWindow newExpenceWindow = new NewExpenceWindow(userViewModel);

            newExpenceWindow.ShowDialog();
        }

        private void incomeButton_Click(object sender, RoutedEventArgs e)
        {
            NewIncomeWindow newIncomeWindow = new NewIncomeWindow(userViewModel);

            newIncomeWindow.ShowDialog();
        }


        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            userViewModel.SaveUser();

        }
    }
}
