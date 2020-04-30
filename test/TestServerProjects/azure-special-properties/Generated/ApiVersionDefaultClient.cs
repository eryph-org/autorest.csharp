// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;

namespace azure_special_properties
{
    /// <summary> The ApiVersionDefault service client. </summary>
    public partial class ApiVersionDefaultClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal ApiVersionDefaultRestClient RestClient { get; }
        /// <summary> Initializes a new instance of ApiVersionDefaultClient for mocking. </summary>
        protected ApiVersionDefaultClient()
        {
        }
        /// <summary> Initializes a new instance of ApiVersionDefaultClient. </summary>
        internal ApiVersionDefaultClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string host = "http://localhost:3000", string apiVersion = "2015-07-01-preview")
        {
            RestClient = new ApiVersionDefaultRestClient(clientDiagnostics, pipeline, host, apiVersion);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> GET method with api-version modeled in global settings. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> GetMethodGlobalValidAsync(CancellationToken cancellationToken = default)
        {
            return await RestClient.GetMethodGlobalValidAsync(cancellationToken).ConfigureAwait(false);
        }

        /// <summary> GET method with api-version modeled in global settings. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response GetMethodGlobalValid(CancellationToken cancellationToken = default)
        {
            return RestClient.GetMethodGlobalValid(cancellationToken);
        }

        /// <summary> GET method with api-version modeled in global settings. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> GetMethodGlobalNotProvidedValidAsync(CancellationToken cancellationToken = default)
        {
            return await RestClient.GetMethodGlobalNotProvidedValidAsync(cancellationToken).ConfigureAwait(false);
        }

        /// <summary> GET method with api-version modeled in global settings. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response GetMethodGlobalNotProvidedValid(CancellationToken cancellationToken = default)
        {
            return RestClient.GetMethodGlobalNotProvidedValid(cancellationToken);
        }

        /// <summary> GET method with api-version modeled in global settings. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> GetPathGlobalValidAsync(CancellationToken cancellationToken = default)
        {
            return await RestClient.GetPathGlobalValidAsync(cancellationToken).ConfigureAwait(false);
        }

        /// <summary> GET method with api-version modeled in global settings. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response GetPathGlobalValid(CancellationToken cancellationToken = default)
        {
            return RestClient.GetPathGlobalValid(cancellationToken);
        }

        /// <summary> GET method with api-version modeled in global settings. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> GetSwaggerGlobalValidAsync(CancellationToken cancellationToken = default)
        {
            return await RestClient.GetSwaggerGlobalValidAsync(cancellationToken).ConfigureAwait(false);
        }

        /// <summary> GET method with api-version modeled in global settings. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response GetSwaggerGlobalValid(CancellationToken cancellationToken = default)
        {
            return RestClient.GetSwaggerGlobalValid(cancellationToken);
        }
    }
}