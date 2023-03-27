using ARKanyFryzjerstwa.Resources;

namespace ARKanyFryzjerstwa.Models
{
    public enum NotificationType
    {
        Info,
        Success, 
        Warning, 
        Error
    }

    public class NotificationModel
    {
        private string _title;
        private string _message;

        public NotificationModel() { } // Nie usuwać!
        public NotificationModel(string message, NotificationType type) : this(message, type, GetDefaultTitle(type))
        {}
        public NotificationModel(string message, NotificationType type, string title)
        {
            Message = message;
            Type = type;
            Title = title;
        }

        public string Message { get { return _message ?? string.Empty; } set { _message = value; } }
        public NotificationType Type { get; set; }
        public string Title { get { return _title ?? GetDefaultTitle(Type); } set { _title = value; } }

        private static string GetDefaultTitle(NotificationType type)
        {
            return type switch
            {
                NotificationType.Info => ARKanyResources.InfoTitle,
                NotificationType.Success => ARKanyResources.SuccessTitle,
                NotificationType.Warning => ARKanyResources.WarningTitle,
                NotificationType.Error => ARKanyResources.ErrorTitle,
                _ => string.Empty,
            };
        }
    }
}
