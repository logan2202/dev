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


namespace calculette
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            resultat.Text = "0";
        }

        int nombre1 = 0;// 1ere opérande
        int nombre2 = 0; //2eme opérande , ces 2 variables sont globales

        String operation_calcul = "";//chaine de caractères pour connaitre quelle opération mathématique l'utilisateur a choisi de faire

        int calcul(int a, int b, String oper) //fonction de calcul
        {
            int res = 0;

            if (oper.Equals("somme"))
                res = a + b;
            if (oper.Equals("multiplication"))
                res = a * b;
            if (oper.Equals("division"))
            {
                if (b != 0)
                    res = a / b;
                else res = 0;
            }

            if (oper.Equals("soustracation"))
                res = a - b;
            return res;

        }
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            //ici on met le code qui s'excute quand on clique sur le boutton 
            if (operation_calcul.Equals("")) //// cela signifie que l'utilisateur nous donne la valeur de la 1ere opérande 
            {
                nombre1 = Convert.ToInt32(button1.Content.ToString()) + nombre1 * 10; //nous devons convertir la valeur en int
                resultat.Text = nombre1.ToString();

            }

            else
            {
                nombre2 = Convert.ToInt32(button1.Content.ToString()) + nombre2 * 10;//on récupère la valeur du boutton button2
                resultat.Text = nombre2.ToString();

            }
        }


        private void button2_Click(object sender, RoutedEventArgs e)
        {
            //ici on met le code qui s'excute quand on clique sur le boutton 
            if (operation_calcul.Equals("")) //// cela signifie que l'utilisateur nous donne la valeur de la 1ere opérande 
            {
                nombre1 = Convert.ToInt32(button2.Content.ToString()) + nombre1 * 10; //nous devons convertir la valeur en int
                resultat.Text = nombre1.ToString();

            }

            else
            {
                nombre2 = Convert.ToInt32(button2.Content.ToString()) + nombre2 * 10;//on récupère la valeur du boutton button2
                resultat.Text = nombre2.ToString();

            }
        }
        private void button3_Click(object sender, RoutedEventArgs e)
        {
            //ici on met le code qui s'excute quand on clique sur le boutton 
            if (operation_calcul.Equals("")) //// cela signifie que l'utilisateur nous donne la valeur de la 1ere opérande 
            {
                nombre1 = Convert.ToInt32(button3.Content.ToString()) + nombre1 * 10; //nous devons convertir la valeur en int
                resultat.Text = nombre1.ToString();

            }

            else
            {
                nombre2 = Convert.ToInt32(button3.Content.ToString()) + nombre2 * 10;//on récupère la valeur du boutton button2
                resultat.Text = nombre2.ToString();

            }
        }
        private void button4_Click(object sender, RoutedEventArgs e)
        {
            //ici on met le code qui s'excute quand on clique sur le boutton 
            if (operation_calcul.Equals("")) //// cela signifie que l'utilisateur nous donne la valeur de la 1ere opérande 
            {
                nombre1 = Convert.ToInt32(button4.Content.ToString()) + nombre1 * 10; //nous devons convertir la valeur en int
                resultat.Text = nombre1.ToString();

            }

            else
            {
                nombre2 = Convert.ToInt32(button4.Content.ToString()) + nombre2 * 10;//on récupère la valeur du boutton button2
                resultat.Text = nombre2.ToString();

            }
        }
        private void button5_Click(object sender, RoutedEventArgs e)
        {
            //ici on met le code qui s'excute quand on clique sur le boutton 
            if (operation_calcul.Equals("")) //// cela signifie que l'utilisateur nous donne la valeur de la 1ere opérande 
            {
                nombre1 = Convert.ToInt32(button5.Content.ToString()) + nombre1 * 10; //nous devons convertir la valeur en int
                resultat.Text = nombre1.ToString();

            }

            else
            {
                nombre2 = Convert.ToInt32(button5.Content.ToString()) + nombre2 * 10;//on récupère la valeur du boutton button2
                resultat.Text = nombre2.ToString();

            }
        }
        private void button6_Click(object sender, RoutedEventArgs e)
        {
            //ici on met le code qui s'excute quand on clique sur le boutton 
            if (operation_calcul.Equals("")) //// cela signifie que l'utilisateur nous donne la valeur de la 1ere opérande 
            {
                nombre1 = Convert.ToInt32(button6.Content.ToString()) + nombre1 * 10; //nous devons convertir la valeur en int
                resultat.Text = nombre1.ToString();

            }

            else
            {
                nombre2 = Convert.ToInt32(button6.Content.ToString()) + nombre2 * 10;//on récupère la valeur du boutton button2
                resultat.Text = nombre2.ToString();

            }
        }
        private void button7_Click(object sender, RoutedEventArgs e)
        {
            //ici on met le code qui s'excute quand on clique sur le boutton 
            if (operation_calcul.Equals("")) //// cela signifie que l'utilisateur nous donne la valeur de la 1ere opérande 
            {
                nombre1 = Convert.ToInt32(button7.Content.ToString()) + nombre1 * 10; //nous devons convertir la valeur en int
                resultat.Text = nombre1.ToString();

            }

            else
            {
                nombre2 = Convert.ToInt32(button7.Content.ToString()) + nombre2 * 10;//on récupère la valeur du boutton button2
                resultat.Text = nombre2.ToString();

            }
        }
        private void button8_Click(object sender, RoutedEventArgs e)
        {
            //ici on met le code qui s'excute quand on clique sur le boutton 
            if (operation_calcul.Equals("")) //// cela signifie que l'utilisateur nous donne la valeur de la 1ere opérande 
            {
                nombre1 = Convert.ToInt32(button8.Content.ToString()) + nombre1 * 10; //nous devons convertir la valeur en int
                resultat.Text = nombre1.ToString();

            }

            else
            {
                nombre2 = Convert.ToInt32(button8.Content.ToString()) + nombre2 * 10;//on récupère la valeur du boutton button2
                resultat.Text = nombre2.ToString();

            }
        }
        private void button9_Click(object sender, RoutedEventArgs e)
        {
            //ici on met le code qui s'excute quand on clique sur le boutton 
            if (operation_calcul.Equals("")) //// cela signifie que l'utilisateur nous donne la valeur de la 1ere opérande 
            {
                nombre1 = Convert.ToInt32(button9.Content.ToString()) + nombre1 * 10; //nous devons convertir la valeur en int
                resultat.Text = nombre1.ToString();

            }

            else
            {
                nombre2 = Convert.ToInt32(button9.Content.ToString()) + nombre2 * 10;//on récupère la valeur du boutton button2
                resultat.Text = nombre2.ToString();

            }
        }
        private void button10_Click(object sender, RoutedEventArgs e)
        {
            //ici on met le code qui s'excute quand on clique sur le boutton 
            if (operation_calcul.Equals("")) //// cela signifie que l'utilisateur nous donne la valeur de la 1ere opérande 
            {
                nombre1 = Convert.ToInt32(button10.Content.ToString()) + nombre1 * 10; //nous devons convertir la valeur en int
                resultat.Text = nombre1.ToString();

            }

            else
            {
                nombre2 = Convert.ToInt32(button10.Content.ToString()) + nombre2 * 10;//on récupère la valeur du boutton button2
                resultat.Text = nombre2.ToString();

            }
        }

        private void button12_Click(object sender, RoutedEventArgs e)
        {
            //on indique ici le type d'opération à faire
            operation_calcul = "somme";//puisque c'est le boutton +

        }

        private void button13_Click(object sender, RoutedEventArgs e)
        {
            operation_calcul = "soustraction";
        }
        private void button14_Click(object sender, RoutedEventArgs e)
        {
            operation_calcul = "multiplication";
        }
        private void button15_Click(object sender, RoutedEventArgs e)
        {
            operation_calcul = "division";
        }

        private void button11_Click(object sender, RoutedEventArgs e)
        {
            //ici on appel la fonction de calcul pour nous donner le résultat

            resultat.Text = calcul(nombre1, nombre2, operation_calcul).ToString();//on utilise Tostring pour convertir en String (chaine de caractères)
                                                                                  //testons. avant on vérifie
                                                                                  //ça marche 
                                                                                  //on améliore le code

        }
        private void button16_Click(object sender, RoutedEventArgs e)
        {
            resultat.Text = "0";
            nombre1 = 0;
            nombre2 = 0;
            operation_calcul = "";
        }
    }
}
