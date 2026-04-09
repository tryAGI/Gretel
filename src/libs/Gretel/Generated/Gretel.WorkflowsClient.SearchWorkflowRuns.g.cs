
#nullable enable

namespace Gretel
{
    public partial class WorkflowsClient
    {


        private static readonly global::Gretel.EndPointSecurityRequirement s_SearchWorkflowRunsSecurityRequirement0 =
            new global::Gretel.EndPointSecurityRequirement
            {
                Authorizations = new global::Gretel.EndPointAuthorizationRequirement[]
                {                    new global::Gretel.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::Gretel.EndPointSecurityRequirement[] s_SearchWorkflowRunsSecurityRequirements =
            new global::Gretel.EndPointSecurityRequirement[]
            {                s_SearchWorkflowRunsSecurityRequirement0,
            };
        partial void PrepareSearchWorkflowRunsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? query,
            ref int? limit,
            ref int? skip,
            ref string? sort);
        partial void PrepareSearchWorkflowRunsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? query,
            int? limit,
            int? skip,
            string? sort);
        partial void ProcessSearchWorkflowRunsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessSearchWorkflowRunsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Search workflow runs<br/>
        /// Search workflow runs with filters.
        /// </summary>
        /// <param name="query"></param>
        /// <param name="limit"></param>
        /// <param name="skip"></param>
        /// <param name="sort"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Gretel.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Gretel.WorkflowRunList> SearchWorkflowRunsAsync(
            string? query = default,
            int? limit = default,
            int? skip = default,
            string? sort = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareSearchWorkflowRunsArguments(
                httpClient: HttpClient,
                query: ref query,
                limit: ref limit,
                skip: ref skip,
                sort: ref sort);


            var __authorizations = global::Gretel.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_SearchWorkflowRunsSecurityRequirements,
                operationName: "SearchWorkflowRunsAsync");

            var __pathBuilder = new global::Gretel.PathBuilder(
                path: "/v1/workflows/runs/search",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("query", query)
                .AddOptionalParameter("limit", limit?.ToString())
                .AddOptionalParameter("skip", skip?.ToString())
                .AddOptionalParameter("sort", sort) 
                ;
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
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

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareSearchWorkflowRunsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                query: query,
                limit: limit,
                skip: skip,
                sort: sort);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessSearchWorkflowRunsResponse(
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
                ProcessSearchWorkflowRunsResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Gretel.WorkflowRunList.FromJson(__content, JsonSerializerContext) ??
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
                        await global::Gretel.WorkflowRunList.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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
    }
}