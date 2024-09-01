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
    public partial class AddServerForm : Form
    {
        public AddServerForm()
        {
            InitializeComponent();
        }

        private void addserverbutton_Click(object sender, EventArgs e)
        {
            Variables.EmptyStrings.Add(serveriptxt.Text);
            Variables.EmptyStrings.Add(serverdomaintxt.Text);
            Variables.EmptyStrings.Add(serverusernametxt.Text);
            Variables.EmptyStrings.Add(serverpasswordtxt.Text);
            if (Variables.checkifvalueisempty())
            {
                MessageBox.Show("Please fill all of the Server information");
            }
            else
            {
                Variables.HandleInput("Server", serveriptxt.Text.Trim(), $@"{serverdomaintxt.Text.Trim()}\{serverusernametxt.Text.Trim()}", serverpasswordtxt.Text.Trim(), "");
                Variables.addServerForm.Close();
                Variables.checkedbuttons.Remove(Variables.buttonclicked);
            }
            Variables.EmptyStrings.Clear();
        }
    }
}
