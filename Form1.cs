using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Semana4tarea1
{
    public partial class Form1 : Form
    {
        private Timer _timer;
        private int _contador;

        public Form1()
        {
            InitializeComponent();

            // Validar solo números
            txtSoloNumeros.KeyPress += (s, e) =>
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            };

            // Configurar timer
            _timer = new Timer();
            _timer.Interval = 1000;
            _timer.Tick += (s, e) =>
            {
                _contador++;
                lblTiempo.Text = _contador + " segs";
            };

            // Botón para iniciar el temporizador
            btnIniciar.Click += (s, e) =>
            {
                _contador = 0;
                lblTiempo.Text = "0 segs";
                _timer.Start();
            };

            // Eventos de clic en el estado
            lblEstado.Click += (s, e) =>
            {
                lblEstado.Text = "Encendido";
            };

            lblEstado.DoubleClick += (s, e) =>
            {
                lblEstado.Text = "Apagado";
            };

            // Habilitar arrastrar imagen JPG o PNG
            pnlImagen.AllowDrop = true;

            pnlImagen.DragEnter += (s, e) =>
            {
                if (e.Data.GetDataPresent(DataFormats.FileDrop))
                {
                    e.Effect = DragDropEffects.Copy;
                }
            };

            pnlImagen.DragDrop += (s, e) =>
            {
                try
                {
                    string[] archivos = (string[])e.Data.GetData(DataFormats.FileDrop);
                    if (archivos.Length > 0)
                    {
                        string archivo = archivos[0];
                        string extension = Path.GetExtension(archivo).ToLower();

                        if (extension == ".jpg" || extension == ".jpeg" || extension == ".png")
                        {
                            pnlImagen.BackgroundImage = Image.FromFile(archivo);
                            pnlImagen.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        else
                        {
                            MessageBox.Show("Solo se permiten imágenes .jpg, .jpeg o .png");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar imagen: " + ex.Message);
                }
            };
        }

        // Métodos vacíos requeridos por el diseñador
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // No hace nada (requerido por el diseñador)
        }

        private void lblArrastrar_Click(object sender, EventArgs e)
        {
            // No hace nada (requerido por el diseñador)
        }

        private void txtSoloNumeros_TextChanged(object sender, EventArgs e)
        {
            // No hace nada (requerido por el diseñador)
        }
    }
}
