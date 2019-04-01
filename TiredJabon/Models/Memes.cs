using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TiredJabon.Models
{
    public class Memes
    {
        [JsonProperty("memes")]
        public MemeStructure memes { get; set; }
    }
    public class MemeStructure
    {
        [JsonProperty("id")]
        public int id { get; set; }
        [JsonProperty("name")]
        public int name { get; set; }
        [JsonProperty("url")]
        public int url { get; set; }
        [JsonProperty("width")]
        public int width { get; set; }
        [JsonProperty("height")]
        public int height { get; set; }
        [JsonProperty("box_count")]
        public int box_count { get; set; }
    }
}
