using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MustDoToday
{
    class SimpleTask : Task
    {

        //static fields


        //instance fields
        public string SimpleTaskDescription
        {
            get { return _simpleTaskDescription; }
            set { _simpleTaskDescription = value; }
        }
        private string _simpleTaskDescription;



        //constructor
        public SimpleTask(string taskName, string simpleTaskDescription)
        {

            TaskName = taskName;
            SimpleTaskDescription = simpleTaskDescription;
            TaskID = TaskCount + 1;
            TaskCount ++;

        }

    }
}
