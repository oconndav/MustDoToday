using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MustDoToday
{
    public abstract class Person
    {
        // static fields

        protected static int PersonCount = 1000;

        // instance properties
        public int PersonID
        {
            get { return _personID; }

            set { _personID = value; }

        }
        private int _personID;

        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }
        private string _userName = null;

        public string UserEmail
        {
            get { return _userEmail; }
            set { _userEmail = value; }
        }
        private string _userEmail = null;



    }
}
