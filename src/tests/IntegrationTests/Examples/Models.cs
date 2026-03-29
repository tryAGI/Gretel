/*
order: 20
title: Models
slug: models

Example showing how to list and get synthetic data models in a project.
*/

namespace Gretel.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_ListModels()
    {
        //// List all synthetic data models in a project.
        using var client = GetAuthenticatedClient();

        var projects = await client.Projects.ListProjectsAsync(limit: 1);
        if (projects.Data is not { Count: > 0 })
        {
            Assert.Inconclusive("No projects found to test with.");
            return;
        }

        var projectId = projects.Data[0].Uid ?? projects.Data[0].Name!;
        var models = await client.Projects.ListModelsAsync(
            projectId: projectId,
            limit: 10);

        models.Data.Should().NotBeNull();
    }
}
