namespace Home_Work_11._11._24
{
    public partial class Form1 : Form
    {
        private MenuStrip menuStrip;
        private ToolStripMenuItem mainItem;
        private int count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void CreateMenuButton_Click(object sender, EventArgs e)
        {
            if (menuStrip == null)
            {
                menuStrip = new MenuStrip();
                this.Controls.Add(menuStrip);

                mainItem = new ToolStripMenuItem("1");
                menuStrip.Items.Add(mainItem);

                mainItem.Click += MenuItem_Click;
            }
        }

        private void MenuItem_Click(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem menuItem)
            {
                if (menuItem.DropDownItems.Count == 0)
                {
                    count++;
                    ToolStripMenuItem newItem = new ToolStripMenuItem(count + "");
                    menuItem.DropDownItems.Add(newItem);
                    newItem.Click += MenuItem_Click;
                }
            }
        }
    }
}
