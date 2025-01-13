using System;
using System.Windows.Forms;
using System.Threading;

namespace TimeTrackerApp
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer taskTimer; // Timer to track the countdown
        private int timeLeft; // Time remaining in seconds

        public Form1()
        {
            InitializeComponent(); // Initialize form components

            this.FormBorderStyle = FormBorderStyle.FixedDialog; // Disable resizing
            this.MaximizeBox = false; // Disable maximize button
            this.MinimizeBox = false; // Disable minimize button
            this.StartPosition = FormStartPosition.CenterScreen; // Center the form on screen
            this.Icon = new Icon(@"Images/iconsailor.ico"); // Set the application icon

            taskTimer = new System.Windows.Forms.Timer(); // Initialize the timer
            taskTimer.Interval = 1000; // Set the timer interval to 1 second
            taskTimer.Tick += TaskTimer_Tick; // Assign the Tick event handler

            Panel backgroundPanel = new Panel(); // Create a panel for background
            backgroundPanel.Size = this.ClientSize; // Match panel size with the form
            backgroundPanel.Location = new Point(0, 0); // Set the panel location to top-left
            backgroundPanel.BackgroundImageLayout = ImageLayout.None; // Keep original image size

            // Draw the background image shifted to the right
            backgroundPanel.Paint += (s, e) =>
            {
                e.Graphics.DrawImage(
                    Image.FromFile(@"Images/backsailor.png"), // Load the background image
                    new Rectangle(250, 40, 90, 130) // Set position and size for drawing
                );
            };

            this.Controls.Add(backgroundPanel); // Add the panel to the form
        }

        private void TaskTimer_Tick(object? sender, EventArgs e)
        {
            if (timeLeft > 0) // Check if time is remaining
            {
                timeLeft--; // Decrement time remaining
                lblResult.Text = $"Time remaining: {timeLeft / 60:D2}:{timeLeft % 60:D2}"; // Display time in MM:SS format
            }
            else
            {
                taskTimer.Stop(); // Stop the timer when finished
                lblResult.Text = "Completed!"; // Show completion message
                Application.SetSuspendState(PowerState.Suspend, true, false); // Put the system to sleep
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            DateTime startTime = dateTimePickerStart.Value; // Get start time
            DateTime endTime = dateTimePickerEnd.Value; // Get end time
            TimeSpan breakTime = TimeSpan.Zero; // Initialize total break time

            // Add breakfast time if checked and valid
            if (checkBoxBreakfast.Checked && int.TryParse(textBoxBreakfast.Text, out int breakfastTime))
            {
                breakTime += TimeSpan.FromMinutes(breakfastTime);
            }

            // Add lunch time if checked and valid
            if (checkBoxLunch.Checked && int.TryParse(textBoxLunch.Text, out int lunchTime))
            {
                breakTime += TimeSpan.FromMinutes(lunchTime);
            }

            // Add dinner time if checked and valid
            if (checkBoxDinner.Checked && int.TryParse(textBoxDinner.Text, out int dinnerTime))
            {
                breakTime += TimeSpan.FromMinutes(dinnerTime);
            }

            TimeSpan totalWorkTime = endTime - startTime - breakTime; // Calculate net work time
            lblResult.Text = $"Total work time: {totalWorkTime.TotalHours:F2} hours"; // Display total work time

            double workTimeLimit = 8; // Set work time limit in hours
            if (totalWorkTime.TotalHours > workTimeLimit) // Check if limit exceeded
            {
                lblResult.Text += "\nWork time limit exceeded. The computer will be shut down!";
                ShutdownComputer(); // Shutdown the computer
            }
            else
            {
                timeLeft = (int)totalWorkTime.TotalMinutes * 60; // Convert total work time to seconds
                taskTimer.Start(); // Start the countdown timer
            }
        }

        private void ShutdownComputer()
        {
            // Confirm shutdown from the user
            var result = MessageBox.Show("Are you sure you want to shut down the computer?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) // If user confirms
            {
                Thread.Sleep(5000); // Delay before shutting down
                System.Diagnostics.Process.Start("shutdown", "/s /f /t 0"); // Execute shutdown command
            }
        }
    }
}
