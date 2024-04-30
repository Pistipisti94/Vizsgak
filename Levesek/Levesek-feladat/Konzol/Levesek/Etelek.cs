    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
//    var etelek = Etelek.FromJson(jsonString);

namespace Levesek
{

    public partial class Etelek
    {
        [JsonProperty("megnevezes")]
        public string Megnevezes { get; set; }

        [JsonProperty("kaloria")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Kaloria { get; set; }

        [JsonProperty("feherje")]
        public string Feherje { get; set; }

        [JsonProperty("zsir")]
        public string Zsir { get; set; }

        [JsonProperty("szenhidrat")]
        public string Szenhidrat { get; set; }

        [JsonProperty("hamu")]
        public string Hamu { get; set; }

        [JsonProperty("rost")]
        public string Rost { get; set; }
    }

    public partial class Etelek
    {
        public static Etelek[] FromJson(string json) => JsonConvert.DeserializeObject<Etelek[]>(json, Levesek.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Etelek[] self) => JsonConvert.SerializeObject(self, Levesek.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class ParseStringConverter : JsonConverter
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
