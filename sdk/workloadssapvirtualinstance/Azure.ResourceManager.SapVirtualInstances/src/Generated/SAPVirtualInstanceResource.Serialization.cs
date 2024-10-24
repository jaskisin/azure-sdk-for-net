// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.Workloads.SAPVirtualInstance
{
    public partial class SAPVirtualInstanceResource : IJsonModel<SAPVirtualInstanceData>
    {
        void IJsonModel<SAPVirtualInstanceData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<SAPVirtualInstanceData>)Data).Write(writer, options);

        SAPVirtualInstanceData IJsonModel<SAPVirtualInstanceData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<SAPVirtualInstanceData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<SAPVirtualInstanceData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        SAPVirtualInstanceData IPersistableModel<SAPVirtualInstanceData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<SAPVirtualInstanceData>(data, options);

        string IPersistableModel<SAPVirtualInstanceData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<SAPVirtualInstanceData>)Data).GetFormatFromOptions(options);
    }
}
