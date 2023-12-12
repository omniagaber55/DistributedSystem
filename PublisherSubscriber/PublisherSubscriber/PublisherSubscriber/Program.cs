using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublisherSubscriber
{
    class Program
    {
        static void Main(string[] args)
        {
           
            FaceBook pub1 = new FaceBook();
            pub1.name = "Ali";
            Linkedin pu1 = new Linkedin();
            pu1.name = "Ali";
            Youtube p1 = new Youtube();       
            p1.name = "Ali";
         
            Subscriber sub1 = new Subscriber();
            Subscriber sub2 = new Subscriber();
            Subscriber sub3 = new Subscriber();

            sub1.subscribe(pub1);
            sub2.subscribe(pub1);
            sub3.subscribe(pub1);
            pub1.Notify("this is the first message");
            sub2.unsubscribe(pub1);
            pub1.Notify("this message");
       
            sub1.subscribe(pu1);
            sub2.subscribe(pu1);
            sub3.subscribe(pu1);
            pu1.Notify(5);
            sub2.unsubscribe(pu1);
            pu1.Notify(55);

            sub1.subscribe(p1);
            sub2.subscribe(p1);
            sub3.subscribe(p1);
            p1.Notify(true);
            sub2.unsubscribe(p1);
            p1.Notify(false);  
            Console.ReadKey();

        }
    }
}
