// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;

namespace HeadAsBooleanTrue
{
    /// <summary> The HttpSuccess service client. </summary>
    public partial class HttpSuccessClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal HttpSuccessRestClient RestClient { get; }

        /// <summary> Initializes a new instance of HttpSuccessClient for mocking. </summary>
        protected HttpSuccessClient()
        {
        }

        /// <summary> Initializes a new instance of HttpSuccessClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        internal HttpSuccessClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            RestClient = new HttpSuccessRestClient(clientDiagnostics, pipeline, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Return 200 status code if successful. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> Head200Async(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("HttpSuccessClient.Head200");
            scope.Start();
            try
            {
                return await RestClient.Head200Async(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Return 200 status code if successful. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Head200(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("HttpSuccessClient.Head200");
            scope.Start();
            try
            {
                return RestClient.Head200(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Return 204 status code if successful. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> Head204Async(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("HttpSuccessClient.Head204");
            scope.Start();
            try
            {
                return await RestClient.Head204Async(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Return 204 status code if successful. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Head204(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("HttpSuccessClient.Head204");
            scope.Start();
            try
            {
                return RestClient.Head204(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Return 404 status code if successful. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> Head404Async(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("HttpSuccessClient.Head404");
            scope.Start();
            try
            {
                return await RestClient.Head404Async(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Return 404 status code if successful. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Head404(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("HttpSuccessClient.Head404");
            scope.Start();
            try
            {
                return RestClient.Head404(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}