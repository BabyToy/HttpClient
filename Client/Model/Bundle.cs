// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using Client.Model;
//
//    var data = Bundle.FromJson(jsonString);
//
namespace Client.Model
{
    using Newtonsoft.Json;

    public partial class Bundle
    {
        [JsonProperty("bgUrl")]
        public string BgUrl { get; set; }

        [JsonProperty("bom")]
        public Bom[] Bom { get; set; }

        [JsonProperty("bundleId")]
        public string BundleId { get; set; }

        [JsonProperty("costs")]
        public Cost[] Costs { get; set; }

        [JsonProperty("created")]
        public long Created { get; set; }

        [JsonProperty("creator")]
        public string Creator { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("fgUrl")]
        public string FgUrl { get; set; }

        [JsonProperty("imageUrl")]
        public string ImageUrl { get; set; }

        [JsonProperty("limits")]
        public Limits Limits { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("requirements")]
        public Requirement[] Requirements { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }
    }

    public partial class Requirement
    {
        [JsonProperty("qty")]
        public long Qty { get; set; }

        [JsonProperty("reqtType")]
        public string ReqtType { get; set; }
    }

    public partial class Limits
    {
        [JsonProperty("endTime")]
        public long EndTime { get; set; }

        [JsonProperty("startTime")]
        public long StartTime { get; set; }
    }

    public partial class Cost
    {
        [JsonProperty("amount")]
        public long Amount { get; set; }

        [JsonProperty("itemId")]
        public string ItemId { get; set; }
    }

    public partial class Bom
    {
        [JsonProperty("itemId")]
        public string ItemId { get; set; }

        [JsonProperty("qty")]
        public long Qty { get; set; }
    }

    public partial class Bundle
    {
        public static Bundle FromJson(string json) => JsonConvert.DeserializeObject<Bundle>(json, Converter.Settings);
    }

    public class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
        };
    }
}