namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        private List<string> imagePaths = new List<string>();
        private int currentIndex = -1;
        public Form1()
        {
            InitializeComponent();
            PBSettings();
        }
        private void PBSettings()
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
        }
        private void pictureBox()
        {
            pictureBox1 = Controls.OfType<PictureBox>().FirstOrDefault();
            if (pictureBox1 != null && currentIndex >= 0 && currentIndex < imagePaths.Count)
            {
                pictureBox1.Image?.Dispose();
                pictureBox1.Image = Image.FromFile(imagePaths[currentIndex]);
            }
            else
            {
                pictureBox1.Image = null;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.Multiselect = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    imagePaths.AddRange(openFileDialog.FileNames);
                    if (currentIndex == -1 && imagePaths.Count > 0)
                    {
                        currentIndex = 0;
                        pictureBox();
                    }
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                pictureBox();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (currentIndex < imagePaths.Count - 1)
            {
                currentIndex++;
                pictureBox();
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (currentIndex >= 0 && currentIndex < imagePaths.Count)
            {
                imagePaths.RemoveAt(currentIndex);
                if (currentIndex >= imagePaths.Count) currentIndex--;
                pictureBox();
            }
        }
    }
}
