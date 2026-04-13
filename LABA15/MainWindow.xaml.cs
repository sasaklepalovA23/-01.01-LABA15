using System;
using System.Windows;
using System.Windows.Controls;

namespace LABA15
{ 
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void GoTheory(object sender, RoutedEventArgs e) => MainFrame.Navigate(new Pages.TheoryPage());
        private void GoTask1(object sender, RoutedEventArgs e) => MainFrame.Navigate(new Pages.Task1Page());
        private void GoTask2(object sender, RoutedEventArgs e) => MainFrame.Navigate(new Pages.Task2Page());
        private void GoTask3(object sender, RoutedEventArgs e) => MainFrame.Navigate(new Pages.Task3Page());
        private void GoTask4(object sender, RoutedEventArgs e) => MainFrame.Navigate(new Pages.Task4Page());
        private void GoTask5(object sender, RoutedEventArgs e) => MainFrame.Navigate(new Pages.Task5Page());
    }
}