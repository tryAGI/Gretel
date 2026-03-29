
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Gretel
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Gretel.JsonConverters.CreateProjectRequestRunnerModeJsonConverter),

            typeof(global::Gretel.JsonConverters.CreateProjectRequestRunnerModeNullableJsonConverter),

            typeof(global::Gretel.JsonConverters.ModelStatusJsonConverter),

            typeof(global::Gretel.JsonConverters.ModelStatusNullableJsonConverter),

            typeof(global::Gretel.JsonConverters.RecordHandlerStatusJsonConverter),

            typeof(global::Gretel.JsonConverters.RecordHandlerStatusNullableJsonConverter),

            typeof(global::Gretel.JsonConverters.CreateWorkflowRequestRunnerModeJsonConverter),

            typeof(global::Gretel.JsonConverters.CreateWorkflowRequestRunnerModeNullableJsonConverter),

            typeof(global::Gretel.JsonConverters.WorkflowRunStatusJsonConverter),

            typeof(global::Gretel.JsonConverters.WorkflowRunStatusNullableJsonConverter),

            typeof(global::Gretel.JsonConverters.WorkflowTaskStatusJsonConverter),

            typeof(global::Gretel.JsonConverters.WorkflowTaskStatusNullableJsonConverter),

            typeof(global::Gretel.JsonConverters.CreateModelRunnerModeJsonConverter),

            typeof(global::Gretel.JsonConverters.CreateModelRunnerModeNullableJsonConverter),

            typeof(global::Gretel.JsonConverters.CreateModelDryRunJsonConverter),

            typeof(global::Gretel.JsonConverters.CreateModelDryRunNullableJsonConverter),

            typeof(global::Gretel.JsonConverters.ListModelsSortByJsonConverter),

            typeof(global::Gretel.JsonConverters.ListModelsSortByNullableJsonConverter),

            typeof(global::Gretel.JsonConverters.GetModelArtifactTypeJsonConverter),

            typeof(global::Gretel.JsonConverters.GetModelArtifactTypeNullableJsonConverter),

            typeof(global::Gretel.JsonConverters.ListRecordHandlersStatusJsonConverter),

            typeof(global::Gretel.JsonConverters.ListRecordHandlersStatusNullableJsonConverter),

            typeof(global::Gretel.JsonConverters.ListRecordHandlersSortByJsonConverter),

            typeof(global::Gretel.JsonConverters.ListRecordHandlersSortByNullableJsonConverter),

            typeof(global::Gretel.JsonConverters.GetRecordHandlerArtifactTypeJsonConverter),

            typeof(global::Gretel.JsonConverters.GetRecordHandlerArtifactTypeNullableJsonConverter),

            typeof(global::Gretel.JsonConverters.DeleteAccountDryRunJsonConverter),

            typeof(global::Gretel.JsonConverters.DeleteAccountDryRunNullableJsonConverter),

            typeof(global::Gretel.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gretel.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gretel.Project))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Gretel.Member>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gretel.Member))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gretel.ProjectList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Gretel.Project>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gretel.CreateProjectRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gretel.CreateProjectRequestRunnerMode), TypeInfoPropertyName = "CreateProjectRequestRunnerMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gretel.UpdateProjectRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gretel.Artifact))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gretel.ArtifactList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Gretel.Artifact>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gretel.CreateArtifactRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gretel.ArtifactDownload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gretel.Model))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gretel.ModelStatus), TypeInfoPropertyName = "ModelStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gretel.ModelList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Gretel.Model>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gretel.CreateModelRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gretel.UpdateModelRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gretel.RecordHandler))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gretel.RecordHandlerStatus), TypeInfoPropertyName = "RecordHandlerStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gretel.RecordHandlerList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Gretel.RecordHandler>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gretel.CreateRecordHandlerRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gretel.UpdateRecordHandlerRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gretel.MemberList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gretel.Invite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gretel.InviteList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Gretel.Invite>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gretel.CreateInviteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gretel.Workflow))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gretel.WorkflowList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Gretel.Workflow>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gretel.CreateWorkflowRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gretel.CreateWorkflowRequestRunnerMode), TypeInfoPropertyName = "CreateWorkflowRequestRunnerMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gretel.ValidateWorkflowConfigRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gretel.WorkflowRun))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gretel.WorkflowRunStatus), TypeInfoPropertyName = "WorkflowRunStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gretel.WorkflowRunList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Gretel.WorkflowRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gretel.CreateWorkflowRunRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gretel.WorkflowTask))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gretel.WorkflowTaskStatus), TypeInfoPropertyName = "WorkflowTaskStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gretel.WorkflowTaskList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Gretel.WorkflowTask>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gretel.Connection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gretel.ConnectionList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Gretel.Connection>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gretel.CreateConnectionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gretel.UpdateConnectionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gretel.User))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gretel.UserList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Gretel.User>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gretel.UpdateProfileRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gretel.SearchUsersRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gretel.ApiKeyResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gretel.BillingData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gretel.Subscription))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gretel.CreateSubscriptionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gretel.Team))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gretel.TeamInviteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gretel.ActivityEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gretel.ActivityList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Gretel.ActivityEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gretel.Cluster))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gretel.ClusterList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Gretel.Cluster>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gretel.LogEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gretel.LogList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Gretel.LogEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gretel.LogUploadUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gretel.DeleteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gretel.ValidationResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gretel.CreateModelRunnerMode), TypeInfoPropertyName = "CreateModelRunnerMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gretel.CreateModelDryRun), TypeInfoPropertyName = "CreateModelDryRun2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gretel.ListModelsSortBy), TypeInfoPropertyName = "ListModelsSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gretel.GetModelArtifactType), TypeInfoPropertyName = "GetModelArtifactType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gretel.ListRecordHandlersStatus), TypeInfoPropertyName = "ListRecordHandlersStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gretel.ListRecordHandlersSortBy), TypeInfoPropertyName = "ListRecordHandlersSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gretel.GetRecordHandlerArtifactType), TypeInfoPropertyName = "GetRecordHandlerArtifactType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gretel.DeleteAccountDryRun), TypeInfoPropertyName = "DeleteAccountDryRun2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Gretel.Member>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Gretel.Project>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Gretel.Artifact>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Gretel.Model>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Gretel.RecordHandler>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Gretel.Invite>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Gretel.Workflow>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Gretel.WorkflowRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Gretel.WorkflowTask>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Gretel.Connection>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Gretel.User>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Gretel.ActivityEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Gretel.Cluster>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Gretel.LogEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}