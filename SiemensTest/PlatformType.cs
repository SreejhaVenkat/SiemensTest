using System;

namespace SiemensTest
{
    public class PlatformType: IPlatformType
    {
        public string GetMessage(string type)
        {
            if (!Enum.TryParse<PlatformTypes>(type, out var platformType)) return string.Empty;
            var platform = PlatformFactory.GetPlatFormType(platformType);
            return platform.GetMessage();

        }
    }
}
