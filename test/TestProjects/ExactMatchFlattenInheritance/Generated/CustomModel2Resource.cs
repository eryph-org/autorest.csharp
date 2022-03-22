// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace ExactMatchFlattenInheritance
{
    /// <summary> A Class representing a CustomModel2Resource along with the instance operations that can be performed on it. </summary>
    public partial class CustomModel2Resource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="CustomModel2Resource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/customModel2s/{name}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _customModel2ClientDiagnostics;
        private readonly CustomModel2SRestOperations _customModel2RestClient;
        private readonly CustomModel2Data _data;

        /// <summary> Initializes a new instance of the <see cref="CustomModel2Resource"/> class for mocking. </summary>
        protected CustomModel2Resource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "CustomModel2Resource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal CustomModel2Resource(ArmClient client, CustomModel2Data data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="CustomModel2Resource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal CustomModel2Resource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _customModel2ClientDiagnostics = new ClientDiagnostics("ExactMatchFlattenInheritance", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string customModel2ApiVersion);
            _customModel2RestClient = new CustomModel2SRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, customModel2ApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Compute/customModel2s";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual CustomModel2Data Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Get an CustomModel2.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/customModel2s/{name}
        /// Operation Id: CustomModel2s_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<CustomModel2Resource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _customModel2ClientDiagnostics.CreateScope("CustomModel2Resource.Get");
            scope.Start();
            try
            {
                var response = await _customModel2RestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CustomModel2Resource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get an CustomModel2.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/customModel2s/{name}
        /// Operation Id: CustomModel2s_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<CustomModel2Resource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _customModel2ClientDiagnostics.CreateScope("CustomModel2Resource.Get");
            scope.Start();
            try
            {
                var response = _customModel2RestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CustomModel2Resource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}