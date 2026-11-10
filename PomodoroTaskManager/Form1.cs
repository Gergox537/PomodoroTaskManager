using System;
using System.Drawing;
using System.Windows.Forms;

namespace PomodoroTaskManager
{
    public partial class Form1 : Form
    {
        // 1. ÁLLAPOTVÁLTOZÓK
        private int secondsRemaining = 25 * 60; // 25 perc másodpercekben
        private bool isWorkTime = true;         // true = Munkaidõ, false = Szünet
        private bool isRunning = false;         // Fut-e az óra?

        public Form1()
        {
            InitializeComponent();
            UpdateTimerDisplay();
        }

        // --- IDÕZÍTÕ LOGIKA ---
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (secondsRemaining > 0)
            {
                secondsRemaining--;
                UpdateTimerDisplay();
            }
            else
            {
                timer1.Stop();
                System.Media.SystemSounds.Beep.Play();

                isWorkTime = !isWorkTime;

                if (isWorkTime)
                {
                    secondsRemaining = 25 * 60;
                    lblStatus.Text = "Munka idõszak";
                    lblStatus.ForeColor = Color.DarkRed;
                }
                else
                {
                    secondsRemaining = 5 * 60;
                    lblStatus.Text = "Pihenõ idõszak!";
                    lblStatus.ForeColor = Color.Green;
                }

                UpdateTimerDisplay();
                timer1.Start();
            }
        }

        private void UpdateTimerDisplay()
        {
            int minutes = secondsRemaining / 60;
            int seconds = secondsRemaining % 60;
            lblTimer.Text = $"{minutes:D2}:{seconds:D2}";
        }

        // --- GOMBOK ESEMÉNYKEZELÕI ---

        // Indítás / Szüneteltetés
        private void btnStartPause_Click_1(object sender, EventArgs e)
        {
            if (isRunning)
            {
                timer1.Stop();
                isRunning = false;
                btnStartPause.Text = "Folytatás";
            }
            else
            {
                timer1.Start();
                isRunning = true;
                btnStartPause.Text = "Szünet";
            }
        }

        // Visszaállítás
        private void btnReset_Click_1(object sender, EventArgs e)
        {
            timer1.Stop();
            isRunning = false;
            isWorkTime = true;
            secondsRemaining = 25 * 60;

            lblStatus.Text = "Munka idõszak";
            lblStatus.ForeColor = Color.Black;
            btnStartPause.Text = "Indítás";

            UpdateTimerDisplay();
        }

        // FELADATKEZELÕ (TASK LIST) LOGIKA

        // Feladat hozzáadása
        private void btnAddTask_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNewTask.Text))
            {
                lstTasks.Items.Add(txtNewTask.Text.Trim());
                txtNewTask.Clear();

                if (lstTasks.SelectedIndex == -1 && lstTasks.Items.Count > 0)
                {
                    lstTasks.SelectedIndex = 0;
                }
            }
        }

        // Feladat törlése
        private void btnDeleteTask_Click_1(object sender, EventArgs e)
        {
            if (lstTasks.SelectedIndex != -1)
            {
                lstTasks.Items.RemoveAt(lstTasks.SelectedIndex);

                if (lstTasks.Items.Count > 0)
                {
                    lstTasks.SelectedIndex = 0;
                }
            }
        }
    }
}