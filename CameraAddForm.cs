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
    public partial class CameraAddForm : Form
    {
        public CameraAddForm()
        {
            InitializeComponent();
        }
        string InsertcameraInfo = "";
        private void button1_Click(object sender, EventArgs e)
        {
            Variables.EmptyStrings.Add(cameraiptxt.Text);
            Variables.EmptyStrings.Add(camerausernametxt.Text);
            Variables.EmptyStrings.Add(camerapasstxt.Text);
            Variables.EmptyStrings.Add(cameraidtxt.Text);
            Variables.EmptyStrings.Add(camerartsptxt.Text);
            Variables.EmptyStrings.Add(cameraimagetxt.Text);
            if (Variables.checkifvalueisempty())
            {
                MessageBox.Show("Please fill all of the camera information");
            }
            else
            {
                Variables.HandleInput("Camera", cameraiptxt.Text.Trim(), camerausernametxt.Text.Trim(), camerapasstxt.Text.Trim(), cameraimagetxt.Text.Trim());
                Variables.cameraAddForm.Close();
                Variables.checkedbuttons.Remove(Variables.buttonclicked);
            }
            Variables.EmptyStrings.Clear();
        }
    }
}
