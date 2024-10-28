namespace Home_Work_29._10._24
{
    public partial class Form2 : Form
    {
        private DateTime dateOnly;

        public Form2()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (DateTime.TryParse(textBox1.Text, out DateTime parsedDate))
            {
                dateOnly = parsedDate;
                label1.Text = $"Date: {dateOnly:yyyy-MM-dd}";
            }
            else
            {
                label1.Text = "Incorrect date format. Use the format YYYY-MM-DD";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (dateOnly > DateTime.Now)
            {
                TimeSpan remainingTime = dateOnly - DateTime.Now;
                label1.Text = $"There's time left: {remainingTime.Days} days, {remainingTime.Hours} hours, {remainingTime.Minutes} minutes, {remainingTime.Seconds} seconds";
            }
            else
            {
                label1.Text = "The date entered has already passed.";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
