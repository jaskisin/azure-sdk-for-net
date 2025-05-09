// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.SignalR;

/// <summary>
/// SignalRPrivateEndpointConnection.
/// </summary>
public partial class SignalRPrivateEndpointConnection : ProvisionableResource
{
    /// <summary>
    /// The name of the private endpoint connection.
    /// </summary>
    public BicepValue<string> Name 
    {
        get { Initialize(); return _name!; }
        set { Initialize(); _name!.Assign(value); }
    }
    private BicepValue<string>? _name;

    /// <summary>
    /// Connection state of the private endpoint connection.
    /// </summary>
    public SignalRPrivateLinkServiceConnectionState ConnectionState 
    {
        get { Initialize(); return _connectionState!; }
        set { Initialize(); AssignOrReplace(ref _connectionState, value); }
    }
    private SignalRPrivateLinkServiceConnectionState? _connectionState;

    /// <summary>
    /// Gets or sets Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> PrivateEndpointId 
    {
        get { Initialize(); return _privateEndpointId!; }
        set { Initialize(); _privateEndpointId!.Assign(value); }
    }
    private BicepValue<ResourceIdentifier>? _privateEndpointId;

    /// <summary>
    /// Group IDs.
    /// </summary>
    public BicepList<string> GroupIds 
    {
        get { Initialize(); return _groupIds!; }
    }
    private BicepList<string>? _groupIds;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id 
    {
        get { Initialize(); return _id!; }
    }
    private BicepValue<ResourceIdentifier>? _id;

    /// <summary>
    /// Provisioning state of the resource.
    /// </summary>
    public BicepValue<SignalRProvisioningState> ProvisioningState 
    {
        get { Initialize(); return _provisioningState!; }
    }
    private BicepValue<SignalRProvisioningState>? _provisioningState;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public SystemData SystemData 
    {
        get { Initialize(); return _systemData!; }
    }
    private SystemData? _systemData;

    /// <summary>
    /// Gets or sets a reference to the parent SignalRService.
    /// </summary>
    public SignalRService? Parent
    {
        get { Initialize(); return _parent!.Value; }
        set { Initialize(); _parent!.Value = value; }
    }
    private ResourceReference<SignalRService>? _parent;

    /// <summary>
    /// Creates a new SignalRPrivateEndpointConnection.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the SignalRPrivateEndpointConnection
    /// resource.  This can be used to refer to the resource in expressions,
    /// but is not the Azure name of the resource.  This value can contain
    /// letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the SignalRPrivateEndpointConnection.</param>
    public SignalRPrivateEndpointConnection(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.SignalRService/signalR/privateEndpointConnections", resourceVersion ?? "2024-03-01")
    {
    }

    /// <summary>
    /// Define all the provisionable properties of
    /// SignalRPrivateEndpointConnection.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        _name = DefineProperty<string>("Name", ["name"], isRequired: true);
        _connectionState = DefineModelProperty<SignalRPrivateLinkServiceConnectionState>("ConnectionState", ["properties", "privateLinkServiceConnectionState"]);
        _privateEndpointId = DefineProperty<ResourceIdentifier>("PrivateEndpointId", ["properties", "privateEndpoint", "id"]);
        _groupIds = DefineListProperty<string>("GroupIds", ["properties", "groupIds"], isOutput: true);
        _id = DefineProperty<ResourceIdentifier>("Id", ["id"], isOutput: true);
        _provisioningState = DefineProperty<SignalRProvisioningState>("ProvisioningState", ["properties", "provisioningState"], isOutput: true);
        _systemData = DefineModelProperty<SystemData>("SystemData", ["systemData"], isOutput: true);
        _parent = DefineResource<SignalRService>("Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported SignalRPrivateEndpointConnection resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2024-03-01.
        /// </summary>
        public static readonly string V2024_03_01 = "2024-03-01";

        /// <summary>
        /// 2023-02-01.
        /// </summary>
        public static readonly string V2023_02_01 = "2023-02-01";

        /// <summary>
        /// 2022-02-01.
        /// </summary>
        public static readonly string V2022_02_01 = "2022-02-01";

        /// <summary>
        /// 2021-10-01.
        /// </summary>
        public static readonly string V2021_10_01 = "2021-10-01";

        /// <summary>
        /// 2020-05-01.
        /// </summary>
        public static readonly string V2020_05_01 = "2020-05-01";

        /// <summary>
        /// 2018-10-01.
        /// </summary>
        public static readonly string V2018_10_01 = "2018-10-01";
    }

    /// <summary>
    /// Creates a reference to an existing SignalRPrivateEndpointConnection.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the SignalRPrivateEndpointConnection
    /// resource.  This can be used to refer to the resource in expressions,
    /// but is not the Azure name of the resource.  This value can contain
    /// letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the SignalRPrivateEndpointConnection.</param>
    /// <returns>The existing SignalRPrivateEndpointConnection resource.</returns>
    public static SignalRPrivateEndpointConnection FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };
}
