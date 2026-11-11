using System.Globalization;

namespace Adressbook
{
    public static class LanguageManager
    {
        public static string CurrentLanguge
        {
            get
            {
                string language = Properties.Settings.Default.Language;

                if (string.IsNullOrWhiteSpace(language))
                {
                    return "en";
                }

                return language;
            }
        }

        public static void ApplyCulture(string languageCode)
        {
            CultureInfo culture = new CultureInfo(languageCode);

            Thread.CurrentThread.CurrentUICulture = culture;
            Thread.CurrentThread.CurrentCulture = culture;
        }

        public static void SaveLanguage(string languageCode)
        {
            Properties.Settings.Default.Language = languageCode;
            Properties.Settings.Default.Save();

            ApplyCulture(languageCode);
        }
    }
}
