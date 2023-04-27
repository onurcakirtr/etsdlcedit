namespace etsdlcedit
{
    public partial class Form1 : Form
    {
        private string kuruluyer = "etsninkuruluolduguyer.txt";
        private string tasincakyer = "dlclerinatildigiyer.txt";
        public Form1()
        {
            InitializeComponent();
            if (File.Exists(kuruluyer))
            {
                string klasor1Yolu = File.ReadAllText(kuruluyer);
                textBox1.Text = klasor1Yolu;
            }
            if (File.Exists(tasincakyer))
            {
                string klasor2Yolu = File.ReadAllText(tasincakyer);
                textBox2.Text = klasor2Yolu;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string klasorYolu = folderBrowserDialog1.SelectedPath;
                textBox1.Text = klasorYolu;
                File.WriteAllText(kuruluyer, klasorYolu);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string klasorYolu = folderBrowserDialog1.SelectedPath;
                textBox2.Text = klasorYolu;
                File.WriteAllText(tasincakyer, klasorYolu);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}