/*
 * Hue CLIP API
 *
 * See [openhue/openhue-api](https://github.com/openhue/openhue-api)
 *
 * The version of the OpenAPI document: v2
 * Contact: contact@openhue.io
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using clipapisdk.Client;
using clipapisdk.Model;

namespace clipapisdk.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ILightApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get light
        /// </summary>
        /// <remarks>
        /// Get details of a single light from its given &#x60;{lightId}&#x60;.
        /// </remarks>
        /// <exception cref="clipapisdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lightId">ID of the light</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>GetLights200Response</returns>
        GetLights200Response GetLight(string lightId, int operationIndex = 0);

        /// <summary>
        /// Get light
        /// </summary>
        /// <remarks>
        /// Get details of a single light from its given &#x60;{lightId}&#x60;.
        /// </remarks>
        /// <exception cref="clipapisdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lightId">ID of the light</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of GetLights200Response</returns>
        ApiResponse<GetLights200Response> GetLightWithHttpInfo(string lightId, int operationIndex = 0);
        /// <summary>
        /// List lights.
        /// </summary>
        /// <remarks>
        /// List all available lights.
        /// </remarks>
        /// <exception cref="clipapisdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>GetLights200Response</returns>
        GetLights200Response GetLights(int operationIndex = 0);

        /// <summary>
        /// List lights.
        /// </summary>
        /// <remarks>
        /// List all available lights.
        /// </remarks>
        /// <exception cref="clipapisdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of GetLights200Response</returns>
        ApiResponse<GetLights200Response> GetLightsWithHttpInfo(int operationIndex = 0);
        /// <summary>
        /// Update light
        /// </summary>
        /// <remarks>
        /// Update a single light from its given &#x60;{lightId}&#x60;.
        /// </remarks>
        /// <exception cref="clipapisdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lightId">ID of the light</param>
        /// <param name="lightPut"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>UpdateDevice200Response</returns>
        UpdateDevice200Response UpdateLight(string lightId, LightPut? lightPut = default(LightPut?), int operationIndex = 0);

        /// <summary>
        /// Update light
        /// </summary>
        /// <remarks>
        /// Update a single light from its given &#x60;{lightId}&#x60;.
        /// </remarks>
        /// <exception cref="clipapisdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lightId">ID of the light</param>
        /// <param name="lightPut"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of UpdateDevice200Response</returns>
        ApiResponse<UpdateDevice200Response> UpdateLightWithHttpInfo(string lightId, LightPut? lightPut = default(LightPut?), int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ILightApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Get light
        /// </summary>
        /// <remarks>
        /// Get details of a single light from its given &#x60;{lightId}&#x60;.
        /// </remarks>
        /// <exception cref="clipapisdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lightId">ID of the light</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of GetLights200Response</returns>
        System.Threading.Tasks.Task<GetLights200Response> GetLightAsync(string lightId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get light
        /// </summary>
        /// <remarks>
        /// Get details of a single light from its given &#x60;{lightId}&#x60;.
        /// </remarks>
        /// <exception cref="clipapisdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lightId">ID of the light</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (GetLights200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<GetLights200Response>> GetLightWithHttpInfoAsync(string lightId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// List lights.
        /// </summary>
        /// <remarks>
        /// List all available lights.
        /// </remarks>
        /// <exception cref="clipapisdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of GetLights200Response</returns>
        System.Threading.Tasks.Task<GetLights200Response> GetLightsAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// List lights.
        /// </summary>
        /// <remarks>
        /// List all available lights.
        /// </remarks>
        /// <exception cref="clipapisdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (GetLights200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<GetLights200Response>> GetLightsWithHttpInfoAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Update light
        /// </summary>
        /// <remarks>
        /// Update a single light from its given &#x60;{lightId}&#x60;.
        /// </remarks>
        /// <exception cref="clipapisdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lightId">ID of the light</param>
        /// <param name="lightPut"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of UpdateDevice200Response</returns>
        System.Threading.Tasks.Task<UpdateDevice200Response> UpdateLightAsync(string lightId, LightPut? lightPut = default(LightPut?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Update light
        /// </summary>
        /// <remarks>
        /// Update a single light from its given &#x60;{lightId}&#x60;.
        /// </remarks>
        /// <exception cref="clipapisdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lightId">ID of the light</param>
        /// <param name="lightPut"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (UpdateDevice200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<UpdateDevice200Response>> UpdateLightWithHttpInfoAsync(string lightId, LightPut? lightPut = default(LightPut?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ILightApi : ILightApiSync, ILightApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class LightApi : ILightApi
    {
        private clipapisdk.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="LightApi"/> class.
        /// </summary>
        /// <returns></returns>
        public LightApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LightApi"/> class.
        /// </summary>
        /// <returns></returns>
        public LightApi(string basePath)
        {
            this.Configuration = clipapisdk.Client.Configuration.MergeConfigurations(
                clipapisdk.Client.GlobalConfiguration.Instance,
                new clipapisdk.Client.Configuration { BasePath = basePath }
            );
            this.Client = new clipapisdk.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new clipapisdk.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = clipapisdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LightApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public LightApi(clipapisdk.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = clipapisdk.Client.Configuration.MergeConfigurations(
                clipapisdk.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new clipapisdk.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new clipapisdk.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = clipapisdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LightApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public LightApi(clipapisdk.Client.ISynchronousClient client, clipapisdk.Client.IAsynchronousClient asyncClient, clipapisdk.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = clipapisdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public clipapisdk.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public clipapisdk.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public clipapisdk.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public clipapisdk.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Get light Get details of a single light from its given &#x60;{lightId}&#x60;.
        /// </summary>
        /// <exception cref="clipapisdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lightId">ID of the light</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>GetLights200Response</returns>
        public GetLights200Response GetLight(string lightId, int operationIndex = 0)
        {
            clipapisdk.Client.ApiResponse<GetLights200Response> localVarResponse = GetLightWithHttpInfo(lightId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get light Get details of a single light from its given &#x60;{lightId}&#x60;.
        /// </summary>
        /// <exception cref="clipapisdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lightId">ID of the light</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of GetLights200Response</returns>
        public clipapisdk.Client.ApiResponse<GetLights200Response> GetLightWithHttpInfo(string lightId, int operationIndex = 0)
        {
            // verify the required parameter 'lightId' is set
            if (lightId == null)
            {
                throw new clipapisdk.Client.ApiException(400, "Missing required parameter 'lightId' when calling LightApi->GetLight");
            }

            clipapisdk.Client.RequestOptions localVarRequestOptions = new clipapisdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = clipapisdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = clipapisdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("lightId", clipapisdk.Client.ClientUtils.ParameterToString(lightId)); // path parameter

            localVarRequestOptions.Operation = "LightApi.GetLight";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (HueApplicationKey) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("hue-application-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("hue-application-key", this.Configuration.GetApiKeyWithPrefix("hue-application-key"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<GetLights200Response>("/clip/v2/resource/light/{lightId}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetLight", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get light Get details of a single light from its given &#x60;{lightId}&#x60;.
        /// </summary>
        /// <exception cref="clipapisdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lightId">ID of the light</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of GetLights200Response</returns>
        public async System.Threading.Tasks.Task<GetLights200Response> GetLightAsync(string lightId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            clipapisdk.Client.ApiResponse<GetLights200Response> localVarResponse = await GetLightWithHttpInfoAsync(lightId, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get light Get details of a single light from its given &#x60;{lightId}&#x60;.
        /// </summary>
        /// <exception cref="clipapisdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lightId">ID of the light</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (GetLights200Response)</returns>
        public async System.Threading.Tasks.Task<clipapisdk.Client.ApiResponse<GetLights200Response>> GetLightWithHttpInfoAsync(string lightId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'lightId' is set
            if (lightId == null)
            {
                throw new clipapisdk.Client.ApiException(400, "Missing required parameter 'lightId' when calling LightApi->GetLight");
            }


            clipapisdk.Client.RequestOptions localVarRequestOptions = new clipapisdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = clipapisdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = clipapisdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("lightId", clipapisdk.Client.ClientUtils.ParameterToString(lightId)); // path parameter

            localVarRequestOptions.Operation = "LightApi.GetLight";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (HueApplicationKey) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("hue-application-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("hue-application-key", this.Configuration.GetApiKeyWithPrefix("hue-application-key"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<GetLights200Response>("/clip/v2/resource/light/{lightId}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetLight", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// List lights. List all available lights.
        /// </summary>
        /// <exception cref="clipapisdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>GetLights200Response</returns>
        public GetLights200Response GetLights(int operationIndex = 0)
        {
            clipapisdk.Client.ApiResponse<GetLights200Response> localVarResponse = GetLightsWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// List lights. List all available lights.
        /// </summary>
        /// <exception cref="clipapisdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of GetLights200Response</returns>
        public clipapisdk.Client.ApiResponse<GetLights200Response> GetLightsWithHttpInfo(int operationIndex = 0)
        {
            clipapisdk.Client.RequestOptions localVarRequestOptions = new clipapisdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = clipapisdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = clipapisdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }


            localVarRequestOptions.Operation = "LightApi.GetLights";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (HueApplicationKey) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("hue-application-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("hue-application-key", this.Configuration.GetApiKeyWithPrefix("hue-application-key"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<GetLights200Response>("/clip/v2/resource/light", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetLights", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// List lights. List all available lights.
        /// </summary>
        /// <exception cref="clipapisdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of GetLights200Response</returns>
        public async System.Threading.Tasks.Task<GetLights200Response> GetLightsAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            clipapisdk.Client.ApiResponse<GetLights200Response> localVarResponse = await GetLightsWithHttpInfoAsync(operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List lights. List all available lights.
        /// </summary>
        /// <exception cref="clipapisdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (GetLights200Response)</returns>
        public async System.Threading.Tasks.Task<clipapisdk.Client.ApiResponse<GetLights200Response>> GetLightsWithHttpInfoAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            clipapisdk.Client.RequestOptions localVarRequestOptions = new clipapisdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = clipapisdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = clipapisdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }


            localVarRequestOptions.Operation = "LightApi.GetLights";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (HueApplicationKey) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("hue-application-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("hue-application-key", this.Configuration.GetApiKeyWithPrefix("hue-application-key"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<GetLights200Response>("/clip/v2/resource/light", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetLights", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update light Update a single light from its given &#x60;{lightId}&#x60;.
        /// </summary>
        /// <exception cref="clipapisdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lightId">ID of the light</param>
        /// <param name="lightPut"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>UpdateDevice200Response</returns>
        public UpdateDevice200Response UpdateLight(string lightId, LightPut? lightPut = default(LightPut?), int operationIndex = 0)
        {
            clipapisdk.Client.ApiResponse<UpdateDevice200Response> localVarResponse = UpdateLightWithHttpInfo(lightId, lightPut);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update light Update a single light from its given &#x60;{lightId}&#x60;.
        /// </summary>
        /// <exception cref="clipapisdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lightId">ID of the light</param>
        /// <param name="lightPut"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of UpdateDevice200Response</returns>
        public clipapisdk.Client.ApiResponse<UpdateDevice200Response> UpdateLightWithHttpInfo(string lightId, LightPut? lightPut = default(LightPut?), int operationIndex = 0)
        {
            // verify the required parameter 'lightId' is set
            if (lightId == null)
            {
                throw new clipapisdk.Client.ApiException(400, "Missing required parameter 'lightId' when calling LightApi->UpdateLight");
            }

            clipapisdk.Client.RequestOptions localVarRequestOptions = new clipapisdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = clipapisdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = clipapisdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("lightId", clipapisdk.Client.ClientUtils.ParameterToString(lightId)); // path parameter
            localVarRequestOptions.Data = lightPut;

            localVarRequestOptions.Operation = "LightApi.UpdateLight";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (HueApplicationKey) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("hue-application-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("hue-application-key", this.Configuration.GetApiKeyWithPrefix("hue-application-key"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Put<UpdateDevice200Response>("/clip/v2/resource/light/{lightId}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("UpdateLight", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update light Update a single light from its given &#x60;{lightId}&#x60;.
        /// </summary>
        /// <exception cref="clipapisdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lightId">ID of the light</param>
        /// <param name="lightPut"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of UpdateDevice200Response</returns>
        public async System.Threading.Tasks.Task<UpdateDevice200Response> UpdateLightAsync(string lightId, LightPut? lightPut = default(LightPut?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            clipapisdk.Client.ApiResponse<UpdateDevice200Response> localVarResponse = await UpdateLightWithHttpInfoAsync(lightId, lightPut, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update light Update a single light from its given &#x60;{lightId}&#x60;.
        /// </summary>
        /// <exception cref="clipapisdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lightId">ID of the light</param>
        /// <param name="lightPut"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (UpdateDevice200Response)</returns>
        public async System.Threading.Tasks.Task<clipapisdk.Client.ApiResponse<UpdateDevice200Response>> UpdateLightWithHttpInfoAsync(string lightId, LightPut? lightPut = default(LightPut?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'lightId' is set
            if (lightId == null)
            {
                throw new clipapisdk.Client.ApiException(400, "Missing required parameter 'lightId' when calling LightApi->UpdateLight");
            }


            clipapisdk.Client.RequestOptions localVarRequestOptions = new clipapisdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = clipapisdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = clipapisdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("lightId", clipapisdk.Client.ClientUtils.ParameterToString(lightId)); // path parameter
            localVarRequestOptions.Data = lightPut;

            localVarRequestOptions.Operation = "LightApi.UpdateLight";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (HueApplicationKey) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("hue-application-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("hue-application-key", this.Configuration.GetApiKeyWithPrefix("hue-application-key"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PutAsync<UpdateDevice200Response>("/clip/v2/resource/light/{lightId}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("UpdateLight", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}