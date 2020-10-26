using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuLibreria
{
    public partial class Menu : UserControl
    {
        public Menu()
        {
            InitializeComponent();
        }
        double tacocahua=15;
        private void btnCahu_Click(object sender, EventArgs e)
        {
            Pedido.Text = Pedido.Text + "Taco Cahuamanta";
            Pago.Text = Pago.Text + tacocahua;

        }
    }
}
