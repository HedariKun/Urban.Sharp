using System.Collections.Generic;
using Newtonsoft.Json;

namespace Urban.Sharp.Response
{
    public class DefinitionObject
    {
        [JsonProperty("definition")]
        public string Definition;

        [JsonProperty("permalink")]
        public string Permalink;

        [JsonProperty("thumbs_up")]
        public int TbumbsUp;

        [JsonProperty("author")]
        public string Author;

        [JsonProperty("word")]
        public string Word;

        [JsonProperty("defid")]
        public long DefID;

        [JsonProperty("current_vote")]
        public string CurrentVote;

        [JsonProperty("written_on")]
        public string WrittenOn;

        [JsonProperty("example")]
        public string Example;

        [JsonProperty("thumbs_down")]
        public int ThumbsDown;

    }
}
