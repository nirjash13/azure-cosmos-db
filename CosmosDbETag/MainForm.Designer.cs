namespace DocumentDbETag
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
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.newInstanceButton = new System.Windows.Forms.Button();
      this.setupButton = new System.Windows.Forms.Button();
      this.refreshListButton = new System.Windows.Forms.Button();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.editAndUpsertButton = new System.Windows.Forms.Button();
      this.editAndUpsertWithAccessConditionsButton = new System.Windows.Forms.Button();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.tabPage2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.SuspendLayout();
      // 
      // tabControl1
      // 
      this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tabControl1.Controls.Add(this.tabPage1);
      this.tabControl1.Controls.Add(this.tabPage2);
      this.tabControl1.Location = new System.Drawing.Point(12, 12);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(920, 477);
      this.tabControl1.TabIndex = 0;
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.newInstanceButton);
      this.tabPage1.Controls.Add(this.setupButton);
      this.tabPage1.Location = new System.Drawing.Point(4, 22);
      this.tabPage1.Margin = new System.Windows.Forms.Padding(7);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(7);
      this.tabPage1.Size = new System.Drawing.Size(912, 451);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Start";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // tabPage2
      // 
      this.tabPage2.Controls.Add(this.editAndUpsertWithAccessConditionsButton);
      this.tabPage2.Controls.Add(this.editAndUpsertButton);
      this.tabPage2.Controls.Add(this.dataGridView1);
      this.tabPage2.Controls.Add(this.refreshListButton);
      this.tabPage2.Location = new System.Drawing.Point(4, 22);
      this.tabPage2.Margin = new System.Windows.Forms.Padding(7);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(7);
      this.tabPage2.Size = new System.Drawing.Size(912, 451);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "List";
      this.tabPage2.UseVisualStyleBackColor = true;
      // 
      // newInstanceButton
      // 
      this.newInstanceButton.Location = new System.Drawing.Point(10, 39);
      this.newInstanceButton.Name = "newInstanceButton";
      this.newInstanceButton.Size = new System.Drawing.Size(101, 23);
      this.newInstanceButton.TabIndex = 3;
      this.newInstanceButton.Text = "New Instance";
      this.newInstanceButton.UseVisualStyleBackColor = true;
      this.newInstanceButton.Click += new System.EventHandler(this.newInstanceButton_Click);
      // 
      // setupButton
      // 
      this.setupButton.Location = new System.Drawing.Point(10, 10);
      this.setupButton.Name = "setupButton";
      this.setupButton.Size = new System.Drawing.Size(101, 23);
      this.setupButton.TabIndex = 2;
      this.setupButton.Text = "Setup";
      this.setupButton.UseVisualStyleBackColor = true;
      this.setupButton.Click += new System.EventHandler(this.setupButton_Click);
      // 
      // refreshListButton
      // 
      this.refreshListButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.refreshListButton.Location = new System.Drawing.Point(10, 418);
      this.refreshListButton.Name = "refreshListButton";
      this.refreshListButton.Size = new System.Drawing.Size(75, 23);
      this.refreshListButton.TabIndex = 0;
      this.refreshListButton.Text = "Refresh";
      this.refreshListButton.UseVisualStyleBackColor = true;
      this.refreshListButton.Click += new System.EventHandler(this.refreshListButton_Click);
      // 
      // dataGridView1
      // 
      this.dataGridView1.AllowUserToAddRows = false;
      this.dataGridView1.AllowUserToDeleteRows = false;
      this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Location = new System.Drawing.Point(10, 10);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.ReadOnly = true;
      this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dataGridView1.Size = new System.Drawing.Size(892, 402);
      this.dataGridView1.TabIndex = 1;
      // 
      // editAndUpsertButton
      // 
      this.editAndUpsertButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.editAndUpsertButton.Location = new System.Drawing.Point(91, 418);
      this.editAndUpsertButton.Name = "editAndUpsertButton";
      this.editAndUpsertButton.Size = new System.Drawing.Size(187, 23);
      this.editAndUpsertButton.TabIndex = 2;
      this.editAndUpsertButton.Text = "Edit and Upsert Selected Record";
      this.editAndUpsertButton.UseVisualStyleBackColor = true;
      this.editAndUpsertButton.Click += new System.EventHandler(this.editAndUpsertButton_Click);
      // 
      // editAndUpsertWithAccessConditionsButton
      // 
      this.editAndUpsertWithAccessConditionsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.editAndUpsertWithAccessConditionsButton.Location = new System.Drawing.Point(284, 418);
      this.editAndUpsertWithAccessConditionsButton.Name = "editAndUpsertWithAccessConditionsButton";
      this.editAndUpsertWithAccessConditionsButton.Size = new System.Drawing.Size(299, 23);
      this.editAndUpsertWithAccessConditionsButton.TabIndex = 3;
      this.editAndUpsertWithAccessConditionsButton.Text = "Edit and Upsert Selected Record with Access Conditions";
      this.editAndUpsertWithAccessConditionsButton.UseVisualStyleBackColor = true;
      this.editAndUpsertWithAccessConditionsButton.Click += new System.EventHandler(this.editAndUpsertWithAccessConditionsButton_Click);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(944, 501);
      this.Controls.Add(this.tabControl1);
      this.Name = "MainForm";
      this.Text = "DocumentDB ETag";
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.Button newInstanceButton;
    private System.Windows.Forms.Button setupButton;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.Button refreshListButton;
    private System.Windows.Forms.Button editAndUpsertButton;
    private System.Windows.Forms.Button editAndUpsertWithAccessConditionsButton;
  }
}

