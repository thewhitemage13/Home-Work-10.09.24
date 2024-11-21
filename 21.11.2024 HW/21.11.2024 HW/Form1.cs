namespace _21._11._2024_HW
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
            Pen blackPen = new Pen(Color.Black, 2);

            g.FillRectangle(whiteBrush, 50, 50, 300, 200);
            g.FillRectangle(redBrush, 180, 50, 40, 200);
            g.FillRectangle(redBrush, 50, 130, 300, 40);

            int crossSize = 20;
            int crossThickness = 8;

            DrawSmallCross(g, redBrush, 100, 90, crossSize, crossThickness);
            DrawSmallCross(g, redBrush, 260, 90, crossSize, crossThickness);
            DrawSmallCross(g, redBrush, 100, 190, crossSize, crossThickness);
            DrawSmallCross(g, redBrush, 260, 190, crossSize, crossThickness);

            g.DrawRectangle(blackPen, 50, 50, 300, 200);

            redBrush.Dispose();
            whiteBrush.Dispose();
            blackPen.Dispose();
        }

        private void DrawSmallCross(Graphics g, Brush brush, int centerX, int centerY, int size, int thickness)
        {
            g.FillRectangle(brush, centerX - thickness / 2, centerY - size / 2, thickness, size);
            g.FillRectangle(brush, centerX - size / 2, centerY - thickness / 2, size, thickness);
        }
    }
}
