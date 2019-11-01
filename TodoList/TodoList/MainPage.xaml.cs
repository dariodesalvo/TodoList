using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using TodoList.Model;
using TodoList.ViewModels;

namespace TodoList
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel();
        }
        /*
        private void Button_Clicked(object sender, EventArgs e)
        {
            string texto = nombre.Text;
            dataStore.Add(texto);

        }*/
    }
}
