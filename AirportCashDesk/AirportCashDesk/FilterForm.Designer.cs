namespace AirportCashDesk
{
    partial class FilterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtDestination = new TextBox();
            dateTimePicker = new DateTimePicker();
            btnApplyFilter = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 30);
            label1.Name = "label1";
            label1.Size = new Size(199, 20);
            label1.TabIndex = 0;
            label1.Text = "Введіть пункт призначення";
            // 
            // txtDestination
            // 
            txtDestination.Location = new Point(33, 67);
            txtDestination.Name = "txtDestination";
            txtDestination.Size = new Size(193, 27);
            txtDestination.TabIndex = 1;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(36, 123);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(250, 27);
            dateTimePicker.TabIndex = 2;
            // 
            // btnApplyFilter
            // 
            btnApplyFilter.Location = new Point(36, 175);
            btnApplyFilter.Name = "btnApplyFilter";
            btnApplyFilter.Size = new Size(94, 29);
            btnApplyFilter.TabIndex = 3;
            btnApplyFilter.Text = "button1";
            btnApplyFilter.UseVisualStyleBackColor = true;
            btnApplyFilter.Click += btnApplyFilter_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(36, 245);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "button1";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // FilterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnApplyFilter);
            Controls.Add(dateTimePicker);
            Controls.Add(txtDestination);
            Controls.Add(label1);
            Name = "FilterForm";
            Text = "FilterForm";
            Load += FilterForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtDestination;
        private DateTimePicker dateTimePicker;
        private Button btnApplyFilter;
        private Button btnCancel;
    }
}