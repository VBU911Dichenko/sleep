using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sleep
{
    class Cal_sleep
    {
        public string rezult { get; set; }      
        DateTime now { get; set; }
        DateTime up { get; set; }
        double interval;
        public Cal_sleep() {  interval = 1.5; rezult = $"Заведите будильник на это время: "; }
       
        public string Calculating(int horse_sleep)
        {
            now = DateTime.Now;
            for (int i = 0; i < horse_sleep; i++)
            {
                now.AddDays(interval);
                rezult += $"({now.Hour}:{now.Minute})\t";
            }
           
            return rezult;
        }

    }
}
