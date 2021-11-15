using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xmlOldViewer
{
    class forPrintClass
    {
        public string loaction { get; private set; }
        public string name { get; private set; }
        public string institution { get; private set; }
        public string number { get; private set; }
        public string dbLocation { get; private set; }
        public string target { get; private set; }
        public string time { get; private set; }
        public string dayOfTheWeek { get; private set; }

        public string getName()
        {
            return name;
        }

        public forPrintClass(string name, string location, string institution, string number, string dbLocation, 
            string target, string time, string dayOfTheWeek)
        {
            this.loaction = location;
            this.name = name;
            this.institution = institution;
            this.number = number;
            this.dbLocation = dbLocation;
            this.target = target;
            this.time = time;
            this.dayOfTheWeek = dayOfTheWeek;
        }
        public object[] returnAll()
        {
            object[] arr = new object[2];
            arr[0] = name;
            arr[1] = loaction;
            arr[2] = institution;
            arr[3] = number;
            arr[4] = dbLocation;
            arr[5] = target;
            arr[6] = time;
            arr[7] = dayOfTheWeek;
            return arr;
        }
        public override string ToString()
        {
            return this.name;
        }
    }
}
