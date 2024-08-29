using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddOnIntercompany.Entities
{
    [SAPEntityName("SQLQueries")]
    public class OQRY
    {
        [JsonProperty("SqlCode"), SAPKey] public string SqlCode { get; set; }
        [JsonProperty("SqlName")] public string SqlName { get; set; }
        [JsonProperty("SqlText")] public string SqlText { get; set; }
    }
}
