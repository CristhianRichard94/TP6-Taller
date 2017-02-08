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
    public partial class ListaCuentas : Form
    {
        public Facade iFacade;
        public ListaCuentas(Facade pFacade)
        {
            InitializeComponent();
            this.iFacade = pFacade;
            dataGridView1.DataSource = pFacade.Account.GetAllAccounts();
           
        }
        public void ActualizarTabla()
        {
            dataGridView1.DataSource = iFacade.Account.GetAllAccounts();
        }

        private void ListaCuentas_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void crearToolStripMenuItem_Crear_Click(object sender, EventArgs e)
        {
            CrearCuenta crearcu = new CrearCuenta(iFacade);
            crearcu.Show();
            ActualizarTabla();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var crearcu = new CrearCuenta(iFacade, (AccountDTO)dataGridView1.SelectedRows[0].DataBoundItem);
            crearcu.Show();
            crearcu.FormClosing += new FormClosingEventHandler(Form_FormClosing);
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Desea eliminar la cuenta?", "Eliminar", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                iFacade.Account.DeleteAccount(((AccountDTO)dataGridView1.SelectedRows[0].DataBoundItem));

            }
            ActualizarTabla();
        }
        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.ActualizarTabla();
        }

        private void actualizarTablaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


    }
}
