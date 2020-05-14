using Hymnal.Core.Models;
using System.Linq;

namespace Hymnal.Core.Extensions
{
    public static class HymnalLanguageExtension
    {
        /// <summary>
        /// Get updated information about this Language
        /// Useful for Favorites and Records Hymnals becouse the name of the files of the hymals can change
        /// </summary>
        public static HymnalLanguage Configuration(this HymnalLanguage hymnalLanguage)
        {
            return Constants.HymnsLanguages.First(hl => hl.Id == hymnalLanguage.Id);
        }

        /// <summary>
        /// Get Instrument URL
        /// </summary>
        /// <param name="hymnalLanguage"></param>
        /// <param name="hymnNumber"></param>
        /// <returns></returns>
        public static string GetInstrumentURL(this HymnalLanguage hymnalLanguage, int hymnNumber)
        {
            // Number in 3 digits number when it's less than 3 digits. In an other situation
            // the number will not change
            return hymnalLanguage.Configuration().InstrumentalMusic.Replace("###", hymnNumber.ToString("D3"));
        }

        /// <summary>
        /// Get Sung URL
        /// </summary>
        /// <param name="hymnalLanguage"></param>
        /// <param name="hymnNumber"></param>
        /// <returns></returns>
        public static string GetSungURL(this HymnalLanguage hymnalLanguage, int hymnNumber)
        {
            // Number in 3 digits number when it's less than 3 digits. In an other situation
            // the number will not change
            return hymnalLanguage.Configuration().SungMusic.Replace("###", hymnNumber.ToString("D3"));
        }

        /// <summary>
        /// Get Music Sheet
        /// </summary>
        /// <param name="hymnalLanguage"></param>
        /// <param name="hymnNymber"></param>
        /// <returns></returns>
        public static string GetMusicSheetSource(this HymnalLanguage hymnalLanguage, int hymnNymber)
        {
            return hymnalLanguage.Configuration().HymnsSheetsFileName.Replace("###", hymnNymber.ToString("D3"));
        }
    }
}
