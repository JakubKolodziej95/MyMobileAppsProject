using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CourierApp
{
    public class ProfileInfo : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string name, id;
        public string userName
        {
            get { return name; }
            set { name = value; OnPropertyChanged("userName"); }
        }

        public string userID
        {
            get { return id; }
            set { id = value; OnPropertyChanged("userID"); }
        }

        private void OnPropertyChanged (string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
