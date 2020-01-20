namespace CosmosDbInvestigation
{
  partial class DocumentForm
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
      this.jsonTextBox = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // jsonTextBox
      // 
      this.jsonTextBox.AcceptsReturn = true;
      this.jsonTextBox.AcceptsTab = true;
      this.jsonTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.jsonTextBox.Location = new System.Drawing.Point(0, 0);
      this.jsonTextBox.Multiline = true;
      this.jsonTextBox.Name = "jsonTextBox";
      this.jsonTextBox.ReadOnly = true;
      this.jsonTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.jsonTextBox.Size = new System.Drawing.Size(583, 375);
      this.jsonTextBox.TabIndex = 0;
      // 
      // DocumentForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(583, 375);
      this.Controls.Add(this.jsonTextBox);
      this.Name = "DocumentForm";
      this.Text = "Show Document";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox jsonTextBox;
  }
}