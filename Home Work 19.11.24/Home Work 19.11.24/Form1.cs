namespace Home_Work_19._11._24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(Form1_Paint);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Brush redBrush = new SolidBrush(Color.Red);
            Brush whiteBrush = new SolidBrush(Color.White);
            Brush blueBrush = new SolidBrush(Color.Blue);

            int flagWidth = 300;
            int flagHeight = 200;
            int stripeHeight = flagHeight / 13;
            int starFieldWidth = (int)(flagWidth * 0.4);
            int starFieldHeight = stripeHeight * 7;

            for (int i = 0; i < 13; i++)
            {
                Brush brush = (i % 2 == 0) ? redBrush : whiteBrush;
                g.FillRectangle(brush, 50, 50 + i * stripeHeight, flagWidth, stripeHeight);
            }

            g.FillRectangle(blueBrush, 50, 50, starFieldWidth, starFieldHeight);

            int starRows = 9;
            int starColumns = 6;
            int starSize = 6;

            float horizontalSpacing = starFieldWidth / (float)starColumns;
            float verticalSpacing = starFieldHeight / (float)starRows;

            for (int row = 0; row < starRows; row++)
            {
                int starsInRow = (row % 2 == 0) ? starColumns : starColumns - 1;
                float rowOffset = (row % 2 == 0) ? 0 : horizontalSpacing / 2;

                for (int col = 0; col < starsInRow; col++)
                {
                    float x = 50 + rowOffset + col * horizontalSpacing;
                    float y = 50 + row * verticalSpacing;

                    g.FillEllipse(whiteBrush, x - starSize / 2, y - starSize / 2, starSize, starSize);
                }
            }

            redBrush.Dispose();
            whiteBrush.Dispose();
            blueBrush.Dispose();
        }
    }
}