using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublisherSubscriber
{
    class Linkedin:PublicPublisher
    {
     
        public int sum { get; set; }
      
        public event EventHandler<EventArgument> myevent;

        public void Notify(int sum)
        {
            EventArgument args = new EventArgument(sum);
            if (myevent != null)
            {
                myevent(this, args);
            }
        }
    }
}
