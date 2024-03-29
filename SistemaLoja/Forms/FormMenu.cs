﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLoja.Forms
{
    public partial class FormMenu : Form
    {
        public static bool lgn;
        public static bool lgnOpen;
        public static bool sistema;
        public static string UsuarioGeral;
        Form1 form1 = new Form1();

        public FormMenu()
        {
            InitializeComponent();
            lgn = false;
            lgnOpen = false;
            sistema = false;
            UsuarioGeral = "";
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            if(lgnOpen == false)
            {
                form1.Show();
                lgnOpen = true;
            }
        }

        #region Timers
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (lgn == false & lgnOpen == false)
            {
                form1.Show();
                lgnOpen = true;
                this.Hide();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            NomeUsuario.Text = "Seja Bem Vindo " + UsuarioGeral;
            if (sistema == true)
            {
                this.Show();
                sistema = false;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            this.Hide();
            timer3.Enabled = false;
        }
        #endregion

        private void vendaBtn_Click(object sender, EventArgs e)
        {
            Vendas vendas = new Vendas();
            vendas.Show();
            this.Hide();
        }

        private void sairMenu_Click(object sender, EventArgs e)
        {
            //DialogResult diag = MessageBox.Show("Deseja sair do programa?", "Fechar",MessageBoxButtons.YesNo);
            //if(diag == DialogResult.Yes)
            //{
            Application.Exit();
            //}
            //else
            //{

            //}
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
