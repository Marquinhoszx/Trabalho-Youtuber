﻿using System;
using Model;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Achou que eu iria salvar?");
            MessageBox.Show("Logo EU");



        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            ListarYT listar = new ListarYT();
            listar.ShowDialog();
        }

      

       
        
    }
}
