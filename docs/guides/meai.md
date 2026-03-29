# Microsoft.Extensions.AI Integration

The Gretel SDK provides `AIFunction` tools that can be used with any `IChatClient` from the
[Microsoft.Extensions.AI](https://www.nuget.org/packages/Microsoft.Extensions.AI.Abstractions) ecosystem.

## Available Tools

| Tool | Description |
|------|-------------|
| `AsListProjectsTool()` | List all Gretel projects accessible to the user |
| `AsGetProjectTool()` | Get details of a specific project |
| `AsListModelsTool()` | List synthetic data models in a project |
| `AsGetModelTool()` | Get model status and configuration |
| `AsGetWorkflowRunTool()` | Get workflow run status and details |
| `AsListWorkflowsTool()` | List all data generation workflows |

## Usage

```csharp
using Gretel;
using Microsoft.Extensions.AI;

var gretelClient = new GretelClient(apiKey);

// Create tools
var tools = new[]
{
    gretelClient.AsListProjectsTool(),
    gretelClient.AsGetProjectTool(),
    gretelClient.AsListModelsTool(),
    gretelClient.AsGetModelTool(),
    gretelClient.AsGetWorkflowRunTool(),
    gretelClient.AsListWorkflowsTool(),
};

// Use with any IChatClient for AI agent scenarios
IChatClient chatClient = /* your chat client */;

var response = await chatClient.GetResponseAsync(
    "List all my Gretel projects",
    new ChatOptions { Tools = [.. tools] });
```
