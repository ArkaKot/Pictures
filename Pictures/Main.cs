using Pictures.Properties;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Pictures
{
    public partial class Main : Form
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

        public Main()
        {
            InitializeComponent();

            var verify = VerifyImage();
            if (verify == true)
            {
                SetImage(Settings.Default.ImageAdres);
            }
        }

        private bool VerifyImage()
        {
            if (!File.Exists(ImageAdres) && ImageAdres != null)
            {
                var verifyImageFile = MessageBox.Show("Brak pliku, czy chcesz wczytać inny?", "Brak określonego pliku", MessageBoxButtons.YesNo);

                if (verifyImageFile == DialogResult.Yes)
                {
                    OpenFileDialog fileDialog = new OpenFileDialog();
                    fileDialog.Filter = "Obrazy (BMP, JPG, PNG, GIF)| *.BMP; *.JPG; *.PNG;  *.GIF; | All files(*.*) | *.*";
                    fileDialog.FilterIndex = 2;

                    if (fileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string newImageAdres = fileDialog.FileName;
                        SetImage(newImageAdres);
                        HideButtnos(true);
                    }
                    return false;
                }
                else
                {
                    ClearImage();
                    return false;
                }
            }
            return true;
        }

        private void SetImage(string fileAdres)
        {
            SaveImage(fileAdres);

            Bitmap bitmap = new Bitmap(fileAdres);
            pb1.Image = bitmap;
            pb1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private static void SaveImage(string fileAdres)
        {
            Settings.Default.ImageAdres = fileAdres;
            Settings.Default.Save();
        }

        private void ClearImage()
        {
            pb1.Image = null;
            HideButtnos(false);
            SaveImage(null);
        }

        private void HideButtnos(bool visiblebutton)
        {
            btnClear.Visible = visiblebutton;
            btnDetail.Visible = visiblebutton;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Obrazy (BMP, JPG, PNG, GIF)| *.BMP; *.JPG; *.PNG;  *.GIF; | All files(*.*) | *.*";
            fileDialog.FilterIndex = 2;

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                SetImageAdd(fileDialog);
            }
        }

        private void SetImageAdd(OpenFileDialog fileDialog)
        {
            string imageAdres = fileDialog.FileName;
            Bitmap bitmap = new Bitmap(imageAdres);
            pb1.Image = bitmap;
            pb1.SizeMode = PictureBoxSizeMode.Zoom;
            SaveImage(imageAdres);
            HideButtnos(true);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            var confirmClearImage = MessageBox.Show("Czy jesteś pewny, że chcesz wyczyścić obraz?", "Czyszczenie obrazu", MessageBoxButtons.YesNo);

            if (confirmClearImage == DialogResult.Yes)
            {
                ClearImage();
            }
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            var detailImage = new DetailImage();

            detailImage.ShowDialog();
        }
    }
}