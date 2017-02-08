using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccountManager.Logic;
using AccountManager.DTO;

namespace AccountManager.UserInterface
{
    public partial class ListaClientes : Form
    {
        public Facade iFacade;


        public ListaClientes(Facade pFacade)
        {
            InitializeComponent();
            this.iFacade = pFacade;
            this.dataGridView1.AutoGenerateColumns = false;
            ActualizarTabla();
        }

        public void ActualizarTabla()
        {
            dataGridView1.DataSource = iFacade.Client.GetAllClients();
        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearCliente crearcl = new CrearCliente(iFacade);
            crearcl.Show();
            ActualizarTabla();
        }

        private void modificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var crearcl = new CrearCliente(iFacade, (ClientDTO)dataGridView1.SelectedRows[0].DataBoundItem);
            crearcl.Show();
            crearcl.FormClosing += new FormClosingEventHandler(Form_FormClosing);
        }

        /// <summary>
        /// Procedimientos que hará al cerrar la ventana
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.ActualizarTabla();
        }

        private void eliminarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
             var result = MessageBox.Show("¿Desea eliminar al cliente?", "Eliminar", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                iFacade.Client.DeleteClient(((ClientDTO)dataGridView1.SelectedRows[0].DataBoundItem));
            }

            ActualizarTabla();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListaClientes_Load(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void actualizarTablaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActualizarTabla();
        }
    }
}
