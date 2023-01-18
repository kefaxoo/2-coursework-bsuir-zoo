﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Timers;
using System.Windows.Forms;
using Timer = System.Timers.Timer;

namespace pet_store
{
    public partial class Menu : Form
    {
        private readonly Timer timer = new Timer(1000);
        private User user;
        public Menu(User user)
        {
            InitializeComponent();
            this.user = user;
            userLabel.Text += user.GetLogin();
            roleLabel.Text += user.GetRole();
            if (user.GetRole() == "Продавец")
            {
                workersButton.Enabled = false;
            }
        }

        private void UpdateDateAndTime(object sender, ElapsedEventArgs e)
        {
            dateLabel.Text = $"Дата: {DateTime.Now.ToShortDateString()}";
            timeLabel.Text = $"Время: {DateTime.Now.ToShortTimeString()}";
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            timer.Elapsed += UpdateDateAndTime;
            timer.Start();
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.Show();
        }

        private void workersButton_Click(object sender, EventArgs e)
        {

        }
    }
}