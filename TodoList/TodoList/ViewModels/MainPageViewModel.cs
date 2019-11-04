using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using TodoList.Model;
using Xamarin.Forms;

namespace TodoList.ViewModels
{
    class MainPageViewModel
    {
        DataStore dataStore = new DataStore();

        public MainPageViewModel()
        {
            agregarCommand = new Command(agregarevent);

        }

        private void agregarevent()
        {
            dataStore.Add(nombre,prioridad,fecha);
        }

        private DateTime fecha;

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        private string nombre;    
        
        public string Nombre 
        { get { return nombre; }
          set { nombre = value; } 
        }

        private int prioridad;
        public int Prioridad
        {
            get { return prioridad; }
            set { prioridad = value; }
        }

        // private ObservableCollection<Task> tasks;

        public ObservableCollection<Task> Tasks
        {
            get { return dataStore.Tasks; }
            // no lleva set porque solo se lee
        }

        private Command agregarCommand;

        public Command Agregar { 
            get { return agregarCommand; }
            set { agregarCommand = value; }
            
          }


    }
}
