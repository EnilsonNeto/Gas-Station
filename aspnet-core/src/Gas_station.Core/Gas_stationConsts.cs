using Gas_station.Debugging;

namespace Gas_station
{
    public class Gas_stationConsts
    {
        public const string LocalizationSourceName = "Gas_station";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "bf4188e8bf7241a2aeaec7f6da6c00bf";
    }
}
