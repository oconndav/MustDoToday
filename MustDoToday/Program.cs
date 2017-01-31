using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MustDoToday
{
    class Program
    {
        static void Main()
        {

            SimpleTask simpletask1 = new SimpleTask("get milk", "make sure it's the right one");
            SimpleTask simpletask2 = new SimpleTask("get bread", "make sure it's sliced");

            User user1 = new User("oconndav", "oconndav@hotmail.com", false);
            User user2 = new User("jamesT", "tehasdk@hotmail.com", false);
            User user3 = new User("fred783", "kdidkdk@yahoo.com", false);

            Console.WriteLine($"{user1.PersonID}, {user1.UserName}, {user1.UserEmail}, {user1.SendDailyEmail}");

            user1.userSimpleTasks.Add(new SimpleTask("check postbox", "the red one outside"));
            user1.userSimpleTasks.Add(new SimpleTask("do some excercise", "to keep fit"));
            user1.userSimpleTasks.Add(new SimpleTask("go for a drive", "outside"));



            foreach (SimpleTask simpleTask in user1.userSimpleTasks)
            {
                Console.WriteLine($"\t \t Task: {simpleTask.TaskName}");
            }

            Console.WriteLine($"{user2.PersonID}, {user2.UserName}, {user2.UserEmail}, {user2.SendDailyEmail}");
            Console.WriteLine($"{user3.PersonID}, {user3.UserName}, {user3.UserEmail}, {user3.SendDailyEmail}");
            Console.ReadKey();

           
            
        }
    }
}
