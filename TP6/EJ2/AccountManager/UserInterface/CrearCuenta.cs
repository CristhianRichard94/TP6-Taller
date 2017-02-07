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
            if (this.iAccount == null)
            {
                this.iAccount = new AccountDTO();
            }
            else
            {
                textBox4.Text = iAccount.Id.ToString();
               // textBox3.Text = 
            }
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
            this.iAccount.Name = textBox1.Text;
            this.iAccount.OverdraftLimit = Convert.ToDouble(textBox2.Text);
            try
            {
                this.iAccount.ClientId = Convert.ToInt32(textBox3.Text);
            }
            catch (Exception)
            {
                MessageBox.Show(" El Id ingresado es incorrecto ");
            }
            
            if (String.IsNullOrWhiteSpace(textBox4.Text))
            {
                try
                {
                    iFacade.Account.CreateAccount(this.iAccount);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error "+
                                    ex.Message);
                }
            }
            else
            {
                try
                {
                    iFacade.Account.UpdateAccount(this.iAccount);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha occurido un error" +
                                    ex.Message);
                }

            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SeleccionarCliente selecCliente = new SeleccionarCliente(iFacade);
            selecCliente.Show();
        }

        private void CrearCuenta_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
