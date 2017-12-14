// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using Client.Model;
//
//    var data = Bundle.FromJson(jsonString);
//
namespace Client.Model
{
    using Newtonsoft.Json;

    public static class Serialize
    {
        public static string ToJson(this Bundle self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }
}