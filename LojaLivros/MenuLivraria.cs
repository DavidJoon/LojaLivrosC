using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaLivros
{
    public partial class MenuLivraria : Form
    {
        public MenuLivraria()
        {
            InitializeComponent();
        }

        private void adicionarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            InserirLivro inserelivro = new InserirLivro();
            inserelivro.Show();
        }
    }
}
