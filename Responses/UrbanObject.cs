using System.Collections.Generic;
using Newtonsoft.Json;

namespace Urban.Sharp.Response
{
    public class UrbanObject
    {
        [JsonProperty("list")]
        public IList<DefinitionObject> List;
    }
}