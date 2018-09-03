using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace KubeClient.Models
{
    /// <summary>
    ///     Represents a Photon Controller persistent disk resource.
    /// </summary>
    public partial class PhotonPersistentDiskVolumeSourceV1
    {
        /// <summary>
        ///     Filesystem type to mount. Must be a filesystem type supported by the host operating system. Ex. "ext4", "xfs", "ntfs". Implicitly inferred to be "ext4" if unspecified.
        /// </summary>
        [JsonProperty("fsType")]
        [YamlMember(Alias = "fsType")]
        public string FsType { get; set; }

        /// <summary>
        ///     ID that identifies Photon Controller persistent disk
        /// </summary>
        [JsonProperty("pdID")]
        [YamlMember(Alias = "pdID")]
        public string PdID { get; set; }
    }
}
