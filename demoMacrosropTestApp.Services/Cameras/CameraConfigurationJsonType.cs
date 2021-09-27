using System;
using System.Collections.Generic;
using System.Text;

namespace demoMacrosropTestApp.Services.Cameras
{

    public class Rootobject
    {
        public string Id { get; set; }
        public string SenderId { get; set; }
        public int RevNum { get; set; }
        public DateTime Timestamp { get; set; }
        public int XmlProtocolVersion { get; set; }
        public string ServerVersion { get; set; }
        public string ProductType { get; set; }
        public Server[] Servers { get; set; }
        public Channel[] Channels { get; set; }
        public Rootsecobject RootSecObject { get; set; }
        public Usergroup UserGroup { get; set; }
        public Mobileserverinfo MobileServerInfo { get; set; }
        public Rtspserverinfo RtspServerInfo { get; set; }
        public Mobiledevicescapabilities MobileDevicesCapabilities { get; set; }
    }

    public class Rootsecobject
    {
        public Childsecobject[] ChildSecObjects { get; set; }
        public object[] ChildChannels { get; set; }
        public string Id { get; set; }
        public object Name { get; set; }
    }

    public class Childsecobject
    {
        public object[] ChildSecObjects { get; set; }
        public string[] ChildChannels { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
    }

    public class Usergroup
    {
        public string[] GridTypesAllowed { get; set; }
        public string Id { get; set; }
        public object Comment { get; set; }
        public string Name { get; set; }
        public bool CanConfigure { get; set; }
        public bool CanConfigureWorkplace { get; set; }
        public bool CanShutdown { get; set; }
        public bool CanChangeChannelMode { get; set; }
        public bool CanManageRec { get; set; }
        public bool CanAccessExpertMode { get; set; }
        public bool CanPTZ { get; set; }
        public string PtzPriority { get; set; }
        public bool CanReceiveSound { get; set; }
        public bool CanTransmitSound { get; set; }
        public bool CanAccessNewCamera { get; set; }
        public bool CanAccessReports { get; set; }
        public bool CanGetTranscodedVideoFromMobileServer { get; set; }
        public bool CanAccessEditingAnalystPluginsInClient { get; set; }
        public bool CanAccessVideoViaWeb { get; set; }
        public bool CanAccessVideoViaSmartTV { get; set; }
        public bool CanExportVideoToAvi { get; set; }
        public bool CanUseArchiveExport { get; set; }
        public bool CanReceiveMainStream { get; set; }
        public bool IsAllForbidden { get; set; }
        public bool CanAccessUnifiedLog { get; set; }
        public bool CanAccessArchiveMarks { get; set; }
        public bool CanAccessSearch { get; set; }
        public bool CanAccessToAllUsersInUnifiedLog { get; set; }
        public bool CanReceiveMobilePush { get; set; }
        public bool MessengerCanSendMessages { get; set; }
        public bool MessengerCanReceiveMessages { get; set; }
        public bool CanConfigureVideowall { get; set; }
        public bool CanBrowsingVideowall { get; set; }
        public bool CanAccessPlans { get; set; }
        public bool CanChangePassword { get; set; }
        public bool CanRunUserScenarios { get; set; }
    }

    public class Mobileserverinfo
    {
        public bool IsEnabled { get; set; }
        public bool IsProxyEnabled { get; set; }
        public bool IsMobilePushEnabled { get; set; }
        public int Port { get; set; }
        public bool UsePFrames { get; set; }
        public int FpsLimit { get; set; }
        public string LowResolution { get; set; }
        public string MiddleResolution { get; set; }
        public string HighResolution { get; set; }
        public Resolution[] Resolutions { get; set; }
    }

    public class Resolution
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public bool IsEnabled { get; set; }
        public int FpsLimit { get; set; }
        public bool UsePFrames { get; set; }
        public string Type { get; set; }
    }

    public class Rtspserverinfo
    {
        public bool IsEnabled { get; set; }
        public int TcpPort { get; set; }
        public bool IsMjpegEnabled { get; set; }
    }

    public class Mobiledevicescapabilities
    {
        public bool Archive { get; set; }
        public bool Ptz { get; set; }
        public bool Hls { get; set; }
        public bool AppleMobilePush { get; set; }
        public bool AndroidMobilePush { get; set; }
        public bool Profiles { get; set; }
        public bool UserScenarios { get; set; }
        public bool SmartAssistant { get; set; }
    }

    public class Server
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string PrimaryIp { get; set; }
        public string PrimaryPort { get; set; }
        public string PrimarySslPort { get; set; }
        public string SecondaryIp { get; set; }
        public string SecondaryPort { get; set; }
        public string SecondarySslPort { get; set; }
        public object ConnectionUrl { get; set; }
    }

    public class Channel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string DeviceInfo { get; set; }
        public string AttachedToServer { get; set; }
        public bool IsDisabled { get; set; }
        public bool IsSoundOn { get; set; }
        public bool IsArchivingEnabled { get; set; }
        public bool IsSoundArchivingEnabled { get; set; }
        public bool AllowedRealtime { get; set; }
        public bool AllowedArchive { get; set; }
        public bool IsPtzOn { get; set; }
        public bool IsTransmitSoundOn { get; set; }
        public string ArchiveMode { get; set; }
        public Stream[] Streams { get; set; }
        public object[] UserScenarios { get; set; }
        public string ArchiveStreamType { get; set; }
        public bool IsFaceRecOn { get; set; }
        public bool IsPeopleCountingEnabled { get; set; }
    }

    public class Stream
    {
        public string StreamType { get; set; }
        public string StreamFormat { get; set; }
        public string RotationMode { get; set; }
    }

}
