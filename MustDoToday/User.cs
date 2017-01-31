using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MustDoToday
{
    class User : Person
    {
        //static fields


        //instance fields
        public bool SendDailyEmail
        {
            get { return _sendDailyEmail; }
            set { _sendDailyEmail = value; }
        }
        private bool _sendDailyEmail;

        // create a list of simple task objects for each new user

        public List<SimpleTask> userSimpleTasks = new List<SimpleTask>();




        
        //constructor
        public User(string username, string email, bool sendDailyEmail)
        {
            UserName = username;
            UserEmail = email;
            SendDailyEmail = sendDailyEmail;
            PersonID = PersonCount + 1;
            PersonCount++;
            

            
        }



    }
}
