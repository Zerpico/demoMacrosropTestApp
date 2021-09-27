using System;
using System.Collections.Generic;
using System.Text;

namespace demoMacrosropTestApp.Services.Cameras
{
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class Configuration
    {

        private ConfigurationServerInfo[] serversField;

        private ConfigurationChannelInfo[] channelsField;

        private ConfigurationRootSecurityObject rootSecurityObjectField;

        private ConfigurationUserGroup userGroupField;

        private ConfigurationMobileServerInfo mobileServerInfoField;

        private ConfigurationRtspServerInfo rtspServerInfoField;

        private ConfigurationMobileDevicesCapabilities mobileDevicesCapabilitiesField;

        private string idField;

        private string senderIdField;

        private byte revisionField;

        private System.DateTime timestampField;

        private byte xMLProtocolVersionField;

        private string serverVersionField;

        private string productTypeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ServerInfo", IsNullable = false)]
        public ConfigurationServerInfo[] Servers
        {
            get
            {
                return this.serversField;
            }
            set
            {
                this.serversField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ChannelInfo", IsNullable = false)]
        public ConfigurationChannelInfo[] Channels
        {
            get
            {
                return this.channelsField;
            }
            set
            {
                this.channelsField = value;
            }
        }

        /// <remarks/>
        public ConfigurationRootSecurityObject RootSecurityObject
        {
            get
            {
                return this.rootSecurityObjectField;
            }
            set
            {
                this.rootSecurityObjectField = value;
            }
        }

        /// <remarks/>
        public ConfigurationUserGroup UserGroup
        {
            get
            {
                return this.userGroupField;
            }
            set
            {
                this.userGroupField = value;
            }
        }

        /// <remarks/>
        public ConfigurationMobileServerInfo MobileServerInfo
        {
            get
            {
                return this.mobileServerInfoField;
            }
            set
            {
                this.mobileServerInfoField = value;
            }
        }

        /// <remarks/>
        public ConfigurationRtspServerInfo RtspServerInfo
        {
            get
            {
                return this.rtspServerInfoField;
            }
            set
            {
                this.rtspServerInfoField = value;
            }
        }

        /// <remarks/>
        public ConfigurationMobileDevicesCapabilities MobileDevicesCapabilities
        {
            get
            {
                return this.mobileDevicesCapabilitiesField;
            }
            set
            {
                this.mobileDevicesCapabilitiesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SenderId
        {
            get
            {
                return this.senderIdField;
            }
            set
            {
                this.senderIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte Revision
        {
            get
            {
                return this.revisionField;
            }
            set
            {
                this.revisionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime Timestamp
        {
            get
            {
                return this.timestampField;
            }
            set
            {
                this.timestampField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte XMLProtocolVersion
        {
            get
            {
                return this.xMLProtocolVersionField;
            }
            set
            {
                this.xMLProtocolVersionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ServerVersion
        {
            get
            {
                return this.serverVersionField;
            }
            set
            {
                this.serverVersionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ProductType
        {
            get
            {
                return this.productTypeField;
            }
            set
            {
                this.productTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ConfigurationServers
    {

        private ConfigurationServerInfo serverInfoField;

        /// <remarks/>
        public ConfigurationServerInfo ServerInfo
        {
            get
            {
                return this.serverInfoField;
            }
            set
            {
                this.serverInfoField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ConfigurationServerInfo
    {

        private string idField;

        private string nameField;

        private string urlField;

        private string primaryIpField;

        private ushort primaryPortField;

        private ushort primarySslPortField;

        private string secondaryIpField;

        private byte secondaryPortField;

        private byte secondarySslPortField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Url
        {
            get
            {
                return this.urlField;
            }
            set
            {
                this.urlField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PrimaryIp
        {
            get
            {
                return this.primaryIpField;
            }
            set
            {
                this.primaryIpField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort PrimaryPort
        {
            get
            {
                return this.primaryPortField;
            }
            set
            {
                this.primaryPortField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort PrimarySslPort
        {
            get
            {
                return this.primarySslPortField;
            }
            set
            {
                this.primarySslPortField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SecondaryIp
        {
            get
            {
                return this.secondaryIpField;
            }
            set
            {
                this.secondaryIpField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte SecondaryPort
        {
            get
            {
                return this.secondaryPortField;
            }
            set
            {
                this.secondaryPortField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte SecondarySslPort
        {
            get
            {
                return this.secondarySslPortField;
            }
            set
            {
                this.secondarySslPortField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ConfigurationChannelInfo
    {

        private ConfigurationChannelInfoStreams streamsField;

        private object userScenariosField;

        private string idField;

        private string nameField;

        private string descriptionField;

        private string deviceInfoField;

        private string attachedToServerField;

        private bool isDisabledField;

        private bool isSoundOnField;

        private bool isArchivingEnabledField;

        private bool isSoundArchivingEnabledField;

        private bool allowedRealtimeField;

        private bool allowedArchiveField;

        private bool isPtzOnField;

        private bool isTransmitSoundOnField;

        private string archiveModeField;

        private string archiveStreamTypeField;

        private bool isFaceAnalystEnabledField;

        private bool isPeopleCountingEnabledField;

        /// <remarks/>
        public ConfigurationChannelInfoStreams Streams
        {
            get
            {
                return this.streamsField;
            }
            set
            {
                this.streamsField = value;
            }
        }

        /// <remarks/>
        public object UserScenarios
        {
            get
            {
                return this.userScenariosField;
            }
            set
            {
                this.userScenariosField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DeviceInfo
        {
            get
            {
                return this.deviceInfoField;
            }
            set
            {
                this.deviceInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AttachedToServer
        {
            get
            {
                return this.attachedToServerField;
            }
            set
            {
                this.attachedToServerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool IsDisabled
        {
            get
            {
                return this.isDisabledField;
            }
            set
            {
                this.isDisabledField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool IsSoundOn
        {
            get
            {
                return this.isSoundOnField;
            }
            set
            {
                this.isSoundOnField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool IsArchivingEnabled
        {
            get
            {
                return this.isArchivingEnabledField;
            }
            set
            {
                this.isArchivingEnabledField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool IsSoundArchivingEnabled
        {
            get
            {
                return this.isSoundArchivingEnabledField;
            }
            set
            {
                this.isSoundArchivingEnabledField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool AllowedRealtime
        {
            get
            {
                return this.allowedRealtimeField;
            }
            set
            {
                this.allowedRealtimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool AllowedArchive
        {
            get
            {
                return this.allowedArchiveField;
            }
            set
            {
                this.allowedArchiveField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool IsPtzOn
        {
            get
            {
                return this.isPtzOnField;
            }
            set
            {
                this.isPtzOnField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool IsTransmitSoundOn
        {
            get
            {
                return this.isTransmitSoundOnField;
            }
            set
            {
                this.isTransmitSoundOnField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ArchiveMode
        {
            get
            {
                return this.archiveModeField;
            }
            set
            {
                this.archiveModeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ArchiveStreamType
        {
            get
            {
                return this.archiveStreamTypeField;
            }
            set
            {
                this.archiveStreamTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool IsFaceAnalystEnabled
        {
            get
            {
                return this.isFaceAnalystEnabledField;
            }
            set
            {
                this.isFaceAnalystEnabledField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool IsPeopleCountingEnabled
        {
            get
            {
                return this.isPeopleCountingEnabledField;
            }
            set
            {
                this.isPeopleCountingEnabledField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ConfigurationChannelInfoStreams
    {

        private ConfigurationChannelInfoStreamsStreamInfo streamInfoField;

        /// <remarks/>
        public ConfigurationChannelInfoStreamsStreamInfo StreamInfo
        {
            get
            {
                return this.streamInfoField;
            }
            set
            {
                this.streamInfoField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ConfigurationChannelInfoStreamsStreamInfo
    {

        private string streamTypeField;

        private string streamFormatField;

        private string rotationModeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string StreamType
        {
            get
            {
                return this.streamTypeField;
            }
            set
            {
                this.streamTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string StreamFormat
        {
            get
            {
                return this.streamFormatField;
            }
            set
            {
                this.streamFormatField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RotationMode
        {
            get
            {
                return this.rotationModeField;
            }
            set
            {
                this.rotationModeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ConfigurationRootSecurityObject
    {

        private ConfigurationRootSecurityObjectSecObjectInfo[] childSecurityObjectsField;

        private object childChannelsField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("SecObjectInfo", IsNullable = false)]
        public ConfigurationRootSecurityObjectSecObjectInfo[] ChildSecurityObjects
        {
            get
            {
                return this.childSecurityObjectsField;
            }
            set
            {
                this.childSecurityObjectsField = value;
            }
        }

        /// <remarks/>
        public object ChildChannels
        {
            get
            {
                return this.childChannelsField;
            }
            set
            {
                this.childChannelsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ConfigurationRootSecurityObjectSecObjectInfo
    {

        private object childSecurityObjectsField;

        private string[] childChannelsField;

        private string idField;

        private string nameField;

        /// <remarks/>
        public object ChildSecurityObjects
        {
            get
            {
                return this.childSecurityObjectsField;
            }
            set
            {
                this.childSecurityObjectsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ChannelId", IsNullable = false)]
        public string[] ChildChannels
        {
            get
            {
                return this.childChannelsField;
            }
            set
            {
                this.childChannelsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ConfigurationUserGroup
    {

        private string[] gridTypesAllowedField;

        private string idField;

        private string nameField;

        private bool canConfigureField;

        private bool canConfigureWorkplaceField;

        private bool canShutdownField;

        private bool canChangeChannelModeField;

        private bool canManageRecField;

        private bool canAccessExpertModeField;

        private bool canPTZField;

        private string ptzPriorityField;

        private bool canReceiveSoundField;

        private bool canTransmitSoundField;

        private bool canAccessNewCameraField;

        private bool canAccessReportsField;

        private bool canGetTranscodedVideoFromMobileServerField;

        private bool canAccessEditingAnalystPluginsInClientField;

        private bool canAccessVideoViaWebField;

        private bool canAccessVideoViaSmartTVField;

        private bool canExportVideoToAviField;

        private bool canUseArchiveExportField;

        private bool canReceiveMainStreamField;

        private bool isAllForbiddenField;

        private bool canAccessUnifiedLogField;

        private bool canAccessArchiveMarksField;

        private bool canAccessSearchField;

        private bool canAccessToAllUsersInUnifiedLogField;

        private bool canReceiveMobilePushField;

        private bool messengerCanSendMessagesField;

        private bool messengerCanReceiveMessagesField;

        private bool canConfigureVideowallField;

        private bool canBrowsingVideowallField;

        private bool canAccessPlansField;

        private bool canChangePasswordField;

        private bool canRunUserScenariosField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("GridTypes", IsNullable = false)]
        public string[] GridTypesAllowed
        {
            get
            {
                return this.gridTypesAllowedField;
            }
            set
            {
                this.gridTypesAllowedField = value;
            }
        }

        /// <remarks/>
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public bool CanConfigure
        {
            get
            {
                return this.canConfigureField;
            }
            set
            {
                this.canConfigureField = value;
            }
        }

        /// <remarks/>
        public bool CanConfigureWorkplace
        {
            get
            {
                return this.canConfigureWorkplaceField;
            }
            set
            {
                this.canConfigureWorkplaceField = value;
            }
        }

        /// <remarks/>
        public bool CanShutdown
        {
            get
            {
                return this.canShutdownField;
            }
            set
            {
                this.canShutdownField = value;
            }
        }

        /// <remarks/>
        public bool CanChangeChannelMode
        {
            get
            {
                return this.canChangeChannelModeField;
            }
            set
            {
                this.canChangeChannelModeField = value;
            }
        }

        /// <remarks/>
        public bool CanManageRec
        {
            get
            {
                return this.canManageRecField;
            }
            set
            {
                this.canManageRecField = value;
            }
        }

        /// <remarks/>
        public bool CanAccessExpertMode
        {
            get
            {
                return this.canAccessExpertModeField;
            }
            set
            {
                this.canAccessExpertModeField = value;
            }
        }

        /// <remarks/>
        public bool CanPTZ
        {
            get
            {
                return this.canPTZField;
            }
            set
            {
                this.canPTZField = value;
            }
        }

        /// <remarks/>
        public string PtzPriority
        {
            get
            {
                return this.ptzPriorityField;
            }
            set
            {
                this.ptzPriorityField = value;
            }
        }

        /// <remarks/>
        public bool CanReceiveSound
        {
            get
            {
                return this.canReceiveSoundField;
            }
            set
            {
                this.canReceiveSoundField = value;
            }
        }

        /// <remarks/>
        public bool CanTransmitSound
        {
            get
            {
                return this.canTransmitSoundField;
            }
            set
            {
                this.canTransmitSoundField = value;
            }
        }

        /// <remarks/>
        public bool CanAccessNewCamera
        {
            get
            {
                return this.canAccessNewCameraField;
            }
            set
            {
                this.canAccessNewCameraField = value;
            }
        }

        /// <remarks/>
        public bool CanAccessReports
        {
            get
            {
                return this.canAccessReportsField;
            }
            set
            {
                this.canAccessReportsField = value;
            }
        }

        /// <remarks/>
        public bool CanGetTranscodedVideoFromMobileServer
        {
            get
            {
                return this.canGetTranscodedVideoFromMobileServerField;
            }
            set
            {
                this.canGetTranscodedVideoFromMobileServerField = value;
            }
        }

        /// <remarks/>
        public bool CanAccessEditingAnalystPluginsInClient
        {
            get
            {
                return this.canAccessEditingAnalystPluginsInClientField;
            }
            set
            {
                this.canAccessEditingAnalystPluginsInClientField = value;
            }
        }

        /// <remarks/>
        public bool CanAccessVideoViaWeb
        {
            get
            {
                return this.canAccessVideoViaWebField;
            }
            set
            {
                this.canAccessVideoViaWebField = value;
            }
        }

        /// <remarks/>
        public bool CanAccessVideoViaSmartTV
        {
            get
            {
                return this.canAccessVideoViaSmartTVField;
            }
            set
            {
                this.canAccessVideoViaSmartTVField = value;
            }
        }

        /// <remarks/>
        public bool CanExportVideoToAvi
        {
            get
            {
                return this.canExportVideoToAviField;
            }
            set
            {
                this.canExportVideoToAviField = value;
            }
        }

        /// <remarks/>
        public bool CanUseArchiveExport
        {
            get
            {
                return this.canUseArchiveExportField;
            }
            set
            {
                this.canUseArchiveExportField = value;
            }
        }

        /// <remarks/>
        public bool CanReceiveMainStream
        {
            get
            {
                return this.canReceiveMainStreamField;
            }
            set
            {
                this.canReceiveMainStreamField = value;
            }
        }

        /// <remarks/>
        public bool IsAllForbidden
        {
            get
            {
                return this.isAllForbiddenField;
            }
            set
            {
                this.isAllForbiddenField = value;
            }
        }

        /// <remarks/>
        public bool CanAccessUnifiedLog
        {
            get
            {
                return this.canAccessUnifiedLogField;
            }
            set
            {
                this.canAccessUnifiedLogField = value;
            }
        }

        /// <remarks/>
        public bool CanAccessArchiveMarks
        {
            get
            {
                return this.canAccessArchiveMarksField;
            }
            set
            {
                this.canAccessArchiveMarksField = value;
            }
        }

        /// <remarks/>
        public bool CanAccessSearch
        {
            get
            {
                return this.canAccessSearchField;
            }
            set
            {
                this.canAccessSearchField = value;
            }
        }

        /// <remarks/>
        public bool CanAccessToAllUsersInUnifiedLog
        {
            get
            {
                return this.canAccessToAllUsersInUnifiedLogField;
            }
            set
            {
                this.canAccessToAllUsersInUnifiedLogField = value;
            }
        }

        /// <remarks/>
        public bool CanReceiveMobilePush
        {
            get
            {
                return this.canReceiveMobilePushField;
            }
            set
            {
                this.canReceiveMobilePushField = value;
            }
        }

        /// <remarks/>
        public bool MessengerCanSendMessages
        {
            get
            {
                return this.messengerCanSendMessagesField;
            }
            set
            {
                this.messengerCanSendMessagesField = value;
            }
        }

        /// <remarks/>
        public bool MessengerCanReceiveMessages
        {
            get
            {
                return this.messengerCanReceiveMessagesField;
            }
            set
            {
                this.messengerCanReceiveMessagesField = value;
            }
        }

        /// <remarks/>
        public bool CanConfigureVideowall
        {
            get
            {
                return this.canConfigureVideowallField;
            }
            set
            {
                this.canConfigureVideowallField = value;
            }
        }

        /// <remarks/>
        public bool CanBrowsingVideowall
        {
            get
            {
                return this.canBrowsingVideowallField;
            }
            set
            {
                this.canBrowsingVideowallField = value;
            }
        }

        /// <remarks/>
        public bool CanAccessPlans
        {
            get
            {
                return this.canAccessPlansField;
            }
            set
            {
                this.canAccessPlansField = value;
            }
        }

        /// <remarks/>
        public bool CanChangePassword
        {
            get
            {
                return this.canChangePasswordField;
            }
            set
            {
                this.canChangePasswordField = value;
            }
        }

        /// <remarks/>
        public bool CanRunUserScenarios
        {
            get
            {
                return this.canRunUserScenariosField;
            }
            set
            {
                this.canRunUserScenariosField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ConfigurationMobileServerInfo
    {

        private ConfigurationMobileServerInfoResolutionInfo[] resolutionsField;

        private bool isEnabledField;

        private bool isProxyEnabledField;

        private bool isMobilePushEnabledField;

        private ushort portField;

        private bool usePFramesField;

        private byte fpsLimitField;

        private string lowResolutionField;

        private string middleResolutionField;

        private string highResolutionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ResolutionInfo", IsNullable = false)]
        public ConfigurationMobileServerInfoResolutionInfo[] Resolutions
        {
            get
            {
                return this.resolutionsField;
            }
            set
            {
                this.resolutionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool IsEnabled
        {
            get
            {
                return this.isEnabledField;
            }
            set
            {
                this.isEnabledField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool IsProxyEnabled
        {
            get
            {
                return this.isProxyEnabledField;
            }
            set
            {
                this.isProxyEnabledField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool IsMobilePushEnabled
        {
            get
            {
                return this.isMobilePushEnabledField;
            }
            set
            {
                this.isMobilePushEnabledField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort Port
        {
            get
            {
                return this.portField;
            }
            set
            {
                this.portField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool UsePFrames
        {
            get
            {
                return this.usePFramesField;
            }
            set
            {
                this.usePFramesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte FpsLimit
        {
            get
            {
                return this.fpsLimitField;
            }
            set
            {
                this.fpsLimitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LowResolution
        {
            get
            {
                return this.lowResolutionField;
            }
            set
            {
                this.lowResolutionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MiddleResolution
        {
            get
            {
                return this.middleResolutionField;
            }
            set
            {
                this.middleResolutionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string HighResolution
        {
            get
            {
                return this.highResolutionField;
            }
            set
            {
                this.highResolutionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ConfigurationMobileServerInfoResolutionInfo
    {

        private ushort widthField;

        private ushort heightField;

        private bool isEnabledField;

        private byte fpsLimitField;

        private bool usePFramesField;

        private string typeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort Width
        {
            get
            {
                return this.widthField;
            }
            set
            {
                this.widthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort Height
        {
            get
            {
                return this.heightField;
            }
            set
            {
                this.heightField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool IsEnabled
        {
            get
            {
                return this.isEnabledField;
            }
            set
            {
                this.isEnabledField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte FpsLimit
        {
            get
            {
                return this.fpsLimitField;
            }
            set
            {
                this.fpsLimitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool UsePFrames
        {
            get
            {
                return this.usePFramesField;
            }
            set
            {
                this.usePFramesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ConfigurationRtspServerInfo
    {

        private bool isEnabledField;

        private ushort tcpPortField;

        private bool isMjpegEnabledField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool IsEnabled
        {
            get
            {
                return this.isEnabledField;
            }
            set
            {
                this.isEnabledField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort TcpPort
        {
            get
            {
                return this.tcpPortField;
            }
            set
            {
                this.tcpPortField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool IsMjpegEnabled
        {
            get
            {
                return this.isMjpegEnabledField;
            }
            set
            {
                this.isMjpegEnabledField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ConfigurationMobileDevicesCapabilities
    {

        private bool archiveField;

        private bool ptzField;

        private bool hlsField;

        private bool appleMobilePushField;

        private bool androidMobilePushField;

        private bool profilesField;

        private bool userScenariosField;

        private bool smartAssistantField;

        /// <remarks/>
        public bool Archive
        {
            get
            {
                return this.archiveField;
            }
            set
            {
                this.archiveField = value;
            }
        }

        /// <remarks/>
        public bool Ptz
        {
            get
            {
                return this.ptzField;
            }
            set
            {
                this.ptzField = value;
            }
        }

        /// <remarks/>
        public bool Hls
        {
            get
            {
                return this.hlsField;
            }
            set
            {
                this.hlsField = value;
            }
        }

        /// <remarks/>
        public bool AppleMobilePush
        {
            get
            {
                return this.appleMobilePushField;
            }
            set
            {
                this.appleMobilePushField = value;
            }
        }

        /// <remarks/>
        public bool AndroidMobilePush
        {
            get
            {
                return this.androidMobilePushField;
            }
            set
            {
                this.androidMobilePushField = value;
            }
        }

        /// <remarks/>
        public bool Profiles
        {
            get
            {
                return this.profilesField;
            }
            set
            {
                this.profilesField = value;
            }
        }

        /// <remarks/>
        public bool UserScenarios
        {
            get
            {
                return this.userScenariosField;
            }
            set
            {
                this.userScenariosField = value;
            }
        }

        /// <remarks/>
        public bool SmartAssistant
        {
            get
            {
                return this.smartAssistantField;
            }
            set
            {
                this.smartAssistantField = value;
            }
        }
    }


}
