using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MustDoToday
{
    public abstract class Task
    {
        // static properties

        protected static int TaskCount { get; set; } = 100000;

        public int TaskID
        {
            get { return _taskID; }
            set { _taskID = value; }
        }
        private int _taskID;
            

        // instance properties

        public string TaskName
        {
            get { return _taskName; }
            set { _taskName = value; }
        }
        private string _taskName;



    }
}
