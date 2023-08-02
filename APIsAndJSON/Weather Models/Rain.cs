using Newtonsoft.Json;

namespace APIsAndJSON
{
    public class Rain
    {
        [JsonProperty("3h")]
        public double _3h { get; set; }
    }
}
