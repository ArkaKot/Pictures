using Pictures.Properties;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Pictures
{
    public partial class DetailImage : Form
    {

        public string ImageAdres
        {
            get
            {
                return Settings.Default.ImageAdres;
            }
            set
            {
                Settings.Default.ImageAdres = value;
            }
        }

        public DetailImage()
        {
            InitializeComponent();

            SetDetail();
        }

        private void SetDetail()
        {
            Image image = Image.FromFile(ImageAdres);

            FileInfo fileInfo = new FileInfo(ImageAdres);

            var imageType = fileInfo.Name;
            var imageSize = fileInfo.Length;
            var createImageDatefileInfo = fileInfo.CreationTime;
            var widthImage = image.Width;
            var heightImage = image.Height;

            tbName.Text = imageType;
            tbSize.Text = imageSize.ToString();
            tbCreateDate.Text = createImageDatefileInfo.ToString();
            tbwidth.Text = widthImage.ToString();
            tbHeight.Text = heightImage.ToString();
        }
    }
}