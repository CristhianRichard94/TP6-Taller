using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccountManager.DTO;
using AccountManager.Logic;
using AccountManager.Domain;

namespace AccountManager.UserInterface
{
    public partial class CrearCliente : Form
    {
        private ClientDTO iClient;
        public Facade iFacade;

        public CrearCliente()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.iClient.FirstName = this.textBox1.Text;
            this.iClient.LastName = this.textBox2.Text;
            this.iClient.DocumentNumber = this.textBox3.Text;
            this.iClient.DocumentType = (DocumentType)this.comboBox1.SelectedIndex;

            if (this.iClient.Id > 0)
            {
                try
                {
                    iFacade.Cliente.UpdateClient(this.iClient);
                    this.Close();
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Se ha producido un error\n" + exception.Message);
                }
            }
            else
            {
                try
                {
                    iFacade.Cliente.CreateClient(this.iClient);
                    this.Close();
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Se ha producido un error\n" + exception.Message);
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
