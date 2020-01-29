// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace CognitiveSearch.Models
{
    public partial class PathHierarchyTokenizerV2 : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Delimiter != null)
            {
                writer.WritePropertyName("delimiter");
                writer.WriteStringValue(Delimiter.Value);
            }
            if (Replacement != null)
            {
                writer.WritePropertyName("replacement");
                writer.WriteStringValue(Replacement.Value);
            }
            if (MaxTokenLength != null)
            {
                writer.WritePropertyName("maxTokenLength");
                writer.WriteNumberValue(MaxTokenLength.Value);
            }
            if (ReverseTokenOrder != null)
            {
                writer.WritePropertyName("reverse");
                writer.WriteBooleanValue(ReverseTokenOrder.Value);
            }
            if (NumberOfTokensToSkip != null)
            {
                writer.WritePropertyName("skip");
                writer.WriteNumberValue(NumberOfTokensToSkip.Value);
            }
            writer.WritePropertyName("@odata.type");
            writer.WriteStringValue(OdataType);
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WriteEndObject();
        }
        internal static PathHierarchyTokenizerV2 DeserializePathHierarchyTokenizerV2(JsonElement element)
        {
            PathHierarchyTokenizerV2 result = new PathHierarchyTokenizerV2();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("delimiter"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Delimiter = property.Value.GetChar();
                    continue;
                }
                if (property.NameEquals("replacement"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Replacement = property.Value.GetChar();
                    continue;
                }
                if (property.NameEquals("maxTokenLength"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.MaxTokenLength = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("reverse"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.ReverseTokenOrder = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("skip"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.NumberOfTokensToSkip = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("@odata.type"))
                {
                    result.OdataType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    result.Name = property.Value.GetString();
                    continue;
                }
            }
            return result;
        }
    }
}