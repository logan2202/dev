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

namespace agenda
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private agenda2 db = new agenda2();
        public MainWindow()
        {
            InitializeComponent();
        }
        // Afficher la liste de clients au démarrage
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            FrameContent.Navigate(new System.Uri("customersList.xaml", UriKind.RelativeOrAbsolute));
        }
        // Menu ajout client 
        private void AddCustomer_Click(object sender, RoutedEventArgs e)
        {
            FrameContent.Navigate(new System.Uri("addCustomer.xaml", UriKind.RelativeOrAbsolute));
        }
        //private void Menu_AddCustomer(object sender, RoutedEventArgs e)
        //{
        //    FrameContent.Content = new addCustomer();
        //}
        // Menu liste clients
        private void ListCustomers_Click(object sender, RoutedEventArgs e)
        {
            FrameContent.Navigate(new System.Uri("customersList.xaml", UriKind.RelativeOrAbsolute));

        }
        // Menu ajout courtier
        private void AddBroker_Click(object sender, RoutedEventArgs e)
        {
            FrameContent.Navigate(new System.Uri("addBroker.xaml", UriKind.RelativeOrAbsolute));
        }
        // Menu liste courtiers
        private void ListBroker_Click(object sender, RoutedEventArgs e)
        {
            FrameContent.Navigate(new System.Uri("brokersList.xaml", UriKind.RelativeOrAbsolute));
        }
        // Menu ajouter un RDV
        private void AddRdv_Click(object sender, RoutedEventArgs e)
        {
            FrameContent.Navigate(new System.Uri("addAppointment.xaml", UriKind.RelativeOrAbsolute));
        }
        // Menu liste des RDV
        private void ListRdv_Click(object sender, RoutedEventArgs e)
        {
            FrameContent.Navigate(new System.Uri("appointmentsList.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}
