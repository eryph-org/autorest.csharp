// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;

namespace MgmtListMethods
{
    internal class TenantTestOperationSource : IOperationSource<TenantTest>
    {
        private readonly ArmClient _client;

        internal TenantTestOperationSource(ArmClient client)
        {
            _client = client;
        }

        TenantTest IOperationSource<TenantTest>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = TenantTestData.DeserializeTenantTestData(document.RootElement);
            return new TenantTest(_client, data);
        }

        async ValueTask<TenantTest> IOperationSource<TenantTest>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = TenantTestData.DeserializeTenantTestData(document.RootElement);
            return new TenantTest(_client, data);
        }
    }
}