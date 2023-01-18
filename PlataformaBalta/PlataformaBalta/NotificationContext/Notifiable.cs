namespace PlataformaBalta.NotificationContext
{
    internal class Notifiable
    {
        public List<Notification> Notifications { get; set;} = new List<Notification>();
        public void Add(Notification notification) => Notifications.Add(notification);
        public void Remove(Notification notification) => Notifications.Remove(notification);
        public void AddRange(IEnumerable<Notification> notifications) => Notifications.AddRange(notifications);
    }
}
