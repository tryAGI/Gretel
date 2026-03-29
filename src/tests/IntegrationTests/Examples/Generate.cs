/*
order: 10
title: Projects
slug: projects

Basic example showing how to list projects and get project details.
*/

namespace Gretel.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_ListProjects()
    {
        //// List all projects accessible to the authenticated user.
        using var client = GetAuthenticatedClient();

        var projects = await client.Projects.ListProjectsAsync(
            limit: 10);

        projects.Data.Should().NotBeNull();
    }

    [TestMethod]
    public async Task Example_GetProject()
    {
        //// Get details of a specific project by ID.
        using var client = GetAuthenticatedClient();

        var projects = await client.Projects.ListProjectsAsync(limit: 1);
        if (projects.Data is not { Count: > 0 })
        {
            Assert.Inconclusive("No projects found to test with.");
            return;
        }

        var project = await client.Projects.GetProjectAsync(
            projectId: projects.Data[0].Uid ?? projects.Data[0].Name!);

        project.Should().NotBeNull();
        project.Uid.Should().NotBeNullOrEmpty();
    }
}
