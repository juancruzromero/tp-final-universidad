namespace Arquetectura4CapasVentana
{
    partial class Home
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
            this.Lb_AltaJugador = new System.Windows.Forms.Label();
            this.Lb_Apellido = new System.Windows.Forms.Label();
            this.Lb_Fuerza = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.caja_nombre = new System.Windows.Forms.TextBox();
            this.caja_apellido = new System.Windows.Forms.TextBox();
            this.caja_fuerza = new System.Windows.Forms.TextBox();
            this.caja_angulo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Lb_Nombre = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonborrar = new System.Windows.Forms.Button();
            this.dataGridViewJugadores = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJugadores)).BeginInit();
            this.SuspendLayout();
            // 
            // Lb_AltaJugador
            // 
            this.Lb_AltaJugador.AutoSize = true;
            this.Lb_AltaJugador.Font = new System.Drawing.Font("Myriad Hebrew", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_AltaJugador.Location = new System.Drawing.Point(15, 20);
            this.Lb_AltaJugador.Name = "Lb_AltaJugador";
            this.Lb_AltaJugador.Size = new System.Drawing.Size(152, 24);
            this.Lb_AltaJugador.TabIndex = 0;
            this.Lb_AltaJugador.Text = "Ingresar Jugador";
            this.Lb_AltaJugador.Click += new System.EventHandler(this.Lb_AltaJugador_Click);
            // 
            // Lb_Apellido
            // 
            this.Lb_Apellido.AutoSize = true;
            this.Lb_Apellido.Font = new System.Drawing.Font("Myriad Hebrew", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Apellido.Location = new System.Drawing.Point(7, 108);
            this.Lb_Apellido.Name = "Lb_Apellido";
            this.Lb_Apellido.Size = new System.Drawing.Size(55, 15);
            this.Lb_Apellido.TabIndex = 3;
            this.Lb_Apellido.Text = "Apellido:";
            // 
            // Lb_Fuerza
            // 
            this.Lb_Fuerza.AutoSize = true;
            this.Lb_Fuerza.Font = new System.Drawing.Font("Myriad Hebrew", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Fuerza.Location = new System.Drawing.Point(15, 146);
            this.Lb_Fuerza.Name = "Lb_Fuerza";
            this.Lb_Fuerza.Size = new System.Drawing.Size(47, 15);
            this.Lb_Fuerza.TabIndex = 4;
            this.Lb_Fuerza.Text = "Fuerza:";
            this.Lb_Fuerza.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Myriad Hebrew", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Angulo:";
            // 
            // caja_nombre
            // 
            this.caja_nombre.Font = new System.Drawing.Font("Myriad Hebrew", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caja_nombre.Location = new System.Drawing.Point(67, 69);
            this.caja_nombre.Name = "caja_nombre";
            this.caja_nombre.Size = new System.Drawing.Size(100, 22);
            this.caja_nombre.TabIndex = 6;
            this.caja_nombre.TextChanged += new System.EventHandler(this.tx_nombre_TextChanged);
            // 
            // caja_apellido
            // 
            this.caja_apellido.Font = new System.Drawing.Font("Myriad Hebrew", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caja_apellido.Location = new System.Drawing.Point(67, 106);
            this.caja_apellido.Name = "caja_apellido";
            this.caja_apellido.Size = new System.Drawing.Size(100, 22);
            this.caja_apellido.TabIndex = 7;
            this.caja_apellido.TextChanged += new System.EventHandler(this.tx_apellido_TextChanged);
            // 
            // caja_fuerza
            // 
            this.caja_fuerza.Font = new System.Drawing.Font("Myriad Hebrew", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caja_fuerza.Location = new System.Drawing.Point(67, 143);
            this.caja_fuerza.Name = "caja_fuerza";
            this.caja_fuerza.Size = new System.Drawing.Size(100, 22);
            this.caja_fuerza.TabIndex = 8;
            this.caja_fuerza.TextChanged += new System.EventHandler(this.tx_fuerza_TextChanged);
            // 
            // caja_angulo
            // 
            this.caja_angulo.Font = new System.Drawing.Font("Myriad Hebrew", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caja_angulo.Location = new System.Drawing.Point(67, 181);
            this.caja_angulo.Name = "caja_angulo";
            this.caja_angulo.Size = new System.Drawing.Size(100, 22);
            this.caja_angulo.TabIndex = 9;
            this.caja_angulo.TextChanged += new System.EventHandler(this.caja_angulo_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Myriad Hebrew", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(380, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Jugadores Ingresados";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Myriad Hebrew", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(10, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Nuevo Jugador";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Lb_Nombre
            // 
            this.Lb_Nombre.AutoSize = true;
            this.Lb_Nombre.Font = new System.Drawing.Font("Myriad Hebrew", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Nombre.Location = new System.Drawing.Point(8, 72);
            this.Lb_Nombre.Name = "Lb_Nombre";
            this.Lb_Nombre.Size = new System.Drawing.Size(54, 15);
            this.Lb_Nombre.TabIndex = 15;
            this.Lb_Nombre.Text = "Nombre:";
            this.Lb_Nombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Myriad Hebrew", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button3.Location = new System.Drawing.Point(755, 261);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Atrás";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // buttonborrar
            // 
            this.buttonborrar.Font = new System.Drawing.Font("Myriad Hebrew", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonborrar.ForeColor = System.Drawing.Color.Red;
            this.buttonborrar.Location = new System.Drawing.Point(10, 261);
            this.buttonborrar.Name = "buttonborrar";
            this.buttonborrar.Size = new System.Drawing.Size(157, 23);
            this.buttonborrar.TabIndex = 17;
            this.buttonborrar.Text = "Borrar Jugador";
            this.buttonborrar.UseVisualStyleBackColor = true;
            this.buttonborrar.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridViewJugadores
            // 
            this.dataGridViewJugadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewJugadores.Location = new System.Drawing.Point(192, 47);
            this.dataGridViewJugadores.Name = "dataGridViewJugadores";
            this.dataGridViewJugadores.Size = new System.Drawing.Size(643, 200);
            this.dataGridViewJugadores.TabIndex = 18;
            this.dataGridViewJugadores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Myriad Hebrew", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Green;
            this.button2.Location = new System.Drawing.Point(371, 253);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(260, 31);
            this.button2.TabIndex = 19;
            this.button2.Text = "Agregar un Bien al Jugador";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 296);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridViewJugadores);
            this.Controls.Add(this.buttonborrar);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Lb_Nombre);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.caja_angulo);
            this.Controls.Add(this.caja_fuerza);
            this.Controls.Add(this.caja_apellido);
            this.Controls.Add(this.caja_nombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Lb_Fuerza);
            this.Controls.Add(this.Lb_Apellido);
            this.Controls.Add(this.Lb_AltaJugador);
            this.Name = "Home";
            this.Text = "Pantalla Principal";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJugadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lb_AltaJugador;
        private System.Windows.Forms.Label Lb_Apellido;
        private System.Windows.Forms.Label Lb_Fuerza;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox caja_nombre;
        private System.Windows.Forms.TextBox caja_apellido;
        private System.Windows.Forms.TextBox caja_fuerza;
        private System.Windows.Forms.TextBox caja_angulo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Lb_Nombre;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonborrar;
        private System.Windows.Forms.DataGridView dataGridViewJugadores;
        private System.Windows.Forms.Button button2;
    }
}

