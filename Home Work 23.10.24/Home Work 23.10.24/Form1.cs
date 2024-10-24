namespace Home_Work_23._10._24
{
    public partial class Form1 : Form
    {
        private int rows = 10;
        private int cols = 10;
        private int buttonWidth = 80;
        private int buttonHeight = 40;
        private int padding = 10;

        private void CreateArray()
        {
            Button[,] buttons = new Button[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    int row = i;
                    int col = j;

                    buttons[i, j] = new Button();
                    buttons[i, j].Width = buttonWidth;
                    buttons[i, j].Height = buttonHeight;
                    buttons[i, j ].Text = (i * cols + j + 1).ToString();
                    buttons[i, j].Left = j * (buttonWidth + padding);
                    buttons[i, j].Top = i * (buttonHeight + padding);
                    buttons[row, col].Click += (sender, e) => b_Click(sender, e, row, col);

                    this.Controls.Add(buttons[i, j]);
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
            CreateArray();
        }

        private void b_Click(object sender, EventArgs e, int row, int col)
        {
            MessageBox.Show($"Row {row + 1}, Column {col + 1}");
            Button clickedButton = sender as Button;
            clickedButton.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
