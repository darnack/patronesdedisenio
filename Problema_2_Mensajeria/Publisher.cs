namespace Problema_2_Mensajeria
{
    internal class Publisher
    {
        private List<ISubscriber> Subscribers = [];

        public void Subscribe(ISubscriber subscriber)
        {
            Subscribers.Add(subscriber);
        }

        public void Unsubscribe(ISubscriber subscriber)
        {
            Subscribers.Remove(subscriber);
        }

        public void NotifySubscribers(string message)
        {
            foreach (ISubscriber subscriber in Subscribers)
            {
                subscriber.Update(message);
            }
        }
    }
}
