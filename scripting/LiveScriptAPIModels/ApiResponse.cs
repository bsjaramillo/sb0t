using Newtonsoft.Json;
using System.Collections.Generic;

public class ApiResponse
{
    [JsonProperty("ok")]
    public bool Ok { get; set; }

    [JsonProperty("data")]
    public List<Repository> Data { get; set; }
}