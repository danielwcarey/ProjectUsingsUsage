namespace ProjectUsingsUsage.Cqrs.Query;

public class SelectProjectQuery
{ }

public class SelectProjectQueryResult
{
    public bool Success { get; set; }
    public string Path { get; set; } = "";
}

public class SelectProjectQueryHandler
{
    public Task<SelectProjectQueryResult> HandleAsync(SelectProjectQuery query)
    {
        var dialog = new OpenFileDialog
        {
            Title = @"Project Selector",
            Filter = @"C# Project (*.csproj)|*.csproj|F# Project (*.fsproj)|*.fsproj|All Files (*.*)|*.*"
        };

        if (dialog.ShowDialog() != DialogResult.OK)
            return Task.FromResult(new SelectProjectQueryResult { Success = false });

        return Task.FromResult(new SelectProjectQueryResult { Success = true, Path = dialog.FileName });
    }
}