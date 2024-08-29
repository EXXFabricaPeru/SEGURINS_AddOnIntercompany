using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddOnIntercompany.Entities
{
    [SAPEntityName("U_EXX_INDO_BASE")]
    public class BASE
    {
        [JsonProperty("Code"), SAPKey] public string Code { get; set; }
        [JsonProperty("Name")] public string Name { get; set; }
        [JsonProperty("EXX_INDO_PROV")] public string EXX_INDO_PROV { get; set; }
        [JsonProperty("EXX_INDO_CLIE")] public string EXX_INDO_CLIE { get; set; }
    }
}
