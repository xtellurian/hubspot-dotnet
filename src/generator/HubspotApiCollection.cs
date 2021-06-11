// this file was generated using quicktype.io
namespace xtellurian.HubSpot.Generator
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class HubspotApiCollection
    {
        [JsonProperty("results")]
        public Result[] Results { get; set; }
    }

    public partial class Result
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("features")]
        public Dictionary<string, Feature> Features { get; set; }
    }

    public partial class Feature
    {
        [JsonProperty("openAPI")]
        public Uri OpenApi { get; set; }

        [JsonProperty("stage")]
        public Stage Stage { get; set; }
    }

    public enum Stage { DeveloperPreview, Latest };

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                StageConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class StageConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Stage) || t == typeof(Stage?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "DEVELOPER_PREVIEW":
                    return Stage.DeveloperPreview;
                case "LATEST":
                    return Stage.Latest;
            }
            throw new Exception("Cannot unmarshal type Stage");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Stage)untypedValue;
            switch (value)
            {
                case Stage.DeveloperPreview:
                    serializer.Serialize(writer, "DEVELOPER_PREVIEW");
                    return;
                case Stage.Latest:
                    serializer.Serialize(writer, "LATEST");
                    return;
            }
            throw new Exception("Cannot marshal type Stage");
        }

        public static readonly StageConverter Singleton = new StageConverter();
    }
}
