using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

namespace BlottEnDag
{
    public static class MakeJson
    {
        public static string Serialize(object obj)
        {
            // Reuse options, https://docs.microsoft.com/en-us/dotnet/standard/serialization/system-text-json-configure-options?pivots=dotnet-5-0
            // https://docs.microsoft.com/en-us/dotnet/standard/serialization/system-text-json-character-encoding
            var encoderSettings = new TextEncoderSettings();
            // ä, Ö, å, Ä, ö
            encoderSettings.AllowCharacters('\u00E4', '\u00D6', '\u00E5', '\u00C4', '\u00F6');
            encoderSettings.AllowRange(UnicodeRanges.BasicLatin);
            
            var options = new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.Create(encoderSettings),
                WriteIndented = true
            };

            return JsonSerializer.Serialize(obj, options);
        }
    }
}
