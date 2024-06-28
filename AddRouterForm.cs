using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I_Surveillance
{
    public partial class AddRouter : Form
    {
        public AddRouter()
        {
            InitializeComponent();
        }

        private void addrouterbutton_Click(object sender, EventArgs e)
        {
            Variables.EmptyStrings.Add(routeriptxt.Text);
            Variables.EmptyStrings.Add(routerusernametxt.Text);
            Variables.EmptyStrings.Add(routerpasswordtxt.Text);
            if (Variables.checkifvalueisempty())
            {
                MessageBox.Show("Please fill all of the Router information");
            }
            else
            {
                Variables.addRouterForm.Close();
                Variables.checkedbuttons.Remove(Variables.buttonclicked);
            }
            Variables.EmptyStrings.Clear();
        }
    }
}
