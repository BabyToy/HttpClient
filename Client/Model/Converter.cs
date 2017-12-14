// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using Client.Model;
//
//    var data = Bundle.FromJson(jsonString);
//
namespace Client.Model
{
    using Newtonsoft.Json;

    public class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
        };
    }
}