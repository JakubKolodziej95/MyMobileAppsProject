using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CourierApp
{
    class CalcCost : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        string[] parcelSize = new string[3] { "Small", "Medium", "Large" };
        private double weight, height, width, length, cost;

        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("height"));
            }
        }
        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                height = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("width"));
            }
        }
        public double Length
        {
            get
            {
                return length;
            }
            set
            {
                height = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("length"));
            }
        }
        public double Cost
        {
            get { return height * width * length; }
        }
    }
}
