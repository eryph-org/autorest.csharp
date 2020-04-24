// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace required_optional.Models
{
    public partial class ClassOptionalWrapper : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Value != null)
            {
                writer.WritePropertyName("value");
                writer.WriteObjectValue(Value);
            }
            writer.WriteEndObject();
        }
    }
}