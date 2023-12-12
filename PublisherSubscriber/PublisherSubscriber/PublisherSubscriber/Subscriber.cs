using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublisherSubscriber
{
    class Subscriber
    {
        public void subscribe(FaceBook pub)
        {
            pub.myevent+= update;
        }

     
        public void unsubscribe(FaceBook pub)
        {
            pub.myevent -= update;
        }
        public void subscribe(Linkedin pu)
        {
            pu.myevent += sum;
        }

        public void unsubscribe(Linkedin pu)
        {
            pu.myevent -= sum;
        }
        public void subscribe(Youtube p)
        {
            p.myevent += gender;
        }

        public void unsubscribe(Youtube p)
        {
            p.myevent -= gender;
        }

        public void update(object sender, EventArgument args)
        {
            FaceBook pub = (FaceBook)sender;
            Console.WriteLine(pub.name+" send a message "+args.message);

        }
        public void sum(object sender, EventArgument args)
        {
            Linkedin pu = (Linkedin)sender;
            Console.WriteLine(pu.name + " send a message " + args.sum);
        }
        public void gender(object sender, EventArgument args)
        {
            Youtube p = (Youtube)sender;
            Console.WriteLine(p.name + " send a message " + args.gender);
        }

    }
}
