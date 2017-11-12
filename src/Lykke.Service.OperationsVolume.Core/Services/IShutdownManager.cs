using System.Threading.Tasks;

namespace Lykke.Service.OperationsVolume.Core.Services
{
    public interface IShutdownManager
    {
        Task StopAsync();
    }
}