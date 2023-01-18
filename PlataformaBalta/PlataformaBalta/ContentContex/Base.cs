using PlataformaBalta.NotificationContext;

namespace PlataformaBalta.ContentContex
{
    internal abstract class Base : Notifiable
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
    }
}
