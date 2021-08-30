
namespace Scheduling_App
{
    partial class AppointmentsForm
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
            this.appointmentDataGridView = new System.Windows.Forms.DataGridView();
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MainLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CustomerIDradioButton = new System.Windows.Forms.RadioButton();
            this.AppointmentTypeRadioButton = new System.Windows.Forms.RadioButton();
            this.DatesRadioButton = new System.Windows.Forms.RadioButton();
            this.CustomerIDlabel = new System.Windows.Forms.Label();
            this.AppointmentTypeLabel = new System.Windows.Forms.Label();
            this.StartDateLabel = new System.Windows.Forms.Label();
            this.EndDateLabel = new System.Windows.Forms.Label();
            this.comboBoxAppointmentType = new System.Windows.Forms.ComboBox();
            this.CustomerIDtextbox = new System.Windows.Forms.TextBox();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // appointmentDataGridView
            // 
            this.appointmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointmentDataGridView.Location = new System.Drawing.Point(12, 56);
            this.appointmentDataGridView.Name = "appointmentDataGridView";
            this.appointmentDataGridView.Size = new System.Drawing.Size(466, 186);
            this.appointmentDataGridView.TabIndex = 0;
            this.appointmentDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.appointmentDataGridView_CellContentClick);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(583, 56);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(164, 41);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(583, 130);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(164, 41);
            this.editButton.TabIndex = 1;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(583, 201);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(164, 41);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(583, 360);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(164, 41);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Back to Main";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search for appointments";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MainLabel
            // 
            this.MainLabel.AutoSize = true;
            this.MainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainLabel.Location = new System.Drawing.Point(235, 9);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(166, 29);
            this.MainLabel.TabIndex = 6;
            this.MainLabel.Text = "Appointments ";
            this.MainLabel.Click += new System.EventHandler(this.MainLabel_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(583, 306);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(164, 42);
            this.searchButton.TabIndex = 7;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Search Type";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // CustomerIDradioButton
            // 
            this.CustomerIDradioButton.AutoSize = true;
            this.CustomerIDradioButton.Location = new System.Drawing.Point(15, 289);
            this.CustomerIDradioButton.Name = "CustomerIDradioButton";
            this.CustomerIDradioButton.Size = new System.Drawing.Size(83, 17);
            this.CustomerIDradioButton.TabIndex = 9;
            this.CustomerIDradioButton.TabStop = true;
            this.CustomerIDradioButton.Text = "Customer ID";
            this.CustomerIDradioButton.UseVisualStyleBackColor = true;
            this.CustomerIDradioButton.CheckedChanged += new System.EventHandler(this.CustomerIDradioButton_CheckedChanged);
            // 
            // AppointmentTypeRadioButton
            // 
            this.AppointmentTypeRadioButton.AutoSize = true;
            this.AppointmentTypeRadioButton.Location = new System.Drawing.Point(15, 337);
            this.AppointmentTypeRadioButton.Name = "AppointmentTypeRadioButton";
            this.AppointmentTypeRadioButton.Size = new System.Drawing.Size(111, 17);
            this.AppointmentTypeRadioButton.TabIndex = 10;
            this.AppointmentTypeRadioButton.TabStop = true;
            this.AppointmentTypeRadioButton.Text = "Appointment Type";
            this.AppointmentTypeRadioButton.UseVisualStyleBackColor = true;
            this.AppointmentTypeRadioButton.CheckedChanged += new System.EventHandler(this.AppointmentTypeRadioButton_CheckedChanged);
            // 
            // DatesRadioButton
            // 
            this.DatesRadioButton.AutoSize = true;
            this.DatesRadioButton.Location = new System.Drawing.Point(15, 384);
            this.DatesRadioButton.Name = "DatesRadioButton";
            this.DatesRadioButton.Size = new System.Drawing.Size(53, 17);
            this.DatesRadioButton.TabIndex = 11;
            this.DatesRadioButton.TabStop = true;
            this.DatesRadioButton.Text = "Dates";
            this.DatesRadioButton.UseVisualStyleBackColor = true;
            this.DatesRadioButton.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // CustomerIDlabel
            // 
            this.CustomerIDlabel.AutoSize = true;
            this.CustomerIDlabel.Location = new System.Drawing.Point(216, 291);
            this.CustomerIDlabel.Name = "CustomerIDlabel";
            this.CustomerIDlabel.Size = new System.Drawing.Size(65, 13);
            this.CustomerIDlabel.TabIndex = 12;
            this.CustomerIDlabel.Text = "Customer ID";
            // 
            // AppointmentTypeLabel
            // 
            this.AppointmentTypeLabel.AutoSize = true;
            this.AppointmentTypeLabel.Location = new System.Drawing.Point(216, 326);
            this.AppointmentTypeLabel.Name = "AppointmentTypeLabel";
            this.AppointmentTypeLabel.Size = new System.Drawing.Size(93, 13);
            this.AppointmentTypeLabel.TabIndex = 13;
            this.AppointmentTypeLabel.Text = "Appointment Type";
            // 
            // StartDateLabel
            // 
            this.StartDateLabel.AutoSize = true;
            this.StartDateLabel.Location = new System.Drawing.Point(216, 361);
            this.StartDateLabel.Name = "StartDateLabel";
            this.StartDateLabel.Size = new System.Drawing.Size(55, 13);
            this.StartDateLabel.TabIndex = 14;
            this.StartDateLabel.Text = "Start Date";
            // 
            // EndDateLabel
            // 
            this.EndDateLabel.AutoSize = true;
            this.EndDateLabel.Location = new System.Drawing.Point(216, 399);
            this.EndDateLabel.Name = "EndDateLabel";
            this.EndDateLabel.Size = new System.Drawing.Size(52, 13);
            this.EndDateLabel.TabIndex = 15;
            this.EndDateLabel.Text = "End Date";
            // 
            // comboBoxAppointmentType
            // 
            this.comboBoxAppointmentType.FormattingEnabled = true;
            this.comboBoxAppointmentType.Location = new System.Drawing.Point(324, 318);
            this.comboBoxAppointmentType.Name = "comboBoxAppointmentType";
            this.comboBoxAppointmentType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAppointmentType.TabIndex = 16;
            this.comboBoxAppointmentType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // CustomerIDtextbox
            // 
            this.CustomerIDtextbox.Location = new System.Drawing.Point(324, 284);
            this.CustomerIDtextbox.Name = "CustomerIDtextbox";
            this.CustomerIDtextbox.Size = new System.Drawing.Size(62, 20);
            this.CustomerIDtextbox.TabIndex = 17;
            this.CustomerIDtextbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(324, 354);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerStartDate.TabIndex = 18;
            this.dateTimePickerStartDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePickerEndDate
            // 
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(324, 393);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerEndDate.TabIndex = 19;
            this.dateTimePickerEndDate.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // AppointmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePickerEndDate);
            this.Controls.Add(this.dateTimePickerStartDate);
            this.Controls.Add(this.CustomerIDtextbox);
            this.Controls.Add(this.comboBoxAppointmentType);
            this.Controls.Add(this.EndDateLabel);
            this.Controls.Add(this.StartDateLabel);
            this.Controls.Add(this.AppointmentTypeLabel);
            this.Controls.Add(this.CustomerIDlabel);
            this.Controls.Add(this.DatesRadioButton);
            this.Controls.Add(this.AppointmentTypeRadioButton);
            this.Controls.Add(this.CustomerIDradioButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.MainLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.appointmentDataGridView);
            this.Name = "AppointmentsForm";
            this.Text = "AppointmentsForm";
            this.Load += new System.EventHandler(this.AppointmentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView appointmentDataGridView;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton CustomerIDradioButton;
        private System.Windows.Forms.RadioButton AppointmentTypeRadioButton;
        private System.Windows.Forms.RadioButton DatesRadioButton;
        private System.Windows.Forms.Label CustomerIDlabel;
        private System.Windows.Forms.Label AppointmentTypeLabel;
        private System.Windows.Forms.Label StartDateLabel;
        private System.Windows.Forms.Label EndDateLabel;
        private System.Windows.Forms.ComboBox comboBoxAppointmentType;
        private System.Windows.Forms.TextBox CustomerIDtextbox;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
    }
}