using System;
using System.Collections.Generic;
using System.Text;

namespace CourierApp
{
    public class ProfileInfo
    {
        private string name, id;
        public string userName
        {
            get { return name; }
            set
            {
                name = value;
                
            }
        }
        public string userID
        {
            get { return id; }
            set
            {
                id = value;
            }
        }
    }
}
