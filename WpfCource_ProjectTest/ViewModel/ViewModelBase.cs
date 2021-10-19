using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfCource_ProjectTest.ViewModel
{
    class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string PropertyName = null)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
        }

        public bool Set<T>(ref T field, T value, [CallerMemberName] string PropertyName = null)
        {
            if (Equals(field, value))
            {
                return false;
            }
            else
            {
                field = value;
                OnPropertyChanged(PropertyName);
                return true;
            }
        }
    }
}
