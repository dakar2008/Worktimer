using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkTimer.Models
{
    public class WorkTime
    {
        public string ID { get; set; }
        public string Title { get; set; }
        public string Time { get; set; }
        public WorkTime()
        {
            ID = Guid.NewGuid().ToString("N");
        }
    }
}