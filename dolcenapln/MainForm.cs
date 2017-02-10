using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dolcenapln
{


    public partial class MainForm : Form
    {
        About pomocokno = new About();
        float stawkaUSD, cenaUSD, cenaPLN;
        String dec_separator = ""+Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
        private String wrong_decsep;

        public MainForm()
        {
            InitializeComponent();
         }

        private void MainForm_Load(object sender, EventArgs e)
        {
            zawszeNaWierzchuToolStripMenuItem.Checked = true;
            this.TopMost = true;
            this.Opacity = 1;
            if (dec_separator == ".") wrong_decsep = ",";
            else if (dec_separator == ",") wrong_decsep = ".";
            
            stawkaUSD_textbox.Text = Load_USD_rate("USD_rate.txt"); //tu juz zmaineia , i . na decsep
            stawkaUSD = float.Parse(stawkaUSD_textbox.Text);
            cenaUSD = float.Parse(cenaUSD_textbox.Text);
            cenaPLN = stawkaUSD * cenaUSD;
            cenaPLN_textbox.Text = cenaPLN.ToString();
        }

        private String Load_USD_rate(String filename)
        {
            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader(filename))
                {
                    // Read the stream to a string, and write the string to the console.
                    String line = sr.ReadToEnd();
                    return line.Replace(wrong_decsep, dec_separator);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            return "4.00";
        }

        private void Save_USD_rate(String filename)
        {
            FileStream file = new FileStream(filename, FileMode.Create);
            using (StreamWriter sr = new StreamWriter(file, System.Text.Encoding.UTF8))
            {
                String str = stawkaUSD_textbox.Text;
                sr.Write(str);
            }
            file.Close();

        }

        void przeliczUSDnaPLN()
        {
            if (
                (stawkaUSD_textbox.Text != "") &&
                (cenaUSD_textbox.Text != "") &&
                (cenaPLN_textbox.Text != "")
                )
            {
                stawkaUSD = float.Parse(stawkaUSD_textbox.Text.Replace(wrong_decsep, dec_separator));
                cenaUSD = float.Parse(cenaUSD_textbox.Text.Replace(wrong_decsep, dec_separator));
                cenaPLN = stawkaUSD * cenaUSD;
                cenaPLN_textbox.Text = cenaPLN.ToString();
                }
        }

        void przeliczPLNnaUSD()
        {
            if (
                (stawkaUSD_textbox.Text != "") &&
                (cenaUSD_textbox.Text != "") &&
                (cenaPLN_textbox.Text != "")
                )
            {
                stawkaUSD = float.Parse(stawkaUSD_textbox.Text.Replace(wrong_decsep, dec_separator));
                cenaPLN = float.Parse(cenaPLN_textbox.Text.Replace(wrong_decsep, dec_separator));
                cenaUSD = stawkaUSD / cenaPLN;
                cenaUSD_textbox.Text = cenaUSD.ToString();
            }
        }
        
        
        private void stawkaUSD_textbox_TextChanged(object sender, EventArgs e)
        {
            przeliczUSDnaPLN();
        }

        private void cenaUSD_textbox_TextChanged(object sender, EventArgs e)
        {
            przeliczUSDnaPLN();
        }

        private void cenaPLN_textbox_TextChanged(object sender, EventArgs e)
        {
            //przeliczPLNnaUSD();
        }

        private void zawszeNaWierzchuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zawszeNaWierzchuToolStripMenuItem.Checked = !(zawszeNaWierzchuToolStripMenuItem.Checked);
            if (zawszeNaWierzchuToolStripMenuItem.Checked == true)
            {
                this.TopMost = true;
            }
            else {
                this.TopMost = false;
            }
        }

        private void zamknijToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void cenaUSD_textbox_MouseHover(object sender, EventArgs e)
        {
        }

        private void btnSaveRate_Click(object sender, EventArgs e)
        {
            Save_USD_rate("USD_rate.txt");
        }

        private void btnAlwaysOnTop_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (this.TopMost)
            {
                this.TopMost = false;
                btn.BackgroundImage = dolcenapln.Properties.Resources._678093_pin_128inactive;
            }
            else
            {
                this.TopMost = true;
                btn.BackgroundImage = dolcenapln.Properties.Resources._678093_pin_128active;
            }

        }

        private void przezroczystość75ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            przezroczystość75ToolStripMenuItem.Checked = !(przezroczystość75ToolStripMenuItem.Checked);
            if (przezroczystość75ToolStripMenuItem.Checked == true)
            {
                this.Opacity = 0.75;
            }
            else
            {
                this.Opacity = 1;
            }
        }

        private void kubaMiszcz2015ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pomocokno.Show();
        }



    }
}
