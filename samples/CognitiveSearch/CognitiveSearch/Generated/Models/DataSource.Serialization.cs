// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace CognitiveSearch.Models
{
    public partial class DataSource : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            if (Description != null)
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type.ToString());
            writer.WritePropertyName("credentials");
            writer.WriteObjectValue(Credentials);
            writer.WritePropertyName("container");
            writer.WriteObjectValue(Container);
            if (DataChangeDetectionPolicy != null)
            {
                writer.WritePropertyName("dataChangeDetectionPolicy");
                writer.WriteObjectValue(DataChangeDetectionPolicy);
            }
            if (DataDeletionDetectionPolicy != null)
            {
                writer.WritePropertyName("dataDeletionDetectionPolicy");
                writer.WriteObjectValue(DataDeletionDetectionPolicy);
            }
            if (ETag != null)
            {
                writer.WritePropertyName("@odata.etag");
                writer.WriteStringValue(ETag);
            }
            writer.WriteEndObject();
        }
        internal static DataSource DeserializeDataSource(JsonElement element)
        {
            DataSource result = new DataSource();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    result.Name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    result.Type = new DataSourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("credentials"))
                {
                    result.Credentials = DataSourceCredentials.DeserializeDataSourceCredentials(property.Value);
                    continue;
                }
                if (property.NameEquals("container"))
                {
                    result.Container = DataContainer.DeserializeDataContainer(property.Value);
                    continue;
                }
                if (property.NameEquals("dataChangeDetectionPolicy"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.DataChangeDetectionPolicy = DataChangeDetectionPolicy.DeserializeDataChangeDetectionPolicy(property.Value);
                    continue;
                }
                if (property.NameEquals("dataDeletionDetectionPolicy"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.DataDeletionDetectionPolicy = DataDeletionDetectionPolicy.DeserializeDataDeletionDetectionPolicy(property.Value);
                    continue;
                }
                if (property.NameEquals("@odata.etag"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.ETag = property.Value.GetString();
                    continue;
                }
            }
            return result;
        }
    }
}