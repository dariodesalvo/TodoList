using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace TodoList.Model
{
    public class DataStore
    {
        private ObservableCollection<Task> tasks;

        public DataStore(){
            tasks = new ObservableCollection<Task>(); 
        }

        public void Add(string nombre, int prioridad, DateTime fecha)
        {
            tasks.Add(new Task { Name = nombre, Prioridad=prioridad, Fecha=fecha });
        }

        public void Remove()
        {
         tasks.Clear();    
        }

        public ObservableCollection<Task> Tasks
        {
            get { return tasks; }
        }

    }
}
