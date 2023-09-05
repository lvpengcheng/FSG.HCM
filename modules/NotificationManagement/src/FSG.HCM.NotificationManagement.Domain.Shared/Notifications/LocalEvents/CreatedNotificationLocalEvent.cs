namespace FSG.HCM.NotificationManagement.Notifications.LocalEvents
{
    public class CreatedNotificationLocalEvent
    {
        public NotificationEto NotificationEto { get;  set; }

        private CreatedNotificationLocalEvent()
        {
            
        }

        public CreatedNotificationLocalEvent(NotificationEto notificationEto)
        {
            NotificationEto = notificationEto;
        }
    }
}