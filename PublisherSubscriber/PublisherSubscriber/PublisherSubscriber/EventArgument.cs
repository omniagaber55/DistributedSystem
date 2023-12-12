using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublisherSubscriber
{
    class EventArgument:EventArgs
    {
        public string message { get; set; }
        public int sum { get; set; }
        public bool gender { get; set; }
        public EventArgument(string message)
        {
            this.message = message;
        }
        public EventArgument(int sum)
        {
            this.sum = sum;
        }
        public EventArgument(bool gender)
        {
            this.gender = gender;
        }
    }
}
