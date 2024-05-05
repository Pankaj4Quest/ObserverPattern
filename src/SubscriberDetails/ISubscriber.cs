using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.SubscriberDetails
{
    internal interface ISubscriber
    {
        public void subscribe();
        public void unSubscribe();
        void update(string data);
    }
}
