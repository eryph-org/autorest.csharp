// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace OmitOperationGroups.Models
{
    public partial class ModelQ : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(M))
            {
                writer.WritePropertyName("m");
                writer.WriteStringValue(M);
            }
            writer.WriteEndObject();
        }

        internal static ModelQ DeserializeModelQ(JsonElement element)
        {
            Optional<string> m = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("m"))
                {
                    m = property.Value.GetString();
                    continue;
                }
            }
            return new ModelQ(m.Value);
        }
    }
}