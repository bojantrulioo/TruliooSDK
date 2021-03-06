using System;

namespace TruliooSDK.Enums
{
    public static class ModeExtension
    {
        public static string ToFriendlyString(this Mode mode)
        {
            switch (mode)
            {
                case Mode.Free:
                    return "free";
                case Mode.Live:
                    return "live";
                case Mode.Trial:
                    return "trial";
                default:
                    throw new ArgumentOutOfRangeException(nameof(mode), mode, "Mode not mapped");
            }
        }
    }
}
