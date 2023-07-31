namespace web_tarayıcı_yeni
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.arama_kutusu = new System.Windows.Forms.TextBox();
            this.cikis = new System.Windows.Forms.Button();
            this.ara = new System.Windows.Forms.Button();
            this.yazdir = new System.Windows.Forms.Button();
            this.ev = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.yenile = new System.Windows.Forms.Button();
            this.ileri = new System.Windows.Forms.Button();
            this.geri = new System.Windows.Forms.Button();
            this.tarayici_sayfa = new EO.WinForm.WebControl();
            this.webView1 = new EO.WebBrowser.WebView();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.arama_kutusu);
            this.panel1.Controls.Add(this.cikis);
            this.panel1.Controls.Add(this.ara);
            this.panel1.Controls.Add(this.yazdir);
            this.panel1.Controls.Add(this.ev);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.yenile);
            this.panel1.Controls.Add(this.ileri);
            this.panel1.Controls.Add(this.geri);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1924, 53);
            this.panel1.TabIndex = 0;
            // 
            // arama_kutusu
            // 
            this.arama_kutusu.Location = new System.Drawing.Point(315, 15);
            this.arama_kutusu.Multiline = true;
            this.arama_kutusu.Name = "arama_kutusu";
            this.arama_kutusu.Size = new System.Drawing.Size(1000, 24);
            this.arama_kutusu.TabIndex = 4;
            // 
            // cikis
            // 
            this.cikis.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikis.Location = new System.Drawing.Point(1836, 5);
            this.cikis.Name = "cikis";
            this.cikis.Size = new System.Drawing.Size(85, 41);
            this.cikis.TabIndex = 3;
            this.cikis.Text = "ÇIKIŞ";
            this.cikis.UseVisualStyleBackColor = true;
            this.cikis.Click += new System.EventHandler(this.cikis_Click);
            // 
            // ara
            // 
            this.ara.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ara.Location = new System.Drawing.Point(1335, 5);
            this.ara.Name = "ara";
            this.ara.Size = new System.Drawing.Size(85, 41);
            this.ara.TabIndex = 3;
            this.ara.Text = "Ara";
            this.ara.UseVisualStyleBackColor = true;
            this.ara.Click += new System.EventHandler(this.ara_Click);
            // 
            // yazdir
            // 
            this.yazdir.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yazdir.Location = new System.Drawing.Point(1666, 5);
            this.yazdir.Name = "yazdir";
            this.yazdir.Size = new System.Drawing.Size(85, 41);
            this.yazdir.TabIndex = 3;
            this.yazdir.Text = "YAZDIR";
            this.yazdir.UseVisualStyleBackColor = true;
            this.yazdir.Click += new System.EventHandler(this.yazdir_Click);
            // 
            // ev
            // 
            this.ev.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ev.Location = new System.Drawing.Point(1751, 5);
            this.ev.Name = "ev";
            this.ev.Size = new System.Drawing.Size(85, 41);
            this.ev.TabIndex = 3;
            this.ev.Text = "EV";
            this.ev.UseVisualStyleBackColor = true;
            this.ev.Click += new System.EventHandler(this.ev_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(239, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Arama";
            // 
            // yenile
            // 
            this.yenile.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yenile.Location = new System.Drawing.Point(129, 1);
            this.yenile.Name = "yenile";
            this.yenile.Size = new System.Drawing.Size(73, 49);
            this.yenile.TabIndex = 0;
            this.yenile.Text = "Yenile";
            this.yenile.UseVisualStyleBackColor = true;
            this.yenile.Click += new System.EventHandler(this.yenile_Click);
            // 
            // ileri
            // 
            this.ileri.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ileri.Location = new System.Drawing.Point(66, 1);
            this.ileri.Name = "ileri";
            this.ileri.Size = new System.Drawing.Size(64, 49);
            this.ileri.TabIndex = 0;
            this.ileri.Text = ">";
            this.ileri.UseVisualStyleBackColor = true;
            this.ileri.Click += new System.EventHandler(this.ileri_Click);
            // 
            // geri
            // 
            this.geri.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.geri.Location = new System.Drawing.Point(3, 1);
            this.geri.Name = "geri";
            this.geri.Size = new System.Drawing.Size(64, 49);
            this.geri.TabIndex = 0;
            this.geri.Text = "<";
            this.geri.UseVisualStyleBackColor = true;
            this.geri.Click += new System.EventHandler(this.geri_Click);
            // 
            // tarayici_sayfa
            // 
            this.tarayici_sayfa.BackColor = System.Drawing.Color.White;
            this.tarayici_sayfa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tarayici_sayfa.Location = new System.Drawing.Point(0, 53);
            this.tarayici_sayfa.Name = "tarayici_sayfa";
            this.tarayici_sayfa.Size = new System.Drawing.Size(1924, 1002);
            this.tarayici_sayfa.TabIndex = 1;
            this.tarayici_sayfa.Text = "webControl1";
            this.tarayici_sayfa.WebView = this.webView1;
            // 
            // webView1
            // 
            this.webView1.CanGoBackChanged += new System.EventHandler(this.webView1_CanGoBackChanged);
            this.webView1.CanGoForwardChanged += new System.EventHandler(this.webView1_CanGoForwardChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.tarayici_sayfa);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Tarayıcı";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cikis;
        private System.Windows.Forms.Button ara;
        private System.Windows.Forms.Button ev;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button yenile;
        private System.Windows.Forms.Button ileri;
        private System.Windows.Forms.Button geri;
        private EO.WinForm.WebControl tarayici_sayfa;
        private EO.WebBrowser.WebView webView1;
        private System.Windows.Forms.TextBox arama_kutusu;
        private System.Windows.Forms.Button yazdir;
    }
}

