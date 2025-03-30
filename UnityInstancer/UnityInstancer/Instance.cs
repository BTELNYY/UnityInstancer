using Newtonsoft.Json;

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
