// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.SapVirtualInstances.Models
{
    /// <summary> Defines the SAP Application Server instance properties. </summary>
    public partial class SapApplicationServerProperties
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SapApplicationServerProperties"/>. </summary>
        public SapApplicationServerProperties()
        {
            VmDetails = new ChangeTrackingList<ApplicationServerVmDetails>();
        }

        /// <summary> Initializes a new instance of <see cref="SapApplicationServerProperties"/>. </summary>
        /// <param name="instanceNo"> Application server Instance Number. </param>
        /// <param name="subnet"> Application server Subnet. </param>
        /// <param name="hostname"> Application server instance SAP hostname. </param>
        /// <param name="kernelVersion"> Application server instance SAP Kernel Version. </param>
        /// <param name="kernelPatch"> Application server instance SAP Kernel Patch level. </param>
        /// <param name="ipAddress"> Application server instance SAP IP Address. </param>
        /// <param name="gatewayPort"> Application server instance gateway Port. </param>
        /// <param name="icmHttpPort"> Application server instance ICM HTTP Port. </param>
        /// <param name="icmHttpsPort"> Application server instance ICM HTTPS Port. </param>
        /// <param name="dispatcherStatus"> Application server instance dispatcher status. </param>
        /// <param name="loadBalancerDetails"> The Load Balancer details such as LoadBalancer ID attached to Application Server Virtual Machines. </param>
        /// <param name="vmDetails"> The list of virtual machines. </param>
        /// <param name="status"> Defines the SAP Instance status. </param>
        /// <param name="health"> Defines the health of SAP Instances. </param>
        /// <param name="provisioningState"> Defines the provisioning states. </param>
        /// <param name="errors"> Defines the Application Instance errors. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SapApplicationServerProperties(string instanceNo, string subnet, string hostname, string kernelVersion, string kernelPatch, string ipAddress, long? gatewayPort, long? icmHttpPort, long? icmHttpsPort, string dispatcherStatus, SubResource loadBalancerDetails, IReadOnlyList<ApplicationServerVmDetails> vmDetails, SapVirtualInstanceStatus? status, SapHealthState? health, SapVirtualInstanceProvisioningState? provisioningState, SapVirtualInstanceError errors, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            InstanceNo = instanceNo;
            Subnet = subnet;
            Hostname = hostname;
            KernelVersion = kernelVersion;
            KernelPatch = kernelPatch;
            IPAddress = ipAddress;
            GatewayPort = gatewayPort;
            IcmHttpPort = icmHttpPort;
            IcmHttpsPort = icmHttpsPort;
            DispatcherStatus = dispatcherStatus;
            LoadBalancerDetails = loadBalancerDetails;
            VmDetails = vmDetails;
            Status = status;
            Health = health;
            ProvisioningState = provisioningState;
            Errors = errors;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Application server Instance Number. </summary>
        public string InstanceNo { get; }
        /// <summary> Application server Subnet. </summary>
        public string Subnet { get; }
        /// <summary> Application server instance SAP hostname. </summary>
        public string Hostname { get; }
        /// <summary> Application server instance SAP Kernel Version. </summary>
        public string KernelVersion { get; }
        /// <summary> Application server instance SAP Kernel Patch level. </summary>
        public string KernelPatch { get; }
        /// <summary> Application server instance SAP IP Address. </summary>
        public string IPAddress { get; }
        /// <summary> Application server instance gateway Port. </summary>
        public long? GatewayPort { get; }
        /// <summary> Application server instance ICM HTTP Port. </summary>
        public long? IcmHttpPort { get; }
        /// <summary> Application server instance ICM HTTPS Port. </summary>
        public long? IcmHttpsPort { get; }
        /// <summary> Application server instance dispatcher status. </summary>
        public string DispatcherStatus { get; }
        /// <summary> The Load Balancer details such as LoadBalancer ID attached to Application Server Virtual Machines. </summary>
        internal SubResource LoadBalancerDetails { get; }
        /// <summary> Gets Id. </summary>
        public ResourceIdentifier LoadBalancerDetailsId
        {
            get => LoadBalancerDetails?.Id;
        }

        /// <summary> The list of virtual machines. </summary>
        public IReadOnlyList<ApplicationServerVmDetails> VmDetails { get; }
        /// <summary> Defines the SAP Instance status. </summary>
        public SapVirtualInstanceStatus? Status { get; }
        /// <summary> Defines the health of SAP Instances. </summary>
        public SapHealthState? Health { get; }
        /// <summary> Defines the provisioning states. </summary>
        public SapVirtualInstanceProvisioningState? ProvisioningState { get; }
        /// <summary> Defines the Application Instance errors. </summary>
        internal SapVirtualInstanceError Errors { get; }
        /// <summary> The Virtual Instance for SAP error body. </summary>
        public ErrorInformation ErrorsProperties
        {
            get => Errors?.Properties;
        }
    }
}
