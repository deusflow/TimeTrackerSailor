namespace TimeTrackerApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private DateTimePicker dateTimePickerStart;
        private DateTimePicker dateTimePickerEnd;
        private CheckBox checkBoxBreakfast;
        private CheckBox checkBoxLunch;
        private CheckBox checkBoxDinner;
        private TextBox textBoxBreakfast;
        private TextBox textBoxLunch;
        private TextBox textBoxDinner;
        private Button btnCalculate;
        private Label lblResult;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dateTimePickerStart = new DateTimePicker();
            this.dateTimePickerEnd = new DateTimePicker();
            this.checkBoxBreakfast = new CheckBox();
            this.checkBoxLunch = new CheckBox();
            this.checkBoxDinner = new CheckBox();
            this.textBoxBreakfast = new TextBox();
            this.textBoxLunch = new TextBox();
            this.textBoxDinner = new TextBox();
            this.btnCalculate = new Button();
            this.lblResult = new Label();

            this.SuspendLayout();

            // dateTimePickerStart
            this.dateTimePickerStart.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            this.dateTimePickerStart.Format = DateTimePickerFormat.Time;
            this.dateTimePickerStart.Location = new System.Drawing.Point(12, 12);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(300, 250);

            // dateTimePickerEnd
            this.dateTimePickerEnd.Format = DateTimePickerFormat.Time;
            this.dateTimePickerEnd.Location = new System.Drawing.Point(12, 38);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(200, 20);

            // checkBoxBreakfast
            this.checkBoxBreakfast.AutoSize = true;
            this.checkBoxBreakfast.Location = new System.Drawing.Point(12, 64);
            this.checkBoxBreakfast.Name = "checkBoxBreakfast";
            this.checkBoxBreakfast.Size = new System.Drawing.Size(78, 17);
            this.checkBoxBreakfast.Text = "Breakfast";
            this.checkBoxBreakfast.UseVisualStyleBackColor = true;

            // checkBoxLunch
            this.checkBoxLunch.AutoSize = true;
            this.checkBoxLunch.Location = new System.Drawing.Point(12, 87);
            this.checkBoxLunch.Name = "checkBoxLunch";
            this.checkBoxLunch.Size = new System.Drawing.Size(68, 17);
            this.checkBoxLunch.Text = "Lunch";
            this.checkBoxLunch.UseVisualStyleBackColor = true;

            // checkBoxDinner
            this.checkBoxDinner.AutoSize = true;
            this.checkBoxDinner.Location = new System.Drawing.Point(12, 110);
            this.checkBoxDinner.Name = "checkBoxDinner";
            this.checkBoxDinner.Size = new System.Drawing.Size(69, 17);
            this.checkBoxDinner.Text = "Diner";
            this.checkBoxDinner.UseVisualStyleBackColor = true;

            // textBoxBreakfast
            this.textBoxBreakfast.Location = new System.Drawing.Point(100, 64);
            this.textBoxBreakfast.Name = "textBoxBreakfast";
            this.textBoxBreakfast.Size = new System.Drawing.Size(100, 20);
            this.textBoxBreakfast.Text = "30"; // default value in minutes

            // textBoxLunch
            this.textBoxLunch.Location = new System.Drawing.Point(100, 87);
            this.textBoxLunch.Name = "textBoxLunch";
            this.textBoxLunch.Size = new System.Drawing.Size(100, 20);
            this.textBoxLunch.Text = "30"; // default value in minutes

            // textBoxDinner
            this.textBoxDinner.Location = new System.Drawing.Point(100, 110);
            this.textBoxDinner.Name = "textBoxDinner";
            this.textBoxDinner.Size = new System.Drawing.Size(100, 20);
            this.textBoxDinner.Text = "30"; // default value in minutes

            // btnCalculate
            this.btnCalculate.Location = new System.Drawing.Point(12, 133);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(200, 23);
            this.btnCalculate.Text = "Start";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new EventHandler(this.btnCalculate_Click);

            // lblResult
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(12, 159);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(35, 13);
            this.lblResult.Text = "Resut";

            // Form1
            this.ClientSize = new System.Drawing.Size(400, 201);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.textBoxDinner);
            this.Controls.Add(this.textBoxLunch);
            this.Controls.Add(this.textBoxBreakfast);
            this.Controls.Add(this.checkBoxDinner);
            this.Controls.Add(this.checkBoxLunch);
            this.Controls.Add(this.checkBoxBreakfast);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.dateTimePickerStart);
            this.Name = "Form1";
            this.Text = "Time Tracker";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}