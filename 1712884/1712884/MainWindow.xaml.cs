﻿using System;
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

namespace _1712884
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Fluent.RibbonWindow
    {
        public MainWindow()
        {
            InitializeComponent();

            //List<Shape> shape = new List<Shape>();

            //for (int i = 0; i < 24; i++)
            //{
            //    string shapeName = "/Images/" + (i + 1) + ".PNG";
            //    shape.Add(new Shape() { Name = shapeName }) ;
            //}


            //Shapes.ItemsSource = shape;

        }

        //public class Shape
        //{
        //    public string Name { get; set; }
            
        //}
    }
}
