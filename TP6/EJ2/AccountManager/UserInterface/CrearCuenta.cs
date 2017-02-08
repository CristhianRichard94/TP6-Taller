using System;
using AccountManager.Logic;
using AccountManager.DTO;
using System.Windows.Forms;
using System.Linq;
using AccountManager.Domain;



namespace AccountManager.UserInterface
{
    public partial class CrearCuenta : Form
    {
        private Facade iFacade;
        private AccountDTO iAccount;

        public CrearCuenta(Facade pFacade, AccountDTO pAccount=null)
        {
            InitializeComponent();
            iFacade = pFacade;
            this.iAccount = pAccount;
           
            ShowAccount();
                  
        }

        private void ShowAccount()


           {
            if (this.iAccount == null)
            {
                this.iAccount = new AccountDTO();
            }
            else
            {
                textBox4_id.Text = iAccount.Id.ToString();
                textBox1_Nombre.Text = iAccount.Name;
                              
            }
            textBox2.Text = iAccount.OverdraftLimit.ToString();
            textBox3.Text = iAccount.ClientId.ToString();

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

            
            try
            {
                this.iAccount.Name = textBox1_Nombre.Text;
                this.iAccount.OverdraftLimit = Convert.ToDouble(textBox2.Text);
                this.iAccount.ClientId = Convert.ToInt32(textBox3.Text);        
                if (this.iAccount.Id == -1)
                    {
                        iFacade.Account.CreateAccount(this.iAccount);
                        MessageBox.Show("Se ha realizado la operacion sobre el id: " + (iFacade.Account.GetAllAccounts()).Last().Id);
                    }
                else
                    {
                        iFacade.Account.UpdateAccount(this.iAccount);
                        MessageBox.Show("Se ha realizado la operacion sobre el id: " + iAccount.Id.ToString());
                    }
                this.Close();
            }

            catch (Exception ex)
                {
                    MessageBox.Show("ERROR "+
                                    ex.Message);
                }
            }
                  

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SeleccionarCliente selecCliente = new SeleccionarCliente(iFacade);
            selecCliente.ShowDialog();
            string pid = selecCliente.IdSeleccionado;
            this.textBox3.Text = pid;
            
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
