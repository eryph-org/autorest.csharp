// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace CognitiveSearch.Models
{
    public partial class LimitTokenFilter : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (MaxTokenCount != null)
            {
                writer.WritePropertyName("maxTokenCount");
                writer.WriteNumberValue(MaxTokenCount.Value);
            }
            if (ConsumeAllTokens != null)
            {
                writer.WritePropertyName("consumeAllTokens");
                writer.WriteBooleanValue(ConsumeAllTokens.Value);
            }
            writer.WritePropertyName("@odata.type");
            writer.WriteStringValue(OdataType);
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WriteEndObject();
        }
        internal static LimitTokenFilter DeserializeLimitTokenFilter(JsonElement element)
        {
            LimitTokenFilter result = new LimitTokenFilter();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("maxTokenCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.MaxTokenCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("consumeAllTokens"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.ConsumeAllTokens = property.Value.GetBoolean();
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