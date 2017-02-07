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
    public partial class SeleccionarCliente : Form

    {
        private Facade iFacade;


        public SeleccionarCliente(Facade pFacade)
        {
            InitializeComponent();
            iFacade = pFacade;
            dataGridView1.DataSource = pFacade.Client.GetAllClients();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SeleccionarCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
