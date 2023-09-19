using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetBasicExam
{
    public delegate void MessageHandler(string message);
    internal class NotificationCenter
    {
        public event MessageHandler MessageReceived;

        public void SendMessage(string message)
        {
            OnMessageReceived(message);
        }

        protected virtual void OnMessageReceived(string message)
        {
            MessageReceived?.Invoke(message);
        }
    }
}
