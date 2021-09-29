namespace Arquetectura4CapasVentana
{
    partial class Login
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
            this.button1 = new System.Windows.Forms.Button();
            this.lb_idusuario = new System.Windows.Forms.Label();
            this.caja_registro = new System.Windows.Forms.TextBox();
            this.bt_salir = new System.Windows.Forms.Button();
            this.caja_contrasena = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Myriad Hebrew", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(217, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ingresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_idusuario
            // 
            this.lb_idusuario.AutoSize = true;
            this.lb_idusuario.Font = new System.Drawing.Font("Myriad Hebrew", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_idusuario.Location = new System.Drawing.Point(46, 39);
            this.lb_idusuario.Name = "lb_idusuario";
            this.lb_idusuario.Size = new System.Drawing.Size(140, 19);
            this.lb_idusuario.TabIndex = 1;
            this.lb_idusuario.Text = "Ingrese su Registro";
            this.lb_idusuario.Click += new System.EventHandler(this.label1_Click);
            // 
            // caja_registro
            // 
            this.caja_registro.Font = new System.Drawing.Font("Myriad Hebrew", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caja_registro.Location = new System.Drawing.Point(192, 39);
            this.caja_registro.Name = "caja_registro";
            this.caja_registro.Size = new System.Drawing.Size(100, 23);
            this.caja_registro.TabIndex = 2;
            this.caja_registro.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // bt_salir
            // 
            this.bt_salir.Font = new System.Drawing.Font("Myriad Hebrew", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_salir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bt_salir.Location = new System.Drawing.Point(217, 126);
            this.bt_salir.Name = "bt_salir";
            this.bt_salir.Size = new System.Drawing.Size(75, 23);
            this.bt_salir.TabIndex = 3;
            this.bt_salir.Text = "Salir";
            this.bt_salir.UseVisualStyleBackColor = true;
            this.bt_salir.Click += new System.EventHandler(this.bt_salir_Click);
            // 
            // caja_contrasena
            // 
            this.caja_contrasena.Font = new System.Drawing.Font("Myriad Hebrew", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caja_contrasena.Location = new System.Drawing.Point(192, 68);
            this.caja_contrasena.Name = "caja_contrasena";
            this.caja_contrasena.Size = new System.Drawing.Size(100, 23);
            this.caja_contrasena.TabIndex = 4;
            this.caja_contrasena.UseSystemPasswordChar = true;
            this.caja_contrasena.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myriad Hebrew", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Contraseña";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myriad Hebrew", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Bienvenid@ al Sistema CAI";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 160);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.caja_contrasena);
            this.Controls.Add(this.bt_salir);
            this.Controls.Add(this.caja_registro);
            this.Controls.Add(this.lb_idusuario);
            this.Controls.Add(this.button1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lb_idusuario;
        private System.Windows.Forms.TextBox caja_registro;
        private System.Windows.Forms.Button bt_salir;
        private System.Windows.Forms.TextBox caja_contrasena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}