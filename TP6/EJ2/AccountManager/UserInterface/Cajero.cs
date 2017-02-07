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
    public partial class Cajero : Form
    {
        public Facade iFacade;
        private AccountDTO iAccount;

        public Cajero(Facade pFacade)
        {
            InitializeComponent();
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            this.iFacade = pFacade;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id=0;
            try
            {
                id = Convert.ToInt32(textBox1.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("El ID ingresado es inválido");
            }
            try
            {
                AccountDTO account = iFacade.Account.GetAccount(id);
                groupBox1.Visible = false;
                groupBox2.Visible = true;
            }
            catch (Exception)
            {
                MessageBox.Show("No Existe Cuenta para el id Ingresado");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cajero_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
            groupBox2.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Movimientos movs = new Movimientos(iFacade, iAccount);
            movs.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = true;
            groupBox2.Visible = false;
            double balance = iFacade.Account.GetBalance(iAccount);
            label3.Text = balance.ToString();
            if (balance<0)   
            {
                label3.ForeColor= System.Drawing.Color.Red;
            }
            else
            {
                label3.ForeColor = System.Drawing.Color.Green;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox4.Visible = true;
            groupBox2.Visible = false;
            button9.Visible = true;
            button11.Visible = false;
            button12.Visible = false;
            label4.Text = "Depósito";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupBox4.Visible = true;
            groupBox2.Visible = false;
            button9.Visible = false;
            button11.Visible = true;
            button12.Visible = false;
            label4.Text = "Retiro";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            groupBox4.Visible = true;
            groupBox2.Visible = false;
            button9.Visible = false;
            button11.Visible = false;
            button12.Visible = true;
            label4.Text = "Transferencia";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            groupBox4.Visible = false;
            groupBox2.Visible = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            double monto;
            try
            {
                monto = Convert.ToDouble(textBox2.Text);
                iFacade.Account.NewMovement(iAccount, "Deposito", monto);
                groupBox2.Visible = true;
                groupBox4.Visible = false;
                MessageBox.Show("Se ha Realizado el depósito");
            }
            catch (Exception)
            {
                MessageBox.Show("El monto ingresado es inválido");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            double monto;
            try
            {
                monto = Convert.ToDouble(textBox2.Text) * -1;
                iFacade.Account.NewMovement(iAccount, "Retiro", monto);
                groupBox2.Visible = true;
                groupBox4.Visible = false;
                MessageBox.Show("Se ha Realizado el retiro");
            }
            catch (Exception)
            {
                MessageBox.Show("El monto ingresado es inválido");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            double monto;
            try
            {
                monto = Convert.ToDouble(textBox2.Text) * -1;
                iFacade.Account.NewMovement(iAccount, "Transferencia", monto);
                groupBox2.Visible = true;
                groupBox4.Visible = false;
                MessageBox.Show("Se ha Realizado la transferencia");
            }
            catch (Exception)
            {
                MessageBox.Show("El monto ingresado es inválido");
            }
        }
    }
}
