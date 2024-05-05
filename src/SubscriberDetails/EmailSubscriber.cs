using ObserverPattern.PublisherDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.SubscriberDetails
{
    internal class EmailSubscriber : ISubscriber
    {
        public void subscribe()
        {
            Publisher publisher = new PublisherImplementation();
            publisher.addSubscriber(this);
        }

        public void unSubscribe()
        {
            Publisher publisher = new PublisherImplementation();
            publisher.removeSubscriber(this);
        }

        public void update(string data)
        {
            Console.WriteLine($"Email subscriber received updated data. Data = {data}");
        }
    }
}
