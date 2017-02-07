using System.Threading.Tasks;

namespace MusicStore.Services
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);
    }
}