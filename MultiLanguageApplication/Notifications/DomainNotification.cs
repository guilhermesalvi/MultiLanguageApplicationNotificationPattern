using MediatR;
using System;

namespace MultiLanguageApplication.Notifications
{
    public class DomainNotification : INotification
    {
        public Guid NotificationId { get; }
        public string Message { get; }

        public DomainNotification(string message)
        {
            this.NotificationId = Guid.NewGuid();
            this.Message = message;
        }
    }
}
