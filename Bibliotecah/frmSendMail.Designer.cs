namespace Bibliotecah
{
    partial class frmSendMail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSendMail));
            this.txtcuerpo = new System.Windows.Forms.RichTextBox();
            this.txtpara = new System.Windows.Forms.TextBox();
            this.txtasunto = new System.Windows.Forms.TextBox();
            this.txtde = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnenviar = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnupload = new System.Windows.Forms.Button();
            this.lwlista = new System.Windows.Forms.ListView();
            this.imgiconosexplorer = new System.Windows.Forms.ImageList(this.components);
            this.cbotrimestre = new System.Windows.Forms.ComboBox();
            this.cbo_carrera = new System.Windows.Forms.ComboBox();
            this.cbotipo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblinfo = new System.Windows.Forms.Label();
            this.txtdestinatarioidentidad = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtdestinatario = new System.Windows.Forms.TextBox();
            this.labelmagico = new System.Windows.Forms.Label();
            this.txtanio = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtcuerpo
            // 
            this.txtcuerpo.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtcuerpo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcuerpo.ForeColor = System.Drawing.Color.White;
            this.txtcuerpo.Location = new System.Drawing.Point(21, 216);
            this.txtcuerpo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtcuerpo.Name = "txtcuerpo";
            this.txtcuerpo.Size = new System.Drawing.Size(458, 423);
            this.txtcuerpo.TabIndex = 0;
            this.txtcuerpo.Text = "";
            // 
            // txtpara
            // 
            this.txtpara.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtpara.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpara.ForeColor = System.Drawing.SystemColors.Window;
            this.txtpara.Location = new System.Drawing.Point(88, 69);
            this.txtpara.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtpara.Name = "txtpara";
            this.txtpara.Size = new System.Drawing.Size(391, 19);
            this.txtpara.TabIndex = 5;
            // 
            // txtasunto
            // 
            this.txtasunto.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtasunto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtasunto.ForeColor = System.Drawing.SystemColors.Window;
            this.txtasunto.Location = new System.Drawing.Point(88, 151);
            this.txtasunto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtasunto.Name = "txtasunto";
            this.txtasunto.Size = new System.Drawing.Size(391, 19);
            this.txtasunto.TabIndex = 6;
            // 
            // txtde
            // 
            this.txtde.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtde.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtde.ForeColor = System.Drawing.SystemColors.Window;
            this.txtde.Location = new System.Drawing.Point(88, 111);
            this.txtde.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtde.Name = "txtde";
            this.txtde.ReadOnly = true;
            this.txtde.Size = new System.Drawing.Size(391, 19);
            this.txtde.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Para:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "De:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 151);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Asunto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 191);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Mensaje:";
            // 
            // btnenviar
            // 
            this.btnenviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.btnenviar.FlatAppearance.BorderSize = 0;
            this.btnenviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnenviar.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnenviar.Location = new System.Drawing.Point(524, 571);
            this.btnenviar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnenviar.Name = "btnenviar";
            this.btnenviar.Size = new System.Drawing.Size(313, 68);
            this.btnenviar.TabIndex = 16;
            this.btnenviar.Text = "Enviar Mensaje";
            this.btnenviar.UseVisualStyleBackColor = false;
            this.btnenviar.Click += new System.EventHandler(this.btnenviar_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Gray;
            this.label15.Location = new System.Drawing.Point(408, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 30);
            this.label15.TabIndex = 17;
            this.label15.Text = "ENVIOS";
            this.label15.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label15_MouseDown);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(813, 9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(25, 23);
            this.button3.TabIndex = 18;
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
            this.button2.Location = new System.Drawing.Point(844, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 23);
            this.button2.TabIndex = 19;
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
            this.btnupload.TabIndex = 20;
            this.btnupload.UseVisualStyleBackColor = false;
            this.btnupload.Click += new System.EventHandler(this.btnupload_Click);
            // 
            // lwlista
            // 
            this.lwlista.AllowDrop = true;
            this.lwlista.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lwlista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lwlista.Cursor = System.Windows.Forms.Cursors.Default;
            this.lwlista.ForeColor = System.Drawing.SystemColors.Window;
            this.lwlista.LargeImageList = this.imgiconosexplorer;
            this.lwlista.Location = new System.Drawing.Point(524, 377);
            this.lwlista.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lwlista.Name = "lwlista";
            this.lwlista.Size = new System.Drawing.Size(313, 133);
            this.lwlista.SmallImageList = this.imgiconosexplorer;
            this.lwlista.TabIndex = 21;
            this.lwlista.UseCompatibleStateImageBehavior = false;
            this.lwlista.View = System.Windows.Forms.View.SmallIcon;
            this.lwlista.SelectedIndexChanged += new System.EventHandler(this.lwlista_SelectedIndexChanged);
            // 
            // imgiconosexplorer
            // 
            this.imgiconosexplorer.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imgiconosexplorer.ImageSize = new System.Drawing.Size(24, 24);
            this.imgiconosexplorer.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // cbotrimestre
            // 
            this.cbotrimestre.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cbotrimestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotrimestre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbotrimestre.ForeColor = System.Drawing.SystemColors.Info;
            this.cbotrimestre.FormattingEnabled = true;
            this.cbotrimestre.Location = new System.Drawing.Point(714, 187);
            this.cbotrimestre.Name = "cbotrimestre";
            this.cbotrimestre.Size = new System.Drawing.Size(123, 28);
            this.cbotrimestre.TabIndex = 39;
            this.cbotrimestre.SelectedIndexChanged += new System.EventHandler(this.cbotrimestre_SelectedIndexChanged);
            // 
            // cbo_carrera
            // 
            this.cbo_carrera.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cbo_carrera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_carrera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbo_carrera.ForeColor = System.Drawing.SystemColors.Info;
            this.cbo_carrera.FormattingEnabled = true;
            this.cbo_carrera.Location = new System.Drawing.Point(523, 124);
            this.cbo_carrera.Name = "cbo_carrera";
            this.cbo_carrera.Size = new System.Drawing.Size(311, 28);
            this.cbo_carrera.TabIndex = 38;
            this.cbo_carrera.SelectedValueChanged += new System.EventHandler(this.cbo_carrera_SelectedValueChanged);
            // 
            // cbotipo
            // 
            this.cbotipo.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cbotipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbotipo.ForeColor = System.Drawing.SystemColors.Info;
            this.cbotipo.FormattingEnabled = true;
            this.cbotipo.Location = new System.Drawing.Point(524, 66);
            this.cbotipo.Name = "cbotipo";
            this.cbotipo.Size = new System.Drawing.Size(313, 28);
            this.cbotipo.TabIndex = 37;
            this.cbotipo.SelectedIndexChanged += new System.EventHandler(this.cbotipo_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(523, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 36;
            this.label5.Text = "Año:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(711, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 35;
            this.label6.Text = "Trimestre:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(520, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 20);
            this.label7.TabIndex = 34;
            this.label7.Text = "Carrera:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(520, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 20);
            this.label8.TabIndex = 33;
            this.label8.Text = "Tipo de Carrera:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(523, 352);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 20);
            this.label9.TabIndex = 42;
            this.label9.Text = "Archivos Adjuntos:";
            // 
            // lblinfo
            // 
            this.lblinfo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinfo.ForeColor = System.Drawing.Color.Red;
            this.lblinfo.Location = new System.Drawing.Point(524, 515);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(314, 45);
            this.lblinfo.TabIndex = 41;
            this.lblinfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtdestinatarioidentidad
            // 
            this.txtdestinatarioidentidad.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtdestinatarioidentidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtdestinatarioidentidad.ForeColor = System.Drawing.SystemColors.Window;
            this.txtdestinatarioidentidad.Location = new System.Drawing.Point(523, 318);
            this.txtdestinatarioidentidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtdestinatarioidentidad.Name = "txtdestinatarioidentidad";
            this.txtdestinatarioidentidad.Size = new System.Drawing.Size(314, 19);
            this.txtdestinatarioidentidad.TabIndex = 50;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(523, 293);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(205, 20);
            this.label10.TabIndex = 49;
            this.label10.Text = "No. Identidad Destinatario:";
            // 
            // txtdestinatario
            // 
            this.txtdestinatario.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtdestinatario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtdestinatario.ForeColor = System.Drawing.SystemColors.Window;
            this.txtdestinatario.Location = new System.Drawing.Point(524, 260);
            this.txtdestinatario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtdestinatario.Name = "txtdestinatario";
            this.txtdestinatario.Size = new System.Drawing.Size(314, 19);
            this.txtdestinatario.TabIndex = 48;
            // 
            // labelmagico
            // 
            this.labelmagico.AutoSize = true;
            this.labelmagico.ForeColor = System.Drawing.Color.White;
            this.labelmagico.Location = new System.Drawing.Point(524, 235);
            this.labelmagico.Name = "labelmagico";
            this.labelmagico.Size = new System.Drawing.Size(100, 20);
            this.labelmagico.TabIndex = 47;
            this.labelmagico.Text = "Destinatario:";
            // 
            // txtanio
            // 
            this.txtanio.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtanio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtanio.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtanio.ForeColor = System.Drawing.SystemColors.Window;
            this.txtanio.Location = new System.Drawing.Point(524, 187);
            this.txtanio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtanio.Multiline = true;
            this.txtanio.Name = "txtanio";
            this.txtanio.Size = new System.Drawing.Size(179, 28);
            this.txtanio.TabIndex = 51;
            this.txtanio.TextChanged += new System.EventHandler(this.txtanio_TextChanged);
            this.txtanio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtanio_KeyDown);
            this.txtanio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtanio_KeyPress);
            // 
            // frmSendMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(881, 653);
            this.Controls.Add(this.txtanio);
            this.Controls.Add(this.txtdestinatarioidentidad);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtdestinatario);
            this.Controls.Add(this.labelmagico);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblinfo);
            this.Controls.Add(this.cbotrimestre);
            this.Controls.Add(this.cbo_carrera);
            this.Controls.Add(this.cbotipo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lwlista);
            this.Controls.Add(this.btnupload);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnenviar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtde);
            this.Controls.Add(this.txtasunto);
            this.Controls.Add(this.txtpara);
            this.Controls.Add(this.txtcuerpo);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmSendMail";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bibliotecah";
            this.Load += new System.EventHandler(this.frmSendMail_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmSendMail_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtcuerpo;
        private System.Windows.Forms.TextBox txtpara;
        private System.Windows.Forms.TextBox txtasunto;
        private System.Windows.Forms.TextBox txtde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnenviar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnupload;
        private System.Windows.Forms.ListView lwlista;
        private System.Windows.Forms.ComboBox cbotrimestre;
        private System.Windows.Forms.ComboBox cbo_carrera;
        private System.Windows.Forms.ComboBox cbotipo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ImageList imgiconosexplorer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblinfo;
        private System.Windows.Forms.TextBox txtdestinatarioidentidad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtdestinatario;
        private System.Windows.Forms.Label labelmagico;
        private System.Windows.Forms.TextBox txtanio;
    }
}