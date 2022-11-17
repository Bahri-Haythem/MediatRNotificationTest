
public class Notifier1 : INotificationHandler<NotificationMessage>
{
    public ILogger Logger { get; }
    public Notifier1(ILogger<Notifier1> logger)
    {
        Logger = logger;
    }

    public Task Handle(NotificationMessage notification, CancellationToken cancellationToken)
    {
        Logger.LogInformation($"Debugging from Notifier 1. Message  : {notification.NotifyText} ");
        return Task.CompletedTask;
    }
}

public class Notifier2 : INotificationHandler<NotificationMessage>
{
    public ILogger<Notifier2> Logger { get; }
    public Notifier2(ILogger<Notifier2> logger)
    {
        Logger = logger;
    }

    public Task Handle(NotificationMessage notification, CancellationToken cancellationToken)
    {
        Logger.LogInformation($"Debugging from Notifier 2. Message  : {notification.NotifyText} ");
        return Task.CompletedTask;
    }
}



