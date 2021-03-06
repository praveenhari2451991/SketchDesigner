﻿using Syncfusion.UI.Xaml.Diagram;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PDFTutorial
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {

            InitializeComponent();


            this.Loaded += new RoutedEventHandler(Window1_Loaded);

        }

        void Window1_Loaded(object sender, RoutedEventArgs e)
        {
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ToggleButton_Checked(object sender, RoutedEventArgs e)
        {
            Storyboard sb = Resources["sbShowLeftMenu"] as Storyboard;
            sb.Begin(layer);
        }

        private void ToggleButton_Unchecked(object sender, RoutedEventArgs e)
        {
            Storyboard sb = Resources["sbHideLeftMenu"] as Storyboard;
            sb.Begin(layer);
        }
    }
}
