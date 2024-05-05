using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverPattern.SubscriberDetails;

namespace ObserverPattern.PublisherDetails
{
    internal abstract class Publisher
    {
        static List<ISubscriber> subscribers = new List<ISubscriber>();

        public void addSubscriber(ISubscriber subscriber)
        {
            var type = subscriber.GetType();
            if (!subscribers.Any(x => x.GetType() == type))
            {
                subscribers.Add(subscriber);
                Console.WriteLine($"{type.Name} added successfully.");
            }
            else
            {
                Console.WriteLine($"{type.Name} already subscribed.");
            }
        }
        public void removeSubscriber(ISubscriber subscriber)
        {
            var type = subscriber.GetType();
            if (subscribers.Any(x => x.GetType() == type))
            {
                subscribers.Remove(subscriber);
                Console.WriteLine($"{type.Name} removed successfully.");
            }
            else
            {
                Console.WriteLine($"{type.Name} already unsubscribed.");
            }
        }

        public void showAllSubscribers()
        {
            if (subscribers.Count > 0)
            {
                foreach (var subscriber in subscribers)
                {
                    Console.WriteLine($"{subscriber.GetType().Name}");
                }
            }
            else
                Console.WriteLine("NONE SUBSCRIBED !!");
        }

        public void notifySubscribers(string data)
        {
            foreach (var subscriber in subscribers)
            {
                subscriber.update(data);
            }
        }

        public abstract void setData(string data);

        public abstract string getData();
    }
}
