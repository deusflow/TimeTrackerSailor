namespace TimeTrackerApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null; // Container for components
        private DateTimePicker dateTimePickerStart; // Start time picker
        private DateTimePicker dateTimePickerEnd; // End time picker
        private CheckBox checkBoxBreakfast; // Checkbox for breakfast break
        private CheckBox checkBoxLunch; // Checkbox for lunch break
        private CheckBox checkBoxDinner; // Checkbox for dinner break
        private TextBox textBoxBreakfast; // Input for breakfast duration
        private TextBox textBoxLunch; // Input for lunch duration
        private TextBox textBoxDinner; // Input for dinner duration
        private Button btnCalculate; // Button to start calculation
        private Label lblResult; // Label to display results

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) // Check if resources need to be disposed
            {
                components.Dispose(); // Dispose components
            }
            base.Dispose(disposing); // Call base Dispose method
        }

        private void InitializeComponent()
        {
            this.dateTimePickerStart = new DateTimePicker(); // Initialize start time picker
            this.dateTimePickerEnd = new DateTimePicker(); // Initialize end time picker
            this.checkBoxBreakfast = new CheckBox(); // Initialize breakfast checkbox
            this.checkBoxLunch = new CheckBox(); // Initialize lunch checkbox
            this.checkBoxDinner = new CheckBox(); // Initialize dinner checkbox
            this.textBoxBreakfast = new TextBox(); // Initialize breakfast input
            this.textBoxLunch = new TextBox(); // Initialize lunch input
            this.textBoxDinner = new TextBox(); // Initialize dinner input
            this.btnCalculate = new Button(); // Initialize start button
            this.lblResult = new Label(); // Initialize result label

            this.SuspendLayout(); // Temporarily suspend layout for performance

            // dateTimePickerStart
            this.dateTimePickerStart.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right); // Anchor to top and stretch horizontally
            this.dateTimePickerStart.Format = DateTimePickerFormat.Time; // Use time format
            this.dateTimePickerStart.Location = new System.Drawing.Point(12, 12); // Set position
            this.dateTimePickerStart.Name = "dateTimePickerStart"; // Assign name
            this.dateTimePickerStart.Size = new System.Drawing.Size(300, 250); // Set size

            // dateTimePickerEnd
            this.dateTimePickerEnd.Format = DateTimePickerFormat.Time; // Use time format
            this.dateTimePickerEnd.Location = new System.Drawing.Point(12, 38); // Set position
            this.dateTimePickerEnd.Name = "dateTimePickerEnd"; // Assign name
            this.dateTimePickerEnd.Size = new System.Drawing.Size(200, 20); // Set size

            // checkBoxBreakfast
            this.checkBoxBreakfast.AutoSize = true; // Automatically size to fit content
            this.checkBoxBreakfast.Location = new System.Drawing.Point(12, 64); // Set position
            this.checkBoxBreakfast.Name = "checkBoxBreakfast"; // Assign name
            this.checkBoxBreakfast.Size = new System.Drawing.Size(78, 17); // Set size
            this.checkBoxBreakfast.Text = "Breakfast"; // Set label text
            this.checkBoxBreakfast.UseVisualStyleBackColor = true; // Use default styling

            // checkBoxLunch
            this.checkBoxLunch.AutoSize = true; // Automatically size to fit content
            this.checkBoxLunch.Location = new System.Drawing.Point(12, 87); // Set position
            this.checkBoxLunch.Name = "checkBoxLunch"; // Assign name
            this.checkBoxLunch.Size = new System.Drawing.Size(68, 17); // Set size
            this.checkBoxLunch.Text = "Lunch"; // Set label text
            this.checkBoxLunch.UseVisualStyleBackColor = true; // Use default styling

            // checkBoxDinner
            this.checkBoxDinner.AutoSize = true; // Automatically size to fit content
            this.checkBoxDinner.Location = new System.Drawing.Point(12, 110); // Set position
            this.checkBoxDinner.Name = "checkBoxDinner"; // Assign name
            this.checkBoxDinner.Size = new System.Drawing.Size(69, 17); // Set size
            this.checkBoxDinner.Text = "Dinner"; // Set label text
            this.checkBoxDinner.UseVisualStyleBackColor = true; // Use default styling

            // textBoxBreakfast
            this.textBoxBreakfast.Location = new System.Drawing.Point(100, 64); // Set position
            this.textBoxBreakfast.Name = "textBoxBreakfast"; // Assign name
            this.textBoxBreakfast.Size = new System.Drawing.Size(100, 20); // Set size
            this.textBoxBreakfast.Text = "30"; // Default value for breakfast

            // textBoxLunch
            this.textBoxLunch.Location = new System.Drawing.Point(100, 87); // Set position
            this.textBoxLunch.Name = "textBoxLunch"; // Assign name
            this.textBoxLunch.Size = new System.Drawing.Size(100, 20); // Set size
            this.textBoxLunch.Text = "30"; // Default value for lunch

            // textBoxDinner
            this.textBoxDinner.Location = new System.Drawing.Point(100, 110); // Set position
            this.textBoxDinner.Name = "textBoxDinner"; // Assign name
            this.textBoxDinner.Size = new System.Drawing.Size(100, 20); // Set size
            this.textBoxDinner.Text = "30"; // Default value for dinner

            // btnCalculate
            this.btnCalculate.Location = new System.Drawing.Point(12, 133); // Set position
            this.btnCalculate.Name = "btnCalculate"; // Assign name
            this.btnCalculate.Size = new System.Drawing.Size(200, 23); // Set size
            this.btnCalculate.Text = "Start"; // Button text
            this.btnCalculate.UseVisualStyleBackColor = true; // Use default styling
            this.btnCalculate.Click += new EventHandler(this.btnCalculate_Click); // Add click event handler

            // lblResult
            this.lblResult.AutoSize = true; // Automatically size to fit content
            this.lblResult.Location = new System.Drawing.Point(12, 159); // Set position
            this.lblResult.Name = "lblResult"; // Assign name
            this.lblResult.Size = new System.Drawing.Size(35, 13); // Set size
            this.lblResult.Text = "Result"; // Default label text

            // Form1
            this.ClientSize = new System.Drawing.Size(340, 178); // Set form size
            this.Controls.Add(this.lblResult); // Add result label to form
            this.Controls.Add(this.btnCalculate); // Add calculate button to form
            this.Controls.Add(this.textBoxDinner); // Add dinner input to form
            this.Controls.Add(this.textBoxLunch); // Add lunch input to form
            this.Controls.Add(this.textBoxBreakfast); // Add breakfast input to form
            this.Controls.Add(this.checkBoxDinner); // Add dinner checkbox to form
            this.Controls.Add(this.checkBoxLunch); // Add lunch checkbox to form
            this.Controls.Add(this.checkBoxBreakfast); // Add breakfast checkbox to form
            this.Controls.Add(this.dateTimePickerEnd); // Add end time picker to form
            this.Controls.Add(this.dateTimePickerStart); // Add start time picker to form
            this.Name = "Form1"; // Assign form name
            this.Text = "Time Tracker"; // Set form title
            this.ResumeLayout(false); // Resume layout updates
            this.PerformLayout(); // Apply pending layout changes
        }
    }
}
