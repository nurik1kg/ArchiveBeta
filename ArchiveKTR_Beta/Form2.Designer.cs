namespace ArchiveKTR_Beta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.textPassword = new Bunifu.Framework.UI.BunifuTextbox();
            this.textEmail = new Bunifu.Framework.UI.BunifuTextbox();
            this.buttonSignin = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureClose = new System.Windows.Forms.PictureBox();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.bunifuGradientPanel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.pictureClose);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel1);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox1);
            this.bunifuGradientPanel1.Controls.Add(this.textPassword);
            this.bunifuGradientPanel1.Controls.Add(this.textEmail);
            this.bunifuGradientPanel1.Controls.Add(this.buttonSignin);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Navy;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.SeaGreen;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.SeaGreen;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Violet;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(393, 402);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // textPassword
            // 
            this.textPassword.BackColor = System.Drawing.Color.White;
            this.textPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("textPassword.BackgroundImage")));
            this.textPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.textPassword.ForeColor = System.Drawing.Color.SeaGreen;
            this.textPassword.Icon = ((System.Drawing.Image)(resources.GetObject("textPassword.Icon")));
            this.textPassword.Location = new System.Drawing.Point(86, 230);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(232, 42);
            this.textPassword.TabIndex = 3;
            this.textPassword.text = "password";
            this.textPassword.OnTextChange += new System.EventHandler(this.bunifuTextbox2_OnTextChange);
            // 
            // textEmail
            // 
            this.textEmail.BackColor = System.Drawing.Color.White;
            this.textEmail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("textEmail.BackgroundImage")));
            this.textEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.textEmail.ForeColor = System.Drawing.Color.SeaGreen;
            this.textEmail.Icon = ((System.Drawing.Image)(resources.GetObject("textEmail.Icon")));
            this.textEmail.Location = new System.Drawing.Point(86, 182);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(232, 42);
            this.textEmail.TabIndex = 2;
            this.textEmail.text = "email";
            this.textEmail.OnTextChange += new System.EventHandler(this.bunifuTextbox1_OnTextChange);
            // 
            // buttonSignin
            // 
            this.buttonSignin.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttonSignin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttonSignin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSignin.BorderRadius = 0;
            this.buttonSignin.ButtonText = "                               Вход";
            this.buttonSignin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSignin.DisabledColor = System.Drawing.Color.Gray;
            this.buttonSignin.Font = new System.Drawing.Font("Segoe UI Light", 8.25F);
            this.buttonSignin.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonSignin.Iconimage = ((System.Drawing.Image)(resources.GetObject("buttonSignin.Iconimage")));
            this.buttonSignin.Iconimage_right = null;
            this.buttonSignin.Iconimage_right_Selected = null;
            this.buttonSignin.Iconimage_Selected = null;
            this.buttonSignin.IconMarginLeft = 0;
            this.buttonSignin.IconMarginRight = 0;
            this.buttonSignin.IconRightVisible = true;
            this.buttonSignin.IconRightZoom = 0D;
            this.buttonSignin.IconVisible = false;
            this.buttonSignin.IconZoom = 90D;
            this.buttonSignin.IsTab = false;
            this.buttonSignin.Location = new System.Drawing.Point(86, 284);
            this.buttonSignin.Name = "buttonSignin";
            this.buttonSignin.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttonSignin.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.buttonSignin.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonSignin.selected = false;
            this.buttonSignin.Size = new System.Drawing.Size(232, 48);
            this.buttonSignin.TabIndex = 0;
            this.buttonSignin.Text = "                               Вход";
            this.buttonSignin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSignin.Textcolor = System.Drawing.Color.White;
            this.buttonSignin.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSignin.Click += new System.EventHandler(this.buttonSignin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(141, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 26F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(142, 111);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(129, 42);
            this.bunifuCustomLabel1.TabIndex = 5;
            this.bunifuCustomLabel1.Text = "Архив";
            // 
            // pictureClose
            // 
            this.pictureClose.BackColor = System.Drawing.Color.Transparent;
            this.pictureClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureClose.Image")));
            this.pictureClose.Location = new System.Drawing.Point(365, 7);
            this.pictureClose.Name = "pictureClose";
            this.pictureClose.Size = new System.Drawing.Size(18, 21);
            this.pictureClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureClose.TabIndex = 6;
            this.pictureClose.TabStop = false;
            this.pictureClose.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 402);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuTextbox textEmail;
        private Bunifu.Framework.UI.BunifuFlatButton buttonSignin;
        private Bunifu.Framework.UI.BunifuTextbox textPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.PictureBox pictureClose;
    }
}