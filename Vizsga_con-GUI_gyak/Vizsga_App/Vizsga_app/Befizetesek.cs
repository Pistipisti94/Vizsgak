    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
//    var befizetesek = Befizetesek.FromJson(jsonString);

namespace Vizsga_app
{

    public partial class Befizetesek
    {
        [JsonProperty("azon", Required = Required.AllowNull)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? Azon { get; set; }

        [JsonProperty("datum", Required = Required.AllowNull)]
        public DateTimeOffset? Datum { get; set; }

        [JsonProperty("osszeg", Required = Required.Always)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Osszeg { get; set; }
    }

    public partial class Befizetesek
    {
        public static Befizetesek[] FromJson(string json) => JsonConvert.DeserializeObject<Befizetesek[]>(json, Vizsga_app.Converter.Settings);
    }

    public static class Serialize2
    {
        public static string ToJson(this Befizetesek[] self) => JsonConvert.SerializeObject(self, Vizsga_app.Converter.Settings);
    }

    internal static class Converter2
    {
        public static readonly JsonSerializerSettings Settings2 = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class ParseStringConverter2 : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            long l;
            if (Int64.TryParse(value, out l))
            {
                return l;
            }
            throw new Exception("Cannot unmarshal type long");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (long)untypedValue;
            serializer.Serialize(writer, value.ToString());
            return;
        }

        public static readonly ParseStringConverter Singleton = new ParseStringConverter();
    }
}
