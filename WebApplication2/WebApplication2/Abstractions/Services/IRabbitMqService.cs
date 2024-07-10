namespace WebApplication2.Abstractions.Services;

public interface IRabbitMqService
{
    void SendMessage(object obj);
    void SendMessage(string message);
}