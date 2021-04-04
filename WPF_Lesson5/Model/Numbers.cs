using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Lesson5.Model
{
    public class Numbers : INotifyPropertyChanged
    {
        private int m_number;

        public int Number {
            get {
                return this.m_number;
            }
            set {
                this.m_number = value;
                OnPropertyChanged("Number");
            }
        }

        public int Number2 { get; set; }
        private void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
