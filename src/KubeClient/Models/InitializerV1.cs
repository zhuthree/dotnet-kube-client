using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace KubeClient.Models
{
    /// <summary>
    ///     Initializer is information about an initializer that has not yet completed.
    /// </summary>
    [KubeResource("Initializer", "v1")]
    public class InitializerV1
    {
        /// <summary>
        ///     name of the process that is responsible for initializing this object.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}