namespace ProjectUsingsUsage;

partial class MainForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.VisualStudioInstancesComboBox = new System.Windows.Forms.ComboBox();
            this.VisualStudioInstancesLabel = new System.Windows.Forms.Label();
            this.RefreshListButton = new System.Windows.Forms.Button();
            this.MicrosoftBuildProjectLabel = new System.Windows.Forms.Label();
            this.MicrosoftBuildProjectTextBox = new System.Windows.Forms.TextBox();
            this.SelectProjectButton = new System.Windows.Forms.Button();
            this.AnalyzeUsingsButton = new System.Windows.Forms.Button();
            this.UsingsDataGridView = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.AnalyzeToolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.UsingsDataGridView)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // VisualStudioInstancesComboBox
            // 
            this.VisualStudioInstancesComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VisualStudioInstancesComboBox.DisplayMember = "Name";
            this.VisualStudioInstancesComboBox.FormattingEnabled = true;
            this.VisualStudioInstancesComboBox.Location = new System.Drawing.Point(12, 32);
            this.VisualStudioInstancesComboBox.Name = "VisualStudioInstancesComboBox";
            this.VisualStudioInstancesComboBox.Size = new System.Drawing.Size(648, 28);
            this.VisualStudioInstancesComboBox.TabIndex = 0;
            // 
            // VisualStudioInstancesLabel
            // 
            this.VisualStudioInstancesLabel.AutoSize = true;
            this.VisualStudioInstancesLabel.Location = new System.Drawing.Point(12, 9);
            this.VisualStudioInstancesLabel.Name = "VisualStudioInstancesLabel";
            this.VisualStudioInstancesLabel.Size = new System.Drawing.Size(159, 20);
            this.VisualStudioInstancesLabel.TabIndex = 1;
            this.VisualStudioInstancesLabel.Text = "&Visual Studio Instances";
            // 
            // RefreshListButton
            // 
            this.RefreshListButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RefreshListButton.Location = new System.Drawing.Point(666, 31);
            this.RefreshListButton.Name = "RefreshListButton";
            this.RefreshListButton.Size = new System.Drawing.Size(146, 29);
            this.RefreshListButton.TabIndex = 2;
            this.RefreshListButton.Text = "&Refresh List";
            this.RefreshListButton.UseVisualStyleBackColor = true;
            this.RefreshListButton.Click += new System.EventHandler(this.OnRefreshListButton_Click);
            // 
            // MicrosoftBuildProjectLabel
            // 
            this.MicrosoftBuildProjectLabel.AutoSize = true;
            this.MicrosoftBuildProjectLabel.Location = new System.Drawing.Point(12, 63);
            this.MicrosoftBuildProjectLabel.Name = "MicrosoftBuildProjectLabel";
            this.MicrosoftBuildProjectLabel.Size = new System.Drawing.Size(160, 20);
            this.MicrosoftBuildProjectLabel.TabIndex = 3;
            this.MicrosoftBuildProjectLabel.Text = "&Microsoft Build Project";
            // 
            // MicrosoftBuildProjectTextBox
            // 
            this.MicrosoftBuildProjectTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MicrosoftBuildProjectTextBox.Location = new System.Drawing.Point(12, 86);
            this.MicrosoftBuildProjectTextBox.Name = "MicrosoftBuildProjectTextBox";
            this.MicrosoftBuildProjectTextBox.Size = new System.Drawing.Size(648, 27);
            this.MicrosoftBuildProjectTextBox.TabIndex = 4;
            // 
            // SelectProjectButton
            // 
            this.SelectProjectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectProjectButton.Location = new System.Drawing.Point(666, 86);
            this.SelectProjectButton.Name = "SelectProjectButton";
            this.SelectProjectButton.Size = new System.Drawing.Size(146, 29);
            this.SelectProjectButton.TabIndex = 5;
            this.SelectProjectButton.Text = "Select &Project...";
            this.SelectProjectButton.UseVisualStyleBackColor = true;
            this.SelectProjectButton.Click += new System.EventHandler(this.OnSelectProjectButton_Click);
            // 
            // AnalyzeUsingsButton
            // 
            this.AnalyzeUsingsButton.Location = new System.Drawing.Point(12, 119);
            this.AnalyzeUsingsButton.Name = "AnalyzeUsingsButton";
            this.AnalyzeUsingsButton.Size = new System.Drawing.Size(160, 29);
            this.AnalyzeUsingsButton.TabIndex = 6;
            this.AnalyzeUsingsButton.Text = "Analyze Usings";
            this.AnalyzeUsingsButton.UseVisualStyleBackColor = true;
            this.AnalyzeUsingsButton.Click += new System.EventHandler(this.OnAnalyzeUsingsButton_Click);
            // 
            // UsingsDataGridView
            // 
            this.UsingsDataGridView.AllowUserToAddRows = false;
            this.UsingsDataGridView.AllowUserToDeleteRows = false;
            this.UsingsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UsingsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsingsDataGridView.Location = new System.Drawing.Point(12, 154);
            this.UsingsDataGridView.Name = "UsingsDataGridView";
            this.UsingsDataGridView.ReadOnly = true;
            this.UsingsDataGridView.RowHeadersWidth = 51;
            this.UsingsDataGridView.RowTemplate.Height = 29;
            this.UsingsDataGridView.Size = new System.Drawing.Size(800, 391);
            this.UsingsDataGridView.TabIndex = 7;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AnalyzeToolStripProgressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 547);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(824, 24);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // AnalyzeToolStripProgressBar
            // 
            this.AnalyzeToolStripProgressBar.Name = "AnalyzeToolStripProgressBar";
            this.AnalyzeToolStripProgressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 571);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.UsingsDataGridView);
            this.Controls.Add(this.AnalyzeUsingsButton);
            this.Controls.Add(this.SelectProjectButton);
            this.Controls.Add(this.MicrosoftBuildProjectTextBox);
            this.Controls.Add(this.MicrosoftBuildProjectLabel);
            this.Controls.Add(this.RefreshListButton);
            this.Controls.Add(this.VisualStudioInstancesLabel);
            this.Controls.Add(this.VisualStudioInstancesComboBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Project Usings Usage";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UsingsDataGridView)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private ComboBox VisualStudioInstancesComboBox;
    private Label VisualStudioInstancesLabel;
    private Button RefreshListButton;
    private Label MicrosoftBuildProjectLabel;
    private TextBox MicrosoftBuildProjectTextBox;
    private Button SelectProjectButton;
    private Button AnalyzeUsingsButton;
    private DataGridView UsingsDataGridView;
    private StatusStrip statusStrip1;
    private ToolStripProgressBar AnalyzeToolStripProgressBar;
}
