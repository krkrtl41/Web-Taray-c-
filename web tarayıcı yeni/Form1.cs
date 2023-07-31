using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace web_tarayıcı_yeni
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            webView1.Url = "www.google.com.tr";
            ileri.Enabled = false;
            geri.Enabled = false;
        }

        private void cikis_Click(object sender, EventArgs e)
        { 
            Application.Exit();
        }

        private void ev_Click(object sender, EventArgs e)
        {
            webView1.Url = "www.google.com.tr";
        }

        private void yenile_Click(object sender, EventArgs e)
        {
            webView1.Reload();
        }

        private void geri_Click(object sender, EventArgs e)
        {
            if (webView1.CanGoBack == true)
            {
                webView1.GoBack();
            }
        }
        private void ileri_Click(object sender, EventArgs e)
        {
            if(webView1.CanGoForward == true)
            {
                webView1.GoForward();
            }
        }

        private void ara_Click(object sender, EventArgs e)
        {
            try
            {
                if (arama_kutusu.Text.Trim() == "")
                {
                    MessageBox.Show("Lütfen geçerli bir değer giriniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    webView1.Url = "https://www.google.com/search?q=" + arama_kutusu.Text;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu." + "\n" +  ex.Message,"UYARI",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void webView1_CanGoBackChanged(object sender, EventArgs e)
        {
            if(webView1.CanGoBack == true)
            {
                geri.Enabled = true;
            }
            else
            {
                geri.Enabled = false;
            }
        }

        private void webView1_CanGoForwardChanged(object sender, EventArgs e)
        {
            if (webView1.CanGoForward == true)
            {
                ileri.Enabled = true;
            }
            else
            {
                ileri.Enabled = false;
            }
        }

        private void yazdir_Click(object sender, EventArgs e)
        {
            webView1.Print();
           
        }
    }
}
