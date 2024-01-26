using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace etsdlcedit
{
    public partial class Form2 : Form
    {
        private string kuruluyer = "etsninkuruluolduguyer.txt";
        private string tasincakyer = "dlclerinatildigiyer.txt";
        private string karar = "karar.txt";
        public Form2()
        {
            InitializeComponent();

            if (File.Exists(karar))
            {
                string klasorYolu = File.ReadAllText(karar);
                textBox1.Text = klasorYolu;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string karar1 = "Konvoy Öncesi";
            textBox1.Text = karar1;
            File.WriteAllText(karar, karar1);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string karar1 = "Konvoy Sonrası";
            textBox1.Text = karar1;
            File.WriteAllText(karar, karar1);
        }
        private void button3_Click(object sender, EventArgs e)
        {

            progressBar1.Minimum = 0;
            progressBar1.Maximum = checkedListBox1.CheckedItems.Count;
            progressBar1.Value = 0;
            string karar = "karar.txt";
            if (File.Exists(karar))
            {
                string karar1 = File.ReadAllText(karar);
                if (karar1 == "Konvoy Öncesi")
                {
                    string kaynak = File.ReadAllText(kuruluyer);
                    string hedef = File.ReadAllText(tasincakyer);
                    tasima(kaynak, hedef);
                }
                if (karar1 == "Konvoy Sonrası")
                {
                    string hedef = File.ReadAllText(kuruluyer);
                    string kaynak = File.ReadAllText(tasincakyer);
                    tasima(kaynak, hedef);
                }
            }
            else
            {
                MessageBox.Show("Karar dosyası yok.");
                return;
            }
        }
        public void tasima(string kaynak, string hedef)
        {
            var selectedItems = checkedListBox1.CheckedItems;
            foreach (var selectedItem in selectedItems)
            {
                switch (selectedItem.ToString())
                {
                    case "İtalya":
                        string file = "dlc_it.scs";
                        string sourceFile = Path.Combine(kaynak, file);
                        string destFile = Path.Combine(hedef, file);
                        File.Move(sourceFile, destFile);
                        progressBar1.Value++;
                        break;
                    case "Fransa":
                        string file2 = "dlc_fr.scs";
                        string sourceFile2 = Path.Combine(kaynak, file2);
                        string destFile2 = Path.Combine(hedef, file2);
                        File.Move(sourceFile2, destFile2);
                        progressBar1.Value++;
                        break;
                    case "Going East (Polonya Çek Cumhuriyeti Slovakya Macaristan)":
                        string file3 = "dlc_east.scs";
                        string sourceFile3 = Path.Combine(kaynak, file3);
                        string destFile3 = Path.Combine(hedef, file3);
                        File.Move(sourceFile3, destFile3);
                        progressBar1.Value++;
                        break;
                    case "Road The Black Sea (Romanya Bulgaristan Turkiye)":
                        string file4 = "dlc_balkan_e.scs";
                        string sourceFile4 = Path.Combine(kaynak, file4);
                        string destFile4 = Path.Combine(hedef, file4);
                        File.Move(sourceFile4, destFile4);
                        progressBar1.Value++;
                        break;
                    case "Baltic Sea (Estonya Letonya Litvanya Finlandiya Rusya)":
                        string file5 = "dlc_balt.scs";
                        string sourceFile5 = Path.Combine(kaynak, file5);
                        string destFile5 = Path.Combine(hedef, file5);
                        File.Move(sourceFile5, destFile5);
                        progressBar1.Value++;
                        break;
                    case "Iberia (Ispanya Portekiz)":
                        string file6 = "dlc_iberia.scs";
                        string sourceFile6 = Path.Combine(kaynak, file6);
                        string destFile6 = Path.Combine(hedef, file6);
                        File.Move(sourceFile6, destFile6);
                        progressBar1.Value++;
                        break;
                    case "Iskandinavya(Norveç Isveç Danimarka)":
                        string file7 = "dlc_north.scs";
                        string sourceFile7 = Path.Combine(kaynak, file7);
                        string destFile7 = Path.Combine(hedef, file7);
                        File.Move(sourceFile7, destFile7);
                        progressBar1.Value++;
                        break;
                    case "Batı Balkanlar (West Balkans)":
                        string file8 = "dlc_balkan_w.scs";
                        string sourceFile8 = Path.Combine(kaynak, file8);
                        string destFile8 = Path.Combine(hedef, file8);
                        File.Move(sourceFile8, destFile8);
                        progressBar1.Value++;
                        break;
                    case "Krone":
                        string file9 = "dlc_krone.scs";
                        string sourceFile9 = Path.Combine(kaynak, file9);
                        string destFile9 = Path.Combine(hedef, file9);
                        File.Move(sourceFile9, destFile9);
                        progressBar1.Value++;
                        break;
                    case "Reno modifiye":
                        string file10 = "dlc_renault_t_tuning.scs";
                        string sourceFile10 = Path.Combine(kaynak, file10);
                        string destFile10 = Path.Combine(hedef, file10);
                        File.Move(sourceFile10, destFile10);
                        progressBar1.Value++;
                        break;
                    default:
                        break;
                }
            }
            Process.Start("explorer.exe", kaynak);
            Process.Start("explorer.exe", hedef);
        }
        private bool first7Selected = false;
        private bool allSelected = false;
        private void button4_Click(object sender, EventArgs e)
        {
            if (!allSelected)
            {
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    checkedListBox1.SetItemChecked(i, true);
                }
                allSelected = true;
            }
            else
            {
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    checkedListBox1.SetItemChecked(i, false);
                }
                allSelected = false;
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (!first7Selected)
            {
                for (int i = 0; i < 8; i++)
                {
                    checkedListBox1.SetItemChecked(i, true);
                }
                first7Selected = true;
            }
            else
            {
                for (int i = 0; i < 8; i++)
                {
                    checkedListBox1.SetItemChecked(i, false);
                }
                first7Selected = false;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;
        }
    }
}