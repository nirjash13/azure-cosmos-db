using System.Drawing;
using System.Windows.Forms;

namespace CosmosDbAttachments
{
  public partial class ImageForm : Form
  {
    public ImageForm(Image image)
    {
      InitializeComponent();
      this.BackgroundImage = image;
      this.BackgroundImageLayout = ImageLayout.Zoom;
    }
  }
}
