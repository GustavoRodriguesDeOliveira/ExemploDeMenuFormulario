using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploDeMenu
{
    public partial class Form1 : Form
    {
        cadastrar cad;
        Atualizar atu;
        Consultar con;
        Excluir exc;
        public Form1()
        {
            InitializeComponent();
            cad = new cadastrar();
            atu = new Atualizar();
            con = new Consultar();
            exc = new Excluir();
        }

        private void consultar_Click(object sender, EventArgs e)
        {
            Visible = false;
            con.ShowDialog();
            Visible = true;
        }

        private void atualizar_Click(object sender, EventArgs e)
        {
            Visible = false;
            atu.ShowDialog();
            Visible = true;
        }

        private void excluir_Click(object sender, EventArgs e)
        {
            Visible = false;
            exc.ShowDialog();
            Visible = true;
        }

        private void cadastrar_Click(object sender, EventArgs e)
        {
            Visible = false;
            cad.ShowDialog();//Mostrar a tela ao ser chamada
            Visible = true;
        }
    }
}
