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
            textBox1 = new TextBox();
            checkedListBox1 = new CheckedListBox();
            button3 = new Button();
            progressBar1 = new ProgressBar();
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(20, 75);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(400, 37);
            textBox1.TabIndex = 2;
            // 
            // checkedListBox1
            // 
            checkedListBox1.Items.AddRange(new object[] { "İtalya", "Fransa", "Going East (Polonya Çek Cumhuriyeti Slovakya Macaristan)", "Road The Black Sea (Romanya Bulgaristan Turkiye)", "Baltic Sea (Estonya Letonya Litvanya Finlandiya Rusya)", "Iberia (Ispanya Portekiz)", "Iskandinavya(Norveç Isveç Danimarka)", "Batı Balkanlar (West Balkans)", "Krone", "Reno modifiye" });
            checkedListBox1.Location = new Point(20, 118);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(400, 220);
            checkedListBox1.TabIndex = 4;
            // 
            // button3
            // 
            button3.Location = new Point(240, 399);
            button3.Name = "button3";
            button3.Size = new Size(180, 49);
            button3.TabIndex = 3;
            button3.Text = "Taşı";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(20, 399);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(180, 49);
            progressBar1.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(20, 20);
            button1.Name = "button1";
            button1.Size = new Size(180, 49);
            button1.TabIndex = 6;
            button1.Text = "Konvoy Öncesi";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(240, 20);
            button2.Name = "button2";
            button2.Size = new Size(180, 49);
            button2.TabIndex = 7;
            button2.Text = "Konvoy Sonrası";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.Location = new Point(20, 344);
            button4.Name = "button4";
            button4.Size = new Size(180, 49);
            button4.TabIndex = 8;
            button4.Text = "Tümünü Seç / Seçimi Kaldır";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(240, 344);
            button5.Name = "button5";
            button5.Size = new Size(180, 49);
            button5.TabIndex = 9;
            button5.Text = "Tüm Harita Dlclerini Seç / Seçimi Kaldır";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(440, 460);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(progressBar1);
            Controls.Add(button3);
            Controls.Add(checkedListBox1);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form2";
            Text = "Ets2dlcedit/2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
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