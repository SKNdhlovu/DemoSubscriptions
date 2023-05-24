using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSubcriptions
{
    class Program
    {
        static void Main(string[] args)
        {
            PhysicalNewspaperSubscription physical = new PhysicalNewspaperSubscription();
            OnlineNewspaperSubscription online = new OnlineNewspaperSubscription();

            physical.SubscriberName = "Candace Owens";
            physical.setSubscriberAddress();
            Console.WriteLine();
            online.SubscriberName = "Candace Owens";
            online.setSubscriberAddress();

            Console.ReadLine();
        }
    }
}
