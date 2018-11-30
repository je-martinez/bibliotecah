namespace Bibliotecah
{
    partial class FrmMenuP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuP));
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnadmin = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnconsultas = new System.Windows.Forms.Button();
            this.btnenvios = new System.Windows.Forms.Button();
            this.btnupload = new System.Windows.Forms.Button();
            this.tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(121, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = "MENU PRINCIPAL";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(377, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(25, 23);
            this.button3.TabIndex = 5;
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
            this.button2.Location = new System.Drawing.Point(408, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 23);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnadmin
            // 
            this.btnadmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnadmin.BackgroundImage = global::Bibliotecah.Properties.Resources.settings;
            this.btnadmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnadmin.FlatAppearance.BorderSize = 0;
            this.btnadmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadmin.ForeColor = System.Drawing.Color.Transparent;
            this.btnadmin.Location = new System.Drawing.Point(23, 199);
            this.btnadmin.Name = "btnadmin";
            this.btnadmin.Size = new System.Drawing.Size(112, 87);
            this.btnadmin.TabIndex = 0;
            this.tooltip.SetToolTip(this.btnadmin, "Area Administrativa");
            this.btnadmin.UseVisualStyleBackColor = false;
            this.btnadmin.Click += new System.EventHandler(this.btnadmin_Click);
            this.btnadmin.MouseEnter += new System.EventHandler(this.btnexit_MouseEnter);
            this.btnadmin.MouseLeave += new System.EventHandler(this.btnexit_MouseLeave);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.btnexit.BackgroundImage = global::Bibliotecah.Properties.Resources.exit2;
            this.btnexit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnexit.FlatAppearance.BorderSize = 0;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexit.ForeColor = System.Drawing.Color.Transparent;
            this.btnexit.Location = new System.Drawing.Point(321, 199);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(112, 87);
            this.btnexit.TabIndex = 0;
            this.tooltip.SetToolTip(this.btnexit, "Salir");
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            this.btnexit.MouseEnter += new System.EventHandler(this.btnexit_MouseEnter);
            this.btnexit.MouseLeave += new System.EventHandler(this.btnexit_MouseLeave);
            // 
            // btnconsultas
            // 
            this.btnconsultas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnconsultas.BackgroundImage = global::Bibliotecah.Properties.Resources.Ver;
            this.btnconsultas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnconsultas.FlatAppearance.BorderSize = 0;
            this.btnconsultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnconsultas.ForeColor = System.Drawing.Color.Transparent;
            this.btnconsultas.Location = new System.Drawing.Point(174, 77);
            this.btnconsultas.Name = "btnconsultas";
            this.btnconsultas.Size = new System.Drawing.Size(112, 87);
            this.btnconsultas.TabIndex = 0;
            this.tooltip.SetToolTip(this.btnconsultas, "Consulta de Archivos (Monografias y Tesis)");
            this.btnconsultas.UseVisualStyleBackColor = false;
            this.btnconsultas.Click += new System.EventHandler(this.btnconsultas_Click);
            this.btnconsultas.MouseEnter += new System.EventHandler(this.btnconsultas_MouseEnter);
            this.btnconsultas.MouseLeave += new System.EventHandler(this.btnconsultas_MouseLeave);
            // 
            // btnenvios
            // 
            this.btnenvios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(102)))));
            this.btnenvios.BackgroundImage = global::Bibliotecah.Properties.Resources.Mail;
            this.btnenvios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnenvios.FlatAppearance.BorderSize = 0;
            this.btnenvios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnenvios.ForeColor = System.Drawing.Color.Transparent;
            this.btnenvios.Location = new System.Drawing.Point(321, 77);
            this.btnenvios.Name = "btnenvios";
            this.btnenvios.Size = new System.Drawing.Size(112, 87);
            this.btnenvios.TabIndex = 0;
            this.tooltip.SetToolTip(this.btnenvios, "Envios");
            this.btnenvios.UseVisualStyleBackColor = false;
            this.btnenvios.Click += new System.EventHandler(this.btnenvios_Click);
            this.btnenvios.MouseEnter += new System.EventHandler(this.btnenvios_MouseEnter);
            this.btnenvios.MouseLeave += new System.EventHandler(this.btnenvios_MouseLeave);
            // 
            // btnupload
            // 
            this.btnupload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btnupload.BackgroundImage = global::Bibliotecah.Properties.Resources.Upload;
            this.btnupload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnupload.FlatAppearance.BorderSize = 0;
            this.btnupload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupload.ForeColor = System.Drawing.Color.Transparent;
            this.btnupload.Location = new System.Drawing.Point(23, 77);
            this.btnupload.Name = "btnupload";
            this.btnupload.Size = new System.Drawing.Size(112, 87);
            this.btnupload.TabIndex = 0;
            this.tooltip.SetToolTip(this.btnupload, "Subida de Archivos (Monografias y Tesis)");
            this.btnupload.UseVisualStyleBackColor = false;
            this.btnupload.Click += new System.EventHandler(this.btnupload_Click);
            this.btnupload.MouseEnter += new System.EventHandler(this.btnupload_MouseEnter_1);
            this.btnupload.MouseLeave += new System.EventHandler(this.btnupload_MouseLeave);
            // 
            // tooltip
            // 
            this.tooltip.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tooltip.ForeColor = System.Drawing.SystemColors.Info;
            this.tooltip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tooltip.ToolTipTitle = "Información:";
            // 
            // FrmMenuP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(465, 340);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnadmin);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnconsultas);
            this.Controls.Add(this.btnenvios);
            this.Controls.Add(this.btnupload);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMenuP";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bibliotecah";
            this.Load += new System.EventHandler(this.FrmMenuP_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmMenuP_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnupload;
        private System.Windows.Forms.Button btnenvios;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnconsultas;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnadmin;
        private System.Windows.Forms.ToolTip tooltip;
    }
}