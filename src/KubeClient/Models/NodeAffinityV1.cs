using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace KubeClient.Models
{
    /// <summary>
    ///     Node affinity is a group of node affinity scheduling rules.
    /// </summary>
    [KubeResource("NodeAffinity", "v1")]
    public class NodeAffinityV1
    {
        /// <summary>
        ///     The scheduler will prefer to schedule pods to nodes that satisfy the affinity expressions specified by this field, but it may choose a node that violates one or more of the expressions. The node that is most preferred is the one with the greatest sum of weights, i.e. for each node that meets all of the scheduling requirements (resource request, requiredDuringScheduling affinity expressions, etc.), compute a sum by iterating through the elements of this field and adding "weight" to the sum if the node matches the corresponding matchExpressions; the node(s) with the highest sum are the most preferred.
        /// </summary>
        [JsonProperty("preferredDuringSchedulingIgnoredDuringExecution", NullValueHandling = NullValueHandling.Ignore)]
        public List<PreferredSchedulingTermV1> PreferredDuringSchedulingIgnoredDuringExecution { get; set; } = new List<PreferredSchedulingTermV1>();

        /// <summary>
        ///     If the affinity requirements specified by this field are not met at scheduling time, the pod will not be scheduled onto the node. If the affinity requirements specified by this field cease to be met at some point during pod execution (e.g. due to an update), the system may or may not try to eventually evict the pod from its node.
        /// </summary>
        [JsonProperty("requiredDuringSchedulingIgnoredDuringExecution")]
        public NodeSelectorV1 RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
    }
}