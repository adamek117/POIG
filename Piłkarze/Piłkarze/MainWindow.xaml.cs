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

namespace Piłkarze
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>


    public partial class MainWindow : Window
    {
        
        public string imie;
        public string nazwisko;
        public double wzrost;
        public double waga;
        public MainWindow()
        {
            InitializeComponent();
        }
        private bool IsNotEmpty(UserControl1 tb)
        {
            if (tb.Text.Trim() == "")
            {
                tb.SetError("Pole nie może być puste!");
                return false;
            }
            tb.SetError("");
            return true;

        }

        private void Remove_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            if (IsNotEmpty(Pole_imie) & IsNotEmpty(Pole_nazwisko) & IsNotEmpty(Pole_wzrost) & IsNotEmpty(Pole_waga)
            {
                UserControl1.BrushForAll = Brushes.Green;
            }
            /*  waga = double.Parse(Pole_waga.Text);
              wzrost = double.Parse(Pole_wzrost.Text);
              imie = Pole_imie.Text.ToString();
              nazwisko = Pole_nazwisko.Text.ToString();*/





            /* if (this.Pole_nazwisko.Text != "" && this.Pole_waga.Text != "" && this.Pole_wzrost.Text != "")
             {

                 if (this.Bramkarz.IsSelected)
                 {
                     MessageBox.Show("Dodano bramkarza", "Dodałeś zawodnika!");
                     Pilkarz p = new Pilkarz(this.Pole_imie, this.Pole_nazwisko, this.Pole_waga, this.Pole_wzrost, (Pozycja)Pozycje.SelectedIndex);
                 }
                 else if (this.Obrońca.IsSelected)
                 {
                     MessageBox.Show("Dodano obrońce", "Dodałeś zawodnika!");
                     Pilkarz p = new Pilkarz(this.Pole_imie, this.Pole_nazwisko, this.Pole_waga, this.Pole_wzrost, (Pozycja)Pozycje.SelectedIndex);
                 }
                 else if (this.Pomocnik.IsSelected)
                 {
                     MessageBox.Show("Dodano pomocnika", "Dodałeś zawodnika!");
                     Pilkarz p = new Pilkarz(this.Pole_imie, this.Pole_nazwisko, this.Pole_waga, this.Pole_wzrost, (Pozycja)Pozycje.SelectedIndex);
                 }
                 else if (this.Napastnik.IsSelected)
                 {
                     MessageBox.Show("Dodano napastnika", "Dodałeś zawodnika!");
                     Pilkarz p = new Pilkarz(this.Pole_imie, this.Pole_nazwisko, this.Pole_waga, this.Pole_wzrost, (Pozycja)Pozycje.SelectedIndex);
                 }
                 else
                 {
                     MessageBox.Show("Nie podano pozycji!", "BŁĄD!");

                 }
             }
             else
             {
                 MessageBox.Show("Nie podałeś wszystkich informacji!", "BŁĄD!");

             }*/
        }
    }
}