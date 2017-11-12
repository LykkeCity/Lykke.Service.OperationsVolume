using System;
using Common.Log;

namespace Lykke.Service.OperationsVolume.Client
{
    public class OperationsVolumeClient : IOperationsVolumeClient, IDisposable
    {
        private readonly ILog _log;

        public OperationsVolumeClient(string serviceUrl, ILog log)
        {
            _log = log;
        }

        public void Dispose()
        {
            //if (_service == null)
            //    return;
            //_service.Dispose();
            //_service = null;
        }
    }
}
