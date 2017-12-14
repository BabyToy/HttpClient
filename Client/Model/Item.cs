// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using Client.Model;
//
//    var data = Item.FromJson(jsonString);
//
namespace Client.Model
{
    using Newtonsoft.Json;

    public partial class Item
    {
        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("created")]
        public long Created { get; set; }

        [JsonProperty("creator")]
        public string Creator { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("imageUrl")]
        public string ImageUrl { get; set; }

        [JsonProperty("itemId")]
        public string ItemId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public partial class Item
    {
        public static Item FromJson(string json) => JsonConvert.DeserializeObject<Item>(json, Converter.Settings);
    }
}