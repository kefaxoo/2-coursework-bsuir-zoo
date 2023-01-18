using System;
using System.Windows.Forms;
using Timer = System.Timers.Timer;
using System.Timers;

namespace pet_store
{
    public partial class Menu : Form
    {
        private readonly Timer timer = new(1000);
        private readonly User user;
        public Menu(User user)
        {
            InitializeComponent();
            this.user = user;
            userLabel.Text += user.GetLogin();
            roleLabel.Text += user.GetRole();
            dateLabel.Text = $"Дата: {DateTime.Now.ToShortDateString()}";
            timeLabel.Text = $"Время: {DateTime.Now.ToShortTimeString()}";
            if (user.GetRole() == "Продавец")
            {
                workersButton.Enabled = false;
            }
        }

        private void UpdateDateAndTime(object sender, ElapsedEventArgs e)
        {
            //dateLabel.Text = $"Дата: {DateTime.Now.ToShortDateString()}";
            //timeLabel.Text = $"Время: {DateTime.Now.ToShortTimeString()}";
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            timer.Elapsed += UpdateDateAndTime;
            timer.Start();
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm loginForm = new();
            this.Hide();
            loginForm.Show();
        }

        private void WorkersButton_Click(object sender, EventArgs e)
        {
            WorkersMenu workersMenu = new(user, this);
            workersMenu.Show();
            this.Hide();
        }

        private void CatalogButton_Click(object sender, EventArgs e)
        {
            CatalogMenu catalogMenu = new(user, this);
            catalogMenu.Show();
            this.Hide();
        }

        private void SalesButton_Click(object sender, EventArgs e)
        {
            SalesForm salesForm = new(this);
            this.Hide();
            if (salesForm.IsItemsNullOrEmpty())
            {
                this.Show();
                return;
            }

            salesForm.Show();
        }
    }
}
