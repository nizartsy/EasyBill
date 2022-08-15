﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace GUI.BillEasy.Views.HomeMenu
{
    /// <summary>
    /// Interaction logic for HomeWindow.xaml
    /// </summary>
    public partial class HomeWindow : Window
    {
        public HomeWindow()
        {
            InitializeComponent();
            InitializeComponentEx();
        }

        private void InitializeComponentEx()
        {
            var headerBar = new HeaderBar();
            headerBar.Width = this.Width;
            spnlHeader.Children.Add(headerBar);
        }
    }
}
