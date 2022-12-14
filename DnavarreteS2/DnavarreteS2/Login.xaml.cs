using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DnavarreteS2
{
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

      private void btnCalcular_Clicked(System.Object sender, System.EventArgs e)
        {
            double dato1 = Convert.ToDouble(txtDato1.Text);
            double dato2 = Convert.ToDouble(txtDato2.Text);
            double dato3 = Convert.ToDouble(txtDato3.Text);
            double resultado = dato1 + dato2 + dato3;
            txtResultado.Text = resultado.ToString();
        }
    }
}

