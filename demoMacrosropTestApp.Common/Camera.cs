using System;

namespace demoMacrosropTestApp.Common
{
    public class Camera
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string DeviceInfo { get; set; }
        public bool IsDisabled { get; set; }
        public bool IsSoundOn { get; set; }
        public bool IsArchivingEnabled { get; set; }
        public bool AllowedRealtime { get; set; }
        public ServerInfo Server { get; set; }
    }
}
