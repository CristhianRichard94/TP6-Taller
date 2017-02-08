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
    public partial class ListarCuenta : Form
    {
        public Facade iFacade;
        /// <summary>
        /// Listado de cuentas existentes
        /// </summary>
        /// <param name="pFacade"></param>
        public ListarCuenta(Facade pFacade)
        {
            InitializeComponent();
            this.iFacade = pFacade;
            dataGridView1.DataSource = pFacade.Account.GetAllAccounts();
            this.dataGridView1.Columns[1].HeaderText = "Nombre";
            this.dataGridView1.Columns[3].HeaderText = "Límite Descubierto";
            this.dataGridView1.Columns[2].HeaderText = "Id Cliente";
        }

        private void ListarCuenta_Load(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
