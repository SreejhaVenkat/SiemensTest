using System;
using System.Collections.Generic;
using System.Text;

namespace SiemensTest
{
    internal class PlatformFactory
    {
        internal static PlatFormTypeBase GetPlatFormType(PlatformTypes platformType)
        {
            return platformType switch
            {
                PlatformTypes.Android => new AndroidPlatform(),
                PlatformTypes.Windows => new WindowsPlatform(),
                PlatformTypes.iOS => new IosPlatform(),
                _ => null
            };
        }
    }
}
