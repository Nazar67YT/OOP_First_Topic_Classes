using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_First_Topic_Classes
{
   public class User
   {

        int pin = 123456789;
        int balance = 1000;


    public  User()
    {
             


    }
        public int setbalance
        {
            get { return balance; }
            set { balance = value; }
        }
        public int setpin
        {
            get { return pin; }
         set { pin = value; }
            
        }
    }
    
}
