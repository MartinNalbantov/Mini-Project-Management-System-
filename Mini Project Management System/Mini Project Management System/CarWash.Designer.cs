namespace Mini_Project_Management_System
{
    partial class CarWash
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
            Services = new ComboBox();
            timeService = new ComboBox();
            Price = new ComboBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            productQuality = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Services
            // 
            Services.FormattingEnabled = true;
            Services.Items.AddRange(new object[] { "Interior ", "Exterior ", "Polish ", "All" });
            Services.Location = new Point(90, 84);
            Services.Name = "Services";
            Services.Size = new Size(121, 23);
            Services.TabIndex = 0;
            Services.Text = "Services";
            // 
            // timeService
            // 
            timeService.FormattingEnabled = true;
            timeService.Items.AddRange(new object[] { "Regular", "Express" });
            timeService.Location = new Point(290, 84);
            timeService.Name = "timeService";
            timeService.Size = new Size(121, 23);
            timeService.TabIndex = 1;
            timeService.Text = "Time of Service";
            // 
            // Price
            // 
            Price.FormattingEnabled = true;
            Price.Location = new Point(643, 84);
            Price.Name = "Price";
            Price.Size = new Size(121, 23);
            Price.TabIndex = 2;
            Price.Text = "Price";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(138, 127);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(565, 221);
            dataGridView1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(441, 354);
            button1.Name = "button1";
            button1.Size = new Size(93, 40);
            button1.TabIndex = 4;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button2.Location = new Point(290, 354);
            button2.Name = "button2";
            button2.Size = new Size(100, 40);
            button2.TabIndex = 5;
            button2.Text = "Clear All";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button3.Location = new Point(350, 401);
            button3.Name = "button3";
            button3.Size = new Size(124, 37);
            button3.TabIndex = 6;
            button3.Text = " Book a Date";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // productQuality
            // 
            productQuality.FormattingEnabled = true;
            productQuality.Items.AddRange(new object[] { "Regular ", "Premium " });
            productQuality.Location = new Point(480, 84);
            productQuality.Name = "productQuality";
            productQuality.Size = new Size(121, 23);
            productQuality.TabIndex = 7;
            productQuality.Text = "Product Quality";
            // 
            // CarWash
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(productQuality);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(Price);
            Controls.Add(timeService);
            Controls.Add(Services);
            Name = "CarWash";
            Text = "CarWash";
            Load += CarWash_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox Services;
        private ComboBox timeService;
        private ComboBox Price;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private ComboBox productQuality;
    }
}