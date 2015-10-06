﻿using Duckhunt2.containers;
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

namespace Duckhunt2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            new Game(gameCanvas);
            //BitmapImage test = bd._imageSets[Directions.TOP, 0];
            //bd._currentImage.Source = test;
            //gameCanvas.Children.Add(bd._currentImage);
            
        }
    }
}
