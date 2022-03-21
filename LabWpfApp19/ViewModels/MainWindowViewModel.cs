using LabWpfApp19.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LabWpfApp19.ViewModels
{
    internal class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName] string PropertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }

        private double number1;
        public double Number1
        {
            get => number1;
            set
            {
                number1 = 2*Math.PI;
                OnPropertyChanged();
            }
        }
        private double number2;
        public double Number2
        {
            get => number2;
            set
            {
                number2 = value;
                OnPropertyChanged();

            }
        }
        private double number3;
        public double Number3
        {
            get => number3;
            set
            {
                number3 = value;
                OnPropertyChanged();
            }
        }
        public ICommand AddCommand { get; }
        private void OnAddCommandExecuted(object p)
        {
            Number3 = Length.Add( Number1, Number2);
        }
        private bool CanAddCommandExecuted(object p)
        {
            if (Number1 != 0 || Number2 !=0)
            return true;
            else
                return false;
        }
        public MainWindowViewModel()
        {
            AddCommand = new RelayCommand (OnAddCommandExecuted, CanAddCommandExecuted );
        }
    }
}
