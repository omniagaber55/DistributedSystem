using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublisherSubscriber
{
    class Publisher
    {
        public string name { get; set; }
        public event EventHandler<EventArgument> myevent;

        public void Notify(string message)
        {
            EventArgument args = new EventArgument(message);
            if (myevent != null)
            {
                myevent(this, args);
            }
        }
    }
}
