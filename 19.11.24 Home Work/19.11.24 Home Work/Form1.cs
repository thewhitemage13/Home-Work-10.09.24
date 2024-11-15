namespace _19._11._24_Home_Work
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeWishList();
        }

        private void InitializeWishList()
        {
            ListView listView1 = new ListView
            {
                View = View.Details,
                CheckBoxes = true,
                FullRowSelect = true,
                GridLines = true,
                Dock = DockStyle.Fill
            };

            listView1.Columns.Add(" ", 30);
            listView1.Columns.Add("Иконка", 70);
            listView1.Columns.Add("Название товара", 150);
            listView1.Columns.Add("Цена (грн)", 100);

            string[] items = { "Постетить Молдову", "Найти работу по специальности (Dev.)", "Книга \"Тренировка ума\" Том Вуджек ", "Перезапустить e-commerce проект", "Полететь в Ирландию в гости к Ивану Базеляну)" };
            int[] prices = { 3000, 0, 599, 122325, 30000 };
            ImageList imageList = new ImageList();

            imageList.Images.Add(Bitmap.FromFile(@"D:\.Net\Home Work\WinForms\19.11.24 Home Work\iconshw\md.png"));
            imageList.Images.Add(Bitmap.FromFile(@"D:\.Net\Home Work\WinForms\19.11.24 Home Work\iconshw\dev.png"));
            imageList.Images.Add(Bitmap.FromFile(@"D:\.Net\Home Work\WinForms\19.11.24 Home Work\iconshw\book.jpeg"));
            imageList.Images.Add(Bitmap.FromFile(@"D:\.Net\Home Work\WinForms\19.11.24 Home Work\iconshw\e-com.png"));
            imageList.Images.Add(Bitmap.FromFile(@"D:\.Net\Home Work\WinForms\19.11.24 Home Work\iconshw\irish.jpg"));

            listView1.SmallImageList = imageList;

            for (int i = 0; i < items.Length; i++)
            {
                ListViewItem listItem = new ListViewItem();
                listItem.SubItems.Add("");
                listItem.SubItems.Add(items[i]);
                listItem.SubItems.Add(prices[i].ToString() + " грн");
                listItem.ImageIndex = i;

                listView1.Items.Add(listItem);
            }
            this.Controls.Add(listView1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
