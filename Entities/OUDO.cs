using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddOnIntercompany.Entities
{
    public class OUDO
    {
        [JsonProperty("Name"), SAPKey] public string Name { get; set; }
    }
}
