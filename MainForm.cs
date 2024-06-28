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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void addbuttonstolist()
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addcamera_Click(object sender, EventArgs e)
        {
            if (!Variables.checkifbuttonchecked())
            {
                Variables.cameraAddForm = new CameraAddForm();
                Variables.cameraAddForm.Show();
                Variables.checkedbuttons.Add(Variables.buttonclicked);
            }
        }

        private void addserver_Click(object sender, EventArgs e)
        {
            if (!Variables.checkifbuttonchecked())
            {
                Variables.addServerForm = new AddServerForm();
                Variables.addServerForm.Show();
                Variables.checkedbuttons.Add(Variables.buttonclicked);
            }
        }

        private void addswitch_Click(object sender, EventArgs e)
        {
            if (!Variables.checkifbuttonchecked())
            {
                Variables.addSwitchForm = new AddSwitchForm();
                Variables.addSwitchForm.Show();
                Variables.checkedbuttons.Add(Variables.buttonclicked);
            }
        }

        private void addrouter_Click(object sender, EventArgs e)
        {
            if (!Variables.checkifbuttonchecked())
            {
                Variables.addRouterForm = new AddRouter();
                Variables.addRouterForm.Show();
                Variables.checkedbuttons.Add(Variables.buttonclicked);
            }
        }
    }
}
