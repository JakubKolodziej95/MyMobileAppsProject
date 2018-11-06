using System;
using System.Collections.Generic;
using System.Text;

namespace CourierApp
{
    class RandomID
    {
        //Generates a string of 6 random digit 
        public string GenerateId()
        {
            int num, i;
            string str;
            string id = "";
            Random rnd = new Random();

            for (i = 1; i <= 6; i++)
            {
                num = rnd.Next(0, 9); //generates one number at a time
                str = num.ToString(); //converts the number into string
                id += str; //concatinates the numbers together into a 6 digit id
            }

            return id;
        }
    }
}
