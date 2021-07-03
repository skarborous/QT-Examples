using Newtonsoft.Json;

namespace OKExV5Vendor.API.REST
{
    class OKExRestResponce<T>
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("msg")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public T Data { get; set; }
    }
}
