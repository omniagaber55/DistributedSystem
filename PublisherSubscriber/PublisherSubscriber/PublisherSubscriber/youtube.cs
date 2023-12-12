using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublisherSubscriber
{
    class Youtube:PublicPublisher
    {
        public bool gender { get; set; }
     
        public event EventHandler<EventArgument> myevent;

        public void Notify(bool gender)
        {
            EventArgument args = new EventArgument(gender);
            if (myevent != null)
            {
                myevent(this, args);
            }
        }
    }
}