using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CourierApp
{
    class CalcCost : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        //string[] sizeClass = new string[3] { "Small", "Medium", "Large" };
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
                width = value;
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
                length = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("length"));
            }
        }
        public double Cost
        {
            get
            {
                cost = Height * Width * Length;
                if(cost > 0)
                {
                    return cost;
                }
                else
                {
                    cost = 0;
                    return cost;
                }
            }
        }
    }
}
