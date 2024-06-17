using AnahiQuezadaEjemploMVVM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AnahiQuezadaEjemploMVVM.ViewModels
{
    public class LibroViewModel : INotifyPropertyChanged
    {
        private Libro _libro;
        public Libro Libro
        {  
            get { return _libro; }
            set { _libro = value;
                onPropertyChanged(nameof(Libro));}
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void onPropertyChanged(string propertyName)
        {
            PropertyChanged? .Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
