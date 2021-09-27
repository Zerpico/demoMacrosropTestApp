using System;
using System.Collections.Generic;
using System.Text;

namespace demoMacrosropTestApp.Common
{
    public class ServerInfo
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Url { get; set; }

        public string PrimaryIp { get; set; }

        public short PrimaryPort { get; set; }

        public short PrimarySslPort { get; set; }

        public string SecondaryIp { get; set; }

        public short SecondaryPort { get; set; }

        public short SecondarySslPort { get; set; }
    }
}
