
#nullable enable

namespace Gretel
{
    public partial class ProjectsClient
    {
        partial void PrepareCreateModelArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string projectId,
            ref global::Gretel.CreateModelRunnerMode? runnerMode,
            ref global::Gretel.CreateModelDryRun? dryRun,
            global::Gretel.CreateModelRequest request);
        partial void PrepareCreateModelRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string projectId,
            global::Gretel.CreateModelRunnerMode? runnerMode,
            global::Gretel.CreateModelDryRun? dryRun,
            global::Gretel.CreateModelRequest request);
        partial void ProcessCreateModelResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateModelResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create model<br/>
        /// Create a new model in a project. Models define the synthetic data generation configuration including the model type (CTGAN, LSTM, etc.) and parameters.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="runnerMode"></param>
        /// <param name="dryRun"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Gretel.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Gretel.Model> CreateModelAsync(
            string projectId,

            global::Gretel.CreateModelRequest request,
            global::Gretel.CreateModelRunnerMode? runnerMode = default,
            global::Gretel.CreateModelDryRun? dryRun = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateModelArguments(
                httpClient: HttpClient,
                projectId: ref projectId,
                runnerMode: ref runnerMode,
                dryRun: ref dryRun,
                request: request);

            var __pathBuilder = new global::Gretel.PathBuilder(
                path: $"/projects/{projectId}/models",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("runner_mode", runnerMode?.ToValueString())
                .AddOptionalParameter("dry_run", dryRun?.ToValueString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCreateModelRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                projectId: projectId,
                runnerMode: runnerMode,
                dryRun: dryRun,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateModelResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessCreateModelResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Gretel.Model.FromJson(__content, JsonSerializerContext) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::Gretel.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();

                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::Gretel.Model.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
#endif
                        ).ConfigureAwait(false);
                    }
                    catch (global::System.Exception)
                    {
                    }

                    throw new global::Gretel.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
        }
        /// <summary>
        /// Create model<br/>
        /// Create a new model in a project. Models define the synthetic data generation configuration including the model type (CTGAN, LSTM, etc.) and parameters.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="runnerMode"></param>
        /// <param name="dryRun"></param>
        /// <param name="schemaVersion">
        /// Configuration schema version<br/>
        /// Default Value: 1.0
        /// </param>
        /// <param name="name">
        /// Model name
        /// </param>
        /// <param name="models">
        /// Array of model configurations. Each defines a model type and its parameters. Supported types include ctgan, lstm, amplify, transform, classify, and more.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Gretel.Model> CreateModelAsync(
            string projectId,
            global::Gretel.CreateModelRunnerMode? runnerMode = default,
            global::Gretel.CreateModelDryRun? dryRun = default,
            string? schemaVersion = default,
            string? name = default,
            global::System.Collections.Generic.IList<object>? models = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {

            var __request = new global::Gretel.CreateModelRequest
            {
                SchemaVersion = schemaVersion,
                Name = name,
                Models = models,
            };

            return await CreateModelAsync(
                projectId: projectId,
                runnerMode: runnerMode,
                dryRun: dryRun,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}