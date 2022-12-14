using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DnavarreteS2
{
    public partial class Calificaciones : ContentPage
    {
        public Calificaciones(string usuario)
        {
            InitializeComponent();
            txtUsuario.Text = usuario;
        }

        private void btnVerificar_Clicked(System.Object sender, System.EventArgs e)
        {
            txtNparcial1.Text = Nparcial1().ToString();
            txtNparcial2.Text = Nparcial2().ToString();
            txtNFinal.Text = NFinal().ToString();

            if (NFinal() >= 0.1 && NFinal() <= 4.9)
            {
                lblestado.Text = "Perdio Semestre";
            }
            else if (NFinal() >= 5 && NFinal() <=6.9)
            {
                lblestado.Text = "Complementario";
            }
            else if (NFinal() >= 7 && NFinal() <= 10)
            {
                lblestado.Text = "Aprobado";
            }
            else
            {
                lblestado.Text = "error";
            }
        }

        public double Nparcial1()
        {
            double Nseguimiento = Convert.ToDouble(txtNseguimiento.Text) * 0.3;
            double Nexamen = Convert.ToDouble(txtNexamen.Text) * 0.2;
            double Nparcial1 = Nseguimiento + Nexamen;
            return Nparcial1;
        }
        public double Nparcial2()
        {
            double Nseguimiento = Convert.ToDouble(txtNseguimiento2.Text) * 0.3;
            double Nexamen = Convert.ToDouble(txtNexamen2.Text) * 0.2;
            double Nparcial2 = Nseguimiento + Nexamen;
            return Nparcial2;
        }

        public double NFinal()
        {
            double notaParcial1 = Nparcial1();
            double notaParcial2 = Nparcial2();
            double resultado = notaParcial1 + notaParcial2;
            return resultado;
        }

        void txtNseguimiento_TextChanged(System.Object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            try
            {
                if (Convert.ToDouble(txtNseguimiento.Text) > 10) 
                {
                    DisplayAlert("Alerta", "Solo se permite numero de 1 a 10", "Cerrar");
                }
            }
            catch (Exception ex)
            {
                //txtNseguimiento.Text = "0";

            }
          
          
        }

        void txtNexamen_TextChanged(System.Object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            try
            {
                if (Convert.ToDouble(txtNexamen.Text) > 10)
                {
                    DisplayAlert("Alerta", "Solo se permite numero de 1 a 10", "Cerrar");
                }
            }
            catch (Exception ex)
            {
                //txtNexamen.Text = "0";
            }

        }

        void txtNseguimiento2_TextChanged(System.Object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            try
            {
                if (Convert.ToDouble(txtNseguimiento2.Text) > 10)
                {
                    DisplayAlert("Alerta", "Solo se permite numero de 1 a 10", "Cerrar");
                }
            }
            catch (Exception ex)
            {
                //txtNseguimiento2.Text = "0";
            }
        }

        void txtNexamen2_TextChanged(System.Object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            try
            {
                if (Convert.ToDouble(txtNexamen2.Text) > 10)
                {
                    DisplayAlert("Alerta", "Solo se permite numero de 1 a 10", "Cerrar");
                }
            }
            catch (Exception ex)
            {
                //txtNexamen2.Text = "0";
            }
        }
    }
}

