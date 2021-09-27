using demoMacrosropTestApp.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace demoMacrosropTestApp.Services.Cameras
{
    public interface ICameraConfiguration
    {
        Task<IEnumerable<Camera>> GetConfigurationAsync();
    }
}
