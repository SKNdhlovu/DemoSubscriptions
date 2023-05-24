using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSubcriptions
{
    class PhysicalNewspaperSubscription: NewspaperSubscription
    {
        
        string addess = "322 Albertus street Mont Rouge";
        public override void setSubscriberAddress()
        {
            subscriberAddress = "126 Lusitania road Mitchells Plain";
            if (subscriberAddress.Equals(addess))
            {
                subscriberRate = 15;
                Console.WriteLine("Valid adrress \nSubscription rate is set to $" + subscriberRate);
            }
            else
            {
                subscriberRate = 0;
                Console.WriteLine("Error Occured - Must contain an @ sign \nSubscription rate is set to $" + subscriberRate);
            }
        }
    }

}
