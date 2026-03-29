/*
order: 30
title: Workflows
slug: workflows

Example showing how to work with Gretel workflows for automated data generation.
*/

namespace Gretel.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_ListWorkflows()
    {
        //// List all workflows available to the authenticated user.
        using var client = GetAuthenticatedClient();

        var workflows = await client.Workflows.ListWorkflowsAsync();

        workflows.Data.Should().NotBeNull();
    }

    [TestMethod]
    public async Task Example_SearchWorkflowRuns()
    {
        //// Search for workflow runs with optional filters.
        using var client = GetAuthenticatedClient();

        var runs = await client.Workflows.SearchWorkflowRunsAsync(
            limit: 5);

        runs.Data.Should().NotBeNull();
    }
}
