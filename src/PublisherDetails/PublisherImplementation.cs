using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.PublisherDetails
{
    internal class PublisherImplementation : Publisher
    {
        private string data { get; set; }

        public override void setData(string data)
        {
            Console.WriteLine($"writing new data to publisher. Data = {data}");
            this.data = data;
            notifySubscribers(data);
        }
        public override string getData()
        {
            Console.WriteLine("getting current data from publisher.");
            return this.data;
        }
    }
}
