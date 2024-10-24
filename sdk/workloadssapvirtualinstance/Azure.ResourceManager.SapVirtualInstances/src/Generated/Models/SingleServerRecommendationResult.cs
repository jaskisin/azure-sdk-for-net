// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Workloads.SAPVirtualInstance.Models
{
    /// <summary> The recommended configuration for a single server SAP system. </summary>
    public partial class SingleServerRecommendationResult : SAPSizingRecommendationResult
    {
        /// <summary> Initializes a new instance of <see cref="SingleServerRecommendationResult"/>. </summary>
        internal SingleServerRecommendationResult()
        {
            DeploymentType = SAPDeploymentType.SingleServer;
        }

        /// <summary> Initializes a new instance of <see cref="SingleServerRecommendationResult"/>. </summary>
        /// <param name="deploymentType"> The deployment type. Eg: SingleServer/ThreeTier. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="vmSku"> The recommended VM SKU for single server. </param>
        internal SingleServerRecommendationResult(SAPDeploymentType deploymentType, IDictionary<string, BinaryData> serializedAdditionalRawData, string vmSku) : base(deploymentType, serializedAdditionalRawData)
        {
            VmSku = vmSku;
            DeploymentType = deploymentType;
        }

        /// <summary> The recommended VM SKU for single server. </summary>
        public string VmSku { get; }
    }
}
