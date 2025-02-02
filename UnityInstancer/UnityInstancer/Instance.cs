using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityInstancer
{
    public class Instance
    {
        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;
    
        public List<string> Arguments { get; set; } = new List<string>();

        [JsonIgnore]
        public string FolderPath { get; set; } = string.Empty;
    }
}
