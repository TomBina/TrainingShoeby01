namespace TrainingShoeby01.HeapStack
{
    public class EventBus
    {
        private string _lastSentEvent;

        public bool Send(string evt)
        {
            evt = evt.ToUpper();

            _lastSentEvent = evt;

            var messageBus = new MessageBus();
            messageBus.SendEvent(evt);

            return true;
        } 
    }

    public class MessageBus
    {
        public void SendEvent(string evt)
        {
            
        }
    }
}