using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weekly_Jump_OreCollection
{
    public partial class AddCharacterForm : Form
    {
        public AddCharacterForm()
        {
            InitializeComponent();
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            // Se crea el OpenFileDialog
            OpenFileDialog dialog = new OpenFileDialog();
            // Se muestra al usuario esperando una acción
            DialogResult result = dialog.ShowDialog();

            // Si seleccionó un archivo (asumiendo que es una imagen lo que seleccionó)
            // la mostramos en el PictureBox de la inferfaz
            if (result == DialogResult.OK)
            {
                retrato.Image = Image.FromFile(dialog.FileName);
            }
        }

        private void btnAddImage2_Click(object sender, EventArgs e)
        {
            // Se crea el OpenFileDialog
            OpenFileDialog dialog = new OpenFileDialog();
            // Se muestra al usuario esperando una acción
            DialogResult result = dialog.ShowDialog();

            // Si seleccionó un archivo (asumiendo que es una imagen lo que seleccionó)
            // la mostramos en el PictureBox de la inferfaz
            if (result == DialogResult.OK)
            {
                carta.Image = Image.FromFile(dialog.FileName);
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            nombre.Clear();
            detalle.Clear();
            tipo.Items.Clear();
            era.Items.Clear();
            clase.Items.Clear();
            serie.Items.Clear();
            comoObtener.Clear();
            fechaAparicion.ResetText();
            F2P.Checked = false;
            caracteristica1.Items.Clear();
            caracteristica2.Items.Clear();
            caracteristica3.Items.Clear();
            caracteristica4.Items.Clear();
            caracteristica5.Items.Clear();
            caracteristica6.Items.Clear();
            habLider.Clear();
            habPasivas.Clear();
            atqDef.Clear();
            atqDefMax.Clear();
            HP50.Clear();
            HP60.Clear();
            HP60Max.Clear();
            Atq50.Clear();
            Atq60.Clear();
            Atq60Max.Clear();
            Def50.Clear();
            Def60.Clear();
            Def60Max.Clear();
            Vel50.Clear();
            Vel60.Clear();
            Vel60Max.Clear();
            skill1.Clear();
            skill1Max.Clear();
            skill2.Clear();
            skill2Max.Clear();
            skill3.Clear();
            skill3Max.Clear();
            skill4.Clear();
            skill4Max.Clear();

            nombre.Focus();
        }

        private void registrarPersonaje(object sender, EventArgs e)
        {
            bool todoCorrecto = validarCampos();

            if (todoCorrecto)
            {
                MessageBox.Show("Todo correcto.");
            }
        }

        private bool validarCampos()
        {
            if (nombre.TextLength < 1)
            {
                MessageBox.Show("El nombre del personaje no puede estar vacio.");
                nombre.Focus();
                return false;
            }
            if (detalle.TextLength < 1)
            {
                MessageBox.Show("El detalle del personaje no puede estar vacio.");
                detalle.Focus();
                return false;
            }
            return true;
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
