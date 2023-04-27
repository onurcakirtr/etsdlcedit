namespace etsdlcedit
{
    partial class Form2
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(20, 75);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(400, 37);
            this.textBox1.TabIndex = 2;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Items.AddRange(new object[] {
            "İtalya",
            "Fransa",
            "Going East (Polonya Çek Cumhuriyeti Slovakya Macaristan)",
            "Road The Black Sea (Romanya Bulgaristan Turkiye)",
            "Baltic Sea (Estonya Letonya Litvanya Finlandiya Rusya)",
            "Iberia (Ispanya Portekiz)",
            "Iskandinavya(Norveç Isveç Danimarka)",
            "Krone",
            "Reno modifiye"});
            this.checkedListBox1.Location = new System.Drawing.Point(20, 118);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(400, 220);
            this.checkedListBox1.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(240, 399);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(180, 49);
            this.button3.TabIndex = 3;
            this.button3.Text = "Taşı";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(20, 399);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(180, 49);
            this.progressBar1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 49);
            this.button1.TabIndex = 6;
            this.button1.Text = "Konvoy Öncesi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(240, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 49);
            this.button2.TabIndex = 7;
            this.button2.Text = "Konvoy Sonrası";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(20, 344);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(180, 49);
            this.button4.TabIndex = 8;
            this.button4.Text = "Tümünü Seç / Seçimi Kaldır";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(240, 344);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(180, 49);
            this.button5.TabIndex = 9;
            this.button5.Text = "Tüm Harita Dlclerini Seç / Seçimi Kaldır";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(440, 460);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.Text = "Ets2dlcedit/2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox textBox1;
        private CheckedListBox checkedListBox1;
        private Button button3;
        private ProgressBar progressBar1;
        private Button button1;
        private Button button2;
        private Button button4;
        private Button button5;
    }
}