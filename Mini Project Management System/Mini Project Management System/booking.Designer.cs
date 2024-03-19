namespace Mini_Project_Management_System
{
    partial class booking
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
            Name = new TextBox();
            Number = new TextBox();
            bookingDate = new DateTimePicker();
            Reserve = new Button();
            Services = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            SuspendLayout();
            // 
            // Name
            // 
            Name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Name.Location = new Point(260, 68);
            Name.Name = "Name";
            Name.PlaceholderText = "Name";
            Name.Size = new Size(100, 29);
            Name.TabIndex = 0;
            // 
            // Number
            // 
            Number.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Number.Location = new Point(448, 68);
            Number.Name = "Number";
            Number.PlaceholderText = "Number";
            Number.Size = new Size(100, 29);
            Number.TabIndex = 1;
            // 
            // bookingDate
            // 
            bookingDate.Location = new Point(284, 174);
            bookingDate.Name = "bookingDate";
            bookingDate.Size = new Size(218, 23);
            bookingDate.TabIndex = 3;
            // 
            // Reserve
            // 
            Reserve.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Reserve.Location = new Point(337, 273);
            Reserve.Name = "Reserve";
            Reserve.Size = new Size(99, 44);
            Reserve.TabIndex = 4;
            Reserve.Text = "Reserve";
            Reserve.UseVisualStyleBackColor = true;
            Reserve.Click += Reserve_Click;
            // 
            // Services
            // 
            Services.FormattingEnabled = true;
            Services.Items.AddRange(new object[] { "Interior ", "Exterior ", "Polish ", "All" });
            Services.Location = new Point(179, 123);
            Services.Name = "Services";
            Services.Size = new Size(121, 23);
            Services.TabIndex = 5;
            Services.Text = "Service";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Regular", "Express" });
            comboBox2.Location = new Point(337, 123);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 6;
            comboBox2.Text = "Service Time ";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Regular", "Premium" });
            comboBox3.Location = new Point(488, 123);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 23);
            comboBox3.TabIndex = 7;
            comboBox3.Text = "Product Quality ";
            // 
            // booking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(Services);
            Controls.Add(Reserve);
            Controls.Add(bookingDate);
            Controls.Add(Number);
            Controls.Add(Name);
            Text = "booking";
            Load += booking_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Name;
        private TextBox Number;
        private DateTimePicker bookingDate;
        private Button Reserve;
        private ComboBox Services;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
    }
}