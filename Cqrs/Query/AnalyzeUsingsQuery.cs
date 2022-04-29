namespace ProjectUsingsUsage.Cqrs.Query;

public class AnalyzeUsingsQuery
{
    public string Path { get; set; } = "";
}

public class AnalyzeUsingsQueryResult
{
    public string UsingStatement { get; set; } = "";
    public int FileCount { get; set; }
    public int ProjectFileCount { get; set; }
    public float Percentage { get; set; }
    public List<string> Files { get; set; } = new();
}

public class AnalyzeUsingsQueryHandler
{
    public async Task<List<AnalyzeUsingsQueryResult>> HandleAsync(AnalyzeUsingsQuery query)
    {
        if (!File.Exists(query.Path))
            return new List<AnalyzeUsingsQueryResult>();

        var usingsQueryHandler = new ProjectUsingsQueryHandler();

        var projectUsings = await usingsQueryHandler.HandleAsync(new ProjectUsingsQuery
        {
            Path = query.Path
        });

        var projectFileCount = projectUsings.Select(x => x.FileName).Distinct().Count();

        var analysis = (from projectUsing in projectUsings
            from u in projectUsing.UsingStatements
            select new
            {
                projectUsing.FileName,
                projectUsing.FilePath,
                UsingStatement = u
            }).Distinct();

        var usingDistribution = analysis
            .GroupBy(x => x.UsingStatement)
            .Select(x => new AnalyzeUsingsQueryResult
            {
                UsingStatement = x.Key,
                FileCount = x.Count(),
                ProjectFileCount = projectFileCount,
                Percentage = float.Parse($"{x.Count() / (float)projectFileCount * 100:f2}"),
                Files = x.Select(x => x.FileName).OrderBy(x => x).ToList()
            }).OrderByDescending(x => x.FileCount).ToList();

        return usingDistribution;
    }
}