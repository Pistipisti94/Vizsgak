    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    var ugyfelek = Ugyfelek.FromJson(jsonString);

namespace Vizsga_app
{

    public partial class Ugyfelek
    {
        [JsonProperty("azon", Required = Required.Always)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Azon { get; set; }

        [JsonProperty("nev", Required = Required.Always)]
        public string Nev { get; set; }

        [JsonProperty("szulev", Required = Required.Always)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Szulev { get; set; }

        [JsonProperty("irszam", Required = Required.Always)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Irszam { get; set; }

        [JsonProperty("orsz", Required = Required.Always)]
        public string Orsz { get; set; }
    }

    public partial class Ugyfelek
    {
        public static Ugyfelek[] FromJson(string json) => JsonConvert.DeserializeObject<Ugyfelek[]>(json, Vizsga_app.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Ugyfelek[] self) => JsonConvert.SerializeObject(self, Vizsga_app.Converter.Settings);
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
