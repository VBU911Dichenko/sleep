using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sleep
{
    class Cal_sleep
    {
        public List<DateTime> rezult { get; set; }
        public double time_sleep { get; set; }
        DateTime now { get; set; }
        DateTime up { get; set; }
        double interval;
        public Cal_sleep()
        {
            rezult = new List<DateTime>();
            interval = 1.5;
        }
        private void Set_Date() => now = DateTime.Now;
        public List<DateTime> Calculating()
        {
            Set_Date();
            up = now.AddDays(time_sleep);
            int q = up.Subtract(now).Hours;


            return rezult;
        }

    }
}
