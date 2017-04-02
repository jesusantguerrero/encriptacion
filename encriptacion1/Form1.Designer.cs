namespace encriptacion1
{
    partial class F_principal
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
            this.btn_encriptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rtxt_mensaje = new System.Windows.Forms.RichTextBox();
            this.txt_contrasenia = new System.Windows.Forms.TextBox();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.p_headbar = new System.Windows.Forms.Panel();
            this.btn_m_minimaze = new System.Windows.Forms.Button();
            this.btn_m_info = new System.Windows.Forms.Button();
            this.btn_m_close = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.p_headbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_encriptar
            // 
            this.btn_encriptar.BackColor = System.Drawing.Color.Snow;
            this.btn_encriptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_encriptar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_encriptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Snow;
            this.btn_encriptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_encriptar.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btn_encriptar.ForeColor = System.Drawing.Color.Tomato;
            this.btn_encriptar.Location = new System.Drawing.Point(499, 458);
            this.btn_encriptar.Name = "btn_encriptar";
            this.btn_encriptar.Size = new System.Drawing.Size(129, 42);
            this.btn_encriptar.TabIndex = 0;
            this.btn_encriptar.Text = "Encriptar";
            this.btn_encriptar.UseVisualStyleBackColor = false;
            this.btn_encriptar.Click += new System.EventHandler(this.btn_encriptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.label1.Location = new System.Drawing.Point(24, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tu Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.label2.Location = new System.Drawing.Point(26, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mensaje";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.label3.Location = new System.Drawing.Point(26, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Contraseña";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 6;
            // 
            // rtxt_mensaje
            // 
            this.rtxt_mensaje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxt_mensaje.Location = new System.Drawing.Point(3, 3);
            this.rtxt_mensaje.Name = "rtxt_mensaje";
            this.rtxt_mensaje.Size = new System.Drawing.Size(370, 135);
            this.rtxt_mensaje.TabIndex = 9;
            this.rtxt_mensaje.Text = "";
            // 
            // txt_contrasenia
            // 
            this.txt_contrasenia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_contrasenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.txt_contrasenia.Location = new System.Drawing.Point(5, 8);
            this.txt_contrasenia.Name = "txt_contrasenia";
            this.txt_contrasenia.Size = new System.Drawing.Size(358, 19);
            this.txt_contrasenia.TabIndex = 10;
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.BackColor = System.Drawing.Color.Tomato;
            this.btn_cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tomato;
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btn_cerrar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_cerrar.Location = new System.Drawing.Point(634, 458);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(129, 42);
            this.btn_cerrar.TabIndex = 11;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.White;
            this.lbl_title.Location = new System.Drawing.Point(25, 11);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(110, 25);
            this.lbl_title.TabIndex = 12;
            this.lbl_title.Text = "JEncripter";
            this.lbl_title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_title_MouseDown);
            // 
            // p_headbar
            // 
            this.p_headbar.BackColor = System.Drawing.Color.Tomato;
            this.p_headbar.Controls.Add(this.lbl_title);
            this.p_headbar.Controls.Add(this.btn_m_minimaze);
            this.p_headbar.Controls.Add(this.btn_m_info);
            this.p_headbar.Controls.Add(this.btn_m_close);
            this.p_headbar.Location = new System.Drawing.Point(2, 1);
            this.p_headbar.Name = "p_headbar";
            this.p_headbar.Size = new System.Drawing.Size(771, 54);
            this.p_headbar.TabIndex = 13;
            this.p_headbar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.p_headbar_MouseDown);
            // 
            // btn_m_minimaze
            // 
            this.btn_m_minimaze.BackColor = System.Drawing.Color.Transparent;
            this.btn_m_minimaze.FlatAppearance.BorderSize = 0;
            this.btn_m_minimaze.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_m_minimaze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_m_minimaze.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_m_minimaze.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_m_minimaze.Location = new System.Drawing.Point(659, 0);
            this.btn_m_minimaze.Name = "btn_m_minimaze";
            this.btn_m_minimaze.Size = new System.Drawing.Size(54, 53);
            this.btn_m_minimaze.TabIndex = 15;
            this.btn_m_minimaze.Text = "_";
            this.btn_m_minimaze.UseVisualStyleBackColor = false;
            this.btn_m_minimaze.Click += new System.EventHandler(this.btn_m_minimaze_Click);
            // 
            // btn_m_info
            // 
            this.btn_m_info.BackColor = System.Drawing.Color.Transparent;
            this.btn_m_info.FlatAppearance.BorderSize = 0;
            this.btn_m_info.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_m_info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_m_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_m_info.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_m_info.Location = new System.Drawing.Point(604, 0);
            this.btn_m_info.Name = "btn_m_info";
            this.btn_m_info.Size = new System.Drawing.Size(54, 53);
            this.btn_m_info.TabIndex = 14;
            this.btn_m_info.Text = "?";
            this.btn_m_info.UseVisualStyleBackColor = false;
            // 
            // btn_m_close
            // 
            this.btn_m_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_m_close.FlatAppearance.BorderSize = 0;
            this.btn_m_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_m_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_m_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_m_close.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_m_close.Location = new System.Drawing.Point(714, 0);
            this.btn_m_close.Name = "btn_m_close";
            this.btn_m_close.Size = new System.Drawing.Size(59, 53);
            this.btn_m_close.TabIndex = 13;
            this.btn_m_close.Text = "X";
            this.btn_m_close.UseVisualStyleBackColor = false;
            this.btn_m_close.Click += new System.EventHandler(this.btn_m_close_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.ErrorImage = global::encriptacion1.Properties.Resources._lock;
            this.pictureBox1.Image = global::encriptacion1.Properties.Resources._lock;
            this.pictureBox1.InitialImage = global::encriptacion1.Properties.Resources._lock;
            this.pictureBox1.Location = new System.Drawing.Point(452, 129);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 263);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(2, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(771, 457);
            this.panel1.TabIndex = 16;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.txt_nombre);
            this.panel4.Location = new System.Drawing.Point(30, 111);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(376, 36);
            this.panel4.TabIndex = 11;
            // 
            // txt_nombre
            // 
            this.txt_nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.txt_nombre.Location = new System.Drawing.Point(6, 8);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(360, 19);
            this.txt_nombre.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txt_contrasenia);
            this.panel3.Location = new System.Drawing.Point(30, 213);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(376, 36);
            this.panel3.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.rtxt_mensaje);
            this.panel2.Location = new System.Drawing.Point(30, 293);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(376, 141);
            this.panel2.TabIndex = 6;
            // 
            // F_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(775, 512);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.p_headbar);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_encriptar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_principal";
            this.Text = "JEncripter";
            this.p_headbar.ResumeLayout(false);
            this.p_headbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_encriptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtxt_mensaje;
        private System.Windows.Forms.TextBox txt_contrasenia;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Panel p_headbar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_m_minimaze;
        private System.Windows.Forms.Button btn_m_info;
        private System.Windows.Forms.Button btn_m_close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
    }
}

