using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSubcriptions
{
    abstract class NewspaperSubscription
    {
        private string subscriberName;
        protected string subscriberAddress;
        protected double subscriberRate;

        public string SubscriberName
        {
            get { return subscriberName; }
            set { subscriberName = value; }
        }
        public string SubscriberAddress
        {
            get { return subscriberAddress; }
        }
        public double SubscriberRate
        {
            get { return subscriberRate; }
        }
        public abstract void setSubscriberAddress();
    }
}
