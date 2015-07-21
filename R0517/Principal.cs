// OrtizOL - xCSw - http://ortizol.blogspot.com

using System;
using System.Windows.Forms;

namespace R0517
{
    public partial class frmR0517 : Form
    {
        public frmR0517()
        {
            InitializeComponent();
        }

        #region Eventos
        /// <summary>
        /// Muestra diálogo de apertura de archivo.
        /// </summary>
        /// <param name="sender">Objeto generador del evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void btnAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdAbrir = new OpenFileDialog();
            // Filtros de selección de archivo:
            ofdAbrir.Filter = "Archivos de texto enriquecido (*.rtf)|*RTF|Todos los archivos (*.*)|*.*";
            // Comprobación de existencia de archivo:
            ofdAbrir.CheckFileExists = true;
            // Ruta inicial:
            ofdAbrir.InitialDirectory = @"C:\";

            // Valida que el usuario haya presionado el botón Aceptar (OK):
            if (ofdAbrir.ShowDialog() == DialogResult.OK)
            {
                rtbContenido.LoadFile(ofdAbrir.FileName);
            }
        }
        /// <summary>
        /// Muestra diálogo de guardado de archivo.
        /// </summary>
        /// <param name="sender">Objeto generador del evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfdGuardar = new SaveFileDialog();
            // Filtros de guardado de archivo:
            sfdGuardar.Filter = "Archivos de texto enriquecido (*.rtf)|*RTF|Archivos de texto (*.txt)|*TXT|Todos los archivos (*.*)|*.*";
            // Ruta inicial:
            sfdGuardar.InitialDirectory = @"C:\";

            // Valida que el usuario haya presionado el botón Aceptar (OK):
            if (sfdGuardar.ShowDialog() == DialogResult.OK)
            {
                rtbContenido.SaveFile(sfdGuardar.FileName);
            }
        }
        /// <summary>
        /// Evento de cierre la aplicación.
        /// </summary>
        /// <param name="sender">Objeto generador del evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
