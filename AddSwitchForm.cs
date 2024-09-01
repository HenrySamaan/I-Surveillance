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
    public partial class AddSwitchForm : Form
    {
        public AddSwitchForm()
        {
            InitializeComponent();
        }

        private void addswitchbutton_Click(object sender, EventArgs e)
        {
            Variables.EmptyStrings.Add(switchiptxt.Text);
            Variables.EmptyStrings.Add(switchusernametxt.Text);
            Variables.EmptyStrings.Add(switchpasswordtxt.Text);
            if (Variables.checkifvalueisempty())
            {
                MessageBox.Show("Please fill all of the Switch information");
            }
            else
            {
                Variables.HandleInput("Switch", switchiptxt.Text.Trim(), switchusernametxt.Text.Trim(), switchpasswordtxt.Text.Trim(), "");
                Variables.addSwitchForm.Close();
                Variables.checkedbuttons.Remove(Variables.buttonclicked);
            }
            Variables.EmptyStrings.Clear();
        }
    }
}
