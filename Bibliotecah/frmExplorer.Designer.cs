namespace Bibliotecah
{
    partial class frmExplorer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExplorer));
            this.imgiconosexplorer = new System.Windows.Forms.ImageList(this.components);
            this.treexplorer = new System.Windows.Forms.TreeView();
            this.lwlista = new System.Windows.Forms.ListView();
            this.ctxtopciones = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.holaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.imglisttree = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.txtruta = new System.Windows.Forms.ToolStripTextBox();
            this.barramenu = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnupload = new System.Windows.Forms.Button();
            this.ctxtopciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.barramenu.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgiconosexplorer
            // 
            this.imgiconosexplorer.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imgiconosexplorer.ImageSize = new System.Drawing.Size(48, 48);
            this.imgiconosexplorer.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // treexplorer
            // 
            this.treexplorer.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.treexplorer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treexplorer.ForeColor = System.Drawing.Color.White;
            this.treexplorer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.treexplorer.Location = new System.Drawing.Point(0, 0);
            this.treexplorer.Name = "treexplorer";
            this.treexplorer.ShowNodeToolTips = true;
            this.treexplorer.Size = new System.Drawing.Size(251, 453);
            this.treexplorer.TabIndex = 7;
            this.treexplorer.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
            // 
            // lwlista
            // 
            this.lwlista.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lwlista.ContextMenuStrip = this.ctxtopciones;
            this.lwlista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lwlista.ForeColor = System.Drawing.Color.White;
            this.lwlista.LargeImageList = this.imgiconosexplorer;
            this.lwlista.Location = new System.Drawing.Point(0, 0);
            this.lwlista.MultiSelect = false;
            this.lwlista.Name = "lwlista";
            this.lwlista.Size = new System.Drawing.Size(854, 453);
            this.lwlista.SmallImageList = this.imgiconosexplorer;
            this.lwlista.TabIndex = 4;
            this.lwlista.UseCompatibleStateImageBehavior = false;
            this.lwlista.SelectedIndexChanged += new System.EventHandler(this.lwlista_SelectedIndexChanged);
            this.lwlista.DragDrop += new System.Windows.Forms.DragEventHandler(this.lwlista_DragDrop);
            this.lwlista.DragEnter += new System.Windows.Forms.DragEventHandler(this.lwlista_DragEnter);
            this.lwlista.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lwlista_MouseDoubleClick);
            // 
            // ctxtopciones
            // 
            this.ctxtopciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(63)))));
            this.ctxtopciones.BackgroundImage = global::Bibliotecah.Properties.Resources._25A;
            this.ctxtopciones.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctxtopciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.holaToolStripMenuItem});
            this.ctxtopciones.Name = "contextMenuStrip1";
            this.ctxtopciones.Size = new System.Drawing.Size(153, 50);
            this.ctxtopciones.Opening += new System.ComponentModel.CancelEventHandler(this.ctxtopciones_Opening);
            // 
            // holaToolStripMenuItem
            // 
            this.holaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.holaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.holaToolStripMenuItem.Image = global::Bibliotecah.Properties.Resources.delete;
            this.holaToolStripMenuItem.Name = "holaToolStripMenuItem";
            this.holaToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.holaToolStripMenuItem.Text = "Eliminar";
            this.holaToolStripMenuItem.Click += new System.EventHandler(this.holaToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.AllowDrop = true;
            this.splitContainer1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer1.ForeColor = System.Drawing.Color.White;
            this.splitContainer1.Location = new System.Drawing.Point(12, 75);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treexplorer);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AllowDrop = true;
            this.splitContainer1.Panel2.Controls.Add(this.lwlista);
            this.splitContainer1.Size = new System.Drawing.Size(1109, 453);
            this.splitContainer1.SplitterDistance = 251;
            this.splitContainer1.TabIndex = 9;
            // 
            // imglisttree
            // 
            this.imglisttree.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imglisttree.ImageSize = new System.Drawing.Size(25, 25);
            this.imglisttree.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1133, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            this.menuStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseDown);
            // 
            // txtruta
            // 
            this.txtruta.AutoSize = false;
            this.txtruta.Name = "txtruta";
            this.txtruta.ReadOnly = true;
            this.txtruta.Size = new System.Drawing.Size(500, 22);
            this.txtruta.Visible = false;
            // 
            // barramenu
            // 
            this.barramenu.AllowDrop = true;
            this.barramenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.barramenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtruta});
            this.barramenu.Location = new System.Drawing.Point(0, 48);
            this.barramenu.Name = "barramenu";
            this.barramenu.Size = new System.Drawing.Size(1133, 24);
            this.barramenu.TabIndex = 8;
            this.barramenu.Text = "menuStrip1";
            this.barramenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.barramenu_ItemClicked);
            this.barramenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barramenu_MouseDown);
            // 
            // menuStrip2
            // 
            this.menuStrip2.AllowDrop = true;
            this.menuStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1133, 24);
            this.menuStrip2.TabIndex = 26;
            this.menuStrip2.Text = "menuStrip1";
            this.menuStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked);
            this.menuStrip2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuStrip2_MouseDown);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.ReadOnly = true;
            this.toolStripTextBox1.Size = new System.Drawing.Size(500, 22);
            this.toolStripTextBox1.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Gray;
            this.label15.Location = new System.Drawing.Point(412, 9);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(342, 30);
            this.label15.TabIndex = 27;
            this.label15.Text = "CONSULTA DE DIRECTORIOS";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.button1.BackgroundImage = global::Bibliotecah.Properties.Resources._103292_32;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(218, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 43);
            this.button1.TabIndex = 28;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(1065, 20);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(25, 23);
            this.button3.TabIndex = 24;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.BackgroundImage = global::Bibliotecah.Properties.Resources.Salir;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1096, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 23);
            this.button2.TabIndex = 25;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnupload
            // 
            this.btnupload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnupload.BackgroundImage = global::Bibliotecah.Properties.Resources.Home2;
            this.btnupload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnupload.FlatAppearance.BorderSize = 0;
            this.btnupload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupload.ForeColor = System.Drawing.Color.Transparent;
            this.btnupload.Location = new System.Drawing.Point(12, 12);
            this.btnupload.Name = "btnupload";
            this.btnupload.Size = new System.Drawing.Size(45, 43);
            this.btnupload.TabIndex = 11;
            this.btnupload.UseVisualStyleBackColor = false;
            this.btnupload.Click += new System.EventHandler(this.btnupload_Click);
            // 
            // frmExplorer
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1133, 540);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnupload);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.barramenu);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.barramenu;
            this.Name = "frmExplorer";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bibliotecah";
            this.Load += new System.EventHandler(this.frmExplorer_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.frmExplorer_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.frmExplorer_DragEnter);
            this.DragOver += new System.Windows.Forms.DragEventHandler(this.frmExplorer_DragOver);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmExplorer_MouseDown);
            this.ctxtopciones.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.barramenu.ResumeLayout(false);
            this.barramenu.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip ctxtopciones;
        private System.Windows.Forms.ToolStripMenuItem holaToolStripMenuItem;
        private System.Windows.Forms.ImageList imgiconosexplorer;
        private System.Windows.Forms.TreeView treexplorer;
        private System.Windows.Forms.ListView lwlista;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ImageList imglisttree;
        private System.Windows.Forms.Button btnupload;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripTextBox txtruta;
        private System.Windows.Forms.MenuStrip barramenu;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button1;
    }
}