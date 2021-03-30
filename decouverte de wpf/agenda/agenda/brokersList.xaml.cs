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
using System.Data.Entity;
using System.Text.RegularExpressions;

namespace agenda
{
    /// <summary>
    /// Logique d'interaction pour brokersList.xaml
    /// </summary>
    public partial class brokersList : Page
    {
        private agenda2 db = new agenda2();
        string regexName = @"^[A-Za-zéèàêâôûùïüç\-]+$";
        string regexMail = @"[0-9a-zA-Z\.\-]+@[0-9a-zA-Z\.\-]+.[a-zA-Z]{2,4}";
        string regexPhone = @"^[0][0-9]{9}";
        qsdfg_brokers broker;

        public brokersList()
        {
            InitializeComponent();
            broker = new qsdfg_brokers();
        }
        // Liste des clients
        private void ListBrokersDataGrid_Loaded(object sender, RoutedEventArgs e)
        {
            listBrokersDataGrid.ItemsSource = db.qsdfg_brokers.ToList();
        }
        // Fermer la fenêtre (grid) de modification
        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            EditBroker.Visibility = Visibility.Hidden;
        }
        // Selection d'un courtier à modifier
        private void ListBrokersDataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (listBrokersDataGrid.SelectedItem == null) return;
            broker = listBrokersDataGrid.SelectedItem as qsdfg_brokers;

            BrokerLastName.Text = broker.lastname;
            BrokerFirstName.Text = broker.firstname;
            BrokerMail.Text = broker.mail;
            BrokerPhone.Text = broker.phoneNumber;
            EditBroker.Visibility = Visibility.Visible;
        }
        // Enregistrer Modification
        private void Save_Click(object sender, RoutedEventArgs e)
        {
            bool isValid = true; //Permet de Vérifier les erreurs potentielles
            // Vérification lastname
            if (!String.IsNullOrEmpty(BrokerLastName.Text))
            {
                // Vérif de la validité de l'entrée
                if (!Regex.IsMatch(BrokerLastName.Text, regexName))
                {
                    MessageBox.Show("Ecrire un nom valide");
                    isValid = false;
                }
                else
                {
                    broker.lastname = BrokerLastName.Text;
                }
            }
            else
            {
                MessageBox.Show("Ecrire un nom");
                isValid = false;
            }
            // Vérification firstname
            if (!String.IsNullOrEmpty(BrokerFirstName.Text))
            {
                // Vérif de la validité de l'entrée
                if (!Regex.IsMatch(BrokerFirstName.Text, regexName))
                {
                    MessageBox.Show("Ecrire un prénom valide");
                    isValid = false;
                }
                else
                {
                    broker.firstname = BrokerFirstName.Text;
                }
            }
            else
            {
                MessageBox.Show("Ecrire un prénom");
                isValid = false;
            }
            // Vérification mail
            if (!String.IsNullOrEmpty(BrokerMail.Text))
            {
                // Vérification de la validité de l'entrée
                if (!Regex.IsMatch(BrokerMail.Text, regexMail))
                {
                    // Message d'erreur
                    MessageBox.Show("Ecrire un mail valide");
                    isValid = false;
                }

                else
                {
                    broker.mail = BrokerMail.Text;
                }
            }
            else
            {
                MessageBox.Show("Ecrire un email");
                isValid = false;
            }
            // Vérification phoneNumber
            if (!String.IsNullOrEmpty(BrokerPhone.Text))
            {
                // Vérif de la validité de l'entrée
                if (!Regex.IsMatch(BrokerPhone.Text, regexPhone))
                {
                    MessageBox.Show("Ecrire un numéro de téléphone valide");
                    isValid = false;
                }
                else
                {
                    broker.phoneNumber = BrokerPhone.Text;
                }
            }
            else
            {
                MessageBox.Show("Ecrire un numéro de téléphone");
                isValid = false;
            }
            //SAUVEGARDE ET RESET
            if (isValid == true)
            {
                db.Entry(broker).State = EntityState.Modified;
                db.SaveChanges();
                MessageBox.Show("Client modifié avec succès", "Succès", MessageBoxButton.OK, MessageBoxImage.Information);
                listBrokersDataGrid.Items.Refresh();
            }
        }
        // Confirmation suppression
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Etes-vous sûr de supprimer ce courtier ?", "Suppression", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            switch (result)
            {
                case MessageBoxResult.OK:
                    DeleteBroker();
                    break;
                case MessageBoxResult.Cancel:
                    // retour à modification
                    break;
            }
        }
        // Suppression du client
        private void DeleteBroker()
        {
            db.qsdfg_brokers.Remove(broker);
            db.SaveChanges();
            MessageBox.Show("Client supprimé avec succès", "Succès", MessageBoxButton.OK, MessageBoxImage.Information);
            EditBroker.Visibility = Visibility.Hidden;
            listBrokersDataGrid.ItemsSource = null;
            listBrokersDataGrid.ItemsSource = db.qsdfg_brokers.ToList();
        }
        // Main.NavigationService.Navigate(new MainWindow());
    }
}
