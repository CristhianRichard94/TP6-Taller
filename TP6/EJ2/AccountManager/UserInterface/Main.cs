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
using AccountManager.DAL.EntityFramework;

namespace AccountManager.UserInterface
{
    public partial class Main : Form
    { 
        
        Facade iFacade;
        UnitOfWork iUOW;


        public Main()
        {
        
            InitializeComponent();
            this.iUOW = new UnitOfWork(new AccountManagerDbContext());
            this.iFacade = new Facade(this.iUOW);
        
    }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CrearCliente crearcl = new CrearCliente();
            crearcl.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListarCliente listarcl= new ListarCliente();
            listarcl.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            CrearCuenta crearcu = new CrearCuenta(iFacade);
            crearcu.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ListarCuenta listarcu= new ListarCuenta();
            listarcu.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Cajero cajero = new Cajero();
            cajero.Show();
        }
    }
}
