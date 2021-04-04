using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Lesson5.Model
{            // add class MobilePhone { Model, Brand, Color }
    public class MobilePhone : INotifyPropertyChanged
    {
        private string m_model;

        public string Model
        {
            get 
            {
                return this.m_model;
            }
            set
            {
                this.m_model = value;
                OnPropertyChanged("Model");
            }
        }
        public string Brand { get; set; }
        public string Color { get; set; }
        private void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
