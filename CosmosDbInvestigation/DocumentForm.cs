using System;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace CosmosDbInvestigation
{
  public partial class DocumentForm : Form
  {
    public DocumentForm(object document)
    {
      InitializeComponent();

      try
      {
        jsonTextBox.Text = JsonConvert.SerializeObject(document, Formatting.Indented);
      }
      catch (Exception ex)
      {
        jsonTextBox.Text = ex.Message;
      }

    }
  }
}
