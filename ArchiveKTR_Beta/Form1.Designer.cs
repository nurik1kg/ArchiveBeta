namespace ArchiveKTR_Beta
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuExit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.menuHelp = new Bunifu.Framework.UI.BunifuFlatButton();
            this.menuSearch = new Bunifu.Framework.UI.BunifuFlatButton();
            this.manuAdd = new Bunifu.Framework.UI.BunifuFlatButton();
            this.manuList = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.archiveInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.archiveTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox1);
            this.bunifuGradientPanel1.Controls.Add(this.menuExit);
            this.bunifuGradientPanel1.Controls.Add(this.menuHelp);
            this.bunifuGradientPanel1.Controls.Add(this.menuSearch);
            this.bunifuGradientPanel1.Controls.Add(this.manuAdd);
            this.bunifuGradientPanel1.Controls.Add(this.manuList);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(177)))), ((int)(((byte)(231)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(31)))), ((int)(((byte)(141)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(65)))), ((int)(((byte)(154)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(228, 449);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(62, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // menuExit
            // 
            this.menuExit.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.menuExit.BackColor = System.Drawing.Color.Transparent;
            this.menuExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuExit.BorderRadius = 0;
            this.menuExit.ButtonText = "          Закрыть";
            this.menuExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuExit.DisabledColor = System.Drawing.Color.Gray;
            this.menuExit.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuExit.Iconcolor = System.Drawing.Color.Transparent;
            this.menuExit.Iconimage = ((System.Drawing.Image)(resources.GetObject("menuExit.Iconimage")));
            this.menuExit.Iconimage_right = null;
            this.menuExit.Iconimage_right_Selected = null;
            this.menuExit.Iconimage_Selected = null;
            this.menuExit.IconMarginLeft = 0;
            this.menuExit.IconMarginRight = 0;
            this.menuExit.IconRightVisible = true;
            this.menuExit.IconRightZoom = 0D;
            this.menuExit.IconVisible = false;
            this.menuExit.IconZoom = 90D;
            this.menuExit.IsTab = true;
            this.menuExit.Location = new System.Drawing.Point(0, 302);
            this.menuExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.menuExit.Name = "menuExit";
            this.menuExit.Normalcolor = System.Drawing.Color.Transparent;
            this.menuExit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.menuExit.OnHoverTextColor = System.Drawing.Color.White;
            this.menuExit.selected = false;
            this.menuExit.Size = new System.Drawing.Size(228, 45);
            this.menuExit.TabIndex = 5;
            this.menuExit.Text = "          Закрыть";
            this.menuExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuExit.Textcolor = System.Drawing.Color.White;
            this.menuExit.TextFont = new System.Drawing.Font("Segoe UI Light", 13.75F);
            this.menuExit.Click += new System.EventHandler(this.bunifuFlatButton5_Click);
            // 
            // menuHelp
            // 
            this.menuHelp.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.menuHelp.BackColor = System.Drawing.Color.Transparent;
            this.menuHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuHelp.BorderRadius = 0;
            this.menuHelp.ButtonText = "          Помощь";
            this.menuHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuHelp.DisabledColor = System.Drawing.Color.Gray;
            this.menuHelp.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuHelp.Iconcolor = System.Drawing.Color.Transparent;
            this.menuHelp.Iconimage = ((System.Drawing.Image)(resources.GetObject("menuHelp.Iconimage")));
            this.menuHelp.Iconimage_right = null;
            this.menuHelp.Iconimage_right_Selected = null;
            this.menuHelp.Iconimage_Selected = null;
            this.menuHelp.IconMarginLeft = 0;
            this.menuHelp.IconMarginRight = 0;
            this.menuHelp.IconRightVisible = true;
            this.menuHelp.IconRightZoom = 0D;
            this.menuHelp.IconVisible = false;
            this.menuHelp.IconZoom = 90D;
            this.menuHelp.IsTab = true;
            this.menuHelp.Location = new System.Drawing.Point(0, 257);
            this.menuHelp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Normalcolor = System.Drawing.Color.Transparent;
            this.menuHelp.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.menuHelp.OnHoverTextColor = System.Drawing.Color.White;
            this.menuHelp.selected = false;
            this.menuHelp.Size = new System.Drawing.Size(228, 45);
            this.menuHelp.TabIndex = 4;
            this.menuHelp.Text = "          Помощь";
            this.menuHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuHelp.Textcolor = System.Drawing.Color.White;
            this.menuHelp.TextFont = new System.Drawing.Font("Segoe UI Light", 13.75F);
            // 
            // menuSearch
            // 
            this.menuSearch.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.menuSearch.BackColor = System.Drawing.Color.Transparent;
            this.menuSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuSearch.BorderRadius = 0;
            this.menuSearch.ButtonText = "          Поиск";
            this.menuSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuSearch.DisabledColor = System.Drawing.Color.Gray;
            this.menuSearch.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuSearch.Iconcolor = System.Drawing.Color.Transparent;
            this.menuSearch.Iconimage = ((System.Drawing.Image)(resources.GetObject("menuSearch.Iconimage")));
            this.menuSearch.Iconimage_right = null;
            this.menuSearch.Iconimage_right_Selected = null;
            this.menuSearch.Iconimage_Selected = null;
            this.menuSearch.IconMarginLeft = 0;
            this.menuSearch.IconMarginRight = 0;
            this.menuSearch.IconRightVisible = true;
            this.menuSearch.IconRightZoom = 0D;
            this.menuSearch.IconVisible = false;
            this.menuSearch.IconZoom = 90D;
            this.menuSearch.IsTab = true;
            this.menuSearch.Location = new System.Drawing.Point(0, 212);
            this.menuSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.menuSearch.Name = "menuSearch";
            this.menuSearch.Normalcolor = System.Drawing.Color.Transparent;
            this.menuSearch.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.menuSearch.OnHoverTextColor = System.Drawing.Color.White;
            this.menuSearch.selected = false;
            this.menuSearch.Size = new System.Drawing.Size(228, 45);
            this.menuSearch.TabIndex = 3;
            this.menuSearch.Text = "          Поиск";
            this.menuSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuSearch.Textcolor = System.Drawing.Color.White;
            this.menuSearch.TextFont = new System.Drawing.Font("Segoe UI Light", 13.75F);
            // 
            // manuAdd
            // 
            this.manuAdd.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.manuAdd.BackColor = System.Drawing.Color.Transparent;
            this.manuAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.manuAdd.BorderRadius = 0;
            this.manuAdd.ButtonText = "          Добавить";
            this.manuAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.manuAdd.DisabledColor = System.Drawing.Color.Gray;
            this.manuAdd.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manuAdd.Iconcolor = System.Drawing.Color.Transparent;
            this.manuAdd.Iconimage = ((System.Drawing.Image)(resources.GetObject("manuAdd.Iconimage")));
            this.manuAdd.Iconimage_right = null;
            this.manuAdd.Iconimage_right_Selected = null;
            this.manuAdd.Iconimage_Selected = null;
            this.manuAdd.IconMarginLeft = 0;
            this.manuAdd.IconMarginRight = 0;
            this.manuAdd.IconRightVisible = true;
            this.manuAdd.IconRightZoom = 0D;
            this.manuAdd.IconVisible = false;
            this.manuAdd.IconZoom = 90D;
            this.manuAdd.IsTab = true;
            this.manuAdd.Location = new System.Drawing.Point(0, 167);
            this.manuAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.manuAdd.Name = "manuAdd";
            this.manuAdd.Normalcolor = System.Drawing.Color.Transparent;
            this.manuAdd.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.manuAdd.OnHoverTextColor = System.Drawing.Color.White;
            this.manuAdd.selected = false;
            this.manuAdd.Size = new System.Drawing.Size(228, 45);
            this.manuAdd.TabIndex = 2;
            this.manuAdd.Text = "          Добавить";
            this.manuAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.manuAdd.Textcolor = System.Drawing.Color.White;
            this.manuAdd.TextFont = new System.Drawing.Font("Segoe UI Light", 13.75F);
            // 
            // manuList
            // 
            this.manuList.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.manuList.BackColor = System.Drawing.Color.Transparent;
            this.manuList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.manuList.BorderRadius = 0;
            this.manuList.ButtonText = "          Список";
            this.manuList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.manuList.DisabledColor = System.Drawing.Color.Gray;
            this.manuList.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manuList.Iconcolor = System.Drawing.Color.Transparent;
            this.manuList.Iconimage = ((System.Drawing.Image)(resources.GetObject("manuList.Iconimage")));
            this.manuList.Iconimage_right = null;
            this.manuList.Iconimage_right_Selected = null;
            this.manuList.Iconimage_Selected = null;
            this.manuList.IconMarginLeft = 0;
            this.manuList.IconMarginRight = 0;
            this.manuList.IconRightVisible = true;
            this.manuList.IconRightZoom = 0D;
            this.manuList.IconVisible = false;
            this.manuList.IconZoom = 90D;
            this.manuList.IsTab = true;
            this.manuList.Location = new System.Drawing.Point(0, 122);
            this.manuList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.manuList.Name = "manuList";
            this.manuList.Normalcolor = System.Drawing.Color.Transparent;
            this.manuList.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.manuList.OnHoverTextColor = System.Drawing.Color.White;
            this.manuList.selected = false;
            this.manuList.Size = new System.Drawing.Size(228, 45);
            this.manuList.TabIndex = 1;
            this.manuList.Text = "          Список";
            this.manuList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.manuList.Textcolor = System.Drawing.Color.White;
            this.manuList.TextFont = new System.Drawing.Font("Segoe UI Light", 13.75F);
            this.manuList.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.name,
            this.archiveTitle,
            this.archiveInfo,
            this.fileName});
            this.dataGridView1.Location = new System.Drawing.Point(235, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(617, 300);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // fileName
            // 
            this.fileName.HeaderText = "file";
            this.fileName.Name = "fileName";
            // 
            // archiveInfo
            // 
            this.archiveInfo.HeaderText = "Archive Info";
            this.archiveInfo.Name = "archiveInfo";
            // 
            // archiveTitle
            // 
            this.archiveTitle.HeaderText = "Title Archive";
            this.archiveTitle.Name = "archiveTitle";
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            // 
            // number
            // 
            this.number.HeaderText = "#";
            this.number.Name = "number";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 449);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuFlatButton manuList;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuFlatButton menuHelp;
        private Bunifu.Framework.UI.BunifuFlatButton menuSearch;
        private Bunifu.Framework.UI.BunifuFlatButton manuAdd;
        private Bunifu.Framework.UI.BunifuFlatButton menuExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn archiveTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn archiveInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileName;
    }
}

