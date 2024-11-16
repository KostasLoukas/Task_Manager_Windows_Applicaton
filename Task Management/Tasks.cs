using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Management
{
    public class Tasks
    {
        //All tasks are saved in the array list
        //and are deleted after the program closes
        public static List<string> tasks = new List<string>();
        public static char stringDelimiter = '@';
    }
}
