# CLAUDE.md -- Gretel SDK

## Overview

Auto-generated C# SDK for [Gretel](https://gretel.ai/) -- privacy-preserving synthetic data generation, data classification, and data transformation.
OpenAPI spec manually created from the [Gretel REST API documentation](https://api.docs.gretel.ai/) (Postman collection).

## Build & Test

```bash
dotnet build Gretel.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

Bearer token via API key from the [Gretel Console](https://console.gretel.cloud):

```csharp
var client = new GretelClient(apiKey); // GRETEL_API_KEY env var
```

## Key Files

- `src/libs/Gretel/openapi.yaml` -- Manually created OpenAPI 3.0 spec
- `src/libs/Gretel/generate.sh` -- Runs autosdk generate
- `src/libs/Gretel/Generated/` -- **Never edit** -- auto-generated code
- `src/libs/Gretel/Extensions/GretelClient.Tools.cs` -- MEAI `AIFunction` tools
- `src/tests/IntegrationTests/Examples/` -- Example tests (also generate docs)

## Sub-client Pattern

```csharp
var client = new GretelClient(apiKey);

// Projects -- manage projects and synthetic data models
client.Projects.ListProjectsAsync()
client.Projects.GetProjectAsync(projectId)
client.Projects.CreateModelAsync(projectId, request)
client.Projects.GetModelAsync(projectId, modelId)
client.Projects.CreateRecordHandlerAsync(projectId, modelId, request)

// Workflows -- automated data generation pipelines
client.Workflows.ListWorkflowsAsync()
client.Workflows.CreateWorkflowRunAsync(request)
client.Workflows.GetWorkflowRunAsync(runId)
client.Workflows.CancelWorkflowRunAsync(runId)

// Connections -- data source/destination management
client.Connections.ListConnectionsAsync()
client.Connections.CreateConnectionAsync(request)

// Users -- profile, billing, teams
client.Users.GetProfileAsync()
client.Users.GetBillingAsync()

// Activity -- audit logs
client.Activity.SearchActivityAsync()

// Clusters -- compute cluster management
client.Clusters.ListClustersAsync()

// Logs -- log retrieval
client.Logs.GetLogsAsync()
```

## MEAI Integration

AIFunction tools for use with any `IChatClient`:
- `AsListProjectsTool()` -- List all projects
- `AsGetProjectTool()` -- Get project details
- `AsListModelsTool()` -- List models in a project
- `AsGetModelTool()` -- Get model status and details
- `AsGetWorkflowRunTool()` -- Get workflow run status
- `AsListWorkflowsTool()` -- List all workflows

## Spec Notes

- Base URL: `https://api.gretel.ai`
- Auth: Bearer token (API key or JWT)
- 78 endpoints across 7 API groups
- Spec created manually from Postman collection at api.docs.gretel.ai
