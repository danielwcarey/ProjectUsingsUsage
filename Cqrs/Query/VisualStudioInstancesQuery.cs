using Microsoft.Build.Locator;

namespace ProjectUsingsUsage.Cqrs.Query;

public class VisualStudioInstancesQuery
{ }

public class VisualStudioInstancesQueryResult
{
    public string Name { get; set; } = "";
    public VisualStudioInstance VisualStudioInstance { get; set; }
}

public class VisualStudioInstancesQueryHandler
{
    public List<VisualStudioInstancesQueryResult> Handle(VisualStudioInstancesQuery query)
    {
        return MSBuildLocator.QueryVisualStudioInstances().Select(x => new VisualStudioInstancesQueryResult
        {
            Name = $"[{x.Version}] {x.VisualStudioRootPath}",
            VisualStudioInstance = x
        }).ToList();
    }
}