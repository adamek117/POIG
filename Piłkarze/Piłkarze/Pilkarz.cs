using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Piłkarze
{
    class Pilkarz
    {
        public string imie { get; set; }
        public string nazwisko { get; set; }
        public double waga { get; set; }
        public double wzrost { get; set; }
        public Pozycja Pozycja {get; set;}
        public TextBox Pole_imie { get; }
        public TextBox Pole_nazwisko { get; }
        public TextBox Pole_waga { get; }
        public TextBox Pole_wzrost { get; }
        public Pozycja SelectedIndex { get; }

        public Pilkarz(string imie, string nazwisko, double waga, double wzrost, Pozycja pozycja)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.waga = waga;
            this.wzrost = wzrost;
            this.Pozycja = pozycja;
        }

        public Pilkarz(TextBox pole_imie, TextBox pole_nazwisko, TextBox pole_waga, TextBox pole_wzrost, Pozycja selectedIndex)
        {
            imie = pole_imie.ToString();
            nazwisko = pole_nazwisko.ToString();
            waga = Double.Parse(pole_waga.Text);
            wzrost = Double.Parse(pole_wzrost.Text);
            SelectedIndex = selectedIndex;
        }
        public override string ToString()
        {
            return $"{Pole_nazwisko} {Pole_imie}, p: {Pozycja}, waga: {Pole_waga}[kg], wzrost: {wzrost}[cm]";
        }
    }
}
