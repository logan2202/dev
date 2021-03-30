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
using agenda;
using System.Text.RegularExpressions;

namespace agenda
{
    /// <summary>
    /// Logique d'interaction pour addCustomer.xaml
    /// </summary>
    public partial class addCustomer : Page
    {
        private agenda2 db = new agenda2();
        string regexName = @"^[A-Za-zéèàêâôûùïüç\-]+$";
        string regexMail = @"[0-9a-zA-Z\.\-]+@[0-9a-zA-Z\.\-]+.[a-zA-Z]{2,4}";
        string regexPhone = @"^[0][0-9]{9}";
        string regexBudget = @"[0-9]+$";

        public addCustomer()
        {
            InitializeComponent();
        }
        private void RdvBrokers_Loaded(object sender, RoutedEventArgs e)
        {
            rdvBrokers.ItemsSource = db.qsdfg_brokers.ToList();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            qsdfg__customers customerToAdd = new qsdfg__customers();
            // instanciation
            bool isValid = true; //Permet de Vérifier les erreurs potentielles
            int error = 0; //Compte d'erreur(s)

            if (rdvBrokers.SelectedValue == null)
            {
                MessageBox.Show("Sélectionnez un Courtier");
                isValid = false;
            }
            customerToAdd.idBroker = Convert.ToInt32(rdvBrokers.SelectedValue);
            Console.WriteLine(customerToAdd.idBroker);
            // Vérification lastname
            if (!String.IsNullOrEmpty(CustomerLastName.Text))
            {
                // Vérif de la validité de l'entrée
                if (!Regex.IsMatch(CustomerLastName.Text, regexName))
                {
                    MessageBox.Show("Ecrire un nom valide");
                    isValid = false;
                    error++;
                }
                else
                {
                    customerToAdd.lastname = CustomerLastName.Text;
                }
            }
            else
            {
                MessageBox.Show("Ecrire un nom");
                isValid = false;
                error++;
            }
            // Vérification firstname
            if (!String.IsNullOrEmpty(CustomerFirstName.Text))
            {
                // Vérif de la validité de l'entrée
                if (!Regex.IsMatch(CustomerFirstName.Text, regexName))
                {
                    MessageBox.Show("Ecrire un prénom valide");
                    isValid = false;
                    error++;
                }
                else
                {
                    customerToAdd.firstname = CustomerFirstName.Text;
                }
            }
            else
            {
                MessageBox.Show("Ecrire un prénom");
                isValid = false;
                error++;
            }
            // Vérification mail
            if (!String.IsNullOrEmpty(CustomerMail.Text))
            {
                // Vérification de la validité de l'entrée
                if (!Regex.IsMatch(CustomerMail.Text, regexMail))
                {
                    // Message d'erreur
                    MessageBox.Show("Ecrire un mail valide");
                    isValid = false;
                    error++;
                }

                else
                {
                    customerToAdd.mail = CustomerMail.Text;
                }
            }
            else
            {
                MessageBox.Show("Ecrire un email");
                isValid = false;
                error++;
            }
            // Vérification phoneNumber
            if (!String.IsNullOrEmpty(CustomerPhone.Text))
            {
                // Vérif de la validité de l'entrée
                if (!Regex.IsMatch(CustomerPhone.Text, regexPhone))
                {
                    MessageBox.Show("Ecrire un numéro de téléphone valide");
                    isValid = false;
                    error++;
                }
                else
                {
                    customerToAdd.phoneNumber = CustomerPhone.Text;
                }
            }
            else
            {
                MessageBox.Show("Ecrire un numéro de téléphone");
                isValid = false;
                error++;
            }

            // vérification du champ budget

            if (!String.IsNullOrEmpty(CustomerBudget.Text))
            {
                if (!Regex.IsMatch(CustomerBudget.Text, regexBudget))
                {
                    MessageBox.Show("Budget non valide");
                    isValid = false;
                    error++;
                }
                else
                {
                    customerToAdd.budget = int.Parse(CustomerBudget.Text);
                }
            }
            else
            {
                MessageBox.Show("Ecrire un budget");
                isValid = false;
                error++;
            }

            //SAUVEGARDE ET RESET
            if (isValid == true)
            {
                db.qsdfg__customers.Add(customerToAdd); // insertion dans la bdd avec .Add
                db.SaveChanges(); // enregistrer les changements
                MessageBox.Show("Client ajouté avec succès", "Succès", MessageBoxButton.OK, MessageBoxImage.Information);
                NavigationService.GoBack();
            }
            else
            {
                MessageBox.Show("Vous avez fait " + error + " Erreur(s)");
            }
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            //NavigationService.GoBack();
            NavigationService.Navigate(new System.Uri("customersList.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}
