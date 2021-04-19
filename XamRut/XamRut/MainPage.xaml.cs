using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamRut
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            string Rut = TxtRut.Text;
            int n0, n1, n2, n3, n4, n5, n6, n7, suma, op;
            double mod;
            Rut = Rut.Replace("-", "").ToUpper();//esto elimina los -
            Rut = Rut.Replace(".", "");//elimina los .
            if (Rut.Length < 9) //vee el largo 
            {
                Rut = "0" + Rut;
            }
            if (Rut.Length > 9) // si el largo es mayor a 9
            {
               await DisplayAlert("El Rut ingresado es incorrecto","ok","cancel");
                TxtRut.Text="";
            }
            n0 = 3 * int.Parse(Rut[0].ToString());
            n1 = 2 * int.Parse(Rut[1].ToString());
            n2 = 7 * int.Parse(Rut[2].ToString());
            n3 = 6 * int.Parse(Rut[3].ToString());
            n4 = 5 * int.Parse(Rut[4].ToString());
            n5 = 4 * int.Parse(Rut[5].ToString());
            n6 = 3 * int.Parse(Rut[6].ToString());
            n7 = 2 * int.Parse(Rut[7].ToString());
            suma = n0 + n1 + n2 + n3 + n4 + n5 + n6 + n7;
            mod = (double)suma % 11;
            op = 11 - int.Parse(Convert.ToString(mod));
            string test = Rut[Rut.Length - 1].ToString();
            if (op == 10)
            {
                if (test == "K")
                {
                    await DisplayAlert("Su rute estaria correcto","ok","");
                }
                else
                {
                    await DisplayAlert("por favor ingrese Rut Correcto","","");
                    TxtRut.Text="";
                }
            }
            if (op == 11)
            {
                if (test == "0")
                {
                    await DisplayAlert("Su rute estaria correcto", "ok", "");
                }
                else
                {
                    await DisplayAlert("por favor ingrese Rut Correcto", "", "");
                    TxtRut.Text = "";
                }
            }
            if (op != 10 && op != 11)
            {
                if (test == op.ToString())
                {
                    await DisplayAlert("Su rute estaria correcto", "ok", "");
                }
                else
                {
                    await DisplayAlert("por favor ingrese Rut Correcto", "", "");
                    TxtRut.Text = "";
                }
            }
        }
    }
}
