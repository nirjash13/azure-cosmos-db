namespace CosmosDbAttachments
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
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.refreshListButton = new System.Windows.Forms.Button();
      this.editButton = new System.Windows.Forms.Button();
      this.filesGrid = new System.Windows.Forms.DataGridView();
      this.tabPage3 = new System.Windows.Forms.TabPage();
      this.upsertButton = new System.Windows.Forms.Button();
      this.button1 = new System.Windows.Forms.Button();
      this.nameTextBox = new System.Windows.Forms.TextBox();
      this.idTextBox = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.tabPage4 = new System.Windows.Forms.TabPage();
      this.filePathTextBox = new System.Windows.Forms.TextBox();
      this.mediaTypeTextBox = new System.Windows.Forms.TextBox();
      this.attachmentIdTextBox = new System.Windows.Forms.TextBox();
      this.upsertAttachmentButton = new System.Windows.Forms.Button();
      this.refreshAttachmentsButton = new System.Windows.Forms.Button();
      this.attachmentsGrid = new System.Windows.Forms.DataGridView();
      this.label7 = new System.Windows.Forms.Label();
      this.docIdTextBox = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.attachmentsButton = new System.Windows.Forms.Button();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.deleteAttachmentButton = new System.Windows.Forms.Button();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.tabPage2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.filesGrid)).BeginInit();
      this.tabPage3.SuspendLayout();
      this.tabPage4.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.attachmentsGrid)).BeginInit();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.SuspendLayout();
      // 
      // startButton
      // 
      this.startButton.Location = new System.Drawing.Point(10, 10);
      this.startButton.Name = "startButton";
      this.startButton.Size = new System.Drawing.Size(75, 23);
      this.startButton.TabIndex = 0;
      this.startButton.Text = "Start";
      this.startButton.UseVisualStyleBackColor = true;
      this.startButton.Click += new System.EventHandler(this.startButton_Click);
      // 
      // tabControl1
      // 
      this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tabControl1.Controls.Add(this.tabPage1);
      this.tabControl1.Controls.Add(this.tabPage2);
      this.tabControl1.Controls.Add(this.tabPage3);
      this.tabControl1.Controls.Add(this.tabPage4);
      this.tabControl1.Location = new System.Drawing.Point(12, 12);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(818, 460);
      this.tabControl1.TabIndex = 1;
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.startButton);
      this.tabPage1.Location = new System.Drawing.Point(4, 22);
      this.tabPage1.Margin = new System.Windows.Forms.Padding(7);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(7);
      this.tabPage1.Size = new System.Drawing.Size(643, 351);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Startup";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // tabPage2
      // 
      this.tabPage2.Controls.Add(this.attachmentsButton);
      this.tabPage2.Controls.Add(this.refreshListButton);
      this.tabPage2.Controls.Add(this.editButton);
      this.tabPage2.Controls.Add(this.filesGrid);
      this.tabPage2.Location = new System.Drawing.Point(4, 22);
      this.tabPage2.Margin = new System.Windows.Forms.Padding(7);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(7);
      this.tabPage2.Size = new System.Drawing.Size(643, 351);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "List";
      this.tabPage2.UseVisualStyleBackColor = true;
      // 
      // refreshListButton
      // 
      this.refreshListButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.refreshListButton.Location = new System.Drawing.Point(10, 318);
      this.refreshListButton.Name = "refreshListButton";
      this.refreshListButton.Size = new System.Drawing.Size(75, 23);
      this.refreshListButton.TabIndex = 2;
      this.refreshListButton.Text = "Refresh";
      this.refreshListButton.UseVisualStyleBackColor = true;
      this.refreshListButton.Click += new System.EventHandler(this.refreshListButton_Click);
      // 
      // editButton
      // 
      this.editButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.editButton.Location = new System.Drawing.Point(477, 318);
      this.editButton.Name = "editButton";
      this.editButton.Size = new System.Drawing.Size(75, 23);
      this.editButton.TabIndex = 1;
      this.editButton.Text = "Edit";
      this.editButton.UseVisualStyleBackColor = true;
      this.editButton.Click += new System.EventHandler(this.editButton_Click);
      // 
      // filesGrid
      // 
      this.filesGrid.AllowUserToAddRows = false;
      this.filesGrid.AllowUserToDeleteRows = false;
      this.filesGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.filesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.filesGrid.Location = new System.Drawing.Point(10, 10);
      this.filesGrid.Name = "filesGrid";
      this.filesGrid.ReadOnly = true;
      this.filesGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.filesGrid.Size = new System.Drawing.Size(623, 302);
      this.filesGrid.TabIndex = 0;
      // 
      // tabPage3
      // 
      this.tabPage3.Controls.Add(this.upsertButton);
      this.tabPage3.Controls.Add(this.button1);
      this.tabPage3.Controls.Add(this.nameTextBox);
      this.tabPage3.Controls.Add(this.idTextBox);
      this.tabPage3.Controls.Add(this.label2);
      this.tabPage3.Controls.Add(this.label1);
      this.tabPage3.Location = new System.Drawing.Point(4, 22);
      this.tabPage3.Margin = new System.Windows.Forms.Padding(7);
      this.tabPage3.Name = "tabPage3";
      this.tabPage3.Padding = new System.Windows.Forms.Padding(7);
      this.tabPage3.Size = new System.Drawing.Size(643, 351);
      this.tabPage3.TabIndex = 2;
      this.tabPage3.Text = "Edit";
      this.tabPage3.UseVisualStyleBackColor = true;
      // 
      // upsertButton
      // 
      this.upsertButton.Location = new System.Drawing.Point(82, 62);
      this.upsertButton.Name = "upsertButton";
      this.upsertButton.Size = new System.Drawing.Size(75, 23);
      this.upsertButton.TabIndex = 6;
      this.upsertButton.Text = "Upsert";
      this.upsertButton.UseVisualStyleBackColor = true;
      this.upsertButton.Click += new System.EventHandler(this.upsertButton_Click);
      // 
      // button1
      // 
      this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.button1.Location = new System.Drawing.Point(574, 10);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(59, 20);
      this.button1.TabIndex = 4;
      this.button1.Text = "New Id";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.newIdButton_Click);
      // 
      // nameTextBox
      // 
      this.nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.nameTextBox.Location = new System.Drawing.Point(82, 36);
      this.nameTextBox.Name = "nameTextBox";
      this.nameTextBox.Size = new System.Drawing.Size(486, 20);
      this.nameTextBox.TabIndex = 3;
      // 
      // idTextBox
      // 
      this.idTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.idTextBox.Location = new System.Drawing.Point(82, 10);
      this.idTextBox.Name = "idTextBox";
      this.idTextBox.Size = new System.Drawing.Size(486, 20);
      this.idTextBox.TabIndex = 2;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(10, 39);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(35, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "Name";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(10, 13);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(18, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "ID";
      // 
      // tabPage4
      // 
      this.tabPage4.Controls.Add(this.groupBox2);
      this.tabPage4.Controls.Add(this.docIdTextBox);
      this.tabPage4.Controls.Add(this.label4);
      this.tabPage4.Controls.Add(this.groupBox1);
      this.tabPage4.Location = new System.Drawing.Point(4, 22);
      this.tabPage4.Margin = new System.Windows.Forms.Padding(7);
      this.tabPage4.Name = "tabPage4";
      this.tabPage4.Padding = new System.Windows.Forms.Padding(7);
      this.tabPage4.Size = new System.Drawing.Size(810, 434);
      this.tabPage4.TabIndex = 3;
      this.tabPage4.Text = "Attachments";
      this.tabPage4.UseVisualStyleBackColor = true;
      // 
      // filePathTextBox
      // 
      this.filePathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.filePathTextBox.Location = new System.Drawing.Point(89, 71);
      this.filePathTextBox.Name = "filePathTextBox";
      this.filePathTextBox.Size = new System.Drawing.Size(650, 20);
      this.filePathTextBox.TabIndex = 13;
      this.filePathTextBox.Text = "D:\\Libraries\\Pictures\\Snail\\Snail-04.jpg";
      // 
      // mediaTypeTextBox
      // 
      this.mediaTypeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.mediaTypeTextBox.Location = new System.Drawing.Point(89, 45);
      this.mediaTypeTextBox.Name = "mediaTypeTextBox";
      this.mediaTypeTextBox.Size = new System.Drawing.Size(650, 20);
      this.mediaTypeTextBox.TabIndex = 13;
      this.mediaTypeTextBox.Text = "image/jpeg";
      // 
      // attachmentIdTextBox
      // 
      this.attachmentIdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.attachmentIdTextBox.Location = new System.Drawing.Point(89, 19);
      this.attachmentIdTextBox.Name = "attachmentIdTextBox";
      this.attachmentIdTextBox.Size = new System.Drawing.Size(650, 20);
      this.attachmentIdTextBox.TabIndex = 13;
      // 
      // upsertAttachmentButton
      // 
      this.upsertAttachmentButton.Location = new System.Drawing.Point(89, 97);
      this.upsertAttachmentButton.Name = "upsertAttachmentButton";
      this.upsertAttachmentButton.Size = new System.Drawing.Size(75, 23);
      this.upsertAttachmentButton.TabIndex = 12;
      this.upsertAttachmentButton.Text = "Upsert";
      this.upsertAttachmentButton.UseVisualStyleBackColor = true;
      this.upsertAttachmentButton.Click += new System.EventHandler(this.upsertAttachmentButton_Click);
      // 
      // refreshAttachmentsButton
      // 
      this.refreshAttachmentsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.refreshAttachmentsButton.Location = new System.Drawing.Point(16, 219);
      this.refreshAttachmentsButton.Name = "refreshAttachmentsButton";
      this.refreshAttachmentsButton.Size = new System.Drawing.Size(75, 23);
      this.refreshAttachmentsButton.TabIndex = 11;
      this.refreshAttachmentsButton.Text = "Refresh";
      this.refreshAttachmentsButton.UseVisualStyleBackColor = true;
      this.refreshAttachmentsButton.Click += new System.EventHandler(this.refreshAttachmentsButton_Click);
      // 
      // attachmentsGrid
      // 
      this.attachmentsGrid.AllowUserToAddRows = false;
      this.attachmentsGrid.AllowUserToDeleteRows = false;
      this.attachmentsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.attachmentsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.attachmentsGrid.Location = new System.Drawing.Point(16, 19);
      this.attachmentsGrid.Name = "attachmentsGrid";
      this.attachmentsGrid.ReadOnly = true;
      this.attachmentsGrid.Size = new System.Drawing.Size(723, 194);
      this.attachmentsGrid.TabIndex = 10;
      this.attachmentsGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.attachmentsGrid_CellDoubleClick);
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(10, 74);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(48, 13);
      this.label7.TabIndex = 3;
      this.label7.Text = "File Path";
      // 
      // docIdTextBox
      // 
      this.docIdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.docIdTextBox.Location = new System.Drawing.Point(55, 10);
      this.docIdTextBox.Name = "docIdTextBox";
      this.docIdTextBox.Size = new System.Drawing.Size(745, 20);
      this.docIdTextBox.TabIndex = 4;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(10, 48);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(63, 13);
      this.label6.TabIndex = 3;
      this.label6.Text = "Media Type";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(10, 22);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(73, 13);
      this.label5.TabIndex = 3;
      this.label5.Text = "Attachment Id";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(10, 13);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(39, 13);
      this.label4.TabIndex = 3;
      this.label4.Text = "Doc Id";
      // 
      // attachmentsButton
      // 
      this.attachmentsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.attachmentsButton.Location = new System.Drawing.Point(558, 318);
      this.attachmentsButton.Name = "attachmentsButton";
      this.attachmentsButton.Size = new System.Drawing.Size(75, 23);
      this.attachmentsButton.TabIndex = 3;
      this.attachmentsButton.Text = "Attachments";
      this.attachmentsButton.UseVisualStyleBackColor = true;
      this.attachmentsButton.Click += new System.EventHandler(this.attachmentsButton_Click);
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.deleteAttachmentButton);
      this.groupBox1.Controls.Add(this.attachmentsGrid);
      this.groupBox1.Controls.Add(this.refreshAttachmentsButton);
      this.groupBox1.Location = new System.Drawing.Point(55, 171);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(745, 253);
      this.groupBox1.TabIndex = 14;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Attachments";
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.upsertAttachmentButton);
      this.groupBox2.Controls.Add(this.filePathTextBox);
      this.groupBox2.Controls.Add(this.attachmentIdTextBox);
      this.groupBox2.Controls.Add(this.mediaTypeTextBox);
      this.groupBox2.Controls.Add(this.label5);
      this.groupBox2.Controls.Add(this.label6);
      this.groupBox2.Controls.Add(this.label7);
      this.groupBox2.Location = new System.Drawing.Point(55, 36);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(745, 129);
      this.groupBox2.TabIndex = 15;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Upsert";
      // 
      // deleteAttachmentButton
      // 
      this.deleteAttachmentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.deleteAttachmentButton.Location = new System.Drawing.Point(664, 219);
      this.deleteAttachmentButton.Name = "deleteAttachmentButton";
      this.deleteAttachmentButton.Size = new System.Drawing.Size(75, 23);
      this.deleteAttachmentButton.TabIndex = 12;
      this.deleteAttachmentButton.Text = "Delete";
      this.deleteAttachmentButton.UseVisualStyleBackColor = true;
      this.deleteAttachmentButton.Click += new System.EventHandler(this.deleteAttachmentButton_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(842, 484);
      this.Controls.Add(this.tabControl1);
      this.Name = "Form1";
      this.Text = "CosmosDb Attachments";
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.filesGrid)).EndInit();
      this.tabPage3.ResumeLayout(false);
      this.tabPage3.PerformLayout();
      this.tabPage4.ResumeLayout(false);
      this.tabPage4.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.attachmentsGrid)).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button startButton;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.Button refreshListButton;
    private System.Windows.Forms.Button editButton;
    private System.Windows.Forms.DataGridView filesGrid;
    private System.Windows.Forms.TabPage tabPage3;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.TextBox nameTextBox;
    private System.Windows.Forms.TextBox idTextBox;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button upsertButton;
    private System.Windows.Forms.TabPage tabPage4;
    private System.Windows.Forms.TextBox docIdTextBox;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Button upsertAttachmentButton;
    private System.Windows.Forms.Button refreshAttachmentsButton;
    private System.Windows.Forms.DataGridView attachmentsGrid;
    private System.Windows.Forms.TextBox filePathTextBox;
    private System.Windows.Forms.TextBox mediaTypeTextBox;
    private System.Windows.Forms.TextBox attachmentIdTextBox;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Button attachmentsButton;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Button deleteAttachmentButton;
  }
}

