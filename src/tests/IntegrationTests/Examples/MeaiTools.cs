/*
order: 40
title: MEAI Tools
slug: meai-tools

Example showing how to use Gretel AIFunction tools with any IChatClient.
*/

namespace Gretel.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_MeaiTools()
    {
        //// Gretel provides AIFunction tools that can be used with any `IChatClient`.
        //// These tools wrap common Gretel API operations for use in AI agent workflows.
        using var client = GetAuthenticatedClient();

        var tools = new[]
        {
            client.AsListProjectsTool(),
            client.AsGetProjectTool(),
            client.AsListModelsTool(),
            client.AsGetModelTool(),
            client.AsGetWorkflowRunTool(),
            client.AsListWorkflowsTool(),
        };

        tools.Should().HaveCount(6);
        tools[0].Name.Should().Be("Gretel_ListProjects");
        tools[1].Name.Should().Be("Gretel_GetProject");
        tools[2].Name.Should().Be("Gretel_ListModels");
        tools[3].Name.Should().Be("Gretel_GetModel");
        tools[4].Name.Should().Be("Gretel_GetWorkflowRun");
        tools[5].Name.Should().Be("Gretel_ListWorkflows");
    }
}
