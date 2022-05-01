using Microsoft.Build.Locator;
using ProjectUsingsUsage.Cqrs;
using ProjectUsingsUsage.Cqrs.Query;

namespace ProjectUsingsUsage;

public partial class MainForm : Form
{
    private AnyCommandOrQueryProcessor _commandOrQueryProcessor;

    public MainForm(AnyCommandOrQueryProcessor commandOrQueryProcessor)
    {
        InitializeComponent();
        _commandOrQueryProcessor = commandOrQueryProcessor;
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        RefreshVisualStudioInstancesList();
    }

    public void SetInput(bool enabled)
    {
        Cursor = enabled ? Cursors.Default : Cursors.WaitCursor;
        MicrosoftBuildProjectTextBox.Enabled = enabled;
        VisualStudioInstancesComboBox.Enabled = enabled;
        UsingsDataGridView.Enabled = enabled;
        AnalyzeUsingsButton.Enabled = enabled;
        RefreshListButton.Enabled = enabled;
        SelectProjectButton.Enabled = enabled;
    }

    public async void RefreshVisualStudioInstancesList()
    {
        VisualStudioInstancesComboBox.DataSource = await _commandOrQueryProcessor.ProcessAsync(new VisualStudioInstancesQuery());
    }

    public async Task SelectProjectAsync()
    {
        var result = await _commandOrQueryProcessor.ProcessAsync(new SelectProjectQuery());

        if (!result.Success)
            return;

        MicrosoftBuildProjectTextBox.Text = result.Path;
        await AnalyzeUsingsAsync();
    }

    public async Task AnalyzeUsingsAsync()
    {
        SetInput(false);
        if (VisualStudioInstancesComboBox.SelectedItem is not VisualStudioInstancesQueryResult instance)
        {
            SetInput(true);
            return;
        }

        if (!MSBuildLocator.IsRegistered)
        {
            var selectInstance = instance.VisualStudioInstance;
            MSBuildLocator.RegisterInstance(selectInstance);
        }

        UsingsDataGridView.DataSource = await _commandOrQueryProcessor.ProcessAsync(new AnalyzeUsingsQuery
        {
            Path = MicrosoftBuildProjectTextBox.Text
        }); 
        SetInput(true);
    }
    
    private void OnRefreshListButton_Click(object sender, EventArgs e)
    {
        RefreshVisualStudioInstancesList();
    }

    private async void OnSelectProjectButton_Click(object sender, EventArgs e)
    {
        await SelectProjectAsync();
    }

    private async void OnAnalyzeUsingsButton_Click(object sender, EventArgs e)
    {
        await AnalyzeUsingsAsync();
    }
}