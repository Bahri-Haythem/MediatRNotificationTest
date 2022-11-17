public class NotifierMediatorService : INotifierMediatorService
{
    private readonly IPublisher _mediator;

    public NotifierMediatorService(IPublisher mediator)
    {
        _mediator = mediator;
    }

    public void Notify(string notifyText)
    {
        _mediator.Publish(new NotificationMessage { NotifyText = notifyText });
    }
}
