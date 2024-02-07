using ProductManagement.Domain.Entities;
using ProductManagement.Domain.Notifications;

namespace ProductManagement.Application.ResponseModels;

public class ProductResponse
{
    public ProductResponse(Product data, List<Notification> notifications)
    {
        Data = data;
        Notifications = notifications;
    }

    public Product Data { get; private set; }
    public List<Notification> Notifications { get; private set; }
}