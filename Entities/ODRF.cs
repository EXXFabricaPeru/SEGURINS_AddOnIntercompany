using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddOnIntercompany.Entities
{
    [SAPEntityName("Drafts")]
    public class ODRF
    {
        [JsonProperty("DocEntry"), SAPKey] public int? DocEntry { get; set; }

    }
}
