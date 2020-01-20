namespace CosmosDbInvestigation
{
  partial class Form1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.startButton = new System.Windows.Forms.Button();
      this.serializeButton = new System.Windows.Forms.Button();
      this.deserializeButton = new System.Windows.Forms.Button();
      this.loadTenantsFromFile = new System.Windows.Forms.Button();
      this.loadTenantsFromCosmos = new System.Windows.Forms.Button();
      this.serializeTextBox = new System.Windows.Forms.TextBox();
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.setLazyIndexingButton = new System.Windows.Forms.Button();
      this.createIndexPayloadTitleButton = new System.Windows.Forms.Button();
      this.createStoredProceduresButton = new System.Windows.Forms.Button();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.tabPage3 = new System.Windows.Forms.TabPage();
      this.insertTenantsIntoCosmosButton = new System.Windows.Forms.Button();
      this.tenantGrid = new System.Windows.Forms.DataGridView();
      this.tabPage7 = new System.Windows.Forms.TabPage();
      this.insertUsersIntoCosmosButton = new System.Windows.Forms.Button();
      this.userGrid = new System.Windows.Forms.DataGridView();
      this.loadUsersFromFileButton = new System.Windows.Forms.Button();
      this.loadUsersFromCosmosButton = new System.Windows.Forms.Button();
      this.tabPage4 = new System.Windows.Forms.TabPage();
      this.createAppsTenantComboBox = new System.Windows.Forms.ComboBox();
      this.insertAppsStoredProcButton = new System.Windows.Forms.Button();
      this.insertAppsSerialButton = new System.Windows.Forms.Button();
      this.clearAppGridButton = new System.Windows.Forms.Button();
      this.appsGrid = new System.Windows.Forms.DataGridView();
      this.appsSpinEdit = new System.Windows.Forms.NumericUpDown();
      this.generateAppsButton = new System.Windows.Forms.Button();
      this.tabPage5 = new System.Windows.Forms.TabPage();
      this.readAppSQLButton = new System.Windows.Forms.Button();
      this.readAppPermissionComboBox = new System.Windows.Forms.ComboBox();
      this.readAppPermissionTypeComboBox = new System.Windows.Forms.ComboBox();
      this.readAppUserComboBox = new System.Windows.Forms.ComboBox();
      this.readAppsUserCheckBox = new System.Windows.Forms.CheckBox();
      this.readAppsCountFromCosmosButton = new System.Windows.Forms.Button();
      this.readAppsOrderTextBox = new System.Windows.Forms.TextBox();
      this.readAppsOrderCheckBox = new System.Windows.Forms.CheckBox();
      this.readAppsWhereTextBox = new System.Windows.Forms.TextBox();
      this.readAppsWhereCheckBox = new System.Windows.Forms.CheckBox();
      this.readAppsFromCosmosButton = new System.Windows.Forms.Button();
      this.readAppsGrid = new System.Windows.Forms.DataGridView();
      this.readAppsLimitSpinEdit = new System.Windows.Forms.NumericUpDown();
      this.readAppsTenantComboBox = new System.Windows.Forms.ComboBox();
      this.readAppsTenantCheckBox = new System.Windows.Forms.CheckBox();
      this.readAppsLimitCheckBox = new System.Windows.Forms.CheckBox();
      this.tabPage6 = new System.Windows.Forms.TabPage();
      this.millionRandomButton = new System.Windows.Forms.Button();
      this.generateAppWithPermissionsCheckBox = new System.Windows.Forms.CheckBox();
      this.generateAppsTenantComboBox = new System.Windows.Forms.ComboBox();
      this.generateAppsSpinEdit = new System.Windows.Forms.NumericUpDown();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.generateLabel = new System.Windows.Forms.ToolStripStatusLabel();
      this.refreshTenantGridButton = new System.Windows.Forms.Button();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.tabPage2.SuspendLayout();
      this.tabPage3.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.tenantGrid)).BeginInit();
      this.tabPage7.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.userGrid)).BeginInit();
      this.tabPage4.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.appsGrid)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.appsSpinEdit)).BeginInit();
      this.tabPage5.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.readAppsGrid)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.readAppsLimitSpinEdit)).BeginInit();
      this.tabPage6.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.generateAppsSpinEdit)).BeginInit();
      this.statusStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // startButton
      // 
      this.startButton.Location = new System.Drawing.Point(10, 59);
      this.startButton.Name = "startButton";
      this.startButton.Size = new System.Drawing.Size(75, 23);
      this.startButton.TabIndex = 0;
      this.startButton.Text = "Start";
      this.startButton.UseVisualStyleBackColor = true;
      this.startButton.Click += new System.EventHandler(this.startButton_Click);
      // 
      // serializeButton
      // 
      this.serializeButton.Location = new System.Drawing.Point(10, 10);
      this.serializeButton.Name = "serializeButton";
      this.serializeButton.Size = new System.Drawing.Size(75, 23);
      this.serializeButton.TabIndex = 1;
      this.serializeButton.Text = "Serialize";
      this.serializeButton.UseVisualStyleBackColor = true;
      this.serializeButton.Click += new System.EventHandler(this.serializeButton_Click);
      // 
      // deserializeButton
      // 
      this.deserializeButton.Location = new System.Drawing.Point(91, 10);
      this.deserializeButton.Name = "deserializeButton";
      this.deserializeButton.Size = new System.Drawing.Size(75, 23);
      this.deserializeButton.TabIndex = 2;
      this.deserializeButton.Text = "Deserialize";
      this.deserializeButton.UseVisualStyleBackColor = true;
      this.deserializeButton.Click += new System.EventHandler(this.deserializeButton_Click);
      // 
      // loadTenantsFromFile
      // 
      this.loadTenantsFromFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.loadTenantsFromFile.Location = new System.Drawing.Point(10, 372);
      this.loadTenantsFromFile.Name = "loadTenantsFromFile";
      this.loadTenantsFromFile.Size = new System.Drawing.Size(108, 23);
      this.loadTenantsFromFile.TabIndex = 3;
      this.loadTenantsFromFile.Text = "Load from File";
      this.loadTenantsFromFile.UseVisualStyleBackColor = true;
      this.loadTenantsFromFile.Click += new System.EventHandler(this.loadTenantsFromFile_Click);
      // 
      // loadTenantsFromCosmos
      // 
      this.loadTenantsFromCosmos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.loadTenantsFromCosmos.Location = new System.Drawing.Point(124, 372);
      this.loadTenantsFromCosmos.Name = "loadTenantsFromCosmos";
      this.loadTenantsFromCosmos.Size = new System.Drawing.Size(108, 23);
      this.loadTenantsFromCosmos.TabIndex = 4;
      this.loadTenantsFromCosmos.Text = "Load from Cosmos";
      this.loadTenantsFromCosmos.UseVisualStyleBackColor = true;
      this.loadTenantsFromCosmos.Click += new System.EventHandler(this.loadTenantsFromCosmos_Click);
      // 
      // serializeTextBox
      // 
      this.serializeTextBox.AcceptsReturn = true;
      this.serializeTextBox.AcceptsTab = true;
      this.serializeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.serializeTextBox.Location = new System.Drawing.Point(10, 39);
      this.serializeTextBox.Multiline = true;
      this.serializeTextBox.Name = "serializeTextBox";
      this.serializeTextBox.Size = new System.Drawing.Size(705, 356);
      this.serializeTextBox.TabIndex = 0;
      // 
      // tabControl1
      // 
      this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tabControl1.Controls.Add(this.tabPage1);
      this.tabControl1.Controls.Add(this.tabPage2);
      this.tabControl1.Controls.Add(this.tabPage3);
      this.tabControl1.Controls.Add(this.tabPage7);
      this.tabControl1.Controls.Add(this.tabPage4);
      this.tabControl1.Controls.Add(this.tabPage5);
      this.tabControl1.Controls.Add(this.tabPage6);
      this.tabControl1.Location = new System.Drawing.Point(12, 12);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(871, 512);
      this.tabControl1.TabIndex = 6;
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.setLazyIndexingButton);
      this.tabPage1.Controls.Add(this.createIndexPayloadTitleButton);
      this.tabPage1.Controls.Add(this.createStoredProceduresButton);
      this.tabPage1.Controls.Add(this.startButton);
      this.tabPage1.Location = new System.Drawing.Point(4, 22);
      this.tabPage1.Margin = new System.Windows.Forms.Padding(7);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(7);
      this.tabPage1.Size = new System.Drawing.Size(863, 486);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Start";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // setLazyIndexingButton
      // 
      this.setLazyIndexingButton.Location = new System.Drawing.Point(10, 151);
      this.setLazyIndexingButton.Name = "setLazyIndexingButton";
      this.setLazyIndexingButton.Size = new System.Drawing.Size(75, 23);
      this.setLazyIndexingButton.TabIndex = 3;
      this.setLazyIndexingButton.Text = "Set Lazy Indexing";
      this.setLazyIndexingButton.UseVisualStyleBackColor = true;
      this.setLazyIndexingButton.Click += new System.EventHandler(this.setLazyIndexingButton_Click);
      // 
      // createIndexPayloadTitleButton
      // 
      this.createIndexPayloadTitleButton.Location = new System.Drawing.Point(10, 99);
      this.createIndexPayloadTitleButton.Name = "createIndexPayloadTitleButton";
      this.createIndexPayloadTitleButton.Size = new System.Drawing.Size(192, 23);
      this.createIndexPayloadTitleButton.TabIndex = 2;
      this.createIndexPayloadTitleButton.Text = "Create Index on /payload/Title";
      this.createIndexPayloadTitleButton.UseVisualStyleBackColor = true;
      this.createIndexPayloadTitleButton.Click += new System.EventHandler(this.createIndexPayloadTitleButton_Click);
      // 
      // createStoredProceduresButton
      // 
      this.createStoredProceduresButton.Location = new System.Drawing.Point(10, 191);
      this.createStoredProceduresButton.Name = "createStoredProceduresButton";
      this.createStoredProceduresButton.Size = new System.Drawing.Size(140, 23);
      this.createStoredProceduresButton.TabIndex = 1;
      this.createStoredProceduresButton.Text = "Create Stored Procedures";
      this.createStoredProceduresButton.UseVisualStyleBackColor = true;
      this.createStoredProceduresButton.Click += new System.EventHandler(this.createStoredProceduresButton_Click);
      // 
      // tabPage2
      // 
      this.tabPage2.Controls.Add(this.serializeTextBox);
      this.tabPage2.Controls.Add(this.serializeButton);
      this.tabPage2.Controls.Add(this.deserializeButton);
      this.tabPage2.Location = new System.Drawing.Point(4, 22);
      this.tabPage2.Margin = new System.Windows.Forms.Padding(7);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(7);
      this.tabPage2.Size = new System.Drawing.Size(863, 486);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Serialize Test";
      this.tabPage2.UseVisualStyleBackColor = true;
      // 
      // tabPage3
      // 
      this.tabPage3.Controls.Add(this.refreshTenantGridButton);
      this.tabPage3.Controls.Add(this.insertTenantsIntoCosmosButton);
      this.tabPage3.Controls.Add(this.tenantGrid);
      this.tabPage3.Controls.Add(this.loadTenantsFromFile);
      this.tabPage3.Controls.Add(this.loadTenantsFromCosmos);
      this.tabPage3.Location = new System.Drawing.Point(4, 22);
      this.tabPage3.Margin = new System.Windows.Forms.Padding(7);
      this.tabPage3.Name = "tabPage3";
      this.tabPage3.Padding = new System.Windows.Forms.Padding(7);
      this.tabPage3.Size = new System.Drawing.Size(863, 486);
      this.tabPage3.TabIndex = 2;
      this.tabPage3.Text = "Tenants";
      this.tabPage3.UseVisualStyleBackColor = true;
      // 
      // insertTenantsIntoCosmosButton
      // 
      this.insertTenantsIntoCosmosButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.insertTenantsIntoCosmosButton.Location = new System.Drawing.Point(238, 372);
      this.insertTenantsIntoCosmosButton.Name = "insertTenantsIntoCosmosButton";
      this.insertTenantsIntoCosmosButton.Size = new System.Drawing.Size(108, 23);
      this.insertTenantsIntoCosmosButton.TabIndex = 6;
      this.insertTenantsIntoCosmosButton.Text = "Insert Into Cosmos";
      this.insertTenantsIntoCosmosButton.UseVisualStyleBackColor = true;
      this.insertTenantsIntoCosmosButton.Click += new System.EventHandler(this.insertTenantsIntoCosmosButton_Click);
      // 
      // tenantGrid
      // 
      this.tenantGrid.AllowUserToAddRows = false;
      this.tenantGrid.AllowUserToDeleteRows = false;
      this.tenantGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tenantGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.tenantGrid.Location = new System.Drawing.Point(10, 10);
      this.tenantGrid.Name = "tenantGrid";
      this.tenantGrid.ReadOnly = true;
      this.tenantGrid.Size = new System.Drawing.Size(705, 356);
      this.tenantGrid.TabIndex = 5;
      // 
      // tabPage7
      // 
      this.tabPage7.Controls.Add(this.insertUsersIntoCosmosButton);
      this.tabPage7.Controls.Add(this.userGrid);
      this.tabPage7.Controls.Add(this.loadUsersFromFileButton);
      this.tabPage7.Controls.Add(this.loadUsersFromCosmosButton);
      this.tabPage7.Location = new System.Drawing.Point(4, 22);
      this.tabPage7.Name = "tabPage7";
      this.tabPage7.Size = new System.Drawing.Size(863, 486);
      this.tabPage7.TabIndex = 6;
      this.tabPage7.Text = "Users";
      this.tabPage7.UseVisualStyleBackColor = true;
      // 
      // insertUsersIntoCosmosButton
      // 
      this.insertUsersIntoCosmosButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.insertUsersIntoCosmosButton.Location = new System.Drawing.Point(238, 372);
      this.insertUsersIntoCosmosButton.Name = "insertUsersIntoCosmosButton";
      this.insertUsersIntoCosmosButton.Size = new System.Drawing.Size(108, 23);
      this.insertUsersIntoCosmosButton.TabIndex = 10;
      this.insertUsersIntoCosmosButton.Text = "Insert Into Cosmos";
      this.insertUsersIntoCosmosButton.UseVisualStyleBackColor = true;
      this.insertUsersIntoCosmosButton.Click += new System.EventHandler(this.insertUsersIntoCosmosButton_Click);
      // 
      // userGrid
      // 
      this.userGrid.AllowUserToAddRows = false;
      this.userGrid.AllowUserToDeleteRows = false;
      this.userGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.userGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.userGrid.Location = new System.Drawing.Point(10, 10);
      this.userGrid.Name = "userGrid";
      this.userGrid.ReadOnly = true;
      this.userGrid.Size = new System.Drawing.Size(705, 356);
      this.userGrid.TabIndex = 9;
      // 
      // loadUsersFromFileButton
      // 
      this.loadUsersFromFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.loadUsersFromFileButton.Location = new System.Drawing.Point(10, 372);
      this.loadUsersFromFileButton.Name = "loadUsersFromFileButton";
      this.loadUsersFromFileButton.Size = new System.Drawing.Size(108, 23);
      this.loadUsersFromFileButton.TabIndex = 7;
      this.loadUsersFromFileButton.Text = "Load from File";
      this.loadUsersFromFileButton.UseVisualStyleBackColor = true;
      this.loadUsersFromFileButton.Click += new System.EventHandler(this.loadUsersFromFileButton_Click);
      // 
      // loadUsersFromCosmosButton
      // 
      this.loadUsersFromCosmosButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.loadUsersFromCosmosButton.Location = new System.Drawing.Point(124, 372);
      this.loadUsersFromCosmosButton.Name = "loadUsersFromCosmosButton";
      this.loadUsersFromCosmosButton.Size = new System.Drawing.Size(108, 23);
      this.loadUsersFromCosmosButton.TabIndex = 8;
      this.loadUsersFromCosmosButton.Text = "Load from Cosmos";
      this.loadUsersFromCosmosButton.UseVisualStyleBackColor = true;
      this.loadUsersFromCosmosButton.Click += new System.EventHandler(this.loadUsersFromCosmosButton_Click);
      // 
      // tabPage4
      // 
      this.tabPage4.Controls.Add(this.createAppsTenantComboBox);
      this.tabPage4.Controls.Add(this.insertAppsStoredProcButton);
      this.tabPage4.Controls.Add(this.insertAppsSerialButton);
      this.tabPage4.Controls.Add(this.clearAppGridButton);
      this.tabPage4.Controls.Add(this.appsGrid);
      this.tabPage4.Controls.Add(this.appsSpinEdit);
      this.tabPage4.Controls.Add(this.generateAppsButton);
      this.tabPage4.Location = new System.Drawing.Point(4, 22);
      this.tabPage4.Margin = new System.Windows.Forms.Padding(7);
      this.tabPage4.Name = "tabPage4";
      this.tabPage4.Padding = new System.Windows.Forms.Padding(7);
      this.tabPage4.Size = new System.Drawing.Size(863, 486);
      this.tabPage4.TabIndex = 3;
      this.tabPage4.Text = "Create Apps";
      this.tabPage4.UseVisualStyleBackColor = true;
      // 
      // createAppsTenantComboBox
      // 
      this.createAppsTenantComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.createAppsTenantComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.createAppsTenantComboBox.FormattingEnabled = true;
      this.createAppsTenantComboBox.Location = new System.Drawing.Point(76, 455);
      this.createAppsTenantComboBox.Name = "createAppsTenantComboBox";
      this.createAppsTenantComboBox.Size = new System.Drawing.Size(121, 21);
      this.createAppsTenantComboBox.TabIndex = 6;
      // 
      // insertAppsStoredProcButton
      // 
      this.insertAppsStoredProcButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.insertAppsStoredProcButton.Location = new System.Drawing.Point(750, 453);
      this.insertAppsStoredProcButton.Name = "insertAppsStoredProcButton";
      this.insertAppsStoredProcButton.Size = new System.Drawing.Size(103, 23);
      this.insertAppsStoredProcButton.TabIndex = 5;
      this.insertAppsStoredProcButton.Text = "Insert Stored Proc";
      this.insertAppsStoredProcButton.UseVisualStyleBackColor = true;
      this.insertAppsStoredProcButton.Click += new System.EventHandler(this.insertAppsStoredProcButton_Click);
      // 
      // insertAppsSerialButton
      // 
      this.insertAppsSerialButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.insertAppsSerialButton.Location = new System.Drawing.Point(674, 453);
      this.insertAppsSerialButton.Name = "insertAppsSerialButton";
      this.insertAppsSerialButton.Size = new System.Drawing.Size(70, 23);
      this.insertAppsSerialButton.TabIndex = 4;
      this.insertAppsSerialButton.Text = "Insert Serial";
      this.insertAppsSerialButton.UseVisualStyleBackColor = true;
      this.insertAppsSerialButton.Click += new System.EventHandler(this.insertAppsSerialButton_Click);
      // 
      // clearAppGridButton
      // 
      this.clearAppGridButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.clearAppGridButton.Location = new System.Drawing.Point(548, 453);
      this.clearAppGridButton.Name = "clearAppGridButton";
      this.clearAppGridButton.Size = new System.Drawing.Size(70, 23);
      this.clearAppGridButton.TabIndex = 3;
      this.clearAppGridButton.Text = "Clear Grid";
      this.clearAppGridButton.UseVisualStyleBackColor = true;
      this.clearAppGridButton.Click += new System.EventHandler(this.clearAppGridButton_Click);
      // 
      // appsGrid
      // 
      this.appsGrid.AllowUserToAddRows = false;
      this.appsGrid.AllowUserToDeleteRows = false;
      this.appsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.appsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.appsGrid.Location = new System.Drawing.Point(10, 10);
      this.appsGrid.Name = "appsGrid";
      this.appsGrid.ReadOnly = true;
      this.appsGrid.Size = new System.Drawing.Size(843, 437);
      this.appsGrid.TabIndex = 2;
      // 
      // appsSpinEdit
      // 
      this.appsSpinEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.appsSpinEdit.Location = new System.Drawing.Point(10, 456);
      this.appsSpinEdit.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
      this.appsSpinEdit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.appsSpinEdit.Name = "appsSpinEdit";
      this.appsSpinEdit.Size = new System.Drawing.Size(60, 20);
      this.appsSpinEdit.TabIndex = 1;
      this.appsSpinEdit.Value = new decimal(new int[] {
            100000,
            0,
            0,
            0});
      // 
      // generateAppsButton
      // 
      this.generateAppsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.generateAppsButton.Location = new System.Drawing.Point(203, 453);
      this.generateAppsButton.Name = "generateAppsButton";
      this.generateAppsButton.Size = new System.Drawing.Size(105, 23);
      this.generateAppsButton.TabIndex = 0;
      this.generateAppsButton.Text = "Generate Apps";
      this.generateAppsButton.UseVisualStyleBackColor = true;
      this.generateAppsButton.Click += new System.EventHandler(this.generateAppsButton_Click);
      // 
      // tabPage5
      // 
      this.tabPage5.Controls.Add(this.readAppSQLButton);
      this.tabPage5.Controls.Add(this.readAppPermissionComboBox);
      this.tabPage5.Controls.Add(this.readAppPermissionTypeComboBox);
      this.tabPage5.Controls.Add(this.readAppUserComboBox);
      this.tabPage5.Controls.Add(this.readAppsUserCheckBox);
      this.tabPage5.Controls.Add(this.readAppsCountFromCosmosButton);
      this.tabPage5.Controls.Add(this.readAppsOrderTextBox);
      this.tabPage5.Controls.Add(this.readAppsOrderCheckBox);
      this.tabPage5.Controls.Add(this.readAppsWhereTextBox);
      this.tabPage5.Controls.Add(this.readAppsWhereCheckBox);
      this.tabPage5.Controls.Add(this.readAppsFromCosmosButton);
      this.tabPage5.Controls.Add(this.readAppsGrid);
      this.tabPage5.Controls.Add(this.readAppsLimitSpinEdit);
      this.tabPage5.Controls.Add(this.readAppsTenantComboBox);
      this.tabPage5.Controls.Add(this.readAppsTenantCheckBox);
      this.tabPage5.Controls.Add(this.readAppsLimitCheckBox);
      this.tabPage5.Location = new System.Drawing.Point(4, 22);
      this.tabPage5.Margin = new System.Windows.Forms.Padding(7);
      this.tabPage5.Name = "tabPage5";
      this.tabPage5.Padding = new System.Windows.Forms.Padding(7);
      this.tabPage5.Size = new System.Drawing.Size(863, 486);
      this.tabPage5.TabIndex = 4;
      this.tabPage5.Text = "Retrieve Apps";
      this.tabPage5.UseVisualStyleBackColor = true;
      // 
      // readAppSQLButton
      // 
      this.readAppSQLButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.readAppSQLButton.Location = new System.Drawing.Point(172, 453);
      this.readAppSQLButton.Name = "readAppSQLButton";
      this.readAppSQLButton.Size = new System.Drawing.Size(75, 23);
      this.readAppSQLButton.TabIndex = 14;
      this.readAppSQLButton.Text = "SQL";
      this.readAppSQLButton.UseVisualStyleBackColor = true;
      this.readAppSQLButton.Click += new System.EventHandler(this.readAppSQLButton_Click);
      // 
      // readAppPermissionComboBox
      // 
      this.readAppPermissionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.readAppPermissionComboBox.Enabled = false;
      this.readAppPermissionComboBox.FormattingEnabled = true;
      this.readAppPermissionComboBox.Location = new System.Drawing.Point(330, 115);
      this.readAppPermissionComboBox.Name = "readAppPermissionComboBox";
      this.readAppPermissionComboBox.Size = new System.Drawing.Size(121, 21);
      this.readAppPermissionComboBox.TabIndex = 13;
      // 
      // readAppPermissionTypeComboBox
      // 
      this.readAppPermissionTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.readAppPermissionTypeComboBox.Enabled = false;
      this.readAppPermissionTypeComboBox.FormattingEnabled = true;
      this.readAppPermissionTypeComboBox.Location = new System.Drawing.Point(203, 115);
      this.readAppPermissionTypeComboBox.Name = "readAppPermissionTypeComboBox";
      this.readAppPermissionTypeComboBox.Size = new System.Drawing.Size(121, 21);
      this.readAppPermissionTypeComboBox.TabIndex = 12;
      // 
      // readAppUserComboBox
      // 
      this.readAppUserComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.readAppUserComboBox.Enabled = false;
      this.readAppUserComboBox.FormattingEnabled = true;
      this.readAppUserComboBox.Location = new System.Drawing.Point(76, 115);
      this.readAppUserComboBox.Name = "readAppUserComboBox";
      this.readAppUserComboBox.Size = new System.Drawing.Size(121, 21);
      this.readAppUserComboBox.TabIndex = 11;
      // 
      // readAppsUserCheckBox
      // 
      this.readAppsUserCheckBox.AutoSize = true;
      this.readAppsUserCheckBox.Location = new System.Drawing.Point(10, 117);
      this.readAppsUserCheckBox.Name = "readAppsUserCheckBox";
      this.readAppsUserCheckBox.Size = new System.Drawing.Size(48, 17);
      this.readAppsUserCheckBox.TabIndex = 10;
      this.readAppsUserCheckBox.Text = "User";
      this.readAppsUserCheckBox.UseVisualStyleBackColor = true;
      this.readAppsUserCheckBox.CheckedChanged += new System.EventHandler(this.readAppsUserCheckBox_CheckedChanged);
      // 
      // readAppsCountFromCosmosButton
      // 
      this.readAppsCountFromCosmosButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.readAppsCountFromCosmosButton.Location = new System.Drawing.Point(91, 453);
      this.readAppsCountFromCosmosButton.Name = "readAppsCountFromCosmosButton";
      this.readAppsCountFromCosmosButton.Size = new System.Drawing.Size(75, 23);
      this.readAppsCountFromCosmosButton.TabIndex = 9;
      this.readAppsCountFromCosmosButton.Text = "Count";
      this.readAppsCountFromCosmosButton.UseVisualStyleBackColor = true;
      this.readAppsCountFromCosmosButton.Click += new System.EventHandler(this.readAppsCountFromCosmosButton_Click);
      // 
      // readAppsOrderTextBox
      // 
      this.readAppsOrderTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.readAppsOrderTextBox.Location = new System.Drawing.Point(76, 89);
      this.readAppsOrderTextBox.Name = "readAppsOrderTextBox";
      this.readAppsOrderTextBox.Size = new System.Drawing.Size(777, 20);
      this.readAppsOrderTextBox.TabIndex = 8;
      // 
      // readAppsOrderCheckBox
      // 
      this.readAppsOrderCheckBox.AutoSize = true;
      this.readAppsOrderCheckBox.Location = new System.Drawing.Point(10, 91);
      this.readAppsOrderCheckBox.Name = "readAppsOrderCheckBox";
      this.readAppsOrderCheckBox.Size = new System.Drawing.Size(52, 17);
      this.readAppsOrderCheckBox.TabIndex = 7;
      this.readAppsOrderCheckBox.Text = "Order";
      this.readAppsOrderCheckBox.UseVisualStyleBackColor = true;
      // 
      // readAppsWhereTextBox
      // 
      this.readAppsWhereTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.readAppsWhereTextBox.Location = new System.Drawing.Point(76, 63);
      this.readAppsWhereTextBox.Name = "readAppsWhereTextBox";
      this.readAppsWhereTextBox.Size = new System.Drawing.Size(777, 20);
      this.readAppsWhereTextBox.TabIndex = 6;
      // 
      // readAppsWhereCheckBox
      // 
      this.readAppsWhereCheckBox.AutoSize = true;
      this.readAppsWhereCheckBox.Location = new System.Drawing.Point(10, 65);
      this.readAppsWhereCheckBox.Name = "readAppsWhereCheckBox";
      this.readAppsWhereCheckBox.Size = new System.Drawing.Size(58, 17);
      this.readAppsWhereCheckBox.TabIndex = 5;
      this.readAppsWhereCheckBox.Text = "Where";
      this.readAppsWhereCheckBox.UseVisualStyleBackColor = true;
      // 
      // readAppsFromCosmosButton
      // 
      this.readAppsFromCosmosButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.readAppsFromCosmosButton.Location = new System.Drawing.Point(10, 453);
      this.readAppsFromCosmosButton.Name = "readAppsFromCosmosButton";
      this.readAppsFromCosmosButton.Size = new System.Drawing.Size(75, 23);
      this.readAppsFromCosmosButton.TabIndex = 4;
      this.readAppsFromCosmosButton.Text = "Read";
      this.readAppsFromCosmosButton.UseVisualStyleBackColor = true;
      this.readAppsFromCosmosButton.Click += new System.EventHandler(this.readAppsFromCosmosButton_Click);
      // 
      // readAppsGrid
      // 
      this.readAppsGrid.AllowUserToAddRows = false;
      this.readAppsGrid.AllowUserToDeleteRows = false;
      this.readAppsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.readAppsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.readAppsGrid.Location = new System.Drawing.Point(10, 142);
      this.readAppsGrid.Name = "readAppsGrid";
      this.readAppsGrid.ReadOnly = true;
      this.readAppsGrid.Size = new System.Drawing.Size(843, 305);
      this.readAppsGrid.TabIndex = 3;
      this.readAppsGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.readAppsGrid_CellDoubleClick);
      // 
      // readAppsLimitSpinEdit
      // 
      this.readAppsLimitSpinEdit.Enabled = false;
      this.readAppsLimitSpinEdit.Location = new System.Drawing.Point(77, 10);
      this.readAppsLimitSpinEdit.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
      this.readAppsLimitSpinEdit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.readAppsLimitSpinEdit.Name = "readAppsLimitSpinEdit";
      this.readAppsLimitSpinEdit.Size = new System.Drawing.Size(120, 20);
      this.readAppsLimitSpinEdit.TabIndex = 2;
      this.readAppsLimitSpinEdit.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
      // 
      // readAppsTenantComboBox
      // 
      this.readAppsTenantComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.readAppsTenantComboBox.Enabled = false;
      this.readAppsTenantComboBox.FormattingEnabled = true;
      this.readAppsTenantComboBox.Location = new System.Drawing.Point(76, 36);
      this.readAppsTenantComboBox.Name = "readAppsTenantComboBox";
      this.readAppsTenantComboBox.Size = new System.Drawing.Size(121, 21);
      this.readAppsTenantComboBox.TabIndex = 1;
      // 
      // readAppsTenantCheckBox
      // 
      this.readAppsTenantCheckBox.AutoSize = true;
      this.readAppsTenantCheckBox.Location = new System.Drawing.Point(10, 38);
      this.readAppsTenantCheckBox.Name = "readAppsTenantCheckBox";
      this.readAppsTenantCheckBox.Size = new System.Drawing.Size(60, 17);
      this.readAppsTenantCheckBox.TabIndex = 0;
      this.readAppsTenantCheckBox.Text = "Tenant";
      this.readAppsTenantCheckBox.UseVisualStyleBackColor = true;
      this.readAppsTenantCheckBox.CheckedChanged += new System.EventHandler(this.readAppsTenantCheckBox_CheckedChanged);
      // 
      // readAppsLimitCheckBox
      // 
      this.readAppsLimitCheckBox.AutoSize = true;
      this.readAppsLimitCheckBox.Location = new System.Drawing.Point(10, 11);
      this.readAppsLimitCheckBox.Name = "readAppsLimitCheckBox";
      this.readAppsLimitCheckBox.Size = new System.Drawing.Size(47, 17);
      this.readAppsLimitCheckBox.TabIndex = 0;
      this.readAppsLimitCheckBox.Text = "Limit";
      this.readAppsLimitCheckBox.UseVisualStyleBackColor = true;
      this.readAppsLimitCheckBox.CheckedChanged += new System.EventHandler(this.readAppsLimitCheckBox_CheckedChanged);
      // 
      // tabPage6
      // 
      this.tabPage6.Controls.Add(this.millionRandomButton);
      this.tabPage6.Controls.Add(this.generateAppWithPermissionsCheckBox);
      this.tabPage6.Controls.Add(this.generateAppsTenantComboBox);
      this.tabPage6.Controls.Add(this.generateAppsSpinEdit);
      this.tabPage6.Controls.Add(this.label2);
      this.tabPage6.Controls.Add(this.label1);
      this.tabPage6.Controls.Add(this.button1);
      this.tabPage6.Location = new System.Drawing.Point(4, 22);
      this.tabPage6.Margin = new System.Windows.Forms.Padding(7);
      this.tabPage6.Name = "tabPage6";
      this.tabPage6.Padding = new System.Windows.Forms.Padding(7);
      this.tabPage6.Size = new System.Drawing.Size(863, 486);
      this.tabPage6.TabIndex = 5;
      this.tabPage6.Text = "Generate";
      this.tabPage6.UseVisualStyleBackColor = true;
      // 
      // millionRandomButton
      // 
      this.millionRandomButton.Location = new System.Drawing.Point(85, 203);
      this.millionRandomButton.Name = "millionRandomButton";
      this.millionRandomButton.Size = new System.Drawing.Size(75, 23);
      this.millionRandomButton.TabIndex = 9;
      this.millionRandomButton.Text = "Generate 1 Million Random Records";
      this.millionRandomButton.UseVisualStyleBackColor = true;
      this.millionRandomButton.Click += new System.EventHandler(this.millionRandomButton_Click);
      // 
      // generateAppWithPermissionsCheckBox
      // 
      this.generateAppWithPermissionsCheckBox.AutoSize = true;
      this.generateAppWithPermissionsCheckBox.Location = new System.Drawing.Point(345, 14);
      this.generateAppWithPermissionsCheckBox.Name = "generateAppWithPermissionsCheckBox";
      this.generateAppWithPermissionsCheckBox.Size = new System.Drawing.Size(106, 17);
      this.generateAppWithPermissionsCheckBox.TabIndex = 8;
      this.generateAppWithPermissionsCheckBox.Text = "With Permissions";
      this.generateAppWithPermissionsCheckBox.UseVisualStyleBackColor = true;
      // 
      // generateAppsTenantComboBox
      // 
      this.generateAppsTenantComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.generateAppsTenantComboBox.FormattingEnabled = true;
      this.generateAppsTenantComboBox.Location = new System.Drawing.Point(218, 12);
      this.generateAppsTenantComboBox.Name = "generateAppsTenantComboBox";
      this.generateAppsTenantComboBox.Size = new System.Drawing.Size(121, 21);
      this.generateAppsTenantComboBox.TabIndex = 7;
      // 
      // generateAppsSpinEdit
      // 
      this.generateAppsSpinEdit.Location = new System.Drawing.Point(54, 13);
      this.generateAppsSpinEdit.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
      this.generateAppsSpinEdit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.generateAppsSpinEdit.Name = "generateAppsSpinEdit";
      this.generateAppsSpinEdit.Size = new System.Drawing.Size(93, 20);
      this.generateAppsSpinEdit.TabIndex = 2;
      this.generateAppsSpinEdit.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(153, 15);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(59, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "For Tenant";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(10, 15);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(38, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Create";
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(457, 10);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 0;
      this.button1.Text = "Generate";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.generateAppsButton2_Click);
      // 
      // statusStrip1
      // 
      this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateLabel});
      this.statusStrip1.Location = new System.Drawing.Point(0, 539);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Size = new System.Drawing.Size(895, 22);
      this.statusStrip1.TabIndex = 7;
      this.statusStrip1.Text = "statusStrip1";
      // 
      // generateLabel
      // 
      this.generateLabel.Name = "generateLabel";
      this.generateLabel.Size = new System.Drawing.Size(0, 17);
      // 
      // refreshTenantGridButton
      // 
      this.refreshTenantGridButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.refreshTenantGridButton.Location = new System.Drawing.Point(363, 371);
      this.refreshTenantGridButton.Name = "refreshTenantGridButton";
      this.refreshTenantGridButton.Size = new System.Drawing.Size(94, 23);
      this.refreshTenantGridButton.TabIndex = 7;
      this.refreshTenantGridButton.Text = "Refresh Grid";
      this.refreshTenantGridButton.UseVisualStyleBackColor = true;
      this.refreshTenantGridButton.Click += new System.EventHandler(this.refreshTenantGridButton_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(895, 561);
      this.Controls.Add(this.statusStrip1);
      this.Controls.Add(this.tabControl1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage2.ResumeLayout(false);
      this.tabPage2.PerformLayout();
      this.tabPage3.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.tenantGrid)).EndInit();
      this.tabPage7.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.userGrid)).EndInit();
      this.tabPage4.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.appsGrid)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.appsSpinEdit)).EndInit();
      this.tabPage5.ResumeLayout(false);
      this.tabPage5.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.readAppsGrid)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.readAppsLimitSpinEdit)).EndInit();
      this.tabPage6.ResumeLayout(false);
      this.tabPage6.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.generateAppsSpinEdit)).EndInit();
      this.statusStrip1.ResumeLayout(false);
      this.statusStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button startButton;
    private System.Windows.Forms.Button serializeButton;
    private System.Windows.Forms.Button deserializeButton;
    private System.Windows.Forms.Button loadTenantsFromFile;
    private System.Windows.Forms.Button loadTenantsFromCosmos;
    private System.Windows.Forms.TextBox serializeTextBox;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.TabPage tabPage3;
    private System.Windows.Forms.DataGridView tenantGrid;
    private System.Windows.Forms.Button insertTenantsIntoCosmosButton;
    private System.Windows.Forms.TabPage tabPage4;
    private System.Windows.Forms.DataGridView appsGrid;
    private System.Windows.Forms.NumericUpDown appsSpinEdit;
    private System.Windows.Forms.Button generateAppsButton;
    private System.Windows.Forms.Button clearAppGridButton;
    private System.Windows.Forms.Button insertAppsStoredProcButton;
    private System.Windows.Forms.Button insertAppsSerialButton;
    private System.Windows.Forms.TabPage tabPage5;
    private System.Windows.Forms.NumericUpDown readAppsLimitSpinEdit;
    private System.Windows.Forms.ComboBox readAppsTenantComboBox;
    private System.Windows.Forms.CheckBox readAppsTenantCheckBox;
    private System.Windows.Forms.CheckBox readAppsLimitCheckBox;
    private System.Windows.Forms.DataGridView readAppsGrid;
    private System.Windows.Forms.Button readAppsFromCosmosButton;
    private System.Windows.Forms.Button createStoredProceduresButton;
    private System.Windows.Forms.TextBox readAppsWhereTextBox;
    private System.Windows.Forms.CheckBox readAppsWhereCheckBox;
    private System.Windows.Forms.TextBox readAppsOrderTextBox;
    private System.Windows.Forms.CheckBox readAppsOrderCheckBox;
    private System.Windows.Forms.Button createIndexPayloadTitleButton;
    private System.Windows.Forms.ComboBox createAppsTenantComboBox;
    private System.Windows.Forms.TabPage tabPage6;
    private System.Windows.Forms.ComboBox generateAppsTenantComboBox;
    private System.Windows.Forms.NumericUpDown generateAppsSpinEdit;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button readAppsCountFromCosmosButton;
    private System.Windows.Forms.TabPage tabPage7;
    private System.Windows.Forms.Button insertUsersIntoCosmosButton;
    private System.Windows.Forms.DataGridView userGrid;
    private System.Windows.Forms.Button loadUsersFromFileButton;
    private System.Windows.Forms.Button loadUsersFromCosmosButton;
    private System.Windows.Forms.CheckBox generateAppWithPermissionsCheckBox;
    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.ToolStripStatusLabel generateLabel;
    private System.Windows.Forms.ComboBox readAppUserComboBox;
    private System.Windows.Forms.CheckBox readAppsUserCheckBox;
    private System.Windows.Forms.ComboBox readAppPermissionComboBox;
    private System.Windows.Forms.ComboBox readAppPermissionTypeComboBox;
    private System.Windows.Forms.Button readAppSQLButton;
    private System.Windows.Forms.Button millionRandomButton;
    private System.Windows.Forms.Button setLazyIndexingButton;
    private System.Windows.Forms.Button refreshTenantGridButton;
  }
}

