using ProductManagement.Domain.Notifications;

namespace ProductManagement.Application.ResponseModels;

public class ProductResponse
{
    public ProductResponse(Object data, List<Notification> notifications)
    {
        Data = data;
        Notifications = notifications;
    }

    public Object Data { get; private set; }
    public List<Notification> Notifications { get; private set; }
}