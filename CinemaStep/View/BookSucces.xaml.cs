﻿using CinemaStep.View_Model;
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
using System.Windows.Shapes;

namespace CinemaStep.View
{
    /// <summary>
    /// Interaction logic for BookSucces.xaml
    /// </summary>
    public partial class BookSucces : Window
    {
        public BookSucces()
        {
            InitializeComponent();
            DataContext = new BookSuccesViewModel(this);
        }
    }
}
