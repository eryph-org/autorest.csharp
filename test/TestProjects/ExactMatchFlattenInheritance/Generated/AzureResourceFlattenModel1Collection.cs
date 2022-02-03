// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;
using ExactMatchFlattenInheritance.Models;

namespace ExactMatchFlattenInheritance
{
    /// <summary> A class representing collection of AzureResourceFlattenModel1 and their operations over its parent. </summary>
    public partial class AzureResourceFlattenModel1Collection : ArmCollection, IEnumerable<AzureResourceFlattenModel1>, IAsyncEnumerable<AzureResourceFlattenModel1>
    {
        private readonly ClientDiagnostics _azureResourceFlattenModel1ClientDiagnostics;
        private readonly AzureResourceFlattenModel1SRestOperations _azureResourceFlattenModel1RestClient;

        /// <summary> Initializes a new instance of the <see cref="AzureResourceFlattenModel1Collection"/> class for mocking. </summary>
        protected AzureResourceFlattenModel1Collection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AzureResourceFlattenModel1Collection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AzureResourceFlattenModel1Collection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _azureResourceFlattenModel1ClientDiagnostics = new ClientDiagnostics("ExactMatchFlattenInheritance", AzureResourceFlattenModel1.ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(AzureResourceFlattenModel1.ResourceType, out string azureResourceFlattenModel1ApiVersion);
            _azureResourceFlattenModel1RestClient = new AzureResourceFlattenModel1SRestOperations(_azureResourceFlattenModel1ClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, azureResourceFlattenModel1ApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroup.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroup.ResourceType), nameof(id));
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/azureResourceFlattenModel1s/{name}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: AzureResourceFlattenModel1s_Put
        /// <summary> Create or update an AzureResourceFlattenModel1. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="name"> The String to use. </param>
        /// <param name="parameters"> The AzureResourceFlattenModel1 to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<AzureResourceFlattenModel1CreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string name, AzureResourceFlattenModel1Data parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _azureResourceFlattenModel1ClientDiagnostics.CreateScope("AzureResourceFlattenModel1Collection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _azureResourceFlattenModel1RestClient.PutAsync(Id.SubscriptionId, Id.ResourceGroupName, name, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new AzureResourceFlattenModel1CreateOrUpdateOperation(Client, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/azureResourceFlattenModel1s/{name}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: AzureResourceFlattenModel1s_Put
        /// <summary> Create or update an AzureResourceFlattenModel1. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="name"> The String to use. </param>
        /// <param name="parameters"> The AzureResourceFlattenModel1 to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="parameters"/> is null. </exception>
        public virtual AzureResourceFlattenModel1CreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string name, AzureResourceFlattenModel1Data parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _azureResourceFlattenModel1ClientDiagnostics.CreateScope("AzureResourceFlattenModel1Collection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _azureResourceFlattenModel1RestClient.Put(Id.SubscriptionId, Id.ResourceGroupName, name, parameters, cancellationToken);
                var operation = new AzureResourceFlattenModel1CreateOrUpdateOperation(Client, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/azureResourceFlattenModel1s/{name}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: AzureResourceFlattenModel1s_Get
        /// <summary> Get an AzureResourceFlattenModel1. </summary>
        /// <param name="name"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public async virtual Task<Response<AzureResourceFlattenModel1>> GetAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _azureResourceFlattenModel1ClientDiagnostics.CreateScope("AzureResourceFlattenModel1Collection.Get");
            scope.Start();
            try
            {
                var response = await _azureResourceFlattenModel1RestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _azureResourceFlattenModel1ClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new AzureResourceFlattenModel1(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/azureResourceFlattenModel1s/{name}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: AzureResourceFlattenModel1s_Get
        /// <summary> Get an AzureResourceFlattenModel1. </summary>
        /// <param name="name"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<AzureResourceFlattenModel1> Get(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _azureResourceFlattenModel1ClientDiagnostics.CreateScope("AzureResourceFlattenModel1Collection.Get");
            scope.Start();
            try
            {
                var response = _azureResourceFlattenModel1RestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, name, cancellationToken);
                if (response.Value == null)
                    throw _azureResourceFlattenModel1ClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AzureResourceFlattenModel1(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/azureResourceFlattenModel1s
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: AzureResourceFlattenModel1s_List
        /// <summary> Get an AzureResourceFlattenModel1. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AzureResourceFlattenModel1" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AzureResourceFlattenModel1> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<AzureResourceFlattenModel1>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _azureResourceFlattenModel1ClientDiagnostics.CreateScope("AzureResourceFlattenModel1Collection.GetAll");
                scope.Start();
                try
                {
                    var response = await _azureResourceFlattenModel1RestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new AzureResourceFlattenModel1(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/azureResourceFlattenModel1s
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: AzureResourceFlattenModel1s_List
        /// <summary> Get an AzureResourceFlattenModel1. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AzureResourceFlattenModel1" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AzureResourceFlattenModel1> GetAll(CancellationToken cancellationToken = default)
        {
            Page<AzureResourceFlattenModel1> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _azureResourceFlattenModel1ClientDiagnostics.CreateScope("AzureResourceFlattenModel1Collection.GetAll");
                scope.Start();
                try
                {
                    var response = _azureResourceFlattenModel1RestClient.List(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new AzureResourceFlattenModel1(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/azureResourceFlattenModel1s/{name}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: AzureResourceFlattenModel1s_Get
        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="name"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _azureResourceFlattenModel1ClientDiagnostics.CreateScope("AzureResourceFlattenModel1Collection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(name, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/azureResourceFlattenModel1s/{name}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: AzureResourceFlattenModel1s_Get
        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="name"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<bool> Exists(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _azureResourceFlattenModel1ClientDiagnostics.CreateScope("AzureResourceFlattenModel1Collection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(name, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/azureResourceFlattenModel1s/{name}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: AzureResourceFlattenModel1s_Get
        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="name"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public async virtual Task<Response<AzureResourceFlattenModel1>> GetIfExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _azureResourceFlattenModel1ClientDiagnostics.CreateScope("AzureResourceFlattenModel1Collection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _azureResourceFlattenModel1RestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, name, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<AzureResourceFlattenModel1>(null, response.GetRawResponse());
                return Response.FromValue(new AzureResourceFlattenModel1(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/azureResourceFlattenModel1s/{name}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: AzureResourceFlattenModel1s_Get
        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="name"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<AzureResourceFlattenModel1> GetIfExists(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _azureResourceFlattenModel1ClientDiagnostics.CreateScope("AzureResourceFlattenModel1Collection.GetIfExists");
            scope.Start();
            try
            {
                var response = _azureResourceFlattenModel1RestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, name, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<AzureResourceFlattenModel1>(null, response.GetRawResponse());
                return Response.FromValue(new AzureResourceFlattenModel1(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AzureResourceFlattenModel1> IEnumerable<AzureResourceFlattenModel1>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AzureResourceFlattenModel1> IAsyncEnumerable<AzureResourceFlattenModel1>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
