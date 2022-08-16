// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace MgmtMockAndSample.Models
{
    public partial class VaultValidationResult
    {
        internal static VaultValidationResult DeserializeVaultValidationResult(JsonElement element)
        {
            Optional<IReadOnlyList<VaultIssue>> issues = default;
            Optional<string> result = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("issues"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<VaultIssue> array = new List<VaultIssue>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VaultIssue.DeserializeVaultIssue(item));
                    }
                    issues = array;
                    continue;
                }
                if (property.NameEquals("result"))
                {
                    result = property.Value.GetString();
                    continue;
                }
            }
            return new VaultValidationResult(Optional.ToList(issues), result.Value);
        }
    }
}