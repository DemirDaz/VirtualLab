namespace labaratorija
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
            this.components = new System.ComponentModel.Container();
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.oGLED1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oGLED2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bodovi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bodovibox = new ns1.BunifuMaterialTextbox();
            this.Naslov = new System.Windows.Forms.Label();
            this.bunifuImageButton3 = new ns1.BunifuImageButton();
            this.bunifuImageButton2 = new ns1.BunifuImageButton();
            this.bunifuImageButton1 = new ns1.BunifuImageButton();
            this.minimize = new ns1.BunifuImageButton();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oGLED1ToolStripMenuItem,
            this.oGLED2ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MinimumSize = new System.Drawing.Size(1000, 75);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1000, 75);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // oGLED1ToolStripMenuItem
            // 
            this.oGLED1ToolStripMenuItem.BackColor = System.Drawing.Color.MediumOrchid;
            this.oGLED1ToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oGLED1ToolStripMenuItem.Name = "oGLED1ToolStripMenuItem";
            this.oGLED1ToolStripMenuItem.Size = new System.Drawing.Size(85, 71);
            this.oGLED1ToolStripMenuItem.Text = "OGLED 1";
            this.oGLED1ToolStripMenuItem.Click += new System.EventHandler(this.oGLED1ToolStripMenuItem_Click);
            // 
            // oGLED2ToolStripMenuItem
            // 
            this.oGLED2ToolStripMenuItem.BackColor = System.Drawing.Color.Gold;
            this.oGLED2ToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oGLED2ToolStripMenuItem.Name = "oGLED2ToolStripMenuItem";
            this.oGLED2ToolStripMenuItem.Size = new System.Drawing.Size(85, 71);
            this.oGLED2ToolStripMenuItem.Text = "OGLED 2";
            this.oGLED2ToolStripMenuItem.Click += new System.EventHandler(this.oGLED2ToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(1, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(999, 792);
            this.panel1.TabIndex = 2;
            // 
            // bodovi
            // 
            this.bodovi.AutoSize = true;
            this.bodovi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bodovi.Location = new System.Drawing.Point(177, 32);
            this.bodovi.Name = "bodovi";
            this.bodovi.Size = new System.Drawing.Size(68, 20);
            this.bodovi.TabIndex = 3;
            this.bodovi.Text = "Bodovi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(804, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 3;
            // 
            // bodovibox
            // 
            this.bodovibox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bodovibox.Enabled = false;
            this.bodovibox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.bodovibox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bodovibox.HintForeColor = System.Drawing.Color.Empty;
            this.bodovibox.HintText = "";
            this.bodovibox.isPassword = false;
            this.bodovibox.LineFocusedColor = System.Drawing.Color.Blue;
            this.bodovibox.LineIdleColor = System.Drawing.Color.Gray;
            this.bodovibox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bodovibox.LineThickness = 3;
            this.bodovibox.Location = new System.Drawing.Point(240, 32);
            this.bodovibox.Margin = new System.Windows.Forms.Padding(4);
            this.bodovibox.Name = "bodovibox";
            this.bodovibox.Size = new System.Drawing.Size(40, 20);
            this.bodovibox.TabIndex = 4;
            this.bodovibox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bodovibox.OnValueChanged += new System.EventHandler(this.bodovibox_OnValueChanged);
            // 
            // Naslov
            // 
            this.Naslov.AutoSize = true;
            this.Naslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Naslov.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Naslov.Location = new System.Drawing.Point(287, 28);
            this.Naslov.Name = "Naslov";
            this.Naslov.Size = new System.Drawing.Size(457, 24);
            this.Naslov.TabIndex = 5;
            this.Naslov.Text = "Obojenje plamena jonima zemnoalkalnih metala";
            this.Naslov.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Naslov.Visible = false;
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bunifuImageButton3.Image = global::labaratorija.Properties.Resources.questionmark2;
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.Location = new System.Drawing.Point(750, 12);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new System.Drawing.Size(55, 50);
            this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton3.TabIndex = 10;
            this.bunifuImageButton3.TabStop = false;
            this.bunifuImageButton3.Zoom = 10;
            this.bunifuImageButton3.Click += new System.EventHandler(this.bunifuImageButton3_Click);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bunifuImageButton2.Image = global::labaratorija.Properties.Resources.stampac;
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(811, 12);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(55, 50);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 10;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bunifuImageButton1.Image = global::labaratorija.Properties.Resources.DugmeGasi;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(933, 12);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(55, 50);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 1;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click_1);
            // 
            // minimize
            // 
            this.minimize.BackColor = System.Drawing.Color.Transparent;
            this.minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.minimize.Image = global::labaratorija.Properties.Resources.minbutton;
            this.minimize.ImageActive = null;
            this.minimize.Location = new System.Drawing.Point(872, 12);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(55, 50);
            this.minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimize.TabIndex = 11;
            this.minimize.TabStop = false;
            this.minimize.Zoom = 10;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 870);
            this.Controls.Add(this.minimize);
            this.Controls.Add(this.bunifuImageButton3);
            this.Controls.Add(this.bunifuImageButton2);
            this.Controls.Add(this.Naslov);
            this.Controls.Add(this.bodovibox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bodovi);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ns1.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem oGLED1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oGLED2ToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private ns1.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label bodovi;
        public ns1.BunifuMaterialTextbox bodovibox;
        private System.Windows.Forms.Label Naslov;
        private ns1.BunifuImageButton bunifuImageButton2;
        private ns1.BunifuImageButton bunifuImageButton3;
        private ns1.BunifuImageButton minimize;
    }
}