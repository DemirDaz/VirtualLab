namespace labaratorija
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.bunifuImageButton1 = new ns1.BunifuImageButton();
            this.txt1 = new ns1.BunifuMaterialTextbox();
            this.txt2 = new ns1.BunifuMaterialTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.loginbtn = new ns1.BunifuThinButton2();
            this.registerbtn = new ns1.BunifuThinButton2();
            this.minimize = new ns1.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
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
            this.bunifuImageButton1.TabIndex = 0;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // txt1
            // 
            this.txt1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txt1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt1.HintForeColor = System.Drawing.Color.Empty;
            this.txt1.HintText = "Username";
            this.txt1.isPassword = false;
            this.txt1.LineFocusedColor = System.Drawing.Color.DarkOrchid;
            this.txt1.LineIdleColor = System.Drawing.Color.Gray;
            this.txt1.LineMouseHoverColor = System.Drawing.Color.DarkOrchid;
            this.txt1.LineThickness = 3;
            this.txt1.Location = new System.Drawing.Point(358, 72);
            this.txt1.Margin = new System.Windows.Forms.Padding(4);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(332, 39);
            this.txt1.TabIndex = 1;
            this.txt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt1.OnValueChanged += new System.EventHandler(this.txt1_OnValueChanged);
            // 
            // txt2
            // 
            this.txt2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txt2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt2.HintForeColor = System.Drawing.Color.Empty;
            this.txt2.HintText = "Password";
            this.txt2.isPassword = true;
            this.txt2.LineFocusedColor = System.Drawing.Color.DarkOrchid;
            this.txt2.LineIdleColor = System.Drawing.Color.Gray;
            this.txt2.LineMouseHoverColor = System.Drawing.Color.DarkOrchid;
            this.txt2.LineThickness = 3;
            this.txt2.Location = new System.Drawing.Point(358, 119);
            this.txt2.Margin = new System.Windows.Forms.Padding(4);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(332, 39);
            this.txt2.TabIndex = 1;
            this.txt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt2.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox1_OnValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::labaratorija.Properties.Resources.usericon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(311, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 39);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::labaratorija.Properties.Resources.passpng;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(311, 119);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 39);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // loginbtn
            // 
            this.loginbtn.ActiveBorderThickness = 2;
            this.loginbtn.ActiveCornerRadius = 20;
            this.loginbtn.ActiveFillColor = System.Drawing.Color.MediumOrchid;
            this.loginbtn.ActiveForecolor = System.Drawing.Color.White;
            this.loginbtn.ActiveLineColor = System.Drawing.Color.DarkOrchid;
            this.loginbtn.BackColor = System.Drawing.Color.Transparent;
            this.loginbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginbtn.BackgroundImage")));
            this.loginbtn.ButtonText = "Login";
            this.loginbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbtn.ForeColor = System.Drawing.Color.DarkViolet;
            this.loginbtn.IdleBorderThickness = 1;
            this.loginbtn.IdleCornerRadius = 20;
            this.loginbtn.IdleFillColor = System.Drawing.Color.LavenderBlush;
            this.loginbtn.IdleForecolor = System.Drawing.Color.DarkViolet;
            this.loginbtn.IdleLineColor = System.Drawing.Color.ForestGreen;
            this.loginbtn.Location = new System.Drawing.Point(371, 188);
            this.loginbtn.Margin = new System.Windows.Forms.Padding(5);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(123, 46);
            this.loginbtn.TabIndex = 3;
            this.loginbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // registerbtn
            // 
            this.registerbtn.ActiveBorderThickness = 2;
            this.registerbtn.ActiveCornerRadius = 20;
            this.registerbtn.ActiveFillColor = System.Drawing.Color.MediumOrchid;
            this.registerbtn.ActiveForecolor = System.Drawing.Color.White;
            this.registerbtn.ActiveLineColor = System.Drawing.Color.DarkOrchid;
            this.registerbtn.BackColor = System.Drawing.Color.Transparent;
            this.registerbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("registerbtn.BackgroundImage")));
            this.registerbtn.ButtonText = "Register";
            this.registerbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerbtn.ForeColor = System.Drawing.Color.DarkViolet;
            this.registerbtn.IdleBorderThickness = 1;
            this.registerbtn.IdleCornerRadius = 20;
            this.registerbtn.IdleFillColor = System.Drawing.Color.LavenderBlush;
            this.registerbtn.IdleForecolor = System.Drawing.Color.DarkViolet;
            this.registerbtn.IdleLineColor = System.Drawing.Color.ForestGreen;
            this.registerbtn.Location = new System.Drawing.Point(532, 188);
            this.registerbtn.Margin = new System.Windows.Forms.Padding(5);
            this.registerbtn.Name = "registerbtn";
            this.registerbtn.Size = new System.Drawing.Size(123, 46);
            this.registerbtn.TabIndex = 3;
            this.registerbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.registerbtn.Click += new System.EventHandler(this.registerbtn_Click);
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
            this.minimize.TabIndex = 0;
            this.minimize.TabStop = false;
            this.minimize.Zoom = 10;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::labaratorija.Properties.Resources.loginnn;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.registerbtn);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.minimize);
            this.Controls.Add(this.bunifuImageButton1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.DarkOrchid;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.LightPink;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ns1.BunifuElipse bunifuElipse1;
        private ns1.BunifuImageButton bunifuImageButton1;
        private ns1.BunifuMaterialTextbox txt2;
        private ns1.BunifuMaterialTextbox txt1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ns1.BunifuThinButton2 registerbtn;
        private ns1.BunifuThinButton2 loginbtn;
        private ns1.BunifuImageButton minimize;
    }
}