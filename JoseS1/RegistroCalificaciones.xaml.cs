using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JoseS1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistroCalificaciones : ContentPage
    {
        double nota1;
        double examen1;
        double parcial1;
        double nota2;
        double examen2;
        double parcial2;
        double nfinal;

        public RegistroCalificaciones()
        {
            InitializeComponent();
        }
       
        public void calcular()
        {

            nota1 = Convert.ToDouble(txtNota1.Text);
            examen1 = Convert.ToDouble(txtExamen1.Text);
            parcial1 = ((nota1*0.3) + (examen1*0.2));
            txtParcial.Text = parcial1.ToString();

        }

        private void btnCalcularParcial_Clicked(object sender, EventArgs e)
        {

            calcular();
              
        }
       
        private void txtSeguimiento_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
       
        public void calcular2()
        {

            nota2 = Convert.ToDouble(txtNota2.Text);
            examen2 = Convert.ToDouble(txtExamen2.Text);
            parcial2 = (nota2*0.3) + (examen2*0.2);
            txtParcia2.Text = parcial2.ToString();


        }

        private void btnCalcularParcial2_Clicked(object sender, EventArgs e)
        {
            
            calcular2();

        }

        private void txtNota2_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void btnEstado_Clicked(object sender, EventArgs e)
        {
            nfinal = parcial1 + parcial2;
            if (nfinal >=7 )
            {
                DisplayAlert("Confirmación", "APROBADO CON  : \n " + nfinal.ToString(), "cerrar");
            }
            else
            {
                DisplayAlert("Confirmación", "REPROBADO CON : \n " + nfinal.ToString(), "cerrar");
            }

            if (nfinal == 6)
            {
                DisplayAlert("Confirmación", "EXAMEN CONPLEMENTARIO  : \n " + nfinal.ToString(), "cerrar");
            }

        }
    }
}