using ProjectUsingsUsage.Cqrs.Query;

namespace ProjectUsingsUsage.Cqrs;

public class AnyCommandOrQueryProcessor
{
    public Task<List<AnalyzeUsingsQueryResult>> ProcessAsync(AnalyzeUsingsQuery query)
    {
        var handler = new AnalyzeUsingsQueryHandler();
        return handler.HandleAsync(query);
    }

    public Task<List<ProjectUsingsQueryResult>> ProcessAsync(ProjectUsingsQuery query)
    {
        var handler = new ProjectUsingsQueryHandler();
        return handler.HandleAsync(query);
    }

    public Task<SelectProjectQueryResult> ProcessAsync(SelectProjectQuery query)
    {
        var handler = new SelectProjectQueryHandler();
        return handler.HandleAsync(query);
    }

    public Task<List<VisualStudioInstancesQueryResult>> ProcessAsync(VisualStudioInstancesQuery query)
    {
        var handler = new VisualStudioInstancesQueryHandler();
        return handler.HandleAsync(query);
    }
}

