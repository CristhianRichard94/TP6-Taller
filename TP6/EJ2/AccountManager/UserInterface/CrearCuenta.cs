using System;
using AccountManager.Logic;
using AccountManager.DTO;
using System.Windows.Forms;

namespace AccountManager.UserInterface
{
    public partial class CrearCuenta : Form
    {
        private Facade iFacade;
        private AccountDTO iAccount;

        public CrearCuenta(Facade pFacade)
        {
            InitializeComponent();
            this.iFacade = pFacade;
            textBox2.Text = iAccount.OverdraftLimit.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void CrearCuenta_Load(object sender, EventArgs e)
        {

        }
    }
}
