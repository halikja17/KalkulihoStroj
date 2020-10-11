using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Data;

namespace KalkulihoStroj
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        void Stisknuti(object sender, EventArgs args)
        {
            Button tlacitko = (Button)sender;
            Console.WriteLine(tlacitko.Text);
            if (tlacitko.Text == "C"){
                CislaVypocet.Text = "";
            } else if (tlacitko.Text == "←" && CislaVypocet.Text.Length > 0){
                CislaVypocet.Text = CislaVypocet.Text.Remove(CislaVypocet.Text.Length - 1);
            } else if (tlacitko.Text == "="){
                Vysledek.Text = new DataTable().Compute(CislaVypocet.Text, null).ToString();
            }  else {
                if ("/*-+.".Contains(tlacitko.Text) && !CislaVypocet.Text.EndsWith(tlacitko.Text)){
                    CislaVypocet.Text += tlacitko.Text;
                } else if ("0123456789".Contains(tlacitko.Text)){
                    CislaVypocet.Text += tlacitko.Text;
                }
            }
        }
    }
}
