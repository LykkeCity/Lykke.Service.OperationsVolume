using Lykke.Service.OperationsVolume.Core.Settings.ServiceSettings;
using Lykke.Service.OperationsVolume.Core.Settings.SlackNotifications;

namespace Lykke.Service.OperationsVolume.Core.Settings
{
    public class AppSettings
    {
        public OperationsVolumeSettings OperationsVolumeService { get; set; }
        public SlackNotificationsSettings SlackNotifications { get; set; }
    }
}
