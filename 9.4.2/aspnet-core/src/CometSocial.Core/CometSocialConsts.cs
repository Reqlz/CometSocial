using CometSocial.Debugging;

namespace CometSocial
{
    public class CometSocialConsts
    {
        public const string LocalizationSourceName = "CometSocial";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "583c5ddeb0d542f8b98fa91b37e287aa";
    }
}
