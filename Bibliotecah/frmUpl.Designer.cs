namespace Bibliotecah
{
    partial class frmUpl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpl));
            this.lwlista = new System.Windows.Forms.ListView();
            this.cboanio = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imgiconosexplorer = new System.Windows.Forms.ImageList(this.components);
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btncarga = new System.Windows.Forms.Button();
            this.cbotipo = new System.Windows.Forms.ComboBox();
            this.cbo_carrera = new System.Windows.Forms.ComboBox();
            this.cbotrimestre = new System.Windows.Forms.ComboBox();
            this.lblinfo = new System.Windows.Forms.Label();
            this.btnupload = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lbladv = new System.Windows.Forms.Label();
            this.txtanio = new System.Windows.Forms.TextBox();
            this.cboanio.SuspendLayout();
            this.SuspendLayout();
            // 
            // lwlista
            // 
            this.lwlista.AllowDrop = true;
            this.lwlista.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lwlista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lwlista.ContextMenuStrip = this.cboanio;
            this.lwlista.Cursor = System.Windows.Forms.Cursors.Default;
            this.lwlista.ForeColor = System.Drawing.SystemColors.Window;
            this.lwlista.LargeImageList = this.imgiconosexplorer;
            this.lwlista.Location = new System.Drawing.Point(13, 72);
            this.lwlista.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lwlista.Name = "lwlista";
            this.lwlista.Size = new System.Drawing.Size(465, 422);
            this.lwlista.TabIndex = 0;
            this.lwlista.UseCompatibleStateImageBehavior = false;
            this.lwlista.DragDrop += new System.Windows.Forms.DragEventHandler(this.lwlista_DragDrop);
            this.lwlista.DragEnter += new System.Windows.Forms.DragEventHandler(this.lwlista_DragEnter);
            this.lwlista.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lwlista_MouseDown);
            this.lwlista.MouseEnter += new System.EventHandler(this.lwlista_MouseEnter);
            this.lwlista.MouseHover += new System.EventHandler(this.lwlista_MouseHover);
            // 
            // cboanio
            // 
            this.cboanio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cboanio.BackgroundImage = global::Bibliotecah.Properties.Resources._25A;
            this.cboanio.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboanio.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarToolStripMenuItem});
            this.cboanio.Name = "opciones";
            this.cboanio.Size = new System.Drawing.Size(128, 26);
            this.cboanio.Opening += new System.ComponentModel.CancelEventHandler(this.opciones_Opening);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(63)))));
            this.eliminarToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.eliminarToolStripMenuItem.Image = global::Bibliotecah.Properties.Resources.delete;
            this.eliminarToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.eliminarToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // imgiconosexplorer
            // 
            this.imgiconosexplorer.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imgiconosexplorer.ImageSize = new System.Drawing.Size(32, 32);
            this.imgiconosexplorer.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Gray;
            this.label15.Location = new System.Drawing.Point(339, 5);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(265, 30);
            this.label15.TabIndex = 18;
            this.label15.Text = "SUBIDA DE ARCHIVOS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(488, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Tipo de Carrera:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(488, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Carrera:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(713, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Trimestre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(488, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Año:";
            // 
            // btncarga
            // 
            this.btncarga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.btncarga.FlatAppearance.BorderSize = 0;
            this.btncarga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncarga.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncarga.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btncarga.Location = new System.Drawing.Point(489, 393);
            this.btncarga.Name = "btncarga";
            this.btncarga.Size = new System.Drawing.Size(425, 101);
            this.btncarga.TabIndex = 29;
            this.btncarga.Text = "Carga de Archivos";
            this.btncarga.UseVisualStyleBackColor = false;
            this.btncarga.Click += new System.EventHandler(this.btncarga_Click);
            // 
            // cbotipo
            // 
            this.cbotipo.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cbotipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbotipo.ForeColor = System.Drawing.SystemColors.Info;
            this.cbotipo.FormattingEnabled = true;
            this.cbotipo.Location = new System.Drawing.Point(492, 72);
            this.cbotipo.Name = "cbotipo";
            this.cbotipo.Size = new System.Drawing.Size(422, 28);
            this.cbotipo.TabIndex = 30;
            this.cbotipo.SelectedIndexChanged += new System.EventHandler(this.cbotipo_SelectedIndexChanged);
            this.cbotipo.SelectedValueChanged += new System.EventHandler(this.cbotipo_SelectedValueChanged);
            // 
            // cbo_carrera
            // 
            this.cbo_carrera.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cbo_carrera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_carrera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbo_carrera.ForeColor = System.Drawing.SystemColors.Info;
            this.cbo_carrera.FormattingEnabled = true;
            this.cbo_carrera.Location = new System.Drawing.Point(492, 136);
            this.cbo_carrera.Name = "cbo_carrera";
            this.cbo_carrera.Size = new System.Drawing.Size(422, 28);
            this.cbo_carrera.TabIndex = 31;
            this.cbo_carrera.SelectedValueChanged += new System.EventHandler(this.cbo_carrera_SelectedValueChanged);
            // 
            // cbotrimestre
            // 
            this.cbotrimestre.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cbotrimestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotrimestre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbotrimestre.ForeColor = System.Drawing.SystemColors.Info;
            this.cbotrimestre.FormattingEnabled = true;
            this.cbotrimestre.Location = new System.Drawing.Point(718, 206);
            this.cbotrimestre.Name = "cbotrimestre";
            this.cbotrimestre.Size = new System.Drawing.Size(194, 28);
            this.cbotrimestre.TabIndex = 32;
            this.cbotrimestre.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // lblinfo
            // 
            this.lblinfo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinfo.ForeColor = System.Drawing.Color.Yellow;
            this.lblinfo.Location = new System.Drawing.Point(488, 321);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(424, 45);
            this.lblinfo.TabIndex = 34;
            this.lblinfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.btnupload.TabIndex = 33;
            this.btnupload.UseVisualStyleBackColor = false;
            this.btnupload.Click += new System.EventHandler(this.btnupload_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(858, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(25, 23);
            this.button3.TabIndex = 22;
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
            this.button2.Location = new System.Drawing.Point(889, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 23);
            this.button2.TabIndex = 23;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            // 
            // lbladv
            // 
            this.lbladv.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladv.ForeColor = System.Drawing.Color.Yellow;
            this.lbladv.Location = new System.Drawing.Point(488, 256);
            this.lbladv.Name = "lbladv";
            this.lbladv.Size = new System.Drawing.Size(424, 65);
            this.lbladv.TabIndex = 35;
            this.lbladv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbladv.Click += new System.EventHandler(this.lbladv_Click);
            // 
            // txtanio
            // 
            this.txtanio.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtanio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtanio.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtanio.ForeColor = System.Drawing.SystemColors.Window;
            this.txtanio.Location = new System.Drawing.Point(492, 206);
            this.txtanio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtanio.Multiline = true;
            this.txtanio.Name = "txtanio";
            this.txtanio.Size = new System.Drawing.Size(179, 28);
            this.txtanio.TabIndex = 36;
            this.txtanio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtanio_KeyDown);
            this.txtanio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtanio_KeyPress);
            // 
            // frmUpl
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(924, 508);
            this.Controls.Add(this.txtanio);
            this.Controls.Add(this.lbladv);
            this.Controls.Add(this.lblinfo);
            this.Controls.Add(this.btnupload);
            this.Controls.Add(this.cbotrimestre);
            this.Controls.Add(this.cbo_carrera);
            this.Controls.Add(this.cbotipo);
            this.Controls.Add(this.btncarga);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lwlista);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmUpl";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bibliotecah";
            this.Load += new System.EventHandler(this.frmUpl_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.frmUpl_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.frmUpl_DragEnter);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmUpl_MouseDown);
            this.cboanio.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lwlista;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btncarga;
        private System.Windows.Forms.ImageList imgiconosexplorer;
        private System.Windows.Forms.ComboBox cbotipo;
        private System.Windows.Forms.ComboBox cbo_carrera;
        private System.Windows.Forms.ComboBox cbotrimestre;
        private System.Windows.Forms.Button btnupload;
        private System.Windows.Forms.Label lblinfo;
        private System.Windows.Forms.ContextMenuStrip cboanio;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lbladv;
        private System.Windows.Forms.TextBox txtanio;
    }
}