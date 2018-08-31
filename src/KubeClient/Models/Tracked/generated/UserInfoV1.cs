using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace KubeClient.Models.Tracked
{
    /// <summary>
    ///     UserInfo holds the information about the user needed to implement the user.Info interface.
    /// </summary>
    public partial class UserInfoV1 : Models.UserInfoV1, ITracked
    {
        /// <summary>
        ///     Any additional information provided by the authenticator.
        /// </summary>
        [YamlMember(Alias = "extra")]
        [JsonProperty("extra", NullValueHandling = NullValueHandling.Ignore)]
        public override Dictionary<string, List<string>> Extra { get; set; } = new Dictionary<string, List<string>>();

        /// <summary>
        ///     A unique value that identifies this user across time. If this user is deleted and another user by the same name is added, they will have different UIDs.
        /// </summary>
        [JsonProperty("uid")]
        [YamlMember(Alias = "uid")]
        public override string Uid
        {
            get
            {
                return base.Uid;
            }
            set
            {
                base.Uid = value;

                __ModifiedProperties__.Add("Uid");
            }
        }


        /// <summary>
        ///     The name that uniquely identifies this user among all active users.
        /// </summary>
        [JsonProperty("username")]
        [YamlMember(Alias = "username")]
        public override string Username
        {
            get
            {
                return base.Username;
            }
            set
            {
                base.Username = value;

                __ModifiedProperties__.Add("Username");
            }
        }


        /// <summary>
        ///     The names of groups this user is a part of.
        /// </summary>
        [YamlMember(Alias = "groups")]
        [JsonProperty("groups", NullValueHandling = NullValueHandling.Ignore)]
        public override List<string> Groups { get; set; } = new List<string>();

        /// <summary>
        ///     Names of model properties that have been modified.
        /// </summary>
        [JsonIgnore, YamlIgnore]
        public ISet<string> __ModifiedProperties__ { get; } = new HashSet<string>();
    }
}