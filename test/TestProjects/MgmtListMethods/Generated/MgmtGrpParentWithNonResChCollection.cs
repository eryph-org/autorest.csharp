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
using Azure.ResourceManager.Management;
using MgmtListMethods.Models;

namespace MgmtListMethods
{
    /// <summary> A class representing collection of MgmtGrpParentWithNonResCh and their operations over its parent. </summary>
    public partial class MgmtGrpParentWithNonResChCollection : ArmCollection, IEnumerable<MgmtGrpParentWithNonResCh>, IAsyncEnumerable<MgmtGrpParentWithNonResCh>
    {
        private readonly ClientDiagnostics _mgmtGrpParentWithNonResChClientDiagnostics;
        private readonly MgmtGrpParentWithNonResChesRestOperations _mgmtGrpParentWithNonResChRestClient;

        /// <summary> Initializes a new instance of the <see cref="MgmtGrpParentWithNonResChCollection"/> class for mocking. </summary>
        protected MgmtGrpParentWithNonResChCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MgmtGrpParentWithNonResChCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal MgmtGrpParentWithNonResChCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _mgmtGrpParentWithNonResChClientDiagnostics = new ClientDiagnostics("MgmtListMethods", MgmtGrpParentWithNonResCh.ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(MgmtGrpParentWithNonResCh.ResourceType, out string mgmtGrpParentWithNonResChApiVersion);
            _mgmtGrpParentWithNonResChRestClient = new MgmtGrpParentWithNonResChesRestOperations(_mgmtGrpParentWithNonResChClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, mgmtGrpParentWithNonResChApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ManagementGroup.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ManagementGroup.ResourceType), nameof(id));
        }

        /// RequestPath: /providers/Microsoft.Management/managementGroups/{groupId}/mgmtGrpParentWithNonResChes/{mgmtGrpParentWithNonResChName}
        /// ContextualPath: /providers/Microsoft.Management/managementGroups/{managementGroupId}
        /// OperationId: MgmtGrpParentWithNonResChes_CreateOrUpdate
        /// <summary> Create or update. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="mgmtGrpParentWithNonResChName"> Name. </param>
        /// <param name="parameters"> Parameters supplied to the Create. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="mgmtGrpParentWithNonResChName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="mgmtGrpParentWithNonResChName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<MgmtGrpParentWithNonResChCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string mgmtGrpParentWithNonResChName, MgmtGrpParentWithNonResChData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(mgmtGrpParentWithNonResChName, nameof(mgmtGrpParentWithNonResChName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _mgmtGrpParentWithNonResChClientDiagnostics.CreateScope("MgmtGrpParentWithNonResChCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _mgmtGrpParentWithNonResChRestClient.CreateOrUpdateAsync(Id.Name, mgmtGrpParentWithNonResChName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new MgmtGrpParentWithNonResChCreateOrUpdateOperation(Client, response);
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

        /// RequestPath: /providers/Microsoft.Management/managementGroups/{groupId}/mgmtGrpParentWithNonResChes/{mgmtGrpParentWithNonResChName}
        /// ContextualPath: /providers/Microsoft.Management/managementGroups/{managementGroupId}
        /// OperationId: MgmtGrpParentWithNonResChes_CreateOrUpdate
        /// <summary> Create or update. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="mgmtGrpParentWithNonResChName"> Name. </param>
        /// <param name="parameters"> Parameters supplied to the Create. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="mgmtGrpParentWithNonResChName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="mgmtGrpParentWithNonResChName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual MgmtGrpParentWithNonResChCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string mgmtGrpParentWithNonResChName, MgmtGrpParentWithNonResChData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(mgmtGrpParentWithNonResChName, nameof(mgmtGrpParentWithNonResChName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _mgmtGrpParentWithNonResChClientDiagnostics.CreateScope("MgmtGrpParentWithNonResChCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _mgmtGrpParentWithNonResChRestClient.CreateOrUpdate(Id.Name, mgmtGrpParentWithNonResChName, parameters, cancellationToken);
                var operation = new MgmtGrpParentWithNonResChCreateOrUpdateOperation(Client, response);
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

        /// RequestPath: /providers/Microsoft.Management/managementGroups/{groupId}/mgmtGrpParentWithNonResChes/{mgmtGrpParentWithNonResChName}
        /// ContextualPath: /providers/Microsoft.Management/managementGroups/{managementGroupId}
        /// OperationId: MgmtGrpParentWithNonResChes_Get
        /// <summary> Retrieves information. </summary>
        /// <param name="mgmtGrpParentWithNonResChName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="mgmtGrpParentWithNonResChName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="mgmtGrpParentWithNonResChName"/> is null. </exception>
        public async virtual Task<Response<MgmtGrpParentWithNonResCh>> GetAsync(string mgmtGrpParentWithNonResChName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(mgmtGrpParentWithNonResChName, nameof(mgmtGrpParentWithNonResChName));

            using var scope = _mgmtGrpParentWithNonResChClientDiagnostics.CreateScope("MgmtGrpParentWithNonResChCollection.Get");
            scope.Start();
            try
            {
                var response = await _mgmtGrpParentWithNonResChRestClient.GetAsync(Id.Name, mgmtGrpParentWithNonResChName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _mgmtGrpParentWithNonResChClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new MgmtGrpParentWithNonResCh(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /providers/Microsoft.Management/managementGroups/{groupId}/mgmtGrpParentWithNonResChes/{mgmtGrpParentWithNonResChName}
        /// ContextualPath: /providers/Microsoft.Management/managementGroups/{managementGroupId}
        /// OperationId: MgmtGrpParentWithNonResChes_Get
        /// <summary> Retrieves information. </summary>
        /// <param name="mgmtGrpParentWithNonResChName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="mgmtGrpParentWithNonResChName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="mgmtGrpParentWithNonResChName"/> is null. </exception>
        public virtual Response<MgmtGrpParentWithNonResCh> Get(string mgmtGrpParentWithNonResChName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(mgmtGrpParentWithNonResChName, nameof(mgmtGrpParentWithNonResChName));

            using var scope = _mgmtGrpParentWithNonResChClientDiagnostics.CreateScope("MgmtGrpParentWithNonResChCollection.Get");
            scope.Start();
            try
            {
                var response = _mgmtGrpParentWithNonResChRestClient.Get(Id.Name, mgmtGrpParentWithNonResChName, cancellationToken);
                if (response.Value == null)
                    throw _mgmtGrpParentWithNonResChClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MgmtGrpParentWithNonResCh(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /providers/Microsoft.Management/managementGroups/{groupId}/mgmtGrpParentWithNonResChes
        /// ContextualPath: /providers/Microsoft.Management/managementGroups/{managementGroupId}
        /// OperationId: MgmtGrpParentWithNonResChes_List
        /// <summary> Lists all in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MgmtGrpParentWithNonResCh" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MgmtGrpParentWithNonResCh> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<MgmtGrpParentWithNonResCh>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _mgmtGrpParentWithNonResChClientDiagnostics.CreateScope("MgmtGrpParentWithNonResChCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _mgmtGrpParentWithNonResChRestClient.ListAsync(Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new MgmtGrpParentWithNonResCh(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<MgmtGrpParentWithNonResCh>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _mgmtGrpParentWithNonResChClientDiagnostics.CreateScope("MgmtGrpParentWithNonResChCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _mgmtGrpParentWithNonResChRestClient.ListNextPageAsync(nextLink, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new MgmtGrpParentWithNonResCh(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /providers/Microsoft.Management/managementGroups/{groupId}/mgmtGrpParentWithNonResChes
        /// ContextualPath: /providers/Microsoft.Management/managementGroups/{managementGroupId}
        /// OperationId: MgmtGrpParentWithNonResChes_List
        /// <summary> Lists all in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MgmtGrpParentWithNonResCh" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MgmtGrpParentWithNonResCh> GetAll(CancellationToken cancellationToken = default)
        {
            Page<MgmtGrpParentWithNonResCh> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _mgmtGrpParentWithNonResChClientDiagnostics.CreateScope("MgmtGrpParentWithNonResChCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _mgmtGrpParentWithNonResChRestClient.List(Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new MgmtGrpParentWithNonResCh(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<MgmtGrpParentWithNonResCh> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _mgmtGrpParentWithNonResChClientDiagnostics.CreateScope("MgmtGrpParentWithNonResChCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _mgmtGrpParentWithNonResChRestClient.ListNextPage(nextLink, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new MgmtGrpParentWithNonResCh(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /providers/Microsoft.Management/managementGroups/{groupId}/mgmtGrpParentWithNonResChes/{mgmtGrpParentWithNonResChName}
        /// ContextualPath: /providers/Microsoft.Management/managementGroups/{managementGroupId}
        /// OperationId: MgmtGrpParentWithNonResChes_Get
        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="mgmtGrpParentWithNonResChName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="mgmtGrpParentWithNonResChName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="mgmtGrpParentWithNonResChName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string mgmtGrpParentWithNonResChName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(mgmtGrpParentWithNonResChName, nameof(mgmtGrpParentWithNonResChName));

            using var scope = _mgmtGrpParentWithNonResChClientDiagnostics.CreateScope("MgmtGrpParentWithNonResChCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(mgmtGrpParentWithNonResChName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /providers/Microsoft.Management/managementGroups/{groupId}/mgmtGrpParentWithNonResChes/{mgmtGrpParentWithNonResChName}
        /// ContextualPath: /providers/Microsoft.Management/managementGroups/{managementGroupId}
        /// OperationId: MgmtGrpParentWithNonResChes_Get
        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="mgmtGrpParentWithNonResChName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="mgmtGrpParentWithNonResChName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="mgmtGrpParentWithNonResChName"/> is null. </exception>
        public virtual Response<bool> Exists(string mgmtGrpParentWithNonResChName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(mgmtGrpParentWithNonResChName, nameof(mgmtGrpParentWithNonResChName));

            using var scope = _mgmtGrpParentWithNonResChClientDiagnostics.CreateScope("MgmtGrpParentWithNonResChCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(mgmtGrpParentWithNonResChName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /providers/Microsoft.Management/managementGroups/{groupId}/mgmtGrpParentWithNonResChes/{mgmtGrpParentWithNonResChName}
        /// ContextualPath: /providers/Microsoft.Management/managementGroups/{managementGroupId}
        /// OperationId: MgmtGrpParentWithNonResChes_Get
        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="mgmtGrpParentWithNonResChName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="mgmtGrpParentWithNonResChName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="mgmtGrpParentWithNonResChName"/> is null. </exception>
        public async virtual Task<Response<MgmtGrpParentWithNonResCh>> GetIfExistsAsync(string mgmtGrpParentWithNonResChName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(mgmtGrpParentWithNonResChName, nameof(mgmtGrpParentWithNonResChName));

            using var scope = _mgmtGrpParentWithNonResChClientDiagnostics.CreateScope("MgmtGrpParentWithNonResChCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _mgmtGrpParentWithNonResChRestClient.GetAsync(Id.Name, mgmtGrpParentWithNonResChName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<MgmtGrpParentWithNonResCh>(null, response.GetRawResponse());
                return Response.FromValue(new MgmtGrpParentWithNonResCh(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /providers/Microsoft.Management/managementGroups/{groupId}/mgmtGrpParentWithNonResChes/{mgmtGrpParentWithNonResChName}
        /// ContextualPath: /providers/Microsoft.Management/managementGroups/{managementGroupId}
        /// OperationId: MgmtGrpParentWithNonResChes_Get
        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="mgmtGrpParentWithNonResChName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="mgmtGrpParentWithNonResChName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="mgmtGrpParentWithNonResChName"/> is null. </exception>
        public virtual Response<MgmtGrpParentWithNonResCh> GetIfExists(string mgmtGrpParentWithNonResChName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(mgmtGrpParentWithNonResChName, nameof(mgmtGrpParentWithNonResChName));

            using var scope = _mgmtGrpParentWithNonResChClientDiagnostics.CreateScope("MgmtGrpParentWithNonResChCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _mgmtGrpParentWithNonResChRestClient.Get(Id.Name, mgmtGrpParentWithNonResChName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<MgmtGrpParentWithNonResCh>(null, response.GetRawResponse());
                return Response.FromValue(new MgmtGrpParentWithNonResCh(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<MgmtGrpParentWithNonResCh> IEnumerable<MgmtGrpParentWithNonResCh>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<MgmtGrpParentWithNonResCh> IAsyncEnumerable<MgmtGrpParentWithNonResCh>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
