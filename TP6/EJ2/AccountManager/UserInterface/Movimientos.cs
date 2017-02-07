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
    public partial class Movimientos : Form
    {
        public Facade iFacade;
        private AccountDTO iAccount;

        public Movimientos(Facade pFacade, AccountDTO pAccount)
        {
            InitializeComponent();
            this.iFacade = pFacade;
            this.iAccount = pAccount;
            ActualizarTabla();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void ActualizarTabla()
        {
            dataGridView1.DataSource = iFacade.Account.GetLastMovements(iAccount);
        }

        private void volverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
