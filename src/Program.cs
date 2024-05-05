using ObserverPattern.PublisherDetails;
using ObserverPattern.SubscriberDetails;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Publisher publisher = new PublisherImplementation();
        ISubscriber emailsubscriber = new EmailSubscriber();
        ISubscriber smssubscriber = new SMSSubscriber();
        ISubscriber pnsubscriber = new PushNotificationSubscriber();

        int isExit = -1;
        int input;
        do
        {
            Console.WriteLine("1. Add Email Subscriber");
            Console.WriteLine("2. Add SMS Subscriber");
            Console.WriteLine("3. Add PushNotifiy Subscriber");
            Console.WriteLine("4. Remove Email Subscriber");
            Console.WriteLine("5. Remove SMS Subscriber");
            Console.WriteLine("6. Remove PushNotifiy Subscriber");
            Console.WriteLine("7. Set New data to Publisher");
            Console.WriteLine("8. Get current data of Publisher");
            Console.WriteLine("9. Show all subscribers");
            Console.WriteLine("0. Exit\n");
            input = Convert.ToInt32(Console.ReadLine());

            switch (input)
            {
                case 1:
                    emailsubscriber.subscribe();
                    break;
                case 2:
                    smssubscriber.subscribe();
                    break;
                case 3:
                    pnsubscriber.subscribe();
                    break;
                case 4:
                    emailsubscriber.unSubscribe();
                    break;
                case 5:
                    smssubscriber.unSubscribe();
                    break;
                case 6:
                    pnsubscriber.unSubscribe();
                    break;
                case 7:
                    Console.WriteLine("Enter New Data");
                    publisher.setData(Console.ReadLine());
                    break;
                case 8:
                    Console.WriteLine(publisher.getData());
                    break;
                case 9:
                    publisher.showAllSubscribers();
                    break;
                default:
                    break;
            }

        } while (isExit != 9);

        Console.ReadKey();
    }
}