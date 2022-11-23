// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace TypeSchemaMapping.Models
{
    internal partial class UnknownAbstractModel
    {
        internal static UnknownAbstractModel DeserializeUnknownAbstractModel(JsonElement element)
        {
            string discriminatorProperty = "Unknown";
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("DiscriminatorProperty"))
                {
                    discriminatorProperty = property.Value.GetString();
                    continue;
                }
            }
            return new UnknownAbstractModel(discriminatorProperty);
        }
    }
}