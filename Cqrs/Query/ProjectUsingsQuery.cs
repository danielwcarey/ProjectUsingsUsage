using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.MSBuild;

namespace ProjectUsingsUsage.Cqrs.Query;

public class ProjectUsingsQuery
{
    public string Path { get; set; } = "";
}

public class ProjectUsingsQueryResult
{
    public string FileName { get; set; } = "";
    public string? FilePath { get; set; }
    public List<string> UsingStatements { get; set; } = new();
}

public class ProjectUsingsQueryHandler
{
    public async Task<List<ProjectUsingsQueryResult>> HandleAsync(ProjectUsingsQuery query)
    {
        if (!File.Exists(query.Path)) return new List<ProjectUsingsQueryResult>();

        var result = new List<ProjectUsingsQueryResult>();
        var workspace = MSBuildWorkspace.Create();

        var project = await workspace.OpenProjectAsync(query.Path);

        if (!project.HasDocuments)
            return result;

        foreach (var document in project.Documents)
        {
            if (document.SourceCodeKind != SourceCodeKind.Regular) continue;
            if (document.SupportsSyntaxTree == false) continue;

            var tree = await document.GetSyntaxTreeAsync();
            if (tree == null) continue;

            var root = await tree.GetRootAsync();
            var usings = root.DescendantNodes().OfType<UsingDirectiveSyntax>();
            var qualifiedNames = usings.SelectMany(x => x.DescendantNodes().OfType<QualifiedNameSyntax>());

            var usingStatementsList = qualifiedNames.Select(x => x.GetText().ToString()).ToList();

            result.Add(new ProjectUsingsQueryResult
            {
                FileName = document.Name,
                FilePath = document.FilePath,
                UsingStatements = usingStatementsList
            });
        }

        workspace.CloseSolution();

        return result;
    }
}