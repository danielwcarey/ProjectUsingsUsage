using Microsoft.Build.Locator;
using ProjectUsingsUsage.Cqrs.Query;

namespace ProjectUsingsUsage;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
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

    public void RefreshVisualStudioInstancesList()
    {
        var handler = new VisualStudioInstancesQueryHandler();

        VisualStudioInstancesComboBox.DataSource = handler.Handle(new VisualStudioInstancesQuery());
    }

    public async Task SelectProjectAsync()
    {
        var handler = new SelectProjectQueryHandler();

        var result = handler.Handle(new SelectProjectQuery());

        if (result.Success)
        {
            MicrosoftBuildProjectTextBox.Text = result.Path;
            await AnalyzeUsingsAsync();
        }
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

        var handler = new AnalyzeUsingsQueryHandler();

        var result = await handler.HandleAsync(new AnalyzeUsingsQuery
        {
            Path = MicrosoftBuildProjectTextBox.Text
        });

        UsingsDataGridView.DataSource = result;
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