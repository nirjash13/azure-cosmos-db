namespace CosmosDbContinuationTokens
{
  partial class MainForm
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
      this.setupButton = new System.Windows.Forms.Button();
      this.createButton = new System.Windows.Forms.Button();
      this.begin1Button = new System.Windows.Forms.Button();
      this.begin2Button = new System.Windows.Forms.Button();
      this.begin3Button = new System.Windows.Forms.Button();
      this.continue1Button = new System.Windows.Forms.Button();
      this.continue2Button = new System.Windows.Forms.Button();
      this.continue3Button = new System.Windows.Forms.Button();
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.createSpinEdit = new System.Windows.Forms.NumericUpDown();
      this.label1 = new System.Windows.Forms.Label();
      this.tabPage3 = new System.Windows.Forms.TabPage();
      this.pageSizeSpinEdit = new System.Windows.Forms.NumericUpDown();
      this.label3 = new System.Windows.Forms.Label();
      this.continuationTokenTextBox = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.queryGrid = new System.Windows.Forms.DataGridView();
      this.newInstanceButton = new System.Windows.Forms.Button();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.tabPage2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.createSpinEdit)).BeginInit();
      this.tabPage3.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pageSizeSpinEdit)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.queryGrid)).BeginInit();
      this.SuspendLayout();
      // 
      // setupButton
      // 
      this.setupButton.Location = new System.Drawing.Point(10, 10);
      this.setupButton.Name = "setupButton";
      this.setupButton.Size = new System.Drawing.Size(101, 23);
      this.setupButton.TabIndex = 0;
      this.setupButton.Text = "Setup";
      this.setupButton.UseVisualStyleBackColor = true;
      this.setupButton.Click += new System.EventHandler(this.setupButton_Click);
      // 
      // createButton
      // 
      this.createButton.Location = new System.Drawing.Point(122, 36);
      this.createButton.Name = "createButton";
      this.createButton.Size = new System.Drawing.Size(75, 23);
      this.createButton.TabIndex = 1;
      this.createButton.Text = "Create";
      this.createButton.UseVisualStyleBackColor = true;
      this.createButton.Click += new System.EventHandler(this.createButton_Click);
      // 
      // begin1Button
      // 
      this.begin1Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.begin1Button.Location = new System.Drawing.Point(10, 509);
      this.begin1Button.Name = "begin1Button";
      this.begin1Button.Size = new System.Drawing.Size(177, 23);
      this.begin1Button.TabIndex = 2;
      this.begin1Button.Text = "Begin Query on Connection 1";
      this.begin1Button.UseVisualStyleBackColor = true;
      this.begin1Button.Click += new System.EventHandler(this.begin1Button_Click);
      // 
      // begin2Button
      // 
      this.begin2Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.begin2Button.Location = new System.Drawing.Point(193, 509);
      this.begin2Button.Name = "begin2Button";
      this.begin2Button.Size = new System.Drawing.Size(177, 23);
      this.begin2Button.TabIndex = 3;
      this.begin2Button.Text = "Begin Query on Connection 2";
      this.begin2Button.UseVisualStyleBackColor = true;
      this.begin2Button.Click += new System.EventHandler(this.begin2Button_Click);
      // 
      // begin3Button
      // 
      this.begin3Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.begin3Button.Location = new System.Drawing.Point(376, 509);
      this.begin3Button.Name = "begin3Button";
      this.begin3Button.Size = new System.Drawing.Size(177, 23);
      this.begin3Button.TabIndex = 4;
      this.begin3Button.Text = "Begin Query on Connection 3";
      this.begin3Button.UseVisualStyleBackColor = true;
      this.begin3Button.Click += new System.EventHandler(this.begin3Button_Click);
      // 
      // continue1Button
      // 
      this.continue1Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.continue1Button.Location = new System.Drawing.Point(10, 538);
      this.continue1Button.Name = "continue1Button";
      this.continue1Button.Size = new System.Drawing.Size(177, 23);
      this.continue1Button.TabIndex = 5;
      this.continue1Button.Text = "Continue Query on Connection 1";
      this.continue1Button.UseVisualStyleBackColor = true;
      this.continue1Button.Click += new System.EventHandler(this.continue1Button_Click);
      // 
      // continue2Button
      // 
      this.continue2Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.continue2Button.Location = new System.Drawing.Point(193, 538);
      this.continue2Button.Name = "continue2Button";
      this.continue2Button.Size = new System.Drawing.Size(177, 23);
      this.continue2Button.TabIndex = 6;
      this.continue2Button.Text = "Continue Query on Connection 2";
      this.continue2Button.UseVisualStyleBackColor = true;
      this.continue2Button.Click += new System.EventHandler(this.continue2Button_Click);
      // 
      // continue3Button
      // 
      this.continue3Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.continue3Button.Location = new System.Drawing.Point(376, 538);
      this.continue3Button.Name = "continue3Button";
      this.continue3Button.Size = new System.Drawing.Size(177, 23);
      this.continue3Button.TabIndex = 7;
      this.continue3Button.Text = "Continue Query on Connection 3";
      this.continue3Button.UseVisualStyleBackColor = true;
      this.continue3Button.Click += new System.EventHandler(this.continue3Button_Click);
      // 
      // tabControl1
      // 
      this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tabControl1.Controls.Add(this.tabPage1);
      this.tabControl1.Controls.Add(this.tabPage2);
      this.tabControl1.Controls.Add(this.tabPage3);
      this.tabControl1.Location = new System.Drawing.Point(12, 12);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(955, 597);
      this.tabControl1.TabIndex = 8;
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.newInstanceButton);
      this.tabPage1.Controls.Add(this.setupButton);
      this.tabPage1.Location = new System.Drawing.Point(4, 22);
      this.tabPage1.Margin = new System.Windows.Forms.Padding(7);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(7);
      this.tabPage1.Size = new System.Drawing.Size(947, 571);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Setup";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // tabPage2
      // 
      this.tabPage2.Controls.Add(this.createSpinEdit);
      this.tabPage2.Controls.Add(this.label1);
      this.tabPage2.Controls.Add(this.createButton);
      this.tabPage2.Location = new System.Drawing.Point(4, 22);
      this.tabPage2.Margin = new System.Windows.Forms.Padding(7);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(7);
      this.tabPage2.Size = new System.Drawing.Size(947, 571);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Create";
      this.tabPage2.UseVisualStyleBackColor = true;
      // 
      // createSpinEdit
      // 
      this.createSpinEdit.Location = new System.Drawing.Point(122, 10);
      this.createSpinEdit.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
      this.createSpinEdit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.createSpinEdit.Name = "createSpinEdit";
      this.createSpinEdit.Size = new System.Drawing.Size(120, 20);
      this.createSpinEdit.TabIndex = 3;
      this.createSpinEdit.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(10, 12);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(92, 13);
      this.label1.TabIndex = 2;
      this.label1.Text = "Quantity to Create";
      // 
      // tabPage3
      // 
      this.tabPage3.Controls.Add(this.pageSizeSpinEdit);
      this.tabPage3.Controls.Add(this.label3);
      this.tabPage3.Controls.Add(this.continuationTokenTextBox);
      this.tabPage3.Controls.Add(this.label2);
      this.tabPage3.Controls.Add(this.queryGrid);
      this.tabPage3.Controls.Add(this.begin1Button);
      this.tabPage3.Controls.Add(this.continue3Button);
      this.tabPage3.Controls.Add(this.begin2Button);
      this.tabPage3.Controls.Add(this.continue2Button);
      this.tabPage3.Controls.Add(this.begin3Button);
      this.tabPage3.Controls.Add(this.continue1Button);
      this.tabPage3.Location = new System.Drawing.Point(4, 22);
      this.tabPage3.Margin = new System.Windows.Forms.Padding(7);
      this.tabPage3.Name = "tabPage3";
      this.tabPage3.Padding = new System.Windows.Forms.Padding(7);
      this.tabPage3.Size = new System.Drawing.Size(947, 571);
      this.tabPage3.TabIndex = 2;
      this.tabPage3.Text = "Query";
      this.tabPage3.UseVisualStyleBackColor = true;
      // 
      // pageSizeSpinEdit
      // 
      this.pageSizeSpinEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.pageSizeSpinEdit.Location = new System.Drawing.Point(180, 457);
      this.pageSizeSpinEdit.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
      this.pageSizeSpinEdit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.pageSizeSpinEdit.Name = "pageSizeSpinEdit";
      this.pageSizeSpinEdit.Size = new System.Drawing.Size(120, 20);
      this.pageSizeSpinEdit.TabIndex = 12;
      this.pageSizeSpinEdit.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
      // 
      // label3
      // 
      this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(10, 459);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(160, 13);
      this.label3.TabIndex = 11;
      this.label3.Text = "Number of Records per Request";
      // 
      // continuationTokenTextBox
      // 
      this.continuationTokenTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.continuationTokenTextBox.Location = new System.Drawing.Point(180, 483);
      this.continuationTokenTextBox.Name = "continuationTokenTextBox";
      this.continuationTokenTextBox.Size = new System.Drawing.Size(757, 20);
      this.continuationTokenTextBox.TabIndex = 10;
      // 
      // label2
      // 
      this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(10, 486);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(164, 13);
      this.label2.TabIndex = 9;
      this.label2.Text = "Most Recent Continuation Token";
      // 
      // queryGrid
      // 
      this.queryGrid.AllowUserToAddRows = false;
      this.queryGrid.AllowUserToDeleteRows = false;
      this.queryGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.queryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.queryGrid.Location = new System.Drawing.Point(10, 10);
      this.queryGrid.Name = "queryGrid";
      this.queryGrid.ReadOnly = true;
      this.queryGrid.Size = new System.Drawing.Size(927, 441);
      this.queryGrid.TabIndex = 8;
      // 
      // newInstanceButton
      // 
      this.newInstanceButton.Location = new System.Drawing.Point(10, 39);
      this.newInstanceButton.Name = "newInstanceButton";
      this.newInstanceButton.Size = new System.Drawing.Size(101, 23);
      this.newInstanceButton.TabIndex = 1;
      this.newInstanceButton.Text = "New Instance";
      this.newInstanceButton.UseVisualStyleBackColor = true;
      this.newInstanceButton.Click += new System.EventHandler(this.newInstanceButton_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(979, 621);
      this.Controls.Add(this.tabControl1);
      this.Name = "Form1";
      this.Text = "CosmosDb Continuation Tokens";
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage2.ResumeLayout(false);
      this.tabPage2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.createSpinEdit)).EndInit();
      this.tabPage3.ResumeLayout(false);
      this.tabPage3.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pageSizeSpinEdit)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.queryGrid)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button setupButton;
    private System.Windows.Forms.Button createButton;
    private System.Windows.Forms.Button begin1Button;
    private System.Windows.Forms.Button begin2Button;
    private System.Windows.Forms.Button begin3Button;
    private System.Windows.Forms.Button continue1Button;
    private System.Windows.Forms.Button continue2Button;
    private System.Windows.Forms.Button continue3Button;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.NumericUpDown createSpinEdit;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TabPage tabPage3;
    private System.Windows.Forms.DataGridView queryGrid;
    private System.Windows.Forms.TextBox continuationTokenTextBox;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.NumericUpDown pageSizeSpinEdit;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button newInstanceButton;
  }
}

