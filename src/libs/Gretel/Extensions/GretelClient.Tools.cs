#nullable enable

using System.ComponentModel;
using Microsoft.Extensions.AI;

namespace Gretel;

public static class GretelClientTools
{
    /// <summary>
    /// Creates an AIFunction tool that lists all projects accessible to the user.
    /// </summary>
    public static AIFunction AsListProjectsTool(this GretelClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("Maximum number of projects to return")] int? limit,
                   CancellationToken cancellationToken) =>
            {
                var response = await client.Projects.ListProjectsAsync(
                    limit: limit,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return response;
            },
            name: "Gretel_ListProjects",
            description: "List all Gretel projects accessible to the authenticated user, including project names, IDs, and descriptions.");
    }

    /// <summary>
    /// Creates an AIFunction tool that gets project details by ID.
    /// </summary>
    public static AIFunction AsGetProjectTool(this GretelClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("The project ID or name to retrieve")] string projectId,
                   CancellationToken cancellationToken) =>
            {
                var response = await client.Projects.GetProjectAsync(
                    projectId: projectId,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return response;
            },
            name: "Gretel_GetProject",
            description: "Get details of a specific Gretel project including its configuration and members.");
    }

    /// <summary>
    /// Creates an AIFunction tool that lists models in a project.
    /// </summary>
    public static AIFunction AsListModelsTool(this GretelClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("The project ID or name")] string projectId,
                   [Description("Maximum number of models to return")] int? limit,
                   CancellationToken cancellationToken) =>
            {
                var response = await client.Projects.ListModelsAsync(
                    projectId: projectId,
                    limit: limit,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return response;
            },
            name: "Gretel_ListModels",
            description: "List all synthetic data models in a Gretel project, including model type, status, and creation time.");
    }

    /// <summary>
    /// Creates an AIFunction tool that gets model details including status.
    /// </summary>
    public static AIFunction AsGetModelTool(this GretelClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("The project ID or name")] string projectId,
                   [Description("The model ID to retrieve")] string modelId,
                   CancellationToken cancellationToken) =>
            {
                var response = await client.Projects.GetModelAsync(
                    projectId: projectId,
                    modelId: modelId,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return new
                {
                    response.Uid,
                    response.Name,
                    response.ModelType,
                    Status = response.Status?.ToValueString(),
                    response.CreatedAt,
                    response.CompletedAt,
                    response.ErrorMsg,
                };
            },
            name: "Gretel_GetModel",
            description: "Get details and status of a specific synthetic data model in a Gretel project.");
    }

    /// <summary>
    /// Creates an AIFunction tool that gets a workflow run's status.
    /// </summary>
    public static AIFunction AsGetWorkflowRunTool(this GretelClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("The workflow run ID to check")] string workflowRunId,
                   CancellationToken cancellationToken) =>
            {
                var response = await client.Workflows.GetWorkflowRunAsync(
                    workflowRunId: workflowRunId,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return new
                {
                    response.Id,
                    response.WorkflowId,
                    Status = response.Status?.ToValueString(),
                    response.CreatedAt,
                    response.CompletedAt,
                    response.ErrorMsg,
                };
            },
            name: "Gretel_GetWorkflowRun",
            description: "Get the status and details of a Gretel workflow run for synthetic data generation.");
    }

    /// <summary>
    /// Creates an AIFunction tool that lists workflows.
    /// </summary>
    public static AIFunction AsListWorkflowsTool(this GretelClient client)
    {
        return AIFunctionFactory.Create(
            async (CancellationToken cancellationToken) =>
            {
                var response = await client.Workflows.ListWorkflowsAsync(
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return response;
            },
            name: "Gretel_ListWorkflows",
            description: "List all Gretel workflows for automated synthetic data generation.");
    }
}
