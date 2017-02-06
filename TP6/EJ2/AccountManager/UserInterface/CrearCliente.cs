﻿using System;
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

        public CrearCliente(Facade pFacade, ClientDTO pClient = null)
        {
            InitializeComponent();
            this.iFacade = pFacade;
            this.iClient = pClient;
            this.comboBox1.SelectedIndex = 1;
            ShowClient();
        }

        private void ShowClient()
        {
            if (this.iClient == null)
            {
                this.iClient = new ClientDTO();
            }
            else
            {
                this.textBox4.Text = this.iClient.Id.ToString();
            }
            this.textBox1.Text = this.iClient.FirstName;
            this.textBox2.Text = this.iClient.LastName;
            this.textBox3.Text = this.iClient.DocumentNumber;
            this.comboBox1.SelectedIndex = this.iClient.DocumentType.GetHashCode();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBox1.Text))
            {
                throw new Exception("No se ha ingresado nombre de cliente");
            }
            if (String.IsNullOrWhiteSpace(textBox2.Text))
            {
                throw new Exception("No se ha ingresado apellido de cliente");
            }
            if (String.IsNullOrWhiteSpace(textBox3.Text))
            {
                throw new Exception("No se ha ingresado Numero de documento");
            }
            if (comboBox1.SelectedIndex< 0)
            {
                throw new Exception("No se ha ingresado tipo de documento");
            }
            this.iClient.FirstName = this.textBox1.Text;
            this.iClient.LastName = this.textBox2.Text;
            this.iClient.DocumentNumber = this.textBox3.Text;
            this.iClient.DocumentType = (DocumentType)this.comboBox1.SelectedIndex;

            if (this.iClient.Id > 0)
            {
                try
                {
                    iFacade.Client.UpdateClient(this.iClient);
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
                    iFacade.Client.CreateClient(this.iClient);
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

        private void CrearCliente_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
