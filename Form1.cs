using System;
using System.Windows.Forms;
using System.Threading;

namespace TimeTrackerApp
{
    public partial class Form1 : Form
    {

        private System.Windows.Forms.Timer taskTimer; // Using the timer from System.Windows.Forms

        private int timeLeft; // Time remaining until the action is executed

        public Form1()
        {
            InitializeComponent();

            //this.Size = new Size(400, 200); // Increase the window size
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
           this.Icon = new Icon(@"Images/iconsailor.ico");
           // this.Icon = new Icon(Properties.Resources.iconsailor);

            // Create the timer
            taskTimer = new System.Windows.Forms.Timer();
            taskTimer.Interval = 30000; // Set the timer interval (30 seconds)
            taskTimer.Tick += TaskTimer_Tick; // Bind the Tick event handler

            // Create a panel
            Panel backgroundPanel = new Panel();
            backgroundPanel.Size = this.ClientSize; // Set the panel size to match the form's size
            backgroundPanel.Location = new Point(0, 0);
            //backgroundPanel.BackgroundImage = Image.FromFile(@"C:\Users\deuswork\MyWinFormsApp\backsailor.png"); // Set the panel's background image
            backgroundPanel.BackgroundImageLayout = ImageLayout.None; // Keep the original image size

            // Shift the image to the right
            backgroundPanel.Paint += (s, e) =>
            {
                e.Graphics.DrawImage(
                    Image.FromFile(@"Images/backsailor.png"), // Image
                    new Rectangle(250, 40, 90, 130) // Draw the image shifted to the right
                );
            };

            this.Controls.Add(backgroundPanel); // Add the panel to the form

        }

        private void TaskTimer_Tick(object? sender, EventArgs e)

        {
            if (timeLeft > 0)
            {
                timeLeft--; // Decrease the remaining time
                lblResult.Text = $"Time remaining: {timeLeft / 60:D2}:{timeLeft % 60:D2}"; // Format MM:SS
            }
            else
            {
                taskTimer.Stop(); // Stop the timer
                lblResult.Text = "Completed!";
                Application.SetSuspendState(PowerState.Suspend, true, false); // Put the system into sleep mode
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            DateTime startTime = dateTimePickerStart.Value;
            DateTime endTime = dateTimePickerEnd.Value;
            TimeSpan breakTime = TimeSpan.Zero;

            // Breaks (considering the user-provided values)
            if (checkBoxBreakfast.Checked && int.TryParse(textBoxBreakfast.Text, out int breakfastTime))
            {
                breakTime += TimeSpan.FromMinutes(breakfastTime);
            }
            if (checkBoxLunch.Checked && int.TryParse(textBoxLunch.Text, out int lunchTime))
            {
                breakTime += TimeSpan.FromMinutes(lunchTime);
            }
            if (checkBoxDinner.Checked && int.TryParse(textBoxDinner.Text, out int dinnerTime))
            {
                breakTime += TimeSpan.FromMinutes(dinnerTime);
            }

            TimeSpan totalWorkTime = endTime - startTime - breakTime;
            lblResult.Text = $"Total work time: {totalWorkTime.TotalHours:F2} hours";

            // Check for work time limit
            double workTimeLimit = 8;
            if (totalWorkTime.TotalHours > workTimeLimit)
            {
                lblResult.Text += "\nWork time limit exceeded. The computer will be shut down!";
                ShutdownComputer();
            }
            else
            {
                timeLeft = (int)totalWorkTime.TotalMinutes * 60; // Convert total time to seconds
                taskTimer.Start(); // Start the timer
            }

        }

        private void ShutdownComputer()
        {
            var result = MessageBox.Show("Are you sure you want to shut down the computer?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Thread.Sleep(5000); // Wait before shutting down
                System.Diagnostics.Process.Start("shutdown", "/s /f /t 0");
            }
        }
    }
}