using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exc3
{
    public delegate void EventHandler(string message);
    internal class EventPublisher
    {
        public event EventHandler EventOccurred;

        public void SimulateEvent(string message)
        {
            OnEventOccurred(message);
        }

        protected virtual void OnEventOccurred(string message)
        {
            EventOccurred?.Invoke(message);
        }
    }
}
