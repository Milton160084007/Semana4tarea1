namespace Semana4tarea1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblArrastrar = new System.Windows.Forms.Label();
            this.lblTiempoTexto = new System.Windows.Forms.Label();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.pnlImagen = new System.Windows.Forms.Panel();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.txtSoloNumeros = new System.Windows.Forms.TextBox();
            this.lblEntrada = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblEstadoTexto = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCyan;
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Controls.Add(this.lblArrastrar);
            this.panel1.Controls.Add(this.lblTiempoTexto);
            this.panel1.Controls.Add(this.lblTiempo);
            this.panel1.Controls.Add(this.btnIniciar);
            this.panel1.Controls.Add(this.pnlImagen);
            this.panel1.Controls.Add(this.lblSubtitulo);
            this.panel1.Controls.Add(this.txtSoloNumeros);
            this.panel1.Controls.Add(this.lblEntrada);
            this.panel1.Controls.Add(this.lblEstado);
            this.panel1.Controls.Add(this.lblEstadoTexto);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(680, 440);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(190, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(279, 30);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Funciones windows forms";
            // 
            // lblArrastrar
            // 
            this.lblArrastrar.AutoSize = true;
            this.lblArrastrar.Location = new System.Drawing.Point(400, 157);
            this.lblArrastrar.Name = "lblArrastrar";
            this.lblArrastrar.Size = new System.Drawing.Size(149, 25);
            this.lblArrastrar.TabIndex = 1;
            this.lblArrastrar.Text = "Insertar imagen ";
            this.lblArrastrar.Click += new System.EventHandler(this.lblArrastrar_Click);
            // 
            // lblTiempoTexto
            // 
            this.lblTiempoTexto.AutoSize = true;
            this.lblTiempoTexto.Location = new System.Drawing.Point(40, 355);
            this.lblTiempoTexto.Name = "lblTiempoTexto";
            this.lblTiempoTexto.Size = new System.Drawing.Size(79, 25);
            this.lblTiempoTexto.TabIndex = 2;
            this.lblTiempoTexto.Text = "Tiempo:";
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Location = new System.Drawing.Point(130, 355);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(64, 25);
            this.lblTiempo.TabIndex = 3;
            this.lblTiempo.Text = "0 segs";
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnIniciar.Location = new System.Drawing.Point(40, 290);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(120, 40);
            this.btnIniciar.TabIndex = 4;
            this.btnIniciar.Text = "Comenzar";
            this.btnIniciar.UseVisualStyleBackColor = false;
            // 
            // pnlImagen
            // 
            this.pnlImagen.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlImagen.Location = new System.Drawing.Point(405, 208);
            this.pnlImagen.Name = "pnlImagen";
            this.pnlImagen.Size = new System.Drawing.Size(230, 220);
            this.pnlImagen.TabIndex = 5;
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Location = new System.Drawing.Point(40, 240);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(161, 25);
            this.lblSubtitulo.TabIndex = 6;
            this.lblSubtitulo.Text = "Temporizador ON";
            // 
            // txtSoloNumeros
            // 
            this.txtSoloNumeros.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtSoloNumeros.Location = new System.Drawing.Point(40, 170);
            this.txtSoloNumeros.Name = "txtSoloNumeros";
            this.txtSoloNumeros.Size = new System.Drawing.Size(200, 33);
            this.txtSoloNumeros.TabIndex = 7;
            this.txtSoloNumeros.TextChanged += new System.EventHandler(this.txtSoloNumeros_TextChanged);
            // 
            // lblEntrada
            // 
            this.lblEntrada.AutoSize = true;
            this.lblEntrada.Location = new System.Drawing.Point(40, 140);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(204, 25);
            this.lblEntrada.TabIndex = 8;
            this.lblEntrada.Text = "Ingresar solo números:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEstado.Location = new System.Drawing.Point(160, 95);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(88, 25);
            this.lblEstado.TabIndex = 9;
            this.lblEstado.Text = "Apagado";
            // 
            // lblEstadoTexto
            // 
            this.lblEstadoTexto.AutoSize = true;
            this.lblEstadoTexto.Location = new System.Drawing.Point(40, 95);
            this.lblEstadoTexto.Name = "lblEstadoTexto";
            this.lblEstadoTexto.Size = new System.Drawing.Size(102, 25);
            this.lblEstadoTexto.TabIndex = 10;
            this.lblEstadoTexto.Text = "Estado luz:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(680, 440);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Mi Formulario Modificado";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblArrastrar;
        private System.Windows.Forms.Label lblTiempoTexto;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Panel pnlImagen;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.TextBox txtSoloNumeros;
        private System.Windows.Forms.Label lblEntrada;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblEstadoTexto;
    }
}

