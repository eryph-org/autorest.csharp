// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Resources.Models;
using Azure.ResourceManager.TestFramework;
using MgmtKeyvault;
using MgmtKeyvault.Models;

namespace MgmtKeyvault.Tests.Mock
{
    /// <summary> Test for ManagedHsm. </summary>
    public partial class ManagedHsmMockTests : MockTestBase
    {
        public ManagedHsmMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task GetAsync()
        {
            // Example: Retrieve a managed HSM Pool
            var managedHsm = GetArmClient().GetManagedHsm(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/hsm-group/providers/Microsoft.KeyVault/managedHSMs/hsm1"));

            await managedHsm.GetAsync();
        }

        [RecordedTest]
        public async Task DeleteAsync()
        {
            // Example: Delete a managed HSM Pool
            var managedHsm = GetArmClient().GetManagedHsm(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/hsm-group/providers/Microsoft.KeyVault/managedHSMs/hsm1"));

            await managedHsm.DeleteAsync(true);
        }

        [RecordedTest]
        public async Task UpdateAsync()
        {
            // Example: Update an existing managed HSM Pool
            var managedHsm = GetArmClient().GetManagedHsm(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/hsm-group/providers/Microsoft.KeyVault/managedHSMs/hsm1"));
            MgmtKeyvault.ManagedHsmData parameters = new MgmtKeyvault.ManagedHsmData(location: AzureLocation.WestUS)
            {
            };
            parameters.Tags.ReplaceWith(new Dictionary<string, string>() { ["Dept"] = "hsm", ["Environment"] = "dogfood", ["Slice"] = "A", });
            await managedHsm.UpdateAsync(true, parameters);
        }

        [RecordedTest]
        public async Task GetMHSMPrivateLinkResourcesByMhsmResourceAsync()
        {
            // Example: KeyVaultListPrivateLinkResources
            var managedHsm = GetArmClient().GetManagedHsm(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/sample-group/providers/Microsoft.KeyVault/managedHSMs/sample-mhsm"));

            await foreach (var _ in managedHsm.GetMHSMPrivateLinkResourcesByMhsmResourceAsync())
            {
            }
        }
    }
}